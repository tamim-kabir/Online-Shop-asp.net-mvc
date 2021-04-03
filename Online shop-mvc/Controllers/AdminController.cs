using Newtonsoft.Json;
using Online_shop_mvc.DAL;
using Online_shop_mvc.Models;
using Online_shop_mvc.Repository;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using System.IO;

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

#region product Controling methods

        public ActionResult Products()
        {
            return View(_unitOfWork.GetRepositoryInstance<Tbl_Product>().GetAllRecords());
        }
        [NonAction]
        public List<SelectListItem> GetCategoryList()
        {
            List<SelectListItem> CategoryList = new List<SelectListItem>();
            var categoryLs = _unitOfWork.GetRepositoryInstance<Tbl_Category>().GetAllRecords();
            foreach(var item in categoryLs)
            {                
                CategoryList.Add(new SelectListItem { Value = item.CategoryId.ToString(), Text = item.CategoryName });
            }
            return CategoryList;
        }

        [HttpGet]
        public ActionResult AddProduct()
        {
            ViewBag.CategoryList = GetCategoryList();            
            return View();
        }

        [HttpPost]
        public ActionResult AddProduct(Tbl_Product tbl, HttpPostedFileBase file)
        {
            string picture = null;
            if(file != null)
            {
                picture = Path.GetFileName(file.FileName);
                string path = Path.Combine(Server.MapPath("~/Images/ProductImages/"), picture);
                file.SaveAs(path);
            }
            tbl.ProductImagePath = picture;
            tbl.CreatedDate = DateTime.Now;
            _unitOfWork.GetRepositoryInstance<Tbl_Product>().Add(tbl);
            return Redirect("Products");
        }
        public List<SelectListItem> GetCategoryList(int id)
        {
            List<SelectListItem> CategoryList = new List<SelectListItem>();
            var categoryLs = _unitOfWork.GetRepositoryInstance<Tbl_Category>().GetAllRecords();
            int i = 0;
            foreach(var item in categoryLs)
            {
                CategoryList.Add(new SelectListItem 
                { 
                    Value = item.CategoryId.ToString(),
                    Text = item.CategoryName,
                    Selected = (id == i)? true : false
                });
                i++;
            }
            return CategoryList;
        }
        [HttpGet]
        public ActionResult EditProduct(int productId)
        {
            var Categories = _unitOfWork.GetRepositoryInstance<Tbl_Product>().GetFirstOrDefault(productId);
            ViewBag.CategoryListUsinId = GetCategoryList(Categories.CategoryId.Value);
            return View(Categories);
        }
        [HttpPost]
        public ActionResult EditProduct(Tbl_Product tbl, HttpPostedFileBase file)
        {
            string picture = null;
            if(file != null)
            {
                picture = Path.GetFileName(file.FileName);
                string path = Path.Combine(Server.MapPath("/Images/ProductImages/"), picture);
                file.SaveAs(path);
            }
            tbl.ProductImagePath = file != null ? picture : tbl.ProductImagePath;
            tbl.MdifiedDate = DateTime.Now;
            _unitOfWork.GetRepositoryInstance<Tbl_Product>().Update(tbl);
            return View();
        }

#endregion product Controling methods
    }
}