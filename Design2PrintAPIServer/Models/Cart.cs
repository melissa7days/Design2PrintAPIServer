using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Design2PrintAPIServer.Models
{
    public class Cart
    {
        [Key]
        public int CartId { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public double ProductionCost { get; set; }
        public double DeliveryFee { get; set; }
        public double ArtworkAdjustment { get; set; }
        public double DesignService { get; set; }
        public double NetPrice { get; set; }
        public double Tax { get; set; }
        public double GrossPrice { get; set; }
        public virtual Product Product { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
