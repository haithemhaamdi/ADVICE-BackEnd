using PersonnelASPnetCore.Data;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Domaine.Entities;
using PersonnelASPnetCore.Service.ServiceManagmentInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Service.ServiceManagmentImplementation
{
    public class COMPTE_COMPTABLEService : ICOMPTE_COMPTABLEService
    {
        DatabaseFactory dbFactory = null;
        IUnitOfWork uow = null;
        private readonly ARTIPERSONNEL_SOC001Context _context;

        public COMPTE_COMPTABLEService(ARTIPERSONNEL_SOC001Context context)
        {
            _context = context;
            dbFactory = new DatabaseFactory();
            uow = new UnitOfWork(dbFactory);
        }

        public IEnumerable<COMPTE_COMPTABLE> GetAllCompteComptable()
        {
            return _context.COMPTE_COMPTABLE.ToList();
        }

        public bool CreateCompteComptable(COMPTE_COMPTABLE CompteComptable)
        {
            bool status;

            // validation
            if (string.IsNullOrWhiteSpace(CompteComptable.NumeroCompteComptable))
                throw new AppException("Password is required");

            if (_context.COMPTE_COMPTABLE.Any(x => x.LibelleCompteComptable == CompteComptable.LibelleCompteComptable))
                throw new AppException("LibelleCompteComptable \"" + CompteComptable.LibelleCompteComptable + "\" is already taken");
            try
            {
                _context.COMPTE_COMPTABLE.Add(CompteComptable);
                _context.SaveChanges();
                status = true;
            }
            catch (Exception)
            {
                status = false;
            }
            return status;
        }

        public void DeleteCompteComptable(string numeroCompte)
        {
            var CompteComptable = _context.COMPTE_COMPTABLE.Find(numeroCompte);
            if (CompteComptable != null)
            {
                _context.COMPTE_COMPTABLE.Remove(CompteComptable);
                _context.SaveChanges();
            }
        }

        public void Delete(COMPTE_COMPTABLE CompteComptable)
        {
           var CompteCompta = _context.COMPTE_COMPTABLE.Find(CompteComptable);
            if(CompteCompta != null)
            {
                _context.COMPTE_COMPTABLE.Remove(CompteComptable);
                _context.SaveChanges();
            }

        }

        public COMPTE_COMPTABLE GetCompteComptableByNumeroCompte(string numeroCompte)
        {
            return _context.COMPTE_COMPTABLE.Where(p => p.NumeroCompteComptable == numeroCompte).FirstOrDefault();
        }

        public COMPTE_COMPTABLE GetUserByLibelleCompte(string LibelleCompte)
        {
            return _context.COMPTE_COMPTABLE.Where(p => p.LibelleCompteComptable == LibelleCompte).FirstOrDefault();
        }

        public bool UpdateCompteComptable(COMPTE_COMPTABLE CompteComptable)
        {
            bool status;
            try
            {
                COMPTE_COMPTABLE _compteComptable = _context.COMPTE_COMPTABLE.Where(p => p.NumeroCompteComptable == CompteComptable.NumeroCompteComptable).FirstOrDefault();
                if (_compteComptable != null)
                {
                    _compteComptable.LibelleCompteComptable = CompteComptable.LibelleCompteComptable;
                    _compteComptable.Collectif = CompteComptable.Collectif;
                    _context.SaveChanges();
                }
                status = true;
            }
            catch (Exception)
            {
                status = false;
            }
            return status;
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Commit()
        {
            try
            {
                uow.commit();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void CommitAsync()
        {
            try
            {
                uow.CommitAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
