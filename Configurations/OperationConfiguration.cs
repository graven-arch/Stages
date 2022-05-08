using Gestion_Note.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Note.Configurations
{
    class OperationConfiguration : EntityTypeConfiguration<Operation>
    {
        public OperationConfiguration()
        {
            //ToTable("Operation")
            HasKey(o => o.Id_operation);
            HasRequired(o => o.Compte)
                .WithMany(c => c.Operations)
            .HasForeignKey(o => o.Login);
            Property(o => o.Libelle_operation)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(100);
            Property(o => o.Date_operation)
                .IsRequired();
            //.HasColumnType("varchar");

        }
    }

}
