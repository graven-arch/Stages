using Gestion_Note.Classes;
using Gestion_Note.Configurations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Note
{
    class BdContext : DbContext
    {

        public virtual DbSet<Acceder> Acceders { get; set; }
        public virtual DbSet<Appartenir> Appartenirs { get; set; }
        public virtual DbSet<Compte> Comptes { get; set; }
        public virtual DbSet<Demande_Note> Demande_Notes { get; set; }
        public virtual DbSet<Departement> Departements { get; set; }
        public virtual DbSet<Donner_Avis> Donner_Avis { get; set; }
        public virtual DbSet<Employe> Employes { get; set; }
        public virtual DbSet<Modifier> Modifiers { get; set; }
        public virtual DbSet<Note_Service> Note_Services { get; set; }
        public virtual DbSet<Operation> Operations { get; set; }
        public virtual DbSet<Profile> Profiles { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AccederConfiguration());
            modelBuilder.Configurations.Add(new AppartenirConfiguration());
            modelBuilder.Configurations.Add(new CompteConfiguration());
            modelBuilder.Configurations.Add(new DemandeConfiguration());
            modelBuilder.Configurations.Add(new DepartementConfiguration());
            modelBuilder.Configurations.Add(new DonnerAvisConfiguration());
            modelBuilder.Configurations.Add(new EmployeConfiguration());
            modelBuilder.Configurations.Add(new ModifierConfiguration());
            modelBuilder.Configurations.Add(new NoteConfiguration());
            modelBuilder.Configurations.Add(new OperationConfiguration());
            modelBuilder.Configurations.Add(new ProfileConfiguration());


        }
        public BdContext() : base("BdConnection")
        {

        }
    }

}
