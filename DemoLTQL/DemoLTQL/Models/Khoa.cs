using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoLTQL.Models
{
    public class Khoa
    {
        [Key]
        [StringLength(10)]
        public string KhoaID { get; set; }

        [StringLength(50)]
        public string KhoaName { get; set; }
    }
}