using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Design2PrintAPIServer.Models
{
    public class CustomerBillingDetails
    {
        [Key]
        public int CustomerBillingDetailsId { get; set; }
        public string BillingBuilding { get; set; }
        public string BillingAddress1 { get; set; }
        public string BillingAddress2 { get; set; }
        public string BillingCity { get; set; }
        public string BillingProvince { get; set; }
        public string BillingCountry { get; set; }
        public int BillingPostalCode { get; set; }
    }
}
