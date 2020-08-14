using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Design2PrintAPIServer.Models
{
    public class ProductTypeMaterial
    {
        [Key]
        public int ProductTypeMaterialId { get; set; }
        [ForeignKey("ProductType")]
        public int ProductTypeId { get; set; }
        [ForeignKey("Material")]
        public int MaterialId { get; set; }
        public double MaterialPrice { get; set; }
        public virtual ProductType ProductType { get; set; }
        public virtual Material Material { get; set; }
    }
}
