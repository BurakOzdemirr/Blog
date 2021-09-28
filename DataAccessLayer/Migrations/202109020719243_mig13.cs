namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig13 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Admins", "AdminImage", c => c.String(maxLength: 100));
            AddColumn("dbo.Admins", "AdminName", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Admins", "AdminName");
            DropColumn("dbo.Admins", "AdminImage");
        }
    }
}
