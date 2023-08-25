namespace Ekub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveFf : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Members", name: "Ekub_Id", newName: "EkubInformation_Id");
            RenameIndex(table: "dbo.Members", name: "IX_Ekub_Id", newName: "IX_EkubInformation_Id");
            AddColumn("dbo.Members", "EkubInfromationId", c => c.Byte(nullable: false));
            DropColumn("dbo.Members", "EkubInformationId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Members", "EkubInformationId", c => c.Byte(nullable: false));
            DropColumn("dbo.Members", "EkubInfromationId");
            RenameIndex(table: "dbo.Members", name: "IX_EkubInformation_Id", newName: "IX_Ekub_Id");
            RenameColumn(table: "dbo.Members", name: "EkubInformation_Id", newName: "Ekub_Id");
        }
    }
}
