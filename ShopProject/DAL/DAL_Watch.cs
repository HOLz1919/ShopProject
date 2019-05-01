using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShopProject.Models;
using System.Data.Entity;

namespace ShopProject.DAL
{
    public class DAL_Watch : DbContext
    {
        public DAL_Watch() : base("MyDB")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Watch>().ToTable("Tbl_Watches");
            Database.SetInitializer<DbContext>(null);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Watch> WatchDB { get; set; }

        public List<Watch> GetWatchList()
        {
            List<Watch> WatchList = new List<Watch>();
            WatchList = WatchDB.ToList();
            return WatchList;

        }


    }
}