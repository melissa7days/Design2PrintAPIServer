using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Design2PrintAPIServer.Models.CustomModels
{
    public class FinishedFormatViewModel
    {
        [Key]
        public int ProductTypeFinishedFormatId { get; set; }
        public double FinishedFormatPrice { get; set; }
        public int ProductTypeId { get; set; }
        public string ProductTypeName { get; set; }
        public int FinishedFormatId { get; set; }
        public string FinishedFormatName { get; set; }
    }
}