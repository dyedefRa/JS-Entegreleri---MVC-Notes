namespace CascadingDropDownList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asfsaf : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ilceler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SehirId = c.Int(nullable: false),
                        Adi = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sehirler", t => t.SehirId, cascadeDelete: true)
                .Index(t => t.SehirId);
            
            CreateTable(
                "dbo.Sehirler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ilceler", "SehirId", "dbo.Sehirler");
            DropIndex("dbo.Ilceler", new[] { "SehirId" });
            DropTable("dbo.Sehirler");
            DropTable("dbo.Ilceler");
        }
    }
}
