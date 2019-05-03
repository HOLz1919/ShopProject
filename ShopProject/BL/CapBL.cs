using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShopProject.DAL;
using ShopProject.Models;

namespace ShopProject.BL
{
    public class CapBL
    {
        public List<Cap> GetCapList()
        {
            DAL_Cap DAL_Cap = new DAL_Cap();
            return DAL_Cap.GetCapList();
        }

        public void AddCap(Cap cap)
        {
            DAL_Cap DAL_Cap = new DAL_Cap();
            DAL_Cap.AddCap(cap);
        }

        public void DeleteCap(int id)
        {
            DAL_Cap DAL_Cap = new DAL_Cap();
            DAL_Cap.DeleteCap(id);
        }

        public void EditCap(int id, string name, int cost, string description)
        {
            DAL_Cap DAL_Cap = new DAL_Cap();
            DAL_Cap.EditCap(id, name, cost, description);
        }
    }
}