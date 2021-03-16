using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Online_shop_mvc.Models
{
    public class ProductDetails
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="Product Name is required")]
        [StringLength(500, ErrorMessage ="Minimum 3 and Maximum 500 charaters", MinimumLength =3)]
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductImagePath { get; set; }
        [Required(ErrorMessage ="Category Id required")]
        [Range(1, 100)]
        public Nullable<int> CategoryID { get; set; }
        public Nullable<int> BrandID { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> MdifiedDate { get; set; }
        [Required(ErrorMessage ="Price are required")]
        [Range(typeof(decimal), "1", "10000000", ErrorMessage ="Iivalid price or value detect")]
        public Nullable<decimal> Price { get; set; }
        public string UnitPrice { get; set; }
        public string SKU { get; set; }
        public string Size { get; set; }
        public string AvailableSize { get; set; }
        public string Color { get; set; }
        public string AvailableColor { get; set; }
        public string Discount { get; set; }
        public string UnitInStock { get; set; }
        public string UnitOnOrder { get; set; }
        public Nullable<bool> DiscountAvailable { get; set; }
        public Nullable<bool> IsFeatured { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public string Note { get; set; }
        [StringLength(15)]
        [Range(typeof(int),"1", "100000", ErrorMessage ="Invalid Quantity Item should be grater then 1")]
        public string Quantity { get; set; }
        public SelectList Categoriess { get; set; }
    }
}