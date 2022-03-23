using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTLTQL.Models
{
    [Table("ChiTiet_HD")]
    public class ChiTietHoaDon
    {
        [Key]
        public int MaDon { get; set; }
        public int MaSanPham { get; set; }
        public int MaKH { get; set; }
        public DateTime Ngay_Nhap { get; set; }
        public DateTime Ngay_Xuat { get; set; }
        public int DonGia { get; set; }
        public int SoLuong { get; set; }
    }
}