//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Online_shop_mvc.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Product()
        {
            this.Tbl_Cart = new HashSet<Tbl_Cart>();
            this.Tbl_Order = new HashSet<Tbl_Order>();
        }
    
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductImagePath { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> BrandId { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> MdifiedDate { get; set; }
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
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Cart> Tbl_Cart { get; set; }
        public virtual Tbl_Category Tbl_Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Order> Tbl_Order { get; set; }
        public virtual Tbl_User Tbl_User { get; set; }
    }
}
