using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Design2PrintAPIServer.Models.CustomModels
{
    public class ProductTypeRefinementViewModel
    {
        [Key]
        public int ProductTypeRefinementId { get; set; }
        public double RefinementPrice { get; set; }
        public int ProductTypeId { get; set; }
        public string ProductTypeName { get; set; }
        public int RefinementId { get; set; }
        public string RefinementName { get; set; }
    }
}