using Gestion_Note.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Note.Configurations
{
    class DemandeConfiguration : EntityTypeConfiguration<Demande_Note>
    {
        public DemandeConfiguration()
        {
            //ToTable("Demande_Note")
            HasKey(d => d.Id_demande);
           // HasRequired(d => d.Employe)
             //  .WithMany(e => e.Demande_Notes)
               //.HasForeignKey(d => d.Id_employe);
            //HasMany(d => d.Employes)
            //.WithMany(e => e.Demande_Notes);
            Property(d => d.Date_demande)
                .IsRequired();
            Property(d => d.Objectif_demande)
               .HasColumnType("varchar")
               .HasMaxLength(600);
            Property(d => d.Date_publicationD)
                .IsRequired();
            Property(d => d.Date_effet)
                .IsRequired();
            Property(d => d.Archiver_demande)
                .HasColumnType("varchar")
                .HasMaxLength(3);
        }
    }

}
