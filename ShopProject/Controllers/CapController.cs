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
            CapListVM capListVM = new BeltListVM();
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
            AddCapVM addBeltVM = new AddBeltVM();
            return View(addBeltVM);
        }


        [HttpPost]
        public ActionResult AddCap(Belt belt)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View("AddBelt", belt);
                }

                else
                {
                    BeltBL beltBL = new BeltBL();
                    beltBL.AddBelt(belt);
                    return RedirectToAction("BeltList");
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
            Belt belt = new Belt();
            return View();
        }


        [HttpPost]
        public ActionResult EditCap(Belt belt)
        {

            try
            {
                BeltBL beltBL = new BeltBL();
                beltBL.EditBelt(belt.BeltId, belt.Name, belt.Cost, belt.Description);

                return RedirectToAction("BeltList");
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
        public ActionResult DeleteCap(Belt belt)
        {
            try
            {
                BeltBL beltBL = new BeltBL();
                beltBL.DeleteBelt(belt.BeltId);

                return RedirectToAction("BeltList");
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
