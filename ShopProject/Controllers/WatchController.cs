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
            WatchListVM watchListVM = new WatchListVM();
            WatchBL watchBL = new WatchBL();
            List<Watch> watchList = new List<Watch>();
            watchListVM.WatchVMList = WatchList2WatchVMList(watchBL.GetWatchList());

            return View(watchListVM);
        }


        public ActionResult ShowPhotoWatch(int id)
        {
            return View();
        }


        public ActionResult AddWatch()
        {
            AddWatchVM addWatchVM = new AddWatchVM();
            return View(addWatchVM);
        }


        [HttpPost]
        public ActionResult AddWatch(Watch watch)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View("AddWatch", watch);
                }

                else
                {
                    WatchBL watchBL = new WatchBL();
                    watchBL.AddWatch(watch);
                    return RedirectToAction("WatchList");
                }
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult EditWatch()
        {
            Watch watch = new Watch();
            return View();
        }


        [HttpPost]
        public ActionResult EditWatch(Watch watch)
        {

            try
            {
                WatchBL watchBL = new WatchBL();
                watchBL.EditWatch(watch.WatchId, watch.Name, watch.Cost, watch.Description);

                return RedirectToAction("WatchList");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult DeleteWatch()
        {

            return View();
        }


        [HttpPost]
        public ActionResult DeleteWatch(Watch watch)
        {
            try
            {
                WatchBL watchBL = new WatchBL();
                watchBL.DeleteWatch(watch.WatchId);

                return RedirectToAction("WatchList");
            }
            catch
            {
                return View();
            }
        }



        private List<WatchVM> WatchList2WatchVMList(List<Watch> watchList)
        {
            List<WatchVM> WatchVMList = new List<WatchVM>();

            foreach (Watch watch in watchList)
            {
                WatchVM watchVM = new WatchVM();
                watchVM.watch = watch;
                WatchVMList.Add(watchVM);
            }

            return WatchVMList;
        }
    }
}
