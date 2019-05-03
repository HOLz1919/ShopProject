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
    public class HomeController : Controller
    {


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BeltList()
        {
            BeltListVM beltListVM = new BeltListVM();
            BeltBL beltBL = new BeltBL();
            List<Belt> beltList = new List<Belt>();
            beltListVM.BeltVMList = BeltList2BeltVMList(beltBL.GetBeltList());

            return View(beltListVM);
        }

        public ActionResult WatchList()
        {
            return View();
        }


        public ActionResult CapList()
        {
            return View();
        }

    }
}