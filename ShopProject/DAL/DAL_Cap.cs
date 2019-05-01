using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShopProject.Models;
using System.Data.Entity;

namespace ShopProject.DAL
{
    public class DAL_Cap : DbContext
    {
        public DAL_Cap() : base("MyDB")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cap>().ToTable("Tbl_Caps");
            modelBuilder.Entity<Cap>().Property(p => p.ProductImage).HasColumnType("image");
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Cap> CapDB { get; set; }

        public List<Cap> GetCapList()
        {
            List<Cap> CapList = new List<Cap>();
            CapList = CapDB.ToList();
            return CapList;

        }



    }
}