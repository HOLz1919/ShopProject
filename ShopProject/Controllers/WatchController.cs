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
    public class WatchController : Controller
    {
        public ActionResult WatchList()
        {
            return View();
        }


        public ActionResult ShowPhotoWatch(int id)
        {
            return View();
        }


        public ActionResult AddWatch()
        {
            return View();
        }


        [HttpPost]
        public ActionResult AddWatch(FormCollection collection)
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


        public ActionResult EditWatch(int id)
        {
            return View();
        }


        [HttpPost]
        public ActionResult EditWatch(int id, FormCollection collection)
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


        public ActionResult DeleteWatch(int id)
        {
            return View();
        }


        [HttpPost]
        public ActionResult DeleteWatch(int id, FormCollection collection)
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
