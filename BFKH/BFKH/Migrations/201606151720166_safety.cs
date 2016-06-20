namespace BFKH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class safety : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Schedules",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Date = c.String(nullable: false),
                        Start = c.String(nullable: false),
                        End = c.String(nullable: false),
                        url = c.String(),
                        allDay = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Schedules");
        }
    }
}
