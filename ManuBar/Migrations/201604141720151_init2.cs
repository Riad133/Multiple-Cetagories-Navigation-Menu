namespace ManuBar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        SubCategoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductID)
                .ForeignKey("dbo.SubCategories", t => t.SubCategoryID, cascadeDelete: true)
                .Index(t => t.SubCategoryID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "SubCategoryID", "dbo.SubCategories");
            DropIndex("dbo.Products", new[] { "SubCategoryID" });
            DropTable("dbo.Products");
        }
    }
}
