using Gestion_Note.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Note.Configurations
{
    class AccederConfiguration : EntityTypeConfiguration<Acceder>
    {
        public AccederConfiguration()
        {
            HasRequired(ac => ac.Employe)
               .WithMany(e => e.Acceders)
           .HasForeignKey(ac => ac.Id_employe);
            HasRequired(ac => ac.Demande_Note)
                .WithMany(de => de.Acceders)
            .HasForeignKey(ac => ac.Id_demande);
            HasKey(ac => new { ac.Id_employe, ac.Id_demande });
        }
    }

}
