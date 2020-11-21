using ADVICEData.Infrastructure;
using ADVICEDomaine.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ADVICEData.IRepositoriesDAL
{
    public interface IBulletin_PaieRepository
    {
        IEnumerable<BULLETIN_PAIE> GetAllBulletinPaiesPS();
        Task<BULLETIN_PAIE> GetBulletinPaiePSbyNumero(string NumeroBulletin);
        Task CreateBulletinPaiePSAsync(BULLETIN_PAIE BulletinPaie);
        void UpdateBulletinPaiePS(BULLETIN_PAIE BulletinPaie);
        BULLETIN_PAIE_DETAIL GetBulletinPaieDetailsPS(string NumeroBulletin, string CodeRubrique);
        void DeleteBulletinPaiePS(string NumeroBulletin);
    }
}
