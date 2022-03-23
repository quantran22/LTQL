using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTLTQL.Models
{
    [Table("Danh_Gia")]
    public class DanhGia
    {
        [Key]
        public int MaDanhGia { get; set; }
        public int MaSanPham { get; set; }
        public int MaKH { get; set; }
        public DateTime Ngay_Gio { get; set; }
        public string NoiDung { get; set; }
        public string Sđt { get; set; }
    }
}