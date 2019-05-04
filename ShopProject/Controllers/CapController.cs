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
            CapListVM capListVM = new CapListVM();
            CapBL capBL = new CapBL();
            List<Cap> capList = new List<Cap>();
            capListVM.CapVMList = CapList2CapVMList(capBL.GetCapList());

            return View(capListVM);
        }


        public ActionResult ShowPhotoCap(int id)
        {
            return View();
        }


        public ActionResult AddCap()
        {
            AddCapVM addCapVM = new AddCapVM();
            return View(addCapVM);
        }


        [HttpPost]
        public ActionResult AddCap(Cap cap)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View("AddCap", cap);
                }

                else
                {
                    CapBL capBL = new CapBL();
                    capBL.AddCap(cap);
                    return RedirectToAction("CapList");
                }
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult EditCap()
        {
            Cap cap = new Cap();
            return View();
        }


        [HttpPost]
        public ActionResult EditCap(Cap cap)
        {

            try
            {
                CapBL capBL = new CapBL();
                capBL.EditCap(cap.CapId, cap.Name, cap.Cost, cap.Description);

                return RedirectToAction("CapList");
            }
            catch
            {
                return View();
            }
        }


        public ActionResult DeleteCap()
        {

            return View();
        }


        [HttpPost]
        public ActionResult DeleteCap(Cap cap)
        {
            try
            {
                CapBL capBL = new CapBL();
                capBL.DeleteCap(cap.CapId);

                return RedirectToAction("CapList");
            }
            catch
            {
                return View();
            }
        }



        private List<CapVM> CapList2CapVMList(List<Cap> capList)
        {
            List<CapVM> CapVMList = new List<CapVM>();

            foreach (Cap cap in capList)
            {
                CapVM capVM = new CapVM();
                capVM.cap = cap;
                CapVMList.Add(capVM);
            }

            return CapVMList;
        }




    }
}
