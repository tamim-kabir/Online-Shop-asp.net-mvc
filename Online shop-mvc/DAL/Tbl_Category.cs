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
    
    public partial class Tbl_Category
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Category()
        {
            this.Tbl_Product = new HashSet<Tbl_Product>();
        }
    
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public string CatagoryImagePath { get; set; }
        public string CategoryDescription { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Product> Tbl_Product { get; set; }
    }
}
