using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTLTQL.Models
{
    [Table("Loai_SP")]
    public class LoaiSanPham
    {

        [Key]
        public string MaLoaiSanPham { get; set; }

        public string TenLoaiSanPham { get; set; }
    }
}