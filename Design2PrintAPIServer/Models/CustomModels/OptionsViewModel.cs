using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Design2PrintAPIServer.Models.CustomModels
{
    public class OptionsViewModel
    {
        [Key]
        public int ProductTypeOptionId { get; set; }
        public double OptionPrice { get; set; }
        public int ProductTypeId { get; set; }
        public string ProductTypeName { get; set; }
        public int OptionId { get; set; }
        public string OptionName { get; set; }
    }
}
