using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ShopProject.Models
{
    public class Product
    {
        [Display(Name="Nazwa")]
        [Required(ErrorMessage ="Musisz podać nazwę!")]
        public virtual string Name { get; set; }

        [Display(Name = "Cena")]
        [Required(ErrorMessage = "Musisz podać Cenę!")]
        public virtual int Cost { get; set; }

        [Display(Name = "Opis")]
        [Required(ErrorMessage = "Musisz podać Opis!")]
        public virtual string Description { get; set; }

        [Display(Name="Zdjęcie")]
        public string ProductImage { get; set; }


    }
}