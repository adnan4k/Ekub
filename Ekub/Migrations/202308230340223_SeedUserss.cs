namespace Ekub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUserss : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Members", "EkubInfromationId", "dbo.EkubInformations");
            DropIndex("dbo.Members", new[] { "EkubInfromationId" });
            AddColumn("dbo.Members", "EkubInformation_Id", c => c.Int());
            CreateIndex("dbo.Members", "EkubInformation_Id");
            AddForeignKey("dbo.Members", "EkubInformation_Id", "dbo.EkubInformations", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Members", "EkubInformation_Id", "dbo.EkubInformations");
            DropIndex("dbo.Members", new[] { "EkubInformation_Id" });
            DropColumn("dbo.Members", "EkubInformation_Id");
            CreateIndex("dbo.Members", "EkubInfromationId");
            AddForeignKey("dbo.Members", "EkubInfromationId", "dbo.EkubInformations", "Id");
        }
    }
}
