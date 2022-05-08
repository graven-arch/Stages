using Gestion_Note.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Note.Configurations
{
    class AppartenirConfiguration : EntityTypeConfiguration<Appartenir>
    {
        public AppartenirConfiguration()
        {
            HasRequired(a => a.Employe)
               .WithMany(e => e.Appartenirs)
           .HasForeignKey(a => a.Id_employe);
            HasRequired(a => a.Departement)
                .WithMany(de => de.Appartenirs)
            .HasForeignKey(a => a.Id_departement);
            HasKey(a => new { a.Id_employe, a.Id_departement });
        }
    }
}
