using Gestion_Note.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Note.Configurations
{
    class ProfileConfiguration : EntityTypeConfiguration<Profile>
    {
        public ProfileConfiguration()
        {
            //ToTable("Profile")
            HasKey(p => p.Id_profile);
            HasRequired(p => p.Compte)
                .WithMany(c => c.Profiles)
            .HasForeignKey(p => p.Login);
            Property(p => p.Nom_profile)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(30);

        }
    }


}
