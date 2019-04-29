using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ShopProject.Models
{
    public abstract class Product
    {
        public virtual string Name { get; set; }

        public virtual int Cost { get; set; }

        public virtual string Description { get; set; }



    }
}