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
            BeltListVM beltListVM = new BeltListVM();
            BeltBL beltBL = new BeltBL();
            List<Belt> beltList = new List<Belt>();
            beltListVM.BeltVMList = BeltList2BeltVMList(beltBL.GetBeltList());

            return View(beltListVM);
        }


        public ActionResult ShowPhotoBelt(int id)
        {
            return View();
        }


        public ActionResult AddBelt()
        {
            AddBeltVM addBeltVM = new AddBeltVM();
            return View(addBeltVM);
        }


        [HttpPost]
        public ActionResult AddBelt(Belt belt)
        {
            try
            {
                if(!ModelState.IsValid)
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
        public ActionResult EditBelt()
        {
            Belt belt = new Belt();
            return View();
        }


        [HttpPost]
        public ActionResult EditBelt(Belt belt)
        {
            
            try
            {
                BeltBL beltBL = new BeltBL();
                beltBL.EditBelt(belt.BeltId, belt.Name,belt.Cost,belt.Description);

                return RedirectToAction("BeltList");
            }
            catch
            {
                return View();
            }
        }


        public ActionResult DeleteBelt()
        {
            
            return View();
        }


        [HttpPost]
        public ActionResult DeleteBelt(Belt belt)
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



        private List<BeltVM> BeltList2BeltVMList(List<Belt> beltList)
        {
            List<BeltVM> BeltVMList = new List<BeltVM>();

            foreach (Belt belt in beltList)
            {
                BeltVM beltVM = new BeltVM();
                beltVM.belt = belt;
                BeltVMList.Add(beltVM);
            }

            return BeltVMList;
        }
    }
}
