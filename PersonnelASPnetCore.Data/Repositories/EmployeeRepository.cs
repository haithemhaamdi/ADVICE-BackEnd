using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class EmployeRepository : RepositoryBase<EMPLOYE>, IEmployeRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public EmployeRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
    : base(repositoryContext)
        {
            _ConnectionString = configuration;
            _ctx = repositoryContext;
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public Task CommitAsync()
        {
            throw new NotImplementedException();
        }

        public void CreateEmploye(EMPLOYE Employe)
        {
            Add(Employe);
            Save();
        }

        public async Task CreateEmployeAsync(EMPLOYE Employe)
        {
            Add(Employe);
            await SaveAsync();
        }

        public async void DeleteEmploye(EMPLOYE Employe)
        {
            //uow.getRepository<Employe>().Delete(Employe);
            Delete(Employe);
            await SaveAsync();
        }

        public void Dispose()
        {
            RepositoryContext.DisposeAsync();
        }

        public IEnumerable<EMPLOYE> GetAllEmployes()
        {
            return GetAll()
                .OrderBy(emp => emp.CodeEmploye);
        }

        public async Task<IEnumerable<EMPLOYE>> GetAllEmployesAsync()
        {
            var Employees = await FindAllAsync();
            return Employees.OrderBy(x => x.CodeEmploye);
        }

        public EMPLOYE GetEmployeByID(string code)
        {
            return FindByCondition(Emp=>Emp.CodeEmploye.Equals(code))
                    .DefaultIfEmpty(new EMPLOYE())
                    .FirstOrDefault();
        }

        public async Task<EMPLOYE> GetEmployeByIDAsync(string Code)
        {
            var Employee = await FindByConditionAync(o => o.CodeEmploye.Equals(Code));
            return Employee.DefaultIfEmpty(new EMPLOYE())
                    .FirstOrDefault();
        }

        public async void UpdateEmploye(EMPLOYE Employe)
        {
            //uow.getRepository<Employe>().Delete(Employe);
            //Save();
            Update(Employe);
            await SaveAsync();
        }
    }

    #region EmployeesByPayslip & HighestPaidEmployeesByRegion
    //public static IEnumerable<Employe> EmployeesByPayslip(this IRepositoryBaseAsync<BulletinPaie> repository, string CodeEmploye)
    //{
    //    return repository.GetById(CodeEmploye).CodeEmployeNavigation.AsEnumerable();
    //        //.CodeEmploye.AsEnumerable();

    //}
    //public static IEnumerable<Employe>HighestPaidEmployeesByRegion(this IRepositoryBaseAsync<BulletinPaie> repository, string CodeEmploye)
    //{
    //    return repository.EmployeesByPayslip(CodeEmploye)
    //        .OrderByDescending(b => b.SalaireBase)
    //        .Take(5)
    //        .AsEnumerable();
    //}
    #endregion

    #region ScorePerByEmployee & EmployeesWithAMinimumScore

    //public static IEnumerable<Pointage> ScorePerByEmployee(this IRepositoryBaseAsync<Employe> repository, string code)
    //{
    //    return repository.GetById(code).Pointages.AsEnumerable();
    //}
    //public static IEnumerable<Employe> EmployeesWithAMinimumScore(this IRepositoryBaseAsync<Pointage> repository, string code)
    //{
    //    // Calculate the number of hours worked per month
    //    var calculenbrHeurs;
    //    // Recover the amount of hours worked by an employee X

    //    return repository.EmployeesWithAMinimumScore(code)
    //         .Where() 
    //        .OrderBy(b => b.);
    //        .Take(5)
    //        .AsEnumerable();
    //}
    #endregion

    #region GetAllEmploye

    //public static IEnumerable<Employe> AllEmploye(this IRepositoryBaseAsync<Employe> repository)
    //{
    //    return repository.GetAll();
    //}

    #endregion

    //public class EmployeRepository : RepositoryBase<Employe>, IEmployeRepository
    //{
    //    public EmployeRepository(IDatabaseFactory dbFactory)
    //          : base(dbFactory)
    //    {
    //    }
    //}
    //public interface IEmployeRepository : IRepositoryBaseAsync<Employe> { }

    //}
}
