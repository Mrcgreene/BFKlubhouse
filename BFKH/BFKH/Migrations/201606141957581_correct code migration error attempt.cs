namespace BFKH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class correctcodemigrationerrorattempt : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Start_Date = c.String(),
                        End_Date = c.String(),
                        Wage = c.Double(nullable: false),
                        Phone = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
