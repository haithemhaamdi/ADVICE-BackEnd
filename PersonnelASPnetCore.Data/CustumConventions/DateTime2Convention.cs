using System;
using System.Collections.Generic;
using System.Text;


namespace PersonnelASPnetCore.Data.CustumConventions
{
    /// <summary>
    /// DATETIME2 has a date range of "0001 / 01 / 01" through "9999 / 12 / 31" while the DATETIME type only supports year 1753-9999.
    /// </summary>
    //class DateTime2Convention : Convention
    //{
    //    public DateTime2Convention()
    //    {
    //        this.Properties<DateTime>().Configure(c => c.HasColumnType("datetime2"));
    //    }
    //}
}
