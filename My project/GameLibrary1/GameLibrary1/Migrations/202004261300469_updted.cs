namespace GameLibrary1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updted : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Details",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Genre = c.String(),
                        Rating = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Developers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DevName = c.String(),
                        DevAdress = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Stock = c.Int(nullable: false),
                        Developer = c.Int(nullable: false),
                        Genre = c.Int(nullable: false),
                        Console = c.Int(nullable: false),
                        Publisher = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Platforms",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Console = c.String(),
                        ConsolePrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Publishers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PubName = c.String(),
                        Year = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Publishers");
            DropTable("dbo.Platforms");
            DropTable("dbo.Games");
            DropTable("dbo.Developers");
            DropTable("dbo.Details");
        }
    }
}
