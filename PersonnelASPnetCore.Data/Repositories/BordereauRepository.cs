using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class BordereauRepository : RepositoryBase<BORDEREAU>, IBordereauRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public BordereauRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
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

        public void CreateBordereau(BORDEREAU Bordereau)
        {
            throw new NotImplementedException();
        }

        public Task CreateBordereauAsync(BORDEREAU Bordereau)
        {
            throw new NotImplementedException();
        }

        public void DeleteBordereau(BORDEREAU Bordereau)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBordereauAsync(BORDEREAU Bordereau)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BORDEREAU> GetAllBordereaus()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BORDEREAU>> GetAllBordereausAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BORDEREAU> GetAllWithRefernces()
        {
            throw new NotImplementedException();
        }

        public BORDEREAU GetBordereauByDateBordereau(DateTime DateBordereau)
        {
            throw new NotImplementedException();
        }

        public BORDEREAU GetBordereauByNumeroBordereau(string NumeroBordereau)
        {
            throw new NotImplementedException();
        }

        public Task<BORDEREAU> GetBordereauByNumeroBordereauAsync(string NumeroBordereau)
        {
            throw new NotImplementedException();
        }

        public void UpdateBordereau(BORDEREAU Bordereau)
        {
            throw new NotImplementedException();
        }

        public Task UpdateBordereauAsync(BORDEREAU Bordereau)
        {
            throw new NotImplementedException();
        }
    }
}