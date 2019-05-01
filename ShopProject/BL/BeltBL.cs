using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShopProject.DAL;
using ShopProject.Models;

namespace ShopProject.BL
{
    public class BeltBL
    {
        public List<Belt> GetBeltList()
        {
            DAL_Belt DAL_Belt = new DAL_Belt();
            return DAL_Belt.GetBeltList();
        }

        public void AddBelt(Belt belt)
        {
            DAL_Belt DAL_Belt = new DAL_Belt();
            DAL_Belt.AddBelt(belt);
        }

        public void DeleteBelt(int id)
        {
            DAL_Belt DAL_Belt = new DAL_Belt();
            DAL_Belt.DeleteBelt(id);
        }
        
        public void EditBelt(int id, string name, int cost, string description)
        {
            DAL_Belt DAL_Belt = new DAL_Belt();
            DAL_Belt.EditBelt(id, name, cost, description);
        }



    }
}