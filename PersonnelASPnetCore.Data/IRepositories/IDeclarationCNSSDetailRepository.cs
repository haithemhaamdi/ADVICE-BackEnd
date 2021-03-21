using PersonnelASPnetCore.Domaine.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IDeclarationCNSSDetailRepository
    {
        IEnumerable<DECLARATION_CNSS_DETAIL> GetAllDeclarationCNSSDetails();
        Task<IEnumerable<DECLARATION_CNSS_DETAIL>> GetAllDeclarationCNSSDetailsAsync();
    }
}