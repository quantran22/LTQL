namespace BTLTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Uploand : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Accounts", newName: "Account");
            RenameTable(name: "dbo.DanhGias", newName: "Danh_Gia");
            RenameTable(name: "dbo.GioHangs", newName: "Gio_Hang");
            RenameTable(name: "dbo.HoaDons", newName: "Hoa_Don");
            RenameTable(name: "dbo.KhachHangs", newName: "Khach_Hang");
            RenameTable(name: "dbo.LoaiSanPhams", newName: "Loai_SP");
            RenameTable(name: "dbo.NhaSanXuats", newName: "Nha_SX");
            RenameTable(name: "dbo.SanPhams", newName: "San_Pham");
            AddColumn("dbo.Hoa_Don", "MaDon", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Hoa_Don", "MaDon");
            RenameTable(name: "dbo.San_Pham", newName: "SanPhams");
            RenameTable(name: "dbo.Nha_SX", newName: "NhaSanXuats");
            RenameTable(name: "dbo.Loai_SP", newName: "LoaiSanPhams");
            RenameTable(name: "dbo.Khach_Hang", newName: "KhachHangs");
            RenameTable(name: "dbo.Hoa_Don", newName: "HoaDons");
            RenameTable(name: "dbo.Gio_Hang", newName: "GioHangs");
            RenameTable(name: "dbo.Danh_Gia", newName: "DanhGias");
            RenameTable(name: "dbo.Account", newName: "Accounts");
        }
    }
}
