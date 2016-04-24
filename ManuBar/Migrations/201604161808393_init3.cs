namespace ManuBar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "SubCategoryID", "dbo.SubCategories");
            DropIndex("dbo.Products", new[] { "SubCategoryID" });
            DropTable("dbo.Products");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        SubCategoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductID);
            
            CreateIndex("dbo.Products", "SubCategoryID");
            AddForeignKey("dbo.Products", "SubCategoryID", "dbo.SubCategories", "SubCategoryID", cascadeDelete: true);
        }
    }
}
