using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Design2PrintAPIServer.Models
{
    public class ProductTypeRefinement
    {
        [Key]
        public int ProductTypeRefinementId { get; set; }
        [ForeignKey("ProductType")]
        public int ProductTypeId { get; set; }
        [ForeignKey("Refinement")]
        public int RefinementId { get; set; }
        public double RefinementPrice { get; set; }
        public virtual ProductType ProductType { get; set; }
        public virtual Refinement Refinement { get; set; }
    }
}
