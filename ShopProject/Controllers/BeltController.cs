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
            return View();
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


        public ActionResult EditBelt()
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


        public ActionResult DeleteBelt()
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
