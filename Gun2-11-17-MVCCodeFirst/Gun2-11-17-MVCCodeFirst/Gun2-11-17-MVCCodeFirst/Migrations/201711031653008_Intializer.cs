namespace Gun2_11_17_MVCCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Intializer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DersAdi = c.String(nullable: false),
                        Aciklama = c.String(unicode: false, storeType: "text"),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Egitmen",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AdSoyad = c.String(),
                        DogumTarihi = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Ogrencis",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AdSoyad = c.String(nullable: false, maxLength: 100),
                        DogumTariihi = c.DateTime(),
                        MezunMu = c.Boolean(nullable: false),
                        Ortalama = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Ogrencis");
            DropTable("dbo.Egitmen");
            DropTable("dbo.Ders");
        }
    }
}
