using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BTLTQL.Models
{
    public class Account
    {
        [Key]
        [StringLength(50)]
        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "PassWord is required")]
        [StringLength(50)]
        public string Password { get; set; }
    }
}