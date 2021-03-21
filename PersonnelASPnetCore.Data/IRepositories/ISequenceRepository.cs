using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface ISequenceRepository
    {
        void CreateSequence(SEQUENCE Sequence);
        Task CreateSequenceAsync(SEQUENCE Sequence);
        SEQUENCE GetSequenceByAnnee(DateTime Annee);
        IEnumerable<SEQUENCE> GetAllSequences();
        IEnumerable<SEQUENCE> GetAllWithRefernces();
        Task<IEnumerable<SEQUENCE>> GetAllSequencesAsync();
        Task<SEQUENCE> GetSequenceByAnneeAsync(DateTime Annee);
        void UpdateSequence(SEQUENCE Sequence);
        Task UpdateSequenceAsync(SEQUENCE Sequence);
        void DeleteSequence(SEQUENCE Sequence);
        Task DeleteSequenceAsync(SEQUENCE Sequence);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}