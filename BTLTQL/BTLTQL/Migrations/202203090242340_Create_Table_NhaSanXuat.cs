namespace BTLTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_NhaSanXuat : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NhaSanXuats",
                c => new
                    {
                        MaNhaSanXuat = c.String(nullable: false, maxLength: 128),
                        TenNhaSanXuat = c.String(),
                    })
                .PrimaryKey(t => t.MaNhaSanXuat);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NhaSanXuats");
        }
    }
}
