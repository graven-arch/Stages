using Gestion_Note.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Note.Configurations
{
    class EmployeConfiguration : EntityTypeConfiguration<Employe>
    {
        public EmployeConfiguration()
        {
            //ToTable("Employe")
            HasKey(e => e.Id_employe);
            //HasMany(e => e.Demande_Notes)
            //.WithMany(d => d.Employes);
            HasOptional(e => e.Compte)
                .WithRequired(c => c.Employe);
            HasMany(e => e.Note_Services)
                .WithRequired(n => n.Employe);
            Property(e => e.Nom_employe)
                .IsRequired()
                .HasColumnType("Varchar")
                .HasMaxLength(30);
            Property(e => e.Prenom_employe)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(50);
            Property(e => e.Email_employe)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(30);
            Property(e => e.Nature_employe)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(50);
            Property(e => e.Departement_actuel)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(100);


        }
    }
}
