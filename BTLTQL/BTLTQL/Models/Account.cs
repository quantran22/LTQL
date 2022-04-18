using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTLTQL.Models
{
    [Table("Account")]
    public class Account
    {
        [Key]
        [StringLength(50)]
        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "PassWord is required")]
        [StringLength(50)]
        public string Password { get; set; }
        public object RoleID { get; internal set; }
    }
}