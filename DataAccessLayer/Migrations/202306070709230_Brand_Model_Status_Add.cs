namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Brand_Model_Status_Add : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Brands", "BrandStatus", c => c.Boolean(nullable: false));
            AddColumn("dbo.Models", "ModelStatus", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Models", "ModelStatus");
            DropColumn("dbo.Brands", "BrandStatus");
        }
    }
}
