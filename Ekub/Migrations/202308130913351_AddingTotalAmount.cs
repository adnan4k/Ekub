namespace Ekub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingTotalAmount : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EkubInformations", "TotalContribution", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.EkubInformations", "TotalContribution");
        }
    }
}
