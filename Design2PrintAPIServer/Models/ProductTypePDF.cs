using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Design2PrintAPIServer.Models
{
    public class ProductTypePDF
    {
        [Key]
        public int ProductTypePDFId { get; set; }
        [ForeignKey("ProductType")]
        public int ProductTypeId { get; set; }
        [ForeignKey("PDF")]
        public int PDFId { get; set; }
        public double PDFPrice { get; set; }
        public virtual ProductType ProductType { get; set; }
        public virtual PDF PDF { get; set; }

    }
}
