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
        public int userId { get; set; }

        [Display(Name = "Nazwa uzytkownika")]
        public string userName { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Hasło")]
        public string password { get; set; }

        [Display(Name = "Imię")]
        public string firstName { get; set; }

        [Display(Name = "Nazwisko")]
        public string lastName { get; set; }

        [Display(Name = "Wiek")]
        public int age { get; set; }


    }
}