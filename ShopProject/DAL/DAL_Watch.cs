using ShopProject.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

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

        public void AddWatch(Watch watch)
        {
            WatchDB.Add(watch);
            SaveChanges();
        }

        public void DeleteWatch(int id)
        {
            Watch watch = new Watch();
            WatchDB.Remove(WatchDB.Find(id));
            SaveChanges();
        }

        public void EditWatch(int id, string name, int cost, string description)
        {
            Watch watch = WatchDB.FirstOrDefault(w => w.WatchId == id);
            if (watch != null)
            {
                watch.WatchId = id;
                watch.Name = name;
                watch.Cost = cost;
                watch.Description = description;
                SaveChanges();
            }
        }


    }
}