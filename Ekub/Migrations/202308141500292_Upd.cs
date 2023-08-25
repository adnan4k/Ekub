namespace Ekub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Upd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EligibleParticipants", "Gender", c => c.String());
            AlterColumn("dbo.EligibleParticipants", "TotalAmountContributed", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.EligibleParticipants", "TotalAmountContributed", c => c.String());
            DropColumn("dbo.EligibleParticipants", "Gender");
        }
    }
}
