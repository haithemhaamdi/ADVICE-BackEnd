using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Configuration
{
    public class EmployeesConfiguration : IEntityTypeConfiguration<EMPLOYE>
    { 

        public void Configure(EntityTypeBuilder<EMPLOYE> builder)
        {
            builder.HasKey(u => u.CodeEmploye);
        }
    }
}
