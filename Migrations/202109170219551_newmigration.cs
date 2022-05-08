namespace Gestion_Note.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newmigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employes", "Motdepasse", c => c.String());
            AddColumn("dbo.Employes", "statut", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employes", "statut");
            DropColumn("dbo.Employes", "Motdepasse");
        }
    }
}
