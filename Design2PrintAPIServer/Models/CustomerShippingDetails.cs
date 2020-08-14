using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Design2PrintAPIServer.Models
{
    public class CustomerShippingDetails
    {
        [Key]
        public int CustomerShippingDetailsId { get; set; }
        public string Building { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public int PostalCode { get; set; }
        public string DeliveryInstructions { get; set; }
    }
}
