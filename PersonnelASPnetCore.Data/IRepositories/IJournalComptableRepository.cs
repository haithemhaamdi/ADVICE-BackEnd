using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IJournalComptableRepository
    {
        void CreateJournalComptable(JOURNAL_COMPTABLE JournalComptable);
        Task CreateJournalComptableAsync(JOURNAL_COMPTABLE JournalComptable);
        JOURNAL_COMPTABLE GetJournalComptableByCodeJournalComptable(string CodeJournalComptable);
        JOURNAL_COMPTABLE GetJournalComptableByNumeroCompteComptable(string NumeroCompteComptable);
        IEnumerable<JOURNAL_COMPTABLE> GetAllJournalComptables();
        IEnumerable<JOURNAL_COMPTABLE> GetAllWithRefernces();
        Task<IEnumerable<JOURNAL_COMPTABLE>> GetAllJournalComptablesAsync();
        Task<JOURNAL_COMPTABLE> GetJournalComptableByCodeJournalComptableAsync(string CodeJournalComptable);
        void UpdateJournalComptable(JOURNAL_COMPTABLE JournalComptable);
        Task UpdateJournalComptableAsync(JOURNAL_COMPTABLE JournalComptable);
        void DeleteJournalComptable(JOURNAL_COMPTABLE JournalComptable);
        Task DeleteJournalComptableAsync(JOURNAL_COMPTABLE JournalComptable);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}
