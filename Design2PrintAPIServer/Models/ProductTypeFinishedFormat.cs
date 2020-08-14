using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Design2PrintAPIServer.Models
{
    public class ProductTypeFinishedFormat
    {
        [Key]
        public int ProductTypeFinishedFormatId { get; set; }
        [ForeignKey("ProductType")]
        public int ProductTypeId { get; set; }
        [ForeignKey("FinishedFormat")]
        public int FinishedFormatId { get; set; }
        public double FinishedFormatPrice { get; set; }
        public virtual ProductType ProductType { get; set; }
        public virtual FinishedFormat FinishedFormat { get; set; }

    }
}
