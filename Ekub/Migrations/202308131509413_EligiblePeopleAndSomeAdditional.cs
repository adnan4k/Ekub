namespace Ekub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EligiblePeopleAndSomeAdditional : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EligibleParticipants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        TotalAmountContributed = c.String(),
                        StartDay = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.EkubInformations", "StartDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.EkubInformations", "StartDate");
            DropTable("dbo.EligibleParticipants");
        }
    }
}
