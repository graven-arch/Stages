namespace Gestion_Note.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Acceders",
                c => new
                    {
                        Id_employe = c.Int(nullable: false),
                        Id_demande = c.Int(nullable: false),
                        Date_acces = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.Id_employe, t.Id_demande })
                .ForeignKey("dbo.Demande_Note", t => t.Id_demande, cascadeDelete: true)
                .ForeignKey("dbo.Employes", t => t.Id_employe, cascadeDelete: true)
                .Index(t => t.Id_employe)
                .Index(t => t.Id_demande);
            
            CreateTable(
                "dbo.Demande_Note",
                c => new
                    {
                        Id_demande = c.Int(nullable: false, identity: true),
                        Date_demande = c.DateTime(nullable: false),
                        Objectif_demande = c.String(maxLength: 600, unicode: false),
                        Date_publicationD = c.DateTime(nullable: false),
                        Date_effet = c.DateTime(nullable: false),
                        Archiver_demande = c.String(maxLength: 3, unicode: false),
                    })
                .PrimaryKey(t => t.Id_demande);
            
            CreateTable(
                "dbo.Employes",
                c => new
                    {
                        Id_employe = c.Int(nullable: false, identity: true),
                        Nom_employe = c.String(nullable: false, maxLength: 30, unicode: false),
                        Prenom_employe = c.String(nullable: false, maxLength: 50, unicode: false),
                        Email_employe = c.String(nullable: false, maxLength: 30, unicode: false),
                        Nature_employe = c.String(nullable: false, maxLength: 50, unicode: false),
                        Departement_actuel = c.String(nullable: false, maxLength: 100, unicode: false),
                        Note_Service_Id_note = c.Int(),
                    })
                .PrimaryKey(t => t.Id_employe)
                .ForeignKey("dbo.Note_Service", t => t.Note_Service_Id_note)
                .Index(t => t.Note_Service_Id_note);
            
            CreateTable(
                "dbo.Appartenirs",
                c => new
                    {
                        Id_employe = c.Int(nullable: false),
                        Id_departement = c.Int(nullable: false),
                        Date_debut = c.DateTime(nullable: false),
                        Date_fin = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.Id_employe, t.Id_departement })
                .ForeignKey("dbo.Departements", t => t.Id_departement, cascadeDelete: true)
                .ForeignKey("dbo.Employes", t => t.Id_employe, cascadeDelete: true)
                .Index(t => t.Id_employe)
                .Index(t => t.Id_departement);
            
            CreateTable(
                "dbo.Departements",
                c => new
                    {
                        Id_departement = c.Int(nullable: false, identity: true),
                        Nom_departement = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id_departement);
            
            CreateTable(
                "dbo.Comptes",
                c => new
                    {
                        Login = c.Int(nullable: false),
                        Pswd_initial = c.String(nullable: false, maxLength: 15, unicode: false),
                        Pswd_definitif = c.String(nullable: false, maxLength: 15, unicode: false),
                        Date_expiration = c.DateTime(nullable: false),
                        Profile_actuel = c.String(),
                    })
                .PrimaryKey(t => t.Login)
                .ForeignKey("dbo.Employes", t => t.Login)
                .Index(t => t.Login);
            
            CreateTable(
                "dbo.Operations",
                c => new
                    {
                        Id_operation = c.Int(nullable: false, identity: true),
                        Libelle_operation = c.String(nullable: false, maxLength: 100, unicode: false),
                        Date_operation = c.DateTime(nullable: false),
                        Heure_operation = c.DateTime(nullable: false),
                        Login = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id_operation)
                .ForeignKey("dbo.Comptes", t => t.Login, cascadeDelete: true)
                .Index(t => t.Login);
            
            CreateTable(
                "dbo.Profiles",
                c => new
                    {
                        Id_profile = c.Int(nullable: false, identity: true),
                        Nom_profile = c.String(nullable: false, maxLength: 30, unicode: false),
                        Login = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id_profile)
                .ForeignKey("dbo.Comptes", t => t.Login, cascadeDelete: true)
                .Index(t => t.Login);
            
            CreateTable(
                "dbo.Donner_Avis",
                c => new
                    {
                        Id_employe = c.Int(nullable: false),
                        Id_note = c.Int(nullable: false),
                        Date_avis = c.DateTime(nullable: false),
                        Nature_avis = c.String(),
                    })
                .PrimaryKey(t => new { t.Id_employe, t.Id_note })
                .ForeignKey("dbo.Employes", t => t.Id_employe, cascadeDelete: true)
                .ForeignKey("dbo.Note_Service", t => t.Id_note, cascadeDelete: true)
                .Index(t => t.Id_employe)
                .Index(t => t.Id_note);
            
            CreateTable(
                "dbo.Note_Service",
                c => new
                    {
                        Id_note = c.Int(nullable: false, identity: true),
                        Titre_note = c.String(),
                        Libelle_note = c.String(),
                        Etape_note = c.String(),
                        Remarque_note = c.String(maxLength: 600, unicode: false),
                        Date_publicationN = c.DateTime(nullable: false),
                        Id_employe = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id_note)
                .ForeignKey("dbo.Employes", t => t.Id_employe, cascadeDelete: false)
                .Index(t => t.Id_employe);
            
            CreateTable(
                "dbo.Modifiers",
                c => new
                    {
                        Id_employe = c.Int(nullable: false),
                        Id_note = c.Int(nullable: false),
                        Date_modif = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.Id_employe, t.Id_note })
                .ForeignKey("dbo.Employes", t => t.Id_employe, cascadeDelete: true)
                .ForeignKey("dbo.Note_Service", t => t.Id_note, cascadeDelete: true)
                .Index(t => t.Id_employe)
                .Index(t => t.Id_note);
            
            CreateTable(
                "dbo.DepartementEmployes",
                c => new
                    {
                        Departement_Id_departement = c.Int(nullable: false),
                        Employe_Id_employe = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Departement_Id_departement, t.Employe_Id_employe })
                .ForeignKey("dbo.Departements", t => t.Departement_Id_departement, cascadeDelete: true)
                .ForeignKey("dbo.Employes", t => t.Employe_Id_employe, cascadeDelete: true)
                .Index(t => t.Departement_Id_departement)
                .Index(t => t.Employe_Id_employe);
            
            CreateTable(
                "dbo.EmployeDemande_Note",
                c => new
                    {
                        Employe_Id_employe = c.Int(nullable: false),
                        Demande_Note_Id_demande = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Employe_Id_employe, t.Demande_Note_Id_demande })
                .ForeignKey("dbo.Employes", t => t.Employe_Id_employe, cascadeDelete: true)
                .ForeignKey("dbo.Demande_Note", t => t.Demande_Note_Id_demande, cascadeDelete: true)
                .Index(t => t.Employe_Id_employe)
                .Index(t => t.Demande_Note_Id_demande);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Acceders", "Id_employe", "dbo.Employes");
            DropForeignKey("dbo.Acceders", "Id_demande", "dbo.Demande_Note");
            DropForeignKey("dbo.Note_Service", "Id_employe", "dbo.Employes");
            DropForeignKey("dbo.Donner_Avis", "Id_note", "dbo.Note_Service");
            DropForeignKey("dbo.Modifiers", "Id_note", "dbo.Note_Service");
            DropForeignKey("dbo.Modifiers", "Id_employe", "dbo.Employes");
            DropForeignKey("dbo.Employes", "Note_Service_Id_note", "dbo.Note_Service");
            DropForeignKey("dbo.Donner_Avis", "Id_employe", "dbo.Employes");
            DropForeignKey("dbo.EmployeDemande_Note", "Demande_Note_Id_demande", "dbo.Demande_Note");
            DropForeignKey("dbo.EmployeDemande_Note", "Employe_Id_employe", "dbo.Employes");
            DropForeignKey("dbo.Profiles", "Login", "dbo.Comptes");
            DropForeignKey("dbo.Operations", "Login", "dbo.Comptes");
            DropForeignKey("dbo.Comptes", "Login", "dbo.Employes");
            DropForeignKey("dbo.Appartenirs", "Id_employe", "dbo.Employes");
            DropForeignKey("dbo.Appartenirs", "Id_departement", "dbo.Departements");
            DropForeignKey("dbo.DepartementEmployes", "Employe_Id_employe", "dbo.Employes");
            DropForeignKey("dbo.DepartementEmployes", "Departement_Id_departement", "dbo.Departements");
            DropIndex("dbo.EmployeDemande_Note", new[] { "Demande_Note_Id_demande" });
            DropIndex("dbo.EmployeDemande_Note", new[] { "Employe_Id_employe" });
            DropIndex("dbo.DepartementEmployes", new[] { "Employe_Id_employe" });
            DropIndex("dbo.DepartementEmployes", new[] { "Departement_Id_departement" });
            DropIndex("dbo.Modifiers", new[] { "Id_note" });
            DropIndex("dbo.Modifiers", new[] { "Id_employe" });
            DropIndex("dbo.Note_Service", new[] { "Id_employe" });
            DropIndex("dbo.Donner_Avis", new[] { "Id_note" });
            DropIndex("dbo.Donner_Avis", new[] { "Id_employe" });
            DropIndex("dbo.Profiles", new[] { "Login" });
            DropIndex("dbo.Operations", new[] { "Login" });
            DropIndex("dbo.Comptes", new[] { "Login" });
            DropIndex("dbo.Appartenirs", new[] { "Id_departement" });
            DropIndex("dbo.Appartenirs", new[] { "Id_employe" });
            DropIndex("dbo.Employes", new[] { "Note_Service_Id_note" });
            DropIndex("dbo.Acceders", new[] { "Id_demande" });
            DropIndex("dbo.Acceders", new[] { "Id_employe" });
            DropTable("dbo.EmployeDemande_Note");
            DropTable("dbo.DepartementEmployes");
            DropTable("dbo.Modifiers");
            DropTable("dbo.Note_Service");
            DropTable("dbo.Donner_Avis");
            DropTable("dbo.Profiles");
            DropTable("dbo.Operations");
            DropTable("dbo.Comptes");
            DropTable("dbo.Departements");
            DropTable("dbo.Appartenirs");
            DropTable("dbo.Employes");
            DropTable("dbo.Demande_Note");
            DropTable("dbo.Acceders");
        }
    }
}
