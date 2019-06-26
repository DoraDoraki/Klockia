namespace Klockia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedattributes : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "City", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "City", c => c.Int(nullable: false));
        }
    }
}
