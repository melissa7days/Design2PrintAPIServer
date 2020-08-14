using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Design2PrintAPIServer.Models
{
    public class Option
    {
        [Key]
        public int OptionId { get; set; }
        public string OptionName { get; set; }
    }
}
