using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Design2PrintAPIServer.Models
{
    public class Refinement
    {
        [Key]
        public int RefinementId { get; set; }
        public string RefinementName { get; set; }
    }
}
