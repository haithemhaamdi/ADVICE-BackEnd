using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositoriesDAL
{
    public interface IConnectionHistoryRepository<T> : IRepositoryBaseAsync<T> where T : class
    {
        Task ConnectionHistoryPSAsync(CONNECTIONS_HISTORY cONNECTIONS_HISTORY);
    }
}
