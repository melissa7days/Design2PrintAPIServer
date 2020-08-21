using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Design2PrintAPIServer.Models.CustomModels
{
    public class ColorViewModel
    {
        [Key]
        public int ProductTypeColorId { get; set; }
        public double ColorPrice { get; set; }
        public int ProductTypeId { get; set; }
        public string ProductTypeName { get; set; }
        public int ColorId { get; set; }
        public string ColorName { get; set; }
    }
}