using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoLTQL.Models
{
    public class Employee
    {
        [Key]
        [StringLength(10)]
        public string EmployeeID { get; set; }

        [StringLength(50)]
        public string EmployeeName { get; set; }
    }
}