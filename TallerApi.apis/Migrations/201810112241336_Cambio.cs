namespace TallerApi.apis.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cambio : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Publicacions", newName: "Publicacion");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Publicacion", newName: "Publicacions");
        }
    }
}
