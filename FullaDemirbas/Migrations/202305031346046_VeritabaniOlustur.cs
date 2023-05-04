namespace FullaDemirbas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VeritabaniOlustur : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Demirbas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonelId = c.Int(nullable: false),
                        MagazaId = c.Int(nullable: false),
                        DemirbasAdi = c.String(),
                        DemirbasSeriNo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Magazas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MagazaAdi = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Personels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        Soyad = c.String(),
                        Password = c.String(),
                        Mail = c.String(),
                        Tcno = c.String(),
                        Telefon = c.String(),
                        MagazaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Personels");
            DropTable("dbo.Magazas");
            DropTable("dbo.Demirbas");
        }
    }
}
