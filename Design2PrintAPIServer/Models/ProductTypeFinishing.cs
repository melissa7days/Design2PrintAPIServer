using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Design2PrintAPIServer.Models
{
    public class ProductTypeFinishing
    {
        [Key]
        public int ProductTypeFinishingId { get; set; }
        [ForeignKey("ProductType")]
        public int ProductTypeId { get; set; }
        [ForeignKey("Finishing")]
        public int FinishingId { get; set; }
        public double FinishingPrice { get; set; }
        public virtual ProductType ProductType { get; set; }
        public virtual Finishing Finishing { get; set; }
    }
}
