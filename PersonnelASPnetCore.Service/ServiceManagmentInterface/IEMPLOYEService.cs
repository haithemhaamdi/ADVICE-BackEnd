using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Service.ServiceManagmentInterface
{
    public interface IEMPLOYEService
    {
        void CreateEmploye(EMPLOYE employe);
        EMPLOYE GetEmployeByID(string code);
        EMPLOYE GetEmployeByName(string prenom);
        IEnumerable<EMPLOYE> GetAllEmployes();
        //Task<List<Employe>> FindAllEmployeAsync(Expression<Func<Employe, bool>> employe);
        void UpdateEmploye(EMPLOYE employe);
        void DeleteEmploye(EMPLOYE employe);
        void Commit();
        void CommitAsync();
        void Dispose();
    }
}
