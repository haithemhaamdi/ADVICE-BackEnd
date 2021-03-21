using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class DeclarationCNSSRepository : RepositoryBase<DECLARATION_CNSS>, IDeclarationCNSSRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;
        public DeclarationCNSSRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration) : base(repositoryContext)
        {
            _ConnectionString = configuration;
            _ctx = repositoryContext;
        }

        public void Commit()
        {
            _ctx.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _ctx.SaveChangesAsync();
        }

        public void CreateDeclarationCNSS(DECLARATION_CNSS declarationCNSS)
        {
            Add(declarationCNSS);
            Save();
        }

        public async Task CreateDeclarationCNSSAsync(DECLARATION_CNSS declarationCNSS)
        {
            Add(declarationCNSS);
            await SaveAsync();
        }

        public void DeleteDeclarationCNSS(DECLARATION_CNSS declarationCNSS)
        {
            Delete(declarationCNSS);
            Save();
        }

        public async Task DeleteDeclarationCNSSAsync(DECLARATION_CNSS declarationCNSS)
        {
            Delete(declarationCNSS);
            await SaveAsync();
        }

        public void Dispose()
        {
            RepositoryContext.Dispose();
        }

        public IEnumerable<DECLARATION_CNSS> GetAllDeclarationCNSS()
        {
            return GetAll()
                .OrderBy(d => d.DateDeclaration);
        }

        public async Task<IEnumerable<DECLARATION_CNSS>> GetAllDeclarationCNSSsAsync()
        {
            var declarationCNSS = await FindAllAsync();
            return declarationCNSS.OrderBy(d => d.DateDeclaration);
        }

        public IEnumerable<DECLARATION_CNSS> GetAllWithRefernces()
        {
            throw new NotImplementedException();
        }

        public DECLARATION_CNSS GetDeclarationCNSSByCodeOperateur(string codeOperateur)
        {
            return FindByCondition(d => d.CodeOperateur.Equals(codeOperateur))
                    .DefaultIfEmpty(new DECLARATION_CNSS())
                    .FirstOrDefault();
        }

        public Task<DECLARATION_CNSS> GetDeclarationCNSSByDateAsync(DateTime dateDeclaration)
        {
            throw new NotImplementedException();
        }

        public void UpdateDeclarationCNSS(DECLARATION_CNSS declarationCNSS)
        {
            Update(declarationCNSS);
            Save();
        }

        public async Task UpdateDeclarationCNSSAsync(DECLARATION_CNSS declarationCNSS)
        {
            Update(declarationCNSS);
            await SaveAsync();
        }
    }
}