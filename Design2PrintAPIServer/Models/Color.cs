using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Design2PrintAPIServer.Models
{
    public class Color
    {
        [Key]
        public int ColorId { get; set; }
        public string ColorName { get; set; }
    }
}
