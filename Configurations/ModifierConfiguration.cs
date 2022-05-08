using Gestion_Note.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Note.Configurations
{
    class ModifierConfiguration : EntityTypeConfiguration<Modifier>
    {
        public ModifierConfiguration()
        {
            HasRequired(m => m.Employe)
               .WithMany(e => e.Modifiers)
           .HasForeignKey(m => m.Id_employe);
            HasRequired(m => m.Note_Service)
                .WithMany(n => n.Modifiers)
            .HasForeignKey(m => m.Id_note);
            HasKey(m => new { m.Id_employe, m.Id_note });

        }
    }
}
