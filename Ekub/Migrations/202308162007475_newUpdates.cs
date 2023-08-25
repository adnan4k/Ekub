namespace Ekub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newUpdates : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Members", "EkubInformationId", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Members", "EkubInformationId");
        }
    }
}
