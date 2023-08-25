namespace Ekub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adding : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.EkubInformations", "StartDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.EkubInformations", "StartDate", c => c.DateTime(nullable: false));
        }
    }
}
