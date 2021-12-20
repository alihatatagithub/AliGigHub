namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateTimeeInGigClass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Gigs", "DateTimee", c => c.DateTime(nullable: false));
            DropColumn("dbo.Gigs", "DateTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Gigs", "DateTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.Gigs", "DateTimee");
        }
    }
}
