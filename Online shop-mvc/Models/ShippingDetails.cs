using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Online_shop_mvc.Models
{
    public class ShippingDetails
    {
        public int ID { get; set; }
        [Required]
        public Nullable<int> UserId { get; set; }
        [Required]
        public string Addres { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string ZipCode { get; set; }
        public Nullable<int> OrderId { get; set; }
        public string PaidAmount { get; set; }
        public Nullable<int> PaymentId { get; set; }
        [Required]
        public string PaymentType { get; set; }
    }
}