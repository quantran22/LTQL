using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BTLTQL.Models
{
    public class LoaiSanPham
    {

        [Key]
        public string MaLoaiSanPham { get; set; }

        public string TenLoaiSanPham { get; set; }
    }
}