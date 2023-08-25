namespace Ekub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDetails : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Details",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Gender = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.EkubInformations", "Details_Id", c => c.Int());
            CreateIndex("dbo.EkubInformations", "Details_Id");
            AddForeignKey("dbo.EkubInformations", "Details_Id", "dbo.Details", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EkubInformations", "Details_Id", "dbo.Details");
            DropIndex("dbo.EkubInformations", new[] { "Details_Id" });
            DropColumn("dbo.EkubInformations", "Details_Id");
            DropTable("dbo.Details");
        }
    }
}
