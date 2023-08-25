namespace Ekub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addrer : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.EligibleParticipants", "StartDay");
        }
        
        public override void Down()
        {
            AddColumn("dbo.EligibleParticipants", "StartDay", c => c.DateTime(nullable: false));
        }
    }
}
