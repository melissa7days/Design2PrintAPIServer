using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Design2PrintAPIServer.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [ForeignKey("CustomerShippingDetails")]
        public int CustomerShippingDetailsId { get; set; }
        [ForeignKey("CustomerBillingDetails")]
        public int CustomerBillingDetailsId { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPassword { get; set; }
        public virtual CustomerShippingDetails CustomerShippingDetails { get; set; }
        public virtual CustomerBillingDetails CustomerBillingDetails { get; set; }
    }
}
