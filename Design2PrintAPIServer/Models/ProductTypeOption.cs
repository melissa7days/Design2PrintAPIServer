using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Design2PrintAPIServer.Models
{
    public class ProductTypeOption
    {
        [Key]
        public int ProductTypeOptionId { get; set; }
        [ForeignKey("ProductType")]
        public int ProductTypeId { get; set; }
        [ForeignKey("Option")]
        public int OptionId { get; set; }
        public double OptionPrice { get; set; }
        public virtual ProductType ProductType { get; set; }
        public virtual Options Option { get; set; }
    }
}
