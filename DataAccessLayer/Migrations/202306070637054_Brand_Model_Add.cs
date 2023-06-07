namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Brand_Model_Add : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        BrandID = c.Int(nullable: false, identity: true),
                        BrandName = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.BrandID);
            
            CreateTable(
                "dbo.Models",
                c => new
                    {
                        ModelID = c.Int(nullable: false, identity: true),
                        ModelName = c.String(maxLength: 100),
                        BrandId = c.Int(nullable: false),
                        model_ModelID = c.Int(),
                    })
                .PrimaryKey(t => t.ModelID)
                .ForeignKey("dbo.Models", t => t.model_ModelID)
                .ForeignKey("dbo.Brands", t => t.BrandId, cascadeDelete: true)
                .Index(t => t.BrandId)
                .Index(t => t.model_ModelID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Models", "BrandId", "dbo.Brands");
            DropForeignKey("dbo.Models", "model_ModelID", "dbo.Models");
            DropIndex("dbo.Models", new[] { "model_ModelID" });
            DropIndex("dbo.Models", new[] { "BrandId" });
            DropTable("dbo.Models");
            DropTable("dbo.Brands");
        }
    }
}
