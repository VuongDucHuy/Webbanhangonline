namespace WebBanHangOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateProductForeignKey : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tb_Product", "ProductCategory_id", "dbo.tb_ProductCategory");
            DropIndex("dbo.tb_Product", new[] { "ProductCategory_id" });
            DropColumn("dbo.tb_Product", "ProdutCategoryID");
            RenameColumn(table: "dbo.tb_Product", name: "ProductCategory_id", newName: "ProdutCategoryID");
            AlterColumn("dbo.tb_Product", "ProdutCategoryID", c => c.Int(nullable: false));
            CreateIndex("dbo.tb_Product", "ProdutCategoryID");
            AddForeignKey("dbo.tb_Product", "ProdutCategoryID", "dbo.tb_ProductCategory", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tb_Product", "ProdutCategoryID", "dbo.tb_ProductCategory");
            DropIndex("dbo.tb_Product", new[] { "ProdutCategoryID" });
            AlterColumn("dbo.tb_Product", "ProdutCategoryID", c => c.Int());
            RenameColumn(table: "dbo.tb_Product", name: "ProdutCategoryID", newName: "ProductCategory_id");
            AddColumn("dbo.tb_Product", "ProdutCategoryID", c => c.Int(nullable: false));
            CreateIndex("dbo.tb_Product", "ProductCategory_id");
            AddForeignKey("dbo.tb_Product", "ProductCategory_id", "dbo.tb_ProductCategory", "id");
        }
    }
}
