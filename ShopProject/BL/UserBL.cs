using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShopProject.DAL;
using ShopProject.Models;

namespace ShopProject.BL
{
    public class UserBL
    {
        public List<User> GetUserList()
        {
            DAL_User DAL_User = new DAL_User();
            return DAL_User.GetUserList();
        }

        public void CreateUser(User user)
        {
            DAL_User DAL_User = new DAL_User();
            DAL_User.CreateUser(user);
        }


        public bool IsValidUser(string username, string password)
        {
            DAL_User DAL_User = new DAL_User();
            if (DAL_User.IsValidUser(username, password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}