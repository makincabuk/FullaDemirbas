namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DbFullaDemirbas : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Status", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Users", "Usermage", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Usermage", c => c.String(maxLength: 1000));
            DropColumn("dbo.Users", "Status");
        }
    }
}
