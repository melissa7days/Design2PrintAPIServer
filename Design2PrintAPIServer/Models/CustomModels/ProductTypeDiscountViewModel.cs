using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Design2PrintAPIServer.Models.CustomModels
{
    public class ProductTypeDiscountViewModel
    {
        [Key]
        public int ProductTypeDiscountId { get; set; }
        public double DiscountPrice { get; set; }
        public int ProductTypeId { get; set; }
        public string ProductTypeName { get; set; }
        public int DiscountId { get; set; }
        public string DiscountName { get; set; }
    }
}