using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShopProject.Models
{
    public class Cap : Product
    {
        [Key]
        [ScaffoldColumn(false)]
        public int CapId { get; set; }
    }
}