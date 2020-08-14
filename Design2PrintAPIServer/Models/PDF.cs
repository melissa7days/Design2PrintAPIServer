using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Design2PrintAPIServer.Models
{
    public class PDF
    {
        [Key]
        public int PDFId { get; set; }
        public string PDFName { get; set; }
    }
}
