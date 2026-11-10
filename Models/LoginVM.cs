using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _25dh230046_MyStore.Models.ViewModel
{
    public class LoginVM : Controller
    {
        [Required]
        [Display(Name = "Tên đăng nhập")]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Mật khẩu")]
        public string Password { get; set; }
    }
}