using Gestion_Note.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Note.Configurations
{
    class DonnerAvisConfiguration : EntityTypeConfiguration<Donner_Avis>
    {
        public DonnerAvisConfiguration()
        {
            HasRequired(Do => Do.Employe)
                .WithMany(e => e.Donner_Avis)
            .HasForeignKey(Do => Do.Id_employe);
            HasRequired(Do => Do.Note_Service)
                .WithMany(n => n.Donner_Avis)
            .HasForeignKey(Do => Do.Id_note);
            HasKey(Do => new { Do.Id_employe, Do.Id_note });
        }


    }
}
