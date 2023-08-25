namespace Ekub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeOfname : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.EligibleParticipants", newName: "EligibleParts");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.EligibleParts", newName: "EligibleParticipants");
        }
    }
}
