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
        [ScaffoldColumn(false)]
        public int UserId { get; set; }

        [Display(Name = "Nazwa uzytkownika")]
        [Required(ErrorMessage ="Musisz podać nazwę użytkownika!")]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Hasło")]
        [Required(ErrorMessage = "Musisz podać hasło!")]
        public string Password { get; set; }

        [Display(Name = "Imię")]
        [Required(ErrorMessage = "Musisz podać Imie!")]
        public string FirstName { get; set; }

        [Display(Name = "Nazwisko")]
        [Required(ErrorMessage = "Musisz podać Nazwisko!")]
        public string LastName { get; set; }

        [Display(Name ="Email")]
        [Required(ErrorMessage = "Musisz podać adres email!")]
        [EmailAddress]
        public string Mail { get; set; }

        [Display(Name = "Wiek")]
        [Required(ErrorMessage = "Musisz podać Wiek!")]
        [Range(1,100)]
        public int Age { get; set; }


        [ScaffoldColumn(false)]
        public bool IsAdmin { get; set; }


    }
}