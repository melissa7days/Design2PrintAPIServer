using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Design2PrintAPIServer.Models.CustomModels
{
    public class ProductTypeQuantityViewModel
    {
        [Key]
        public int ProductTypeQuantityId { get; set; }
        public int ProductTypeId { get; set; }
        public string ProductTypeName { get; set; }
        public int QuantityId { get; set; }
        public int QuantityName { get; set; }
    }
}