using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShopProject.Models;
using System.Data.Entity;

namespace ShopProject.DAL
{
    public class DAL_Belt : DbContext
    {
        public DAL_Belt() : base("MyDB")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Belt>().ToTable("Tbl_Belts");
            modelBuilder.Entity<Belt>().Property(p => p.ProductImage).HasColumnType("image");
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Belt> BeltsDB { get; set; }

        public List<Belt> GetBeltList()
        {
            List<Belt> BeltList = new List<Belt>();
            BeltList = BeltsDB.ToList();
            return BeltList;

        }

    }
}