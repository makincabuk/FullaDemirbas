namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class statusupdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SubCategories", "SubCategoryStatus", c => c.Boolean(nullable: false));
            AddColumn("dbo.Fixtures", "UserStatus", c => c.Boolean(nullable: false));
            AddColumn("dbo.Users", "UserStatus", c => c.Boolean(nullable: false));
            AddColumn("dbo.Stores", "StoreStatus", c => c.Boolean(nullable: false));
            DropColumn("dbo.Users", "Status");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Status", c => c.Boolean(nullable: false));
            DropColumn("dbo.Stores", "StoreStatus");
            DropColumn("dbo.Users", "UserStatus");
            DropColumn("dbo.Fixtures", "UserStatus");
            DropColumn("dbo.SubCategories", "SubCategoryStatus");
        }
    }
}
