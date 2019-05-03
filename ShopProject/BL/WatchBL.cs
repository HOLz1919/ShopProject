using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShopProject.DAL;
using ShopProject.Models;

namespace ShopProject.BL
{
    public class WatchBL
    {
        public List<Watch> GetWatchList()
        {
            DAL_Watch DAL_Watch = new DAL_Watch();
            return DAL_Watch.GetWatchList();
        }

        public void AddWatch(Watch watch)
        {
            DAL_Watch DAL_Watch = new DAL_Watch();
            DAL_Watch.AddWatch(watch);
        }

        public void DeleteWatch(int id)
        {
            DAL_Watch DAL_Watch = new DAL_Watch();
            DAL_Watch.DeleteWatch(id);
        }

        public void EditWatch(int id, string name, int cost, string description)
        {
            DAL_Watch DAL_Watch = new DAL_Watch();
            DAL_Watch.EditWatch(id, name, cost, description);
        }
    }
}