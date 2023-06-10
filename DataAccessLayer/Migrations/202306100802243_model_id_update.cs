namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class model_id_update : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Models", "model_ModelID", "dbo.Models");
            DropIndex("dbo.Models", new[] { "model_ModelID" });
            CreateIndex("dbo.Models", "BrandID");
            AddForeignKey("dbo.Models", "BrandID", "dbo.Brands", "BrandID", cascadeDelete: true);
            DropColumn("dbo.Models", "model_ModelID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Models", "model_ModelID", c => c.Int());
            DropForeignKey("dbo.Models", "BrandID", "dbo.Brands");
            DropIndex("dbo.Models", new[] { "BrandID" });
            CreateIndex("dbo.Models", "model_ModelID");
            AddForeignKey("dbo.Models", "model_ModelID", "dbo.Models", "ModelID");
        }
    }
}
