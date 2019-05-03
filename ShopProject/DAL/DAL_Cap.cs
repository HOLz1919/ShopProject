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
            Database.SetInitializer<DbContext>(null);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Cap> CapDB { get; set; }

        public List<Cap> GetCapList()
        {
            List<Cap> CapList = new List<Cap>();
            CapList = CapDB.ToList();
            return CapList;

        }

        public void AddCap(Cap cap)
        {
            CapDB.Add(cap);
            SaveChanges();
        }

        public void DeleteCap(int id)
        {
            Cap cap = new Cap();
            CapDB.Remove(CapDB.Find(id));
            SaveChanges();
        }

        public void EditCap(int id, string name, int cost, string description)
        {
            Cap cap = CapDB.FirstOrDefault(c => c.CapId == id);
            if (cap != null)
            {
                cap.CapId = id;
                cap.Name = name;
                cap.Cost = cost;
                cap.Description = description;
                SaveChanges();
            }
        }



    }
}