﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ADVICEDomaine.Entities;

namespace ADVICEData.IRepositoriesDAL
{
    public interface IBanqueRepository
    {
        IEnumerable<BANQUE> GetAllBanquesPS();
        BANQUE GetBanquesPSbyCode(string codeBanque);
        Task<BANQUE> GetBanqueByCodeAsync(string codeBanque);
        Task CreateBanquePSAsync(BANQUE Banque);
        void UpdateBanquePS(BANQUE Banque);
        BANQUE GetBanqueDetailsPS(string codeBanque);
        void DeleteBanquePS(string codeBanque);
    }
}
