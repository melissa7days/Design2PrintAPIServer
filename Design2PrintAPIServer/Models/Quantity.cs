using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Design2PrintAPIServer.Models
{
    public class Quantity
    {
        [Key]
        public int QuantityId { get; set; }
        public string QuantityName { get; set; }
    }
}
