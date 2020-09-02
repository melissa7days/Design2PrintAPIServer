using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Design2PrintAPIServer.Models.CustomModels
{
    public class ProductTypeBookBindingViewModel
    {
        [Key]
        public int ProductTypeBookBindingId { get; set; }
        public double BookBindingPrice { get; set; }
        public int ProductTypeId { get; set; }
        public string ProductTypeName { get; set; }
        public int BookBindingId { get; set; }
        public string BookBindingName { get; set; }
    }
}
