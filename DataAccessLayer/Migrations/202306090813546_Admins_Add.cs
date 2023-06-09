namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Admins_Add : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Models", "BrandId", "dbo.Brands");
            DropIndex("dbo.Models", new[] { "BrandId" });
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        AdminID = c.Int(nullable: false, identity: true),
                        AdminUsername = c.String(maxLength: 200),
                        AdminUserPassword = c.String(maxLength: 200),
                        AdminRole = c.String(maxLength: 1),
                    })
                .PrimaryKey(t => t.AdminID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Admins");
            CreateIndex("dbo.Models", "BrandId");
            AddForeignKey("dbo.Models", "BrandId", "dbo.Brands", "BrandID", cascadeDelete: true);
        }
    }
}
