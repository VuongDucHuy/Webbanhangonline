namespace WebBanHangOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateNew : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_New", "Detail", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_New", "Detail");
        }
    }
}
