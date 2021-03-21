using PersonnelASPnetCore.Domaine.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositoriesDAL
{
    public interface IDeclarationCNSSRepository
    {
        IEnumerable<DECLARATION_CNSS> GetAllDeclarationCNSSsPS();
        Task CreateDeclarationCNSSPSAsync(DECLARATION_CNSS DeclarationCNSS);
        void UpdateDeclarationCNSSPS(DECLARATION_CNSS DeclarationCNSS);
        DECLARATION_CNSS_DETAIL GetDeclarationCNSSDetailsPS(string MatriculeSecuriteSociale);
        void DeleteDeclarationCNSSPS(int Annee, int Trimestre);
    }
}