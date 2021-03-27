﻿using Newtonsoft.Json;
using Online_shop_mvc.DAL;
using Online_shop_mvc.Models;
using Online_shop_mvc.Repository;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Online_shop_mvc.Controllers
{
    public class AdminController:Controller
    {
        public GenericUnitOfWork _unitOfWork = new GenericUnitOfWork();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
#region Category Controller
        public ActionResult Categories()
        {
            return View(_unitOfWork.GetRepositoryInstance<Tbl_Category>().GetAllRecords());
        }
        
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Tbl_Category tbl)
        {
            _unitOfWork.GetRepositoryInstance<Tbl_Category>().Add(tbl);
            return RedirectToAction("Categories");
        }
        public ActionResult EditCategory(int categoryId)
        {
            return View(_unitOfWork.GetRepositoryInstance<Tbl_Category>().GetFirstOrDefault(categoryId));
        }
        [HttpPost]
        public ActionResult EditCategory(Tbl_Category tbl)
        {
            _unitOfWork.GetRepositoryInstance<Tbl_Category>().Update(tbl);
            return RedirectToAction("Categories");
        }
        public ActionResult DeleteCategory(int categoryId)
        {
            return View(_unitOfWork.GetRepositoryInstance<Tbl_Category>().GetFirstOrDefault(categoryId));
        }
        [HttpPost]
        public ActionResult DeleteCategory(Tbl_Category tbl)
        {
            _unitOfWork.GetRepositoryInstance<Tbl_Category>().Remove(tbl);
            
            return RedirectToAction("Categories");
        }
        #endregion Category Controller

#region product Contr0ller

        public ActionResult Products()
        {
            return View(_unitOfWork.GetRepositoryInstance<Tbl_Product>().GetAllRecords());
        }
        public List<SelectListItem> GetCategory()
        {
            List<SelectListItem> CategoryList = new List<SelectListItem>();
            var categoryLs = _unitOfWork.GetRepositoryInstance<Tbl_Category>().GetAllRecords();
            foreach(var item in categoryLs)
            {
                
                CategoryList.Add(new SelectListItem { Value = item.CategoryId.ToString(), Text = item.CategoryName });
            }
            return CategoryList;
        }
        public ActionResult AddProduct()
        {
            ViewBag.CategoryList = GetCategory();
            Tbl_Product cratedtedDate = new Tbl_Product()
            {
                CreatedDate = DateTime.Now
            };
            return View(cratedtedDate);
        }
        [HttpPost]
        public ActionResult AddProduct(Tbl_Product tbl)
        {
            _unitOfWork.GetRepositoryInstance<Tbl_Product>().Add(tbl);
            return View();
        }

        public ActionResult EditProduct(int productId)
        {
            ViewBag.CategoryList = GetCategory();
            return View(_unitOfWork.GetRepositoryInstance<Tbl_Product>().GetFirstOrDefault(productId));
        }
        [HttpPost]
        public ActionResult EditProduct(Tbl_Product tbl)
        {
            _unitOfWork.GetRepositoryInstance<Tbl_Product>().Update(tbl);
            return View();
        }



#endregion product controller
    }
}