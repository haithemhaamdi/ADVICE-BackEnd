using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.IRepositoriesDAL;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonnelASPnetCore.Data.RepositoriesDAL
{
    public class ActiviteRepository : IActiviteRepository
    {
        #region Configuration ConnectionString + DI
        //put your connection string here
        IConfiguration _ConnectionString;
        protected ARTIPERSONNEL_SOC001Context _repositoryContext { get; set; }

        public ActiviteRepository(IConfiguration configuration, ARTIPERSONNEL_SOC001Context repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _ConnectionString = configuration;
        }
        #endregion
    }
}
