using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTLTQL.Models
{
    [Table("Nha_SX")]
    public class NhaSanXuat
    {
        [Key]

        public string MaNhaSanXuat { get; set; }

        public string TenNhaSanXuat { get; set; }
    }
}