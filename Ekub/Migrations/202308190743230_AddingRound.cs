namespace Ekub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingRound : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rounds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Rounds = c.Int(nullable: false),
                        LuckyManId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Rounds");
        }
    }
}
