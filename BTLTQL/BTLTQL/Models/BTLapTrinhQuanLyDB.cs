using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BTLTQL.Models
{
    public partial class BTLapTrinhQuanLyDB : DbContext
    {
        public BTLapTrinhQuanLyDB()
            : base("name=BTLapTrinhQuanLyDB")
        {
        }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LoaiSanPham> LoaiSanPhams { get; set; }
        public virtual DbSet<NhaSanXuat> NhaSanXuats { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}
