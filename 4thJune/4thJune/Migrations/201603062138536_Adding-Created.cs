namespace _4thJune.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingCreated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Registrations", "Created", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Registrations", "Created");
        }
    }
}
