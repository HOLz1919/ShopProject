using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShopProject.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Display(Name = "Nazwa uzytkownika")]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Hasło")]
        public string Password { get; set; }

        [Display(Name = "Imię")]
        public string FirstName { get; set; }

        [Display(Name = "Nazwisko")]
        public string LastName { get; set; }

        [Display(Name ="Email")]
        public string Mail { get; set; }

        [Display(Name = "Wiek")]
        public int Age { get; set; }


    }
}