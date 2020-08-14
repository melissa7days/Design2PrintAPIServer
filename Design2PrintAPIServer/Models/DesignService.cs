using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Design2PrintAPIServer.Models
{
    public class DesignService
    {
        [Key]
        public int DesignServiceId { get; set; }
        public string DesignServiceName { get; set; }
    }
}
