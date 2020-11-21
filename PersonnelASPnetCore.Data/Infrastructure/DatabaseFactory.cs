
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Infrastructure
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private ARTIPERSONNEL_SOC001Context dataContext;
        public ARTIPERSONNEL_SOC001Context _dataContext { get { return dataContext; } }

        private readonly string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"]?.ConnectionString;
        public int CommandTimeout { get; internal set; }

        public DatabaseFactory()
        {
            dataContext = new ARTIPERSONNEL_SOC001Context();
        }

        public DatabaseFactory(string databaseName)
        {
            this.connectionString = ConfigurationManager.ConnectionStrings[databaseName].ConnectionString;
            this.CommandTimeout = ConfigurationManager.AppSettings.Get("CommandTimeout") != null ? Int32.Parse(ConfigurationManager.AppSettings.Get("CommandTimeout")) : 0;
        }
        #region Connection
        public IDbConnection GetConnection()
        {
            var factory = DbProviderFactories.GetFactory("System.Data.SqlClient");
            var connection = factory.CreateConnection();
            connection.ConnectionString = connectionString;
            connection.Open();
            return connection;
        }

        public SqlConnection GetSqlConnection()
        {
            var connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }

        /// <summary>
        /// Gets the SQL connection read only.
        /// Use this entry for specific SP, call the second database used for read only
        /// </summary>
        /// <returns></returns>
        public SqlConnection GetSqlConnectionReadOnly()
        {
            var connection = new SqlConnection(connectionString + ";ApplicationIntent=ReadOnly;");
            connection.Open();
            return connection;
        }

        public async Task<SqlConnection> GetSqlConnectionAsync()
        {
            var connection = new SqlConnection(connectionString);
            try
            {
                await connection.OpenAsync();

            }
            catch (Exception ex)
            {

            }
            return connection;
        }

        /// <summary>
        /// Gets the SQL connection read only asynchronous.
        /// Use this entry for specific SP, call the second database used for read only
        /// </summary>
        /// <returns></returns>
        public async Task<SqlConnection> GetSqlConnectionReadOnlyAsync()
        {
            var connection = new SqlConnection(connectionString + ";ApplicationIntent=ReadOnly;");
            await connection.OpenAsync();
            return connection;
        }

        #endregion Connection

        #region Command

        public IDbCommand GetCommand(IDbConnection connection, string commandText, CommandType commandType = CommandType.StoredProcedure)
        {
            IDbCommand command = connection.CreateCommand();
            command.CommandType = commandType;
            command.CommandText = commandText;
            command.CommandTimeout = this.CommandTimeout;

            return command;
        }

        public SqlCommand GetSqlCommand(SqlConnection connection, string commandText, CommandType commandType = CommandType.StoredProcedure, int? commandTimeout = null)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandType = commandType;
            command.CommandText = commandText;
            command.CommandTimeout = commandTimeout ?? this.CommandTimeout;

            return command;
        }

        #endregion Command

        #region Parameters

        public static void AddParam(IDbCommand command, string name, object value)
        {
            var param = command.CreateParameter();
            param.ParameterName = "@" + name.TrimStart('@');
            param.Value = value;
            command.Parameters.Add(param);
        }

        public static void AddParamDictionary(IDbCommand command, Dictionary<string, object> dico)
        {
            foreach (KeyValuePair<string, object> item in dico)
            {
                var param = command.CreateParameter();
                param.ParameterName = "@" + item.Key.TrimStart('@');
                param.Value = item.Value;
                command.Parameters.Add(param);
            }
        }

        public static SqlParameter AddIntOutputParam(IDbCommand command, string name, object value = null, ParameterDirection direction = ParameterDirection.Output)
        {
            SqlParameter outputParam = new SqlParameter("@" + name.TrimStart('@'), SqlDbType.Int)
            {
                Direction = direction
            };
            if (value != null)
            {
                outputParam.SqlValue = value;
            }

            command.Parameters.Add(outputParam);
            return outputParam;
        }

        public static SqlParameter AddStringOutputParam(IDbCommand command, string name, object value = null, ParameterDirection direction = ParameterDirection.Output)
        {
            SqlParameter outputParam = new SqlParameter("@" + name.TrimStart('@'), SqlDbType.VarChar)
            {
                Direction = direction,
                Size = 200 //https://stackoverflow.com/questions/3759285/ado-net-the-size-property-has-an-invalid-size-of-0
            };
            if (value != null)
            {
                outputParam.SqlValue = value;
            }
            else
            {
                outputParam.SqlValue = DBNull.Value;
            }

            command.Parameters.Add(outputParam);
            return outputParam;
        }

        public static SqlParameter AddReturnParam(IDbCommand command)
        {
            SqlParameter outputParam = new SqlParameter()
            {
                Direction = ParameterDirection.ReturnValue
            };
            command.Parameters.Add(outputParam);
            return outputParam;
        }

        #endregion Parameters

        #region Reader

        /// <summary>
        /// GetValue batard qui teste rien du tout mais mute les exceptions
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="reader"></param>
        /// <param name="ColName"></param>
        /// <returns></returns>
        public static T GetValue<T>(IDataReader reader, string ColName)
        {
            try
            {
                int ordinal = reader.GetOrdinal(ColName);

                object tempResult = reader.GetValue(ordinal);
                return ConvertReaderValue<T>(tempResult);
            }
            catch (System.IndexOutOfRangeException e)
            {
                Debug.WriteLine("Cannot find or cast field with name " + ColName);
                // in that case, the parameter doesn't exist, so we return the default value
                return default(T);
            }
        }

        /// <summary>
        /// V2 du GetValue, sans le try-catch et le GetOrdinal bullshit
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="reader"></param>
        /// <param name="colName"></param>
        /// <returns></returns>
        public static T GetValueUnsafe<T>(IDataReader reader, string colName) => ConvertReaderValue<T>(reader[colName]);

        /// <summary>
        /// GetValue avec un vrai test d'existence de la colonne, mais du coup beaucoup plus lourd
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="reader"></param>
        /// <param name="colName"></param>
        /// <returns></returns>
        public static T GetValueSafe<T>(IDataReader reader, string colName)
        {
            // Get the column names
            var columns = Enumerable.Range(0, reader.FieldCount).Select(reader.GetName).ToList();
            // If the column exists in the reader
            if (columns.Any(c => c == colName))
            {
                return ConvertReaderValue<T>(reader[colName]);
            }
            return default(T);
        }

        /// <summary>
        /// Convertit la valeur récupéré du DbReader (hopefully)dans le bon type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public static T ConvertReaderValue<T>(object value)
        {
            try
            {
                // if the generic type is nullable and the value in the DB is null, we return the default value
                if (value == null || value == DBNull.Value)
                    return default(T);
                else if (typeof(T) == typeof(bool))
                {
                    // Cas particulier des bit SQL qui se castent mal
                    return (T)(object)Convert.ToBoolean(value);
                }
                else if (typeof(T) == typeof(int) || typeof(T) == typeof(int?))
                {
                    // Cas particulier des bit SQL qui se castent mal
                    return (T)(object)Convert.ToInt32(value);
                }
                else if (typeof(T) == typeof(string))
                {
                    return (T)(object)Convert.ToString(value);
                }
                else if (typeof(T) == typeof(double) || typeof(T) == typeof(double?))
                {
                    return (T)(object)Convert.ToDouble(value);
                }
                else if (typeof(T) == typeof(decimal) || typeof(T) == typeof(decimal?))
                {
                    return (T)(object)Convert.ToDecimal(value);
                }
                else if (typeof(T) == typeof(DateTime) || typeof(T) == typeof(DateTime?))
                {
                    return (T)(object)Convert.ToDateTime(value);
                }
                else
                {
                    return (T)value;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Canno't cast value with type " + value.GetType().Name + " to type " + typeof(T).Name);
                throw ex;
            }
        }

        public static bool TryGetValue<T>(IDataReader reader, string ColName, out T result)
        {
            result = default(T);
            int? ordinal = reader.GetOrdinal(ColName);
            if (ordinal.HasValue)
            {
                result = (T)reader.GetValue(ordinal.Value);
                return true;
            }
            else return false;
        }

        #endregion Reader

        public static void AddParamToCommand<T>(IDbCommand command, string name, T value)
        {
            var _param = command.CreateParameter();
            _param.ParameterName = name;
            _param.Value = value != null ? value : (object)DBNull.Value;
            command.Parameters.Add(_param);
        }

        public static void AddStringToCommandWithEmpyIsNull(IDbCommand command, string name, string value)
        {
            var _param = command.CreateParameter();
            _param.ParameterName = name;
            _param.Value = !string.IsNullOrEmpty(value) ? value : (object)DBNull.Value;
            command.Parameters.Add(_param);
        }

        #region DataTables

        public static DataTable CreateIdDataTable<T>(IEnumerable<T> items)
        {
            DataTable ListIds = new DataTable();

            ListIds.Columns.Add("Id", typeof(T));

            if (items != null)
            {
                foreach (var item in items)
                {
                    DataRow ListIdsRow = ListIds.NewRow();
                    ListIdsRow["Id"] = item;
                    ListIds.Rows.Add(ListIdsRow);
                    ListIds.AcceptChanges();
                }
            }

            return ListIds;
        }

        public static DataTable CreateIntBitDataTable(IEnumerable<Tuple<int, bool>> items)
        {
            DataTable ListIds = new DataTable();
            ListIds.Columns.Add("Id", typeof(int));
            ListIds.Columns.Add("Indicator", typeof(bool));

            if (items != null)
            {
                foreach (var item in items)
                {
                    DataRow ListIdsRow = ListIds.NewRow();
                    ListIdsRow["Id"] = item.Item1;
                    ListIdsRow["Indicator"] = item.Item2;
                    ListIds.Rows.Add(ListIdsRow);
                    ListIds.AcceptChanges();
                }
            }
            return ListIds;
        }

        //public static DataTable CreateDossierIdDataTable(IEnumerable<DossierIdentifier> items)
        //{
        //    //TODO : CSA - to continue, duplicate this function for ApiShipment.ListJobFile (same but with an id)
        //    DataTable ListJobFiles = new DataTable();
        //    ListJobFiles.Columns.Add("COD_EXP", typeof(string));
        //    ListJobFiles.Columns.Add("COD_CEL", typeof(string));
        //    ListJobFiles.Columns.Add("NUM_DOS", typeof(int));

        //    if (items != null)
        //    {
        //        foreach (DossierIdentifier item in items)
        //        {
        //            DataRow ListJobFilesRow = ListJobFiles.NewRow();
        //            ListJobFilesRow["COD_EXP"] = item.CodExp;
        //            ListJobFilesRow["COD_CEL"] = item.CodCel;
        //            ListJobFilesRow["NUM_DOS"] = item.NumDos;
        //            ListJobFiles.Rows.Add(ListJobFilesRow);
        //            ListJobFiles.AcceptChanges();
        //        }
        //    }
        //    return ListJobFiles;
        //}

        /// <summary>
        /// Create a Dossier Identifier DataTable with temp Id for regroup.
        /// </summary>
        /// <param name="items">List of IdForRegroup, CodExp, CodCel, NumDos (DossierIdentifier).</param>
        /// <returns></returns>
        //public static DataTable CreateDossierIdDataTableWithTempId(IEnumerable<DossierIdentifier> items)
        //{
        //    DataTable ListJobFiles = new DataTable();
        //    ListJobFiles.Columns.Add("Id", typeof(int));
        //    ListJobFiles.Columns.Add("COD_EXP", typeof(string));
        //    ListJobFiles.Columns.Add("COD_CEL", typeof(string));
        //    ListJobFiles.Columns.Add("NUM_DOS", typeof(int));

        //    if (items != null)
        //    {
        //        foreach (DossierIdentifier item in items)
        //        {
        //            DataRow ListJobFilesRow = ListJobFiles.NewRow();
        //            ListJobFilesRow["Id"] = item.IdForRegroup ?? (object)DBNull.Value;
        //            ListJobFilesRow["COD_EXP"] = item.CodExp;
        //            ListJobFilesRow["COD_CEL"] = item.CodCel;
        //            ListJobFilesRow["NUM_DOS"] = item.NumDos ?? (object)DBNull.Value;
        //            ListJobFiles.Rows.Add(ListJobFilesRow);
        //            ListJobFiles.AcceptChanges();
        //        }
        //    }
        //    return ListJobFiles;
        //}

        //public static DataTable CreateWarehouseIdDataTable(IEnumerable<WarehouseIdentifier> items)
        //{
        //    DataTable ListWarehouses = new DataTable();
        //    ListWarehouses.Columns.Add("COD_WHR", typeof(string));
        //    ListWarehouses.Columns.Add("NUM_RCP", typeof(int));

        //    if (items != null)
        //    {
        //        foreach (WarehouseIdentifier item in items)
        //        {
        //            DataRow ListWarehousesRow = ListWarehouses.NewRow();
        //            ListWarehousesRow["COD_WHR"] = item.WarehouseCode;
        //            ListWarehousesRow["NUM_RCP"] = item.ReceiptId;
        //            ListWarehouses.Rows.Add(ListWarehousesRow);
        //            ListWarehouses.AcceptChanges();
        //        }
        //    }

        //    return ListWarehouses;
        //}

        public static void AddParamListIds<T>(IDbCommand command, string parameterName, IEnumerable<T> items)
        {
            DataTable ListIds = CreateIdDataTable(items);

            var _paramIds = command.CreateParameter();
            _paramIds.ParameterName = parameterName;
            _paramIds.Value = ListIds;
            command.Parameters.Add(_paramIds);
        }

        public static void AddParamListIds<T>(SqlCommand command, string parameterName, IEnumerable<T> items, string typename = null)
        {
            DataTable ListIds = CreateIdDataTable(items);

            var _paramIds = command.CreateParameter();
            _paramIds.ParameterName = "@" + parameterName.TrimStart('@');
            _paramIds.Value = ListIds;
            if (typename != null)
                _paramIds.TypeName = typename;
            command.Parameters.Add(_paramIds);
        }

        #endregion DataTables
    }
    public static class IDbCommandExtensions
    {
        public static void AddParam<T>(this IDbCommand command, string name, T value)
        {
            var _param = command.CreateParameter();
            _param.ParameterName = name;
            _param.Value = value != null ? value : (object)DBNull.Value;
            command.Parameters.Add(_param);
        }

        public static void AddDataTableParam(this IDbCommand command, string name, DataTable table)
        {
            var _param = command.CreateParameter();
            _param.ParameterName = name;
            _param.Value = table;
            command.Parameters.Add(_param);
        }
    }
}
