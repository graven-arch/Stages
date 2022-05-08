using Gestion_Note.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Note.Configurations
{
    class NoteConfiguration : EntityTypeConfiguration<Note_Service>
    {
        public NoteConfiguration()
        {
            //ToTable("Note_Service")
            HasKey(n => n.Id_note);
 
            HasRequired(n => n.Employe)
                .WithMany(e => e.Note_Services)
                .HasForeignKey(n => n.Id_employe);
            HasRequired(n => n.Departement)
                .WithMany(de => de.Note_Services)
                .HasForeignKey(n => n.Id_departement);

            Property(n => n.Remarque_note)
                .HasColumnType("varchar")
                .HasMaxLength(600);
            Property(n => n.Date_publicationN)
                .IsRequired();


        }
    }
}
