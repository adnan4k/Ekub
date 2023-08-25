namespace Ekub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AvoidNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.EligibleParticipants", "TotalAmountContributed", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.EligibleParticipants", "TotalAmountContributed", c => c.Int());
        }
    }
}
