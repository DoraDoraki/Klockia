namespace Klockia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedproduct : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ImageUrl = c.String(),
                        Name = c.String(),
                        Brand = c.String(),
                        Price = c.Int(nullable: false),
                        Description = c.String(),
                        ProductTypeId = c.Int(nullable: false),
                        Color = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
        }
    }
}
