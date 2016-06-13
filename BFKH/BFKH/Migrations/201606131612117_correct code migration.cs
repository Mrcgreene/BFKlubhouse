namespace BFKH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class correctcodemigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AlcoholInvs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Brand = c.String(),
                        Type = c.String(),
                        Size = c.String(),
                        Price = c.Double(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FoodInvs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Item = c.String(),
                        Description = c.String(),
                        Size = c.String(),
                        Price = c.Double(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SupplyInvs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Item = c.String(),
                        Description = c.String(),
                        Size = c.String(),
                        Price = c.Double(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SupplyInvs");
            DropTable("dbo.FoodInvs");
            DropTable("dbo.AlcoholInvs");
        }
    }
}
