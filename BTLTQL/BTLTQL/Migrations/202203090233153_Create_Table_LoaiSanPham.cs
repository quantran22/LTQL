namespace BTLTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_LoaiSanPham : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LoaiSanPhams",
                c => new
                    {
                        MaLoaiSanPham = c.String(nullable: false, maxLength: 128),
                        TenLoaiSanPham = c.String(),
                    })
                .PrimaryKey(t => t.MaLoaiSanPham);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LoaiSanPhams");
        }
    }
}
