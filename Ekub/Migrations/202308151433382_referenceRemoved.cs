namespace Ekub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class referenceRemoved : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.EligibleParticipants", "EkubInformation_Id", "dbo.EkubInformations");
            DropForeignKey("dbo.EligibleParticipants", "Members_Id", "dbo.Members");
            DropIndex("dbo.EligibleParticipants", new[] { "EkubInformation_Id" });
            DropIndex("dbo.EligibleParticipants", new[] { "Members_Id" });
            DropColumn("dbo.EligibleParticipants", "EkubInformation_Id");
            DropColumn("dbo.EligibleParticipants", "Members_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.EligibleParticipants", "Members_Id", c => c.Int());
            AddColumn("dbo.EligibleParticipants", "EkubInformation_Id", c => c.Int());
            CreateIndex("dbo.EligibleParticipants", "Members_Id");
            CreateIndex("dbo.EligibleParticipants", "EkubInformation_Id");
            AddForeignKey("dbo.EligibleParticipants", "Members_Id", "dbo.Members", "Id");
            AddForeignKey("dbo.EligibleParticipants", "EkubInformation_Id", "dbo.EkubInformations", "Id");
        }
    }
}
