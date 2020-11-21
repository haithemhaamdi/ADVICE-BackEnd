using ADVICEData.Infrastructure;
using ADVICEDomaine.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ADVICEData.IRepositoriesDAL
{
    public interface IConnectionHistoryRepository<T> : IRepositoryBaseAsync<T> where T : class
    {
        Task ConnectionHistoryPSAsync(CONNECTIONS_HISTORY cONNECTIONS_HISTORY);
    }
}
