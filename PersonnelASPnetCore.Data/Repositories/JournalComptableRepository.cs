using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class JournalComptableRepository : RepositoryBase<JOURNAL_COMPTABLE>, IJournalComptableRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public JournalComptableRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
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

        public void CreateJournalComptable(JOURNAL_COMPTABLE JournalComptable)
        {
            throw new NotImplementedException();
        }

        public Task CreateJournalComptableAsync(JOURNAL_COMPTABLE JournalComptable)
        {
            throw new NotImplementedException();
        }

        public void DeleteJournalComptable(JOURNAL_COMPTABLE JournalComptable)
        {
            throw new NotImplementedException();
        }

        public Task DeleteJournalComptableAsync(JOURNAL_COMPTABLE JournalComptable)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<JOURNAL_COMPTABLE> GetAllJournalComptables()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<JOURNAL_COMPTABLE>> GetAllJournalComptablesAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<JOURNAL_COMPTABLE> GetAllWithRefernces()
        {
            throw new NotImplementedException();
        }

        public JOURNAL_COMPTABLE GetJournalComptableByCodeJournalComptable(string CodeJournalComptable)
        {
            throw new NotImplementedException();
        }

        public Task<JOURNAL_COMPTABLE> GetJournalComptableByCodeJournalComptableAsync(string CodeJournalComptable)
        {
            throw new NotImplementedException();
        }

        public JOURNAL_COMPTABLE GetJournalComptableByNumeroCompteComptable(string NumeroCompteComptable)
        {
            throw new NotImplementedException();
        }

        public void UpdateJournalComptable(JOURNAL_COMPTABLE JournalComptable)
        {
            throw new NotImplementedException();
        }

        public Task UpdateJournalComptableAsync(JOURNAL_COMPTABLE JournalComptable)
        {
            throw new NotImplementedException();
        }
    }
}
