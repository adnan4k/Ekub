namespace Ekub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletionOfOme : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.EkubInformations", "TotalContribution");
            DropColumn("dbo.EkubInformations", "Cycle");
        }
        
        public override void Down()
        {
            AddColumn("dbo.EkubInformations", "Cycle", c => c.String());
            AddColumn("dbo.EkubInformations", "TotalContribution", c => c.Int(nullable: false));
        }
    }
}
