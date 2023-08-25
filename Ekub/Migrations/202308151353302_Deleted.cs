namespace Ekub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Deleted : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Members", "EkubId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Members", "EkubId", c => c.Byte(nullable: false));
        }
    }
}
