using ADVICEData;
using ADVICEData.Infrastructure;
using ADVICEDomaine.Entities;
using ADVICEService.ServiceManagmentInterface;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ADVICEService.ServiceManagmentImplementation
{
    public class EMPLOYEService : IEMPLOYEService
    {
        DatabaseFactory dbFactory = null;
        IUnitOfWork uow = null;

        public EMPLOYEService()
        {
            dbFactory = new DatabaseFactory();
            uow = new UnitOfWork(dbFactory);
        }
        public void Commit()
        {
            try
            {
                uow.commit();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void CommitAsync()
        {

            try
            {
                uow.CommitAsync();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void CreateEmploye(EMPLOYE employe)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmploye(EMPLOYE employe)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EMPLOYE> GetAllEmployes()
        {
            throw new NotImplementedException();
        }

        public EMPLOYE GetEmployeByID(string code)
        {
            throw new NotImplementedException();
        }

        public EMPLOYE GetEmployeByName(string prenom)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmploye(EMPLOYE employe)
        {
            throw new NotImplementedException();
        }

        //public void CreateEmploye(Employe Employe)
        //{
        //    uow.getRepository<Employe>().Add(Employe);

        //}

        //public void DeleteEmploye(Employe Employe)
        //{
        //    uow.getRepository<Employe>().Delete(Employe);
        //}

        //public void Dispose()
        //{
        //    uow.Dispose();
        //}

        //public async Task<IEnumerable<Employe>> GetAllEmployes()
        //{
        //    return await uow.getRepository<Employe>().GetAllAsync();
        //}

        //public Employe GetEmployeByID(int id)
        //{
        //    var Employe = uow.getRepository<Employe>().GetById(id);
        //    return Employe;
        //}

        //public Employe GetEmployeByID(string code)
        //{
        //    var Employe = uow.getRepository<Employe>().GetById(code);
        //    return Employe;
        //}

        //public Employe GetEmployeByName(string prenom)
        //{
        //   var Employe = uow.getRepository<Employe>().GetById(prenom);
        //    return Employe;
        //}

        //public void UpdateEmploye(Employe Employe)
        //{
        //    uow.getRepository<Employe>().Delete(Employe);
        //}

        //IEnumerable<Employe> IEMPLOYEService.GetAllEmployes()
        //{
        //    var Employes = uow.getRepository<Employe>().GetAll();
        //    return  Employes;
        //}
    }
}
