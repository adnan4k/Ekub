namespace Ekub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveColumn : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Members", "EkubInformation_Id");
        }
        
        public override void Down()
        {
        }
    }
}
