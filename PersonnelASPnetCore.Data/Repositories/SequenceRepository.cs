using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class SequenceRepository : RepositoryBase<SEQUENCE>, ISequenceRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public SequenceRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
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

        public void CreateSequence(SEQUENCE Sequence)
        {
            throw new NotImplementedException();
        }

        public Task CreateSequenceAsync(SEQUENCE Sequence)
        {
            throw new NotImplementedException();
        }

        public void DeleteSequence(SEQUENCE Sequence)
        {
            throw new NotImplementedException();
        }

        public Task DeleteSequenceAsync(SEQUENCE Sequence)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SEQUENCE> GetAllSequences()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SEQUENCE>> GetAllSequencesAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SEQUENCE> GetAllWithRefernces()
        {
            throw new NotImplementedException();
        }

        public SEQUENCE GetSequenceByAnnee(DateTime Annee)
        {
            throw new NotImplementedException();
        }

        public Task<SEQUENCE> GetSequenceByAnneeAsync(DateTime Annee)
        {
            throw new NotImplementedException();
        }

        public void UpdateSequence(SEQUENCE Sequence)
        {
            throw new NotImplementedException();
        }

        public Task UpdateSequenceAsync(SEQUENCE Sequence)
        {
            throw new NotImplementedException();
        }
    }
}