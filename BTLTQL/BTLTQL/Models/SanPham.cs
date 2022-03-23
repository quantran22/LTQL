using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTLTQL.Models
{
    [Table("San_Pham")]
    public class SanPham
    {
        [Key]
        public int MaSanPham { get; set; }

        public string MaLoaiSanPham { get; set; }

        public string MaNhaSanXuat { get; set; }

        public string TenSanPham { get; set; }

        public string CauHinh { get; set; }

        [StringLength(50)]
        public string HinhChinh { get; set; }

        public int? Gia { get; set; }

        public int SoLuongBan { get; set; }

        public string GioiThieu { get; set; }
    }
}