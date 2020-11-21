using PersonnelASPnetCore.Data.Repositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private ARTIPERSONNEL_SOC001Context dataContext;
        IDatabaseFactory dbFactory;

        //constructeur
        public UnitOfWork(IDatabaseFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        protected ARTIPERSONNEL_SOC001Context DataContext
        {
            get
            {
                return dataContext = dbFactory._dataContext;
            }
        }
        //private IEmployeRepository employeRepository;
        //public IEmployeRepository EmployeRepository
        //{
        //    get { return employeRepository = new EmployeeRepository(dbFactory); }
        //}

        //private IUserRepository userRepository;
        //public IUserRepository UserRepository
        //{
        //    get { return userRepository = new UserRepository(dbFactory); }
        //}

        public void commit()
        {
            DataContext.SaveChanges();
        }
        public void Dispose()
        {
            dbFactory.Dispose();
        }

        //public IRepositoryBaseAsync<T> getRepository<T>() where T : class
        //{
        //    IRepositoryBaseAsync<T> repo = new RepositoryBase<T>(dbFactory);
        //    return repo;
        //}

        public async Task CommitAsync()
        {
            await dataContext.SaveChangesAsync();
        }
    }
}
