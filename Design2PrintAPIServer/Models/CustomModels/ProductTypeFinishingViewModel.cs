using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Design2PrintAPIServer.Models.CustomModels
{
    public class ProductTypeFinishingViewModel
    {
        [Key]
        public int ProductTypeFinishingId { get; set; }
        public double FinishingPrice { get; set; }
        public int ProductTypeId { get; set; }
        public string ProductTypeName { get; set; }
        public int FinishingId { get; set; }
        public string FinishingName { get; set; }
    }
}