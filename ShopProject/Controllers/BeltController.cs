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
    public class BeltController : Controller
    {
        // GET: Belt
        public ActionResult BeltList()
        {
            return View();
        }


        public ActionResult ShowPhotoBelt(int id)
        {
            return View();
        }


        public ActionResult AddBelt()
        {
            return View();
        }


        [HttpPost]
        public ActionResult AddBelt(FormCollection collection)
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


        public ActionResult EditBelt(int id)
        {
            return View();
        }


        [HttpPost]
        public ActionResult EditBelt(int id, FormCollection collection)
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


        public ActionResult DeleteBelt(int id)
        {
            return View();
        }


        [HttpPost]
        public ActionResult DeleteBelt(int id, FormCollection collection)
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
