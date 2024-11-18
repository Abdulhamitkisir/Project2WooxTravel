namespace Project2WooxTravel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Destinations", "Capacity", c => c.Int(nullable: false));
            DropColumn("dbo.Destinations", "Capacıty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Destinations", "Capacıty", c => c.Int(nullable: false));
            DropColumn("dbo.Destinations", "Capacity");
        }
    }
}
