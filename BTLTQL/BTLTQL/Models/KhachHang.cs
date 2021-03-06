using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTLTQL.Models
{
    [Table("Khach_Hang")]
    public class KhachHang
    {
        [Key]
        public int MaKH { get; set; }

        [StringLength(50)]
        public string TenKhachHang { get; set; }

        [StringLength(50)]
        public string Sđt { get; set; }
        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Diachi { get; set; }

        [StringLength(50)]
        public string Hinh1 { get; set; }
    }
}