using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Design2PrintAPIServer.Models
{
    public class BookBinding
    {
        [Key]
        public int BookBindingId { get; set; }
        public string BookBindingName { get; set; }
    }
}
