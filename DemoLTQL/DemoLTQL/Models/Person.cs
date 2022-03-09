using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoLTQL.Models
{
    public class Person
    {
        [Key]
        [StringLength(10)]
        public string StudentID { get; set; }

        [StringLength(50)]
        public string StudentName { get; set; }
    }
}