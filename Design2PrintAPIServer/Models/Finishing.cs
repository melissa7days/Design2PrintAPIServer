using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Design2PrintAPIServer.Models
{
    public class Finishing
    {
        [Key]
        public int FinishingId { get; set; }
        public string FinishingName { get; set; }
    }
}
