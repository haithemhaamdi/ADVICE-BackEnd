using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IAvancement_DetailRepository
    {
        IEnumerable<AVANCEMENT_DETAIL> GetAllAvancementDetails();
        Task<IEnumerable<AVANCEMENT_DETAIL>> GetAllAvancementDetailsAsync();
    }
}
