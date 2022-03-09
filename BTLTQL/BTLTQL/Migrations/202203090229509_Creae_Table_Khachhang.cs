namespace BTLTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Creae_Table_Khachhang : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KhachHangs",
                c => new
                    {
                        MaKH = c.Int(nullable: false, identity: true),
                        TenKhachHang = c.String(maxLength: 50),
                        Sđt = c.String(maxLength: 50),
                        Email = c.String(maxLength: 50),
                        Diachi = c.String(maxLength: 50),
                        Hinh1 = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.MaKH);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.KhachHangs");
        }
    }
}
