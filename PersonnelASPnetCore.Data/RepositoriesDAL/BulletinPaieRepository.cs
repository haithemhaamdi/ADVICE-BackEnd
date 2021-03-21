using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.RepositoriesDAL
{
    public class BulletinPaieRepository :  RepositoryBase<BULLETIN_PAIE>, IBulletinPaieRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public BulletinPaieRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
    : base(repositoryContext)
        {
            _ConnectionString = configuration;
            _ctx = repositoryContext;
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public Task CommitAsync()
        {
            throw new NotImplementedException();
        }

        public void CreateBulletinPaie(BULLETIN_PAIE bulletinPaie)
        {
            Add(bulletinPaie);
            Save();
        }

        public async Task CreateBulletinPaieAsync(BULLETIN_PAIE bulletinPaie)
        {
            Add(bulletinPaie);
            await SaveAsync();
        }

        public void DeleteBulletinPaie(BULLETIN_PAIE bulletinPaie)
        {
            Delete(bulletinPaie);
             Save();
        }

        public async Task DeleteBulletinPaieAsync(BULLETIN_PAIE bulletinPaie)
        {
            Delete(bulletinPaie);
            await SaveAsync();
        }

        public void Dispose()
        {
            RepositoryContext.Dispose();
        }

        public async Task<IEnumerable<BULLETIN_PAIE>> GetAllBulletinPaiesAsync()
        {
            var bulletinsPaie = await FindAllAsync();
            return bulletinsPaie.OrderBy(x => x.CodeEmploye);
        }

        public IEnumerable<BULLETIN_PAIE> GetAllBulletinsPaie()
        {
            return GetAll()
                .OrderBy(bpcp => bpcp.CodePeriode);
        }

        public IEnumerable<BULLETIN_PAIE> GetAllWithRefernces()
        {
            throw new NotImplementedException();
        }

        public BULLETIN_PAIE GetBulletinPaieByID(string numeroBulletin)
        {
            return FindByCondition(bp => bp.NumeroBulletin.Equals(numeroBulletin))
                    .DefaultIfEmpty(new BULLETIN_PAIE())
                    .FirstOrDefault();
        }

        public Task<BULLETIN_PAIE> GetBulletinPaieByIDAsync(string numeroBulletin)
        {
            throw new NotImplementedException();
        }

        public BULLETIN_PAIE GetBulletinPaieByName(string typeContrat)
        {
            return FindByCondition(bp => bp.CodeTypeContrat.Equals(typeContrat))
                    .DefaultIfEmpty(new BULLETIN_PAIE())
                    .FirstOrDefault();
        }

        public void Save()
        {
          _ctx.SaveChanges();
        }

        public async Task SaveAsync()
        {
           await _ctx.SaveChangesAsync();
        }

        public void UpdateBulletinPaie(BULLETIN_PAIE bulletinPaie)
        {
            Update(bulletinPaie);
            Save();
        }

        public async Task UpdateBulletinPaieAsync(BULLETIN_PAIE bulletinPaie)
        {
            Update(bulletinPaie);
            await SaveAsync();
        }
    }
}
