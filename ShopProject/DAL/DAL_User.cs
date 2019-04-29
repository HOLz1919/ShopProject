using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShopProject.Models;
using System.Data.Entity;
using System.Security.Cryptography;
using System.Text;

namespace ShopProject.DAL
{
    public class DAL_User : DbContext
    {
        public DAL_User() : base ("MyDB")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Tbl_Users");
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> UsersDB { get; set; }

        public List<User> GetUserList()
        {
            List<User> UserList = new List<User>();
            UserList = UsersDB.ToList();
            return UserList;

        }


        public void CreateUser(User user)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                string hash = GetMd5Hash(md5Hash, user.Password);
                user.Password = hash;


                UsersDB.Add(user);
                SaveChanges();
            }
        }


        public bool IsValidUser(string _username, string _password)
        {
            using (MD5 md5Hash = MD5.Create())
            {

                User user = UsersDB.FirstOrDefault(m => m.Username.Equals(_username));
                if (user != null)
                {
                    if (VerifyMd5Hash(md5Hash, _password, user.Password))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }

            }
        }




        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }


        static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            // Hash the input.
            string hashOfInput = GetMd5Hash(md5Hash, input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
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