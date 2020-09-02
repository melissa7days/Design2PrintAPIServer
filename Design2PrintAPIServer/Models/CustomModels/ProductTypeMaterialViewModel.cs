using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Design2PrintAPIServer.Models.CustomModels
{
    public class ProductTypeMaterialViewModel
    {
        [Key]
        public int ProductTypeMaterialId { get; set; }
        public double MaterialPrice { get; set; }
        public int ProductTypeId { get; set; }
        public string ProductTypeName { get; set; }
        public int MaterialId { get; set; }
        public string MaterialName { get; set; }
    }
}