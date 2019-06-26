namespace Klockia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmigrationintToString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "Zipcode", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "Zipcode", c => c.Int(nullable: false));
        }
    }
}
