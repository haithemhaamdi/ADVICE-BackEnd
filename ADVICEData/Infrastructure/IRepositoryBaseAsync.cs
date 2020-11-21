using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ADVICEData.Infrastructure
{
    public interface IRepositoryBaseAsync<T> : IRepositoryBase<T> where T : class
    {
        Task<int> CountAsync();
        Task<IEnumerable<T>> FindAllAsync();
        Task<IEnumerable<T>> FindALLByConditionAync(Expression<Func<T, bool>> match);
        Task<IEnumerable<T>> FindByConditionAync(Expression<Func<T, bool>> match);
        Task<T> FindByIDAsync(long id);
        Task<List<T>> GetAllAsync();
        Task<IEnumerable<T>> GetAllAsynchrone();
        Task<T> FindByName(string name);
        Task SaveAsync();
        Task<T> SaveAsync(T entity);


    }
}
