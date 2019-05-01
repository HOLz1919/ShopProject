using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopProject.Models;
using ShopProject.ViewModel;
using ShopProject.BL;

namespace ShopProject.Controllers
{
    public class CapController : Controller
    {
        
        public ActionResult CapList()
        {
            return View();
        }

        
        public ActionResult ShowPhotoCap(int id)
        {
            return View();
        }

        
        public ActionResult AddCap()
        {
            return View();
        }

        
        [HttpPost]
        public ActionResult AddCap(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        
        public ActionResult EditCap(int id)
        {
            return View();
        }

        
        [HttpPost]
        public ActionResult EditCap(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        
        public ActionResult DeleteCap(int id)
        {
            return View();
        }

        
        [HttpPost]
        public ActionResult DeleteCap(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }



    }
}
