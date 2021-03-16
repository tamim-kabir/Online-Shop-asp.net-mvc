using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Online_shop_mvc.Models
{
    public class CategoryDetails
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="Category Name Is required")]
        [StringLength(100, ErrorMessage ="Minimum 3 and Maximum 100 charaters", MinimumLength =3)]
        public string CategoryName { get; set; }
        public string CatagoryImagePath { get; set; }
        public string CategoryDescription { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    }
}