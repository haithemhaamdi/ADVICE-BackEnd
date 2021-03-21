using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class TypeContratRepository : RepositoryBase<TYPE_CONTRAT>, ITypeContratRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public TypeContratRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
    : base(repositoryContext)
        {
            _ConnectionString = configuration;
            _ctx = repositoryContext;
            {
            }
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public Task CommitAsync()
        {
            throw new NotImplementedException();
        }

        public void CreateTypeContrat(TYPE_CONTRAT TypeContrat)
        {
            throw new NotImplementedException();
        }

        public Task CreateTypeContratAsync(TYPE_CONTRAT TypeContrat)
        {
            throw new NotImplementedException();
        }

        public void DeleteTypeContrat(TYPE_CONTRAT TypeContrat)
        {
            throw new NotImplementedException();
        }

        public Task DeleteTypeContratAsync(TYPE_CONTRAT TypeContrat)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TYPE_CONTRAT> GetAllTypeContrats()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TYPE_CONTRAT>> GetAllTypeContratsAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TYPE_CONTRAT> GetAllWithRefernces()
        {
            throw new NotImplementedException();
        }

        public TYPE_CONTRAT GetTypeContratByCodeTypeContrat(string CodeTypeContrat)
        {
            throw new NotImplementedException();
        }

        public Task<TYPE_CONTRAT> GetTypeContratByCodeTypeContratAsync(string CodeTypeContrat)
        {
            throw new NotImplementedException();
        }

        public TYPE_CONTRAT GetTypeContratByLibelleTypeContrat(string LibelleTypeContrat)
        {
            throw new NotImplementedException();
        }

        public void UpdateTypeContrat(TYPE_CONTRAT TypeContrat)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTypeContratAsync(TYPE_CONTRAT TypeContrat)
        {
            throw new NotImplementedException();
        }
    }
}