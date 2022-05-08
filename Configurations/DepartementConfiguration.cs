using Gestion_Note.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Note.Configurations
{
    class DepartementConfiguration : EntityTypeConfiguration<Departement>
    {
        public DepartementConfiguration()
        {
            //ToTable("Departement")
            HasKey(de => de.Id_departement);
            //HasMany(de => de.Employes)
            //.WithMany(e => e.Departements);
            Property(de => de.Nom_departement)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(50);

        }
    }
}
