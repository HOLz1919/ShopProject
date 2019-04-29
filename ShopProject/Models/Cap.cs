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
        public int CapId { get; set; }
    }
}