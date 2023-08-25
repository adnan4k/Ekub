namespace Ekub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Changing : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Members", "EkubInfromationId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Members", "EkubInfromationId", c => c.Byte(nullable: false));
        }
    }
}
