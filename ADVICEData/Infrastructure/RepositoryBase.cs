using Microsoft.EntityFrameworkCore;
using ADVICEDomaine.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ADVICEData.Infrastructure
{
    public abstract class RepositoryBase<T> : IRepositoryBaseAsync<T> where T : class
    {
        //private ARTIPERSONNEL_SOC001Context dataContext;
        protected ARTIPERSONNEL_SOC001Context RepositoryContext { get; set; }
        private readonly DbSet<T> dbset;

        //IDatabaseFactory databaseFactory;

        //Constructeur RepositoryBase qui prend en paramétre le dataContext 
        //public RepositoryBase(IDatabaseFactory dbFactory)
        public RepositoryBase(ARTIPERSONNEL_SOC001Context repositoryContext)
        {
            //this.databaseFactory = dbFactory;
            this.RepositoryContext = repositoryContext;
            dbset = RepositoryContext.Set<T>();
        }

        //protected ARTIPERSONNEL_SOC001Context DataContext
        //{
        //    get { return dataContext = databaseFactory._dataContext; }
        //}


        #region Async methos
        public async Task<int> CountAsync()
        {
            return await dbset.CountAsync();
        }
        public async Task<List<T>> FindAllAsync(Expression<Func<T, bool>> match)
        {
            return await dbset.Where(match).ToListAsync();
        }
        public async Task<T> FindAsync(Expression<Func<T, bool>> match)
        {
            return await dbset.SingleOrDefaultAsync(match);
        }
        public async Task<List<T>> GetAllAsync()
        {
            return await dbset.ToListAsync();
        }
        public async Task<IEnumerable<T>> FindALLByConditionAync(Expression<Func<T, bool>> match)
        {
            return await dbset.Where(match).ToListAsync();
        }
        public async Task<IEnumerable<T>> FindAllAsync()
        {
            return await dbset.ToListAsync();
        }
        public async Task<T> FindByIDAsync(long id)
        {
            return await dbset.FindAsync(id);
        }
        public async Task SaveAsync()
        {
            await RepositoryContext.SaveChangesAsync();
        }
        public async Task<IEnumerable<T>> FindByConditionAync(Expression<Func<T, bool>> expression)
        {
            return await dbset.Where(expression).ToListAsync();
        }

        public async Task<T> FindByName(string name)
        {
            return await dbset.FindAsync(name);
        }

        public async Task<IEnumerable<T>> GetAllAsynchrone()
        {
            return await dbset.ToListAsync();
        }

        #endregion

        #region Synch Methods

        public void Add(T entity)
        {
            dbset.Add(entity);
        }

        public void Delete(Expression<Func<T, bool>> where)
        {
            IEnumerable<T> objects = dbset.Where<T>(where).AsEnumerable();
            foreach (T obj in objects)
                dbset.Remove(obj);
        }

        public void Delete(T entity)
        {
            dbset.Remove(entity);
        }

        public T Get(Expression<Func<T, bool>> where)
        {
            return dbset.Where(where).FirstOrDefault<T>();
        }

        public T GetById(long id)
        {
            return dbset.Find(id);
        }

        public T GetById(string id)
        {
            return dbset.Find(id);
        }
        public IEnumerable<T> GetMany(Expression<Func<T, bool>> where = null, Expression<Func<T, bool>> orderBy = null)
        {
            IQueryable<T> Query = dbset;
            if (where != null)
            {
                Query = Query.Where(where);
            }
            if (orderBy != null)
            {
                Query = Query.OrderBy(orderBy);
            }
            return Query;
        }

        public void Update(T entity)
        {
            dbset.Attach(entity);
            RepositoryContext.Entry(entity).State = EntityState.Modified;
        }

        public IEnumerable<T> GetAll()
        {
            return dbset.ToList();
        }

        public IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return dbset.Where(expression);
        }

        public void Save()
        {
            RepositoryContext.SaveChanges();
        }


        public virtual IEnumerable<T> Get(Expression<Func<T, bool>> filter = null,Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,string includeProperties = "", string includeProperties2 = "", string includeProperties3 = "")
        {
            IQueryable<T> query = dbset;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                foreach (var includeProperty2 in includeProperties2.Split
                    (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty).Include(includeProperties2);
                }
            }
            

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }

        public async Task<T> SaveAsync(T entity)
        {
            await RepositoryContext.SaveChangesAsync();
            return entity;
        }
        #endregion

    }
}
