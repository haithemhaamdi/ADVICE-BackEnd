
using ADVICEDomaine.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ADVICEData.Infrastructure
{
    /// <summary>
    ///     Séparation des Conceptes (SoC)
    ///     Principe de responsabilité unique (SRP)
    ///     
    ///     Chaque objet doit avoir une responsabilité unique,et que tous ses services doit être étroitement aligné avec cette responsabilité.
    /// </summary>
    public interface IDatabaseFactory : IDisposable
    {
        // instancié l'objet Context
        ARTIPERSONNEL_SOC001Context _dataContext { get; }
        IDbConnection GetConnection();

    }
}
