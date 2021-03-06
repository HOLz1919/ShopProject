﻿using System;
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
            WatchListVM watchListVM = new WatchListVM();
            WatchBL watchBL = new WatchBL();
            List<Watch> watchList = new List<Watch>();
            watchListVM.WatchVMList = WatchList2WatchVMList(watchBL.GetWatchList());

            return View(watchListVM);
        }


        public ActionResult CapList()
        {
            CapListVM capListVM = new CapListVM();
            CapBL capBL = new CapBL();
            List<Cap> capList = new List<Cap>();
            capListVM.CapVMList = CapList2CapVMList(capBL.GetCapList());

            return View(capListVM) ;
        }

        // Koszyk ----------------------------------------------

        [Authorize]
        public ActionResult SchoppingCart()
        {
            List<ProductVM> ShoppingListVM = new List<ProductVM>();
            List<Product> ShoppingList = GetShoppingList();
            ShoppingListVM = ProductList2ProductVMList(ShoppingList);


            return View(ShoppingListVM);
        }

        [Authorize]
        public ActionResult AddBelt(Belt belt)
        {
            Product product = new Product();
            product.Name = belt.Name;
            product.Cost = belt.Cost;
            product.Description = belt.Description;
            product.ProductImage = belt.ProductImage;

            return RedirectToAction("AddItem", product);
        }

        
        public ActionResult AddItem(Product p)
        {
            List<ProductVM> ShoppingListVM = new List<ProductVM>();
            List<Product> ShoppingList = GetShoppingList();
            ShoppingList.Add(p);
            ShoppingListVM = ProductList2ProductVMList(ShoppingList);
            SaveShoppingList(ShoppingList);

            return RedirectToAction("SchoppingCart");
        }


        public List<Product> GetShoppingList()
        {
            List<Product> shoppingList;
            if (Session["ShoppingList"] == null)
            {
                shoppingList = new List<Product>();

            }
            else
            {
                shoppingList = (List<Product>)Session["ShoppingList"];
            }
            return shoppingList;
        }

        public void SaveShoppingList(List<Product> shoppingList)
        {
            Session["ShoppingList"] = shoppingList;
        }

        //public void AddItem(Product p)
        //{
        //    List<Product> shoppingList = GetShoppingList();
        //    shoppingList.Add(p);
        //    SaveShoppingList(shoppingList);
        //}

        public void RemoveItem(Product p)
        {
            List<Product> shoppingList = GetShoppingList();
            shoppingList.Remove(p);
            SaveShoppingList(shoppingList);
        }


        private List<ProductVM> ProductList2ProductVMList(List<Product> productList)
        {
            List<ProductVM> ProductVMList = new List<ProductVM>();

            foreach (Product product in productList)
            {
                ProductVM productVM = new ProductVM();
                productVM.product = product;
                ProductVMList.Add(productVM);
            }

            return ProductVMList;
        }

        //--------------------------------------------



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