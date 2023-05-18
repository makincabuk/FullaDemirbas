﻿namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DbFullaDemirbas : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SubCategories", "SubCategoryDescription", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SubCategories", "SubCategoryDescription");
        }
    }
}
