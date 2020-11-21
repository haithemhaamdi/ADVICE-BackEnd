using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Infrastructure
{
    public interface IRepositoryBase<T>
        where T : class
    {
        void Add(T entity);
        void Delete(Expression<Func<T, bool>> where);
        void Delete(T entity);
        T Get(Expression<Func<T, bool>> where);
        IEnumerable<T> Get
            (
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "",  string includeProperties2 = "", string includeProperties3 = ""
            );

        IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression);
        T GetById(long id);
        T GetById(string id);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetMany(Expression<Func<T, bool>> where = null, Expression<Func<T, bool>> orderBy = null);
        void Update(T entity);
        void Save();

    }
}
