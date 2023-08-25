namespace Ekub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LinkingEligibility : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EligibleParticipants", "EkubInformation_Id", c => c.Int());
            AddColumn("dbo.EligibleParticipants", "Members_Id", c => c.Int());
            CreateIndex("dbo.EligibleParticipants", "EkubInformation_Id");
            CreateIndex("dbo.EligibleParticipants", "Members_Id");
            AddForeignKey("dbo.EligibleParticipants", "EkubInformation_Id", "dbo.EkubInformations", "Id");
            AddForeignKey("dbo.EligibleParticipants", "Members_Id", "dbo.Members", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EligibleParticipants", "Members_Id", "dbo.Members");
            DropForeignKey("dbo.EligibleParticipants", "EkubInformation_Id", "dbo.EkubInformations");
            DropIndex("dbo.EligibleParticipants", new[] { "Members_Id" });
            DropIndex("dbo.EligibleParticipants", new[] { "EkubInformation_Id" });
            DropColumn("dbo.EligibleParticipants", "Members_Id");
            DropColumn("dbo.EligibleParticipants", "EkubInformation_Id");
        }
    }
}
