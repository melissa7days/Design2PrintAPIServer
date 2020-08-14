using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Design2PrintAPIServer.Models
{
    public class Discount
    {
        [Key]
        public int DiscountId { get; set; }
        public string DiscountName { get; set; }
    }
}
