namespace Maps.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedOrders : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Sender = c.String(),
                        UserId = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        DeliveryTime = c.DateTime(nullable: false),
                        TimeofOrder = c.DateTime(nullable: false),
                        Route = c.Int(nullable: false),
                        TypeMachinesId = c.Int(nullable: false),
                        DriverId = c.Int(nullable: false),
                        Drivers_Id = c.Int(),
                        RouteId_Id = c.Int(),
                        Users_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Drivers", t => t.Drivers_Id)
                .ForeignKey("dbo.Routes", t => t.RouteId_Id)
                .ForeignKey("dbo.TypeMachines", t => t.TypeMachinesId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .Index(t => t.TypeMachinesId)
                .Index(t => t.Drivers_Id)
                .Index(t => t.RouteId_Id)
                .Index(t => t.Users_Id);
            
            CreateTable(
                "dbo.Drivers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Purse = c.Int(nullable: false),
                        TypeMachinesId = c.Int(nullable: false),
                        RoutesId = c.Int(nullable: false),
                        OrderCompleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TypeMachines", t => t.TypeMachinesId, cascadeDelete: true)
                .Index(t => t.TypeMachinesId);
            
            CreateTable(
                "dbo.TypeMachines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        Name = c.String(),
                        NumberMachin = c.String(),
                        Routes_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Routes", t => t.Routes_Id)
                .Index(t => t.Routes_Id);
            
            CreateTable(
                "dbo.Routes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Сoordinates = c.String(),
                        MarkerId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Markers", t => t.MarkerId_Id)
                .Index(t => t.MarkerId_Id);
            
            CreateTable(
                "dbo.Markers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Streets = c.String(),
                        Сity = c.String(),
                        Сoordinates = c.String(),
                        OrderId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.OrderId_Id)
                .Index(t => t.OrderId_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Purse = c.Int(nullable: false),
                        ShopId = c.Int(nullable: false),
                        Address = c.String(),
                        City = c.String(),
                        Telephone = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Shops", t => t.ShopId, cascadeDelete: true)
                .Index(t => t.ShopId);
            
            CreateTable(
                "dbo.Shops",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GoodsId = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Goods", t => t.GoodsId, cascadeDelete: true)
                .Index(t => t.GoodsId);
            
            CreateTable(
                "dbo.Goods",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        СategoryId = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Сategory", t => t.СategoryId, cascadeDelete: true)
                .Index(t => t.СategoryId);
            
            CreateTable(
                "dbo.Сategory",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.Users", "ShopId", "dbo.Shops");
            DropForeignKey("dbo.Shops", "GoodsId", "dbo.Goods");
            DropForeignKey("dbo.Goods", "СategoryId", "dbo.Сategory");
            DropForeignKey("dbo.Orders", "TypeMachinesId", "dbo.TypeMachines");
            DropForeignKey("dbo.Orders", "RouteId_Id", "dbo.Routes");
            DropForeignKey("dbo.Orders", "Drivers_Id", "dbo.Drivers");
            DropForeignKey("dbo.Drivers", "TypeMachinesId", "dbo.TypeMachines");
            DropForeignKey("dbo.TypeMachines", "Routes_Id", "dbo.Routes");
            DropForeignKey("dbo.Routes", "MarkerId_Id", "dbo.Markers");
            DropForeignKey("dbo.Markers", "OrderId_Id", "dbo.Orders");
            DropIndex("dbo.Goods", new[] { "СategoryId" });
            DropIndex("dbo.Shops", new[] { "GoodsId" });
            DropIndex("dbo.Users", new[] { "ShopId" });
            DropIndex("dbo.Markers", new[] { "OrderId_Id" });
            DropIndex("dbo.Routes", new[] { "MarkerId_Id" });
            DropIndex("dbo.TypeMachines", new[] { "Routes_Id" });
            DropIndex("dbo.Drivers", new[] { "TypeMachinesId" });
            DropIndex("dbo.Orders", new[] { "Users_Id" });
            DropIndex("dbo.Orders", new[] { "RouteId_Id" });
            DropIndex("dbo.Orders", new[] { "Drivers_Id" });
            DropIndex("dbo.Orders", new[] { "TypeMachinesId" });
            DropTable("dbo.Сategory");
            DropTable("dbo.Goods");
            DropTable("dbo.Shops");
            DropTable("dbo.Users");
            DropTable("dbo.Markers");
            DropTable("dbo.Routes");
            DropTable("dbo.TypeMachines");
            DropTable("dbo.Drivers");
            DropTable("dbo.Orders");
        }
    }
}
