using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Design2PrintAPIServer.Models
{
    public class FinishedFormat
    {
        [Key]
        public int FinishedFormatId { get; set; }
        public string FinishedFormatName { get; set; }
    }
}
