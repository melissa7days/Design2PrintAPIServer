using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Design2PrintAPIServer.Models.CustomModels
{
    public class ProductTypePDFViewModel
    {
        [Key]
        public int ProductTypePDFId { get; set; }
        public double PDFPrice { get; set; }
        public int ProductTypeId { get; set; }
        public string ProductTypeName { get; set; }
        public int PDFId { get; set; }
        public string PDFName { get; set; }
    }
}