using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Design2PrintAPIServer.Models
{
    public class OrderDetails
    {
        [Key]
        public int OrderDetailsId { get; set; }
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        [ForeignKey("Cart")]
        public int CartId { get; set; }
        public virtual Order Order { get; set; }
        public virtual Cart Cart { get; set; }
    }
}
