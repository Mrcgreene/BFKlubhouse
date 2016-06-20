namespace BFKH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedemployeemodeltoaddusername : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "User_Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "User_Name");
        }
    }
}
