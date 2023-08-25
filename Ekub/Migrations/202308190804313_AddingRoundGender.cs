namespace Ekub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingRoundGender : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rounds", "Gender", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rounds", "Gender");
        }
    }
}
