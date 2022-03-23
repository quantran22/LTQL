using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTLTQL.Models
{
    [Table("Gio_Hang")]
    public class GioHang
    {
        [Key]
        public int MaHang { get; set; }
        public int MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public int DonGia { get; set; }
        public int Soluong { get; set; }
    }
}