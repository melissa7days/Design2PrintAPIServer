using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Design2PrintAPIServer.Models
{
    public class Material
    {
        [Key]
        public int MaterialId { get; set; }
        public string MaterialName { get; set; }
    }
}
