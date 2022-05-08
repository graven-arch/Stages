using Gestion_Note.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Note.Configurations
{
    class CompteConfiguration : EntityTypeConfiguration<Compte>
    {
        public CompteConfiguration()
        {
            // ToTable("Compte")
            HasKey(c => c.Login);
            //HasMany(c => c.Profiles)
            //.WithRequired(p => p.Compte);
            HasRequired(c => c.Employe)
                .WithOptional(e => e.Compte);
            HasMany(c => c.Operations)
                .WithRequired(o => o.Compte);
            //Longueurs mots de passe
            Property(c => c.Pswd_initial)
                .HasColumnType("varchar")
                .HasMaxLength(15)
                .IsRequired();
            Property(c => c.Pswd_definitif)
                .HasColumnType("varchar")
                .HasMaxLength(15)
                .IsRequired();

        }
    }

}
