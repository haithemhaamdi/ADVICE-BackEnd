using PersonnelASPnetCore.Domaine.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositoriesDAL
{
    public interface IDeclarationCNSSDetailRepository
    {
        //Task CreateDeclarationCNSSDetailPSAsync(DECLARATION_CNSS_DETAIL DeclarationCNSSDetail);
        IEnumerable<DECLARATION_CNSS_DETAIL> GetAllDeclarationCNSSDetailsPS();
        void UpdateDeclarationCNSSDetailPS(DECLARATION_CNSS_DETAIL DeclarationCNSSDetail);
        DECLARATION_CNSS_DETAIL GetDeclarationCNSSDetailsPS(string MatriculeSecuriteSociale);
        void DeleteDeclarationCNSSDetailPS(int Annee, int Trimestre);
    }
}