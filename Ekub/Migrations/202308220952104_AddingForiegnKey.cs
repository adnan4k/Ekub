namespace Ekub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingForiegnKey : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Members", "EkubInfromationId");
            RenameColumn(table: "dbo.Members", name: "EkubInformation_Id", newName: "EkubInfromationId");
            RenameIndex(table: "dbo.Members", name: "IX_EkubInformation_Id", newName: "IX_EkubInfromationId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Members", name: "IX_EkubInfromationId", newName: "IX_EkubInformation_Id");
            RenameColumn(table: "dbo.Members", name: "EkubInfromationId", newName: "EkubInformation_Id");
            AddColumn("dbo.Members", "EkubInfromationId", c => c.Int());
        }
    }
}
