namespace Gestion_Note.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class P : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Note_Service", "Id_departement", c => c.Int(nullable: false));
            CreateIndex("dbo.Note_Service", "Id_departement");
            AddForeignKey("dbo.Note_Service", "Id_departement", "dbo.Departements", "Id_departement", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Note_Service", "Id_departement", "dbo.Departements");
            DropIndex("dbo.Note_Service", new[] { "Id_departement" });
            DropColumn("dbo.Note_Service", "Id_departement");
        }
    }
}
