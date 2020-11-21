using ADVICEData.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ADVICEData.Infrastructure
{
    /// <summary>
    /// Objectif Unit Of Work :
    /// pour regrouper un ensemble d'opérations connexes
    /// rendre la base de données une ou plusieurs transactions validées ou annulées ensemble.
    /// Le "Unité de travail" de motif est utilisé pour:
    /// Groupe Plusieurs «référentiels» afin qu'ils partagent un contexte de base de données unique (DbContext).
    /// Appliquer Les SaveChanges méthode () sur l'instance du contexte défini et veiller à ce que tous les changements-
    /// reliés entre eux seront effectués d'une manière coordonnée.
    /// </summary>

    public interface IUnitOfWork : IDisposable
    {
        public void commit();
        Task CommitAsync();
        //IRepositoryBaseAsync<T> getRepository<T>() where T : class;

        //on définis les repository
        //IEmployeRepository EmployeRepository { get; }
        //IUserRepository UserRepository { get; }

    }
}
