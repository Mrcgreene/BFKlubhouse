namespace BFKH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class standardtest : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderMenus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Dish = c.String(),
                        Description = c.String(),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.OrderMenus");
        }
    }
}
