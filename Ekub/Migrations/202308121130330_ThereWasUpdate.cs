namespace Ekub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ThereWasUpdate : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Ekubs", newName: "EkubInformations");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.EkubInformations", newName: "Ekubs");
        }
    }
}
