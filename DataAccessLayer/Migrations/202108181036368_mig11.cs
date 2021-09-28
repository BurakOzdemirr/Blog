namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Authors", "Facebook", c => c.String(maxLength: 200));
            AddColumn("dbo.Authors", "Instagram", c => c.String(maxLength: 200));
            AddColumn("dbo.Authors", "Twitter", c => c.String(maxLength: 200));
            AddColumn("dbo.Authors", "Linkedin", c => c.String(maxLength: 200));
            AddColumn("dbo.Authors", "Github", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Authors", "Github");
            DropColumn("dbo.Authors", "Linkedin");
            DropColumn("dbo.Authors", "Twitter");
            DropColumn("dbo.Authors", "Instagram");
            DropColumn("dbo.Authors", "Facebook");
        }
    }
}
