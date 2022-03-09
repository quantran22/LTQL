using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Windows.Input;

namespace DemoLTQL.Models
{
    public class Student
    {
        [Key]
        [StringLength(10)]
        public string StudentID { get; set; }

        [StringLength(50)]
        public string StudentName { get; set; }
    }
}