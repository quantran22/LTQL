using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTLTQL.Models
{
    [Table("Hoa_Don")]
    public class HoaDon
    {
        [Key]
        public int MaDonHang { get; set; }
        public int MaDon { get; set; }
        public int MaSanPham { get; set; }
        public int MaKH { get; set; }
        public DateTime Ngay_Nhap { get; set; }
        public DateTime Ngay_Xuat { get; set; }
        public int DonGia { get; set; }
        public int SoLuong { get; set; }
        public int Thanhtien { get; set; }
    }
}