using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Design2PrintAPIServer.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime OrderShippingDate { get; set; }
        public DateTime OrderBillingDate { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
