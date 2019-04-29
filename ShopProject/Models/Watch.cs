using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShopProject.Models
{
    public class Watch : Product
    {
        [Key]
        public int WatchId { get; set; }
    }
}