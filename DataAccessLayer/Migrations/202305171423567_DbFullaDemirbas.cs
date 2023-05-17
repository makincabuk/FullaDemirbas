namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DbFullaDemirbas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abouts",
                c => new
                    {
                        AboutId = c.Int(nullable: false, identity: true),
                        AboutDetails1 = c.String(maxLength: 500),
                        AboutDetails2 = c.String(maxLength: 500),
                        AboutImage1 = c.String(maxLength: 1000),
                        AboutImage2 = c.String(maxLength: 1000),
                    })
                .PrimaryKey(t => t.AboutId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(maxLength: 100),
                        CategoryDescription = c.String(maxLength: 200),
                        CategoryStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.Headings",
                c => new
                    {
                        HeadingId = c.Int(nullable: false, identity: true),
                        HeadingName = c.String(maxLength: 100),
                        HeadingDate = c.DateTime(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        User_UserID = c.Int(),
                    })
                .PrimaryKey(t => t.HeadingId)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_UserID)
                .Index(t => t.CategoryId)
                .Index(t => t.User_UserID);
            
            CreateTable(
                "dbo.Contents",
                c => new
                    {
                        ContentId = c.Int(nullable: false, identity: true),
                        ContentValue = c.String(maxLength: 1000),
                        ContentDate = c.String(),
                        HeadingId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        SubCategory_SubCategoryId = c.Int(),
                    })
                .PrimaryKey(t => t.ContentId)
                .ForeignKey("dbo.Headings", t => t.HeadingId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.SubCategories", t => t.SubCategory_SubCategoryId)
                .Index(t => t.HeadingId)
                .Index(t => t.UserId)
                .Index(t => t.SubCategory_SubCategoryId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Username = c.String(maxLength: 100),
                        UserSurName = c.String(maxLength: 100),
                        Usermage = c.String(maxLength: 1000),
                        UserMail = c.String(maxLength: 100),
                        UserPassword = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.UserID);
            
            CreateTable(
                "dbo.SubCategories",
                c => new
                    {
                        SubCategoryId = c.Int(nullable: false, identity: true),
                        SubCategoryName = c.String(maxLength: 100),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SubCategoryId)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contents", "SubCategory_SubCategoryId", "dbo.SubCategories");
            DropForeignKey("dbo.SubCategories", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Headings", "User_UserID", "dbo.Users");
            DropForeignKey("dbo.Contents", "UserId", "dbo.Users");
            DropForeignKey("dbo.Contents", "HeadingId", "dbo.Headings");
            DropForeignKey("dbo.Headings", "CategoryId", "dbo.Categories");
            DropIndex("dbo.SubCategories", new[] { "CategoryId" });
            DropIndex("dbo.Contents", new[] { "SubCategory_SubCategoryId" });
            DropIndex("dbo.Contents", new[] { "UserId" });
            DropIndex("dbo.Contents", new[] { "HeadingId" });
            DropIndex("dbo.Headings", new[] { "User_UserID" });
            DropIndex("dbo.Headings", new[] { "CategoryId" });
            DropTable("dbo.SubCategories");
            DropTable("dbo.Users");
            DropTable("dbo.Contents");
            DropTable("dbo.Headings");
            DropTable("dbo.Categories");
            DropTable("dbo.Abouts");
        }
    }
}
