namespace WebBanHangOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCategory1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tb_Category", "SeoKeywords", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_Category", "SeoKeywords", c => c.String());
        }
    }
}
