using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BTLTQL.Models
{
    public class NhaSanXuat
    {
        [Key]

        public string MaNhaSanXuat { get; set; }

        public string TenNhaSanXuat { get; set; }
    }
}