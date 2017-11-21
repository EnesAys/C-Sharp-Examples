namespace Teknik.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ankets",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        ArizaID = c.Int(nullable: false),
                        Puan = c.String(),
                        Aciklama = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Arizas", t => t.ID)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.Arizas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Baslik = c.String(),
                        Aciklama = c.String(),
                        Enlem = c.String(),
                        Boylam = c.String(),
                        Adres = c.String(),
                        EklemeTarihi = c.DateTime(nullable: false, storeType: "smalldatetime"),
                        OnaylamaTarihi = c.DateTime(storeType: "smalldatetime"),
                        OnaylandiMi = c.Boolean(nullable: false),
                        KullaniciID = c.String(maxLength: 128),
                        ModelID = c.Int(nullable: false),
                        TeknikerID = c.String(maxLength: 128),
                        ArizaYapildiMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AspNetUsers", t => t.KullaniciID)
                .ForeignKey("dbo.PcModels", t => t.ModelID, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.TeknikerID)
                .Index(t => t.KullaniciID)
                .Index(t => t.ModelID)
                .Index(t => t.TeknikerID);
            
            CreateTable(
                "dbo.ArizaBilgilendirmes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Aciklama = c.String(),
                        AciklamaZamani = c.DateTime(nullable: false, storeType: "smalldatetime"),
                        OlumluMu = c.Boolean(nullable: false),
                        YoneticiID = c.String(maxLength: 128),
                        ArizaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Arizas", t => t.ArizaID, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.YoneticiID)
                .Index(t => t.YoneticiID)
                .Index(t => t.ArizaID);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Fotografs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Yol = c.String(),
                        ArizaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Arizas", t => t.ArizaID, cascadeDelete: true)
                .Index(t => t.ArizaID);
            
            CreateTable(
                "dbo.PcModels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ModelAdi = c.String(),
                        MarkaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.PcMarkas", t => t.MarkaID, cascadeDelete: true)
                .Index(t => t.MarkaID);
            
            CreateTable(
                "dbo.PcMarkas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MarkaAdi = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Ankets", "ID", "dbo.Arizas");
            DropForeignKey("dbo.Arizas", "TeknikerID", "dbo.AspNetUsers");
            DropForeignKey("dbo.Arizas", "ModelID", "dbo.PcModels");
            DropForeignKey("dbo.PcModels", "MarkaID", "dbo.PcMarkas");
            DropForeignKey("dbo.Arizas", "KullaniciID", "dbo.AspNetUsers");
            DropForeignKey("dbo.Fotografs", "ArizaID", "dbo.Arizas");
            DropForeignKey("dbo.ArizaBilgilendirmes", "YoneticiID", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.ArizaBilgilendirmes", "ArizaID", "dbo.Arizas");
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.PcModels", new[] { "MarkaID" });
            DropIndex("dbo.Fotografs", new[] { "ArizaID" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.ArizaBilgilendirmes", new[] { "ArizaID" });
            DropIndex("dbo.ArizaBilgilendirmes", new[] { "YoneticiID" });
            DropIndex("dbo.Arizas", new[] { "TeknikerID" });
            DropIndex("dbo.Arizas", new[] { "ModelID" });
            DropIndex("dbo.Arizas", new[] { "KullaniciID" });
            DropIndex("dbo.Ankets", new[] { "ID" });
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.PcMarkas");
            DropTable("dbo.PcModels");
            DropTable("dbo.Fotografs");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.ArizaBilgilendirmes");
            DropTable("dbo.Arizas");
            DropTable("dbo.Ankets");
        }
    }
}
