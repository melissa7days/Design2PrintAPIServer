using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Design2PrintAPIServer.Models.CustomModels
{
    public class DesignServiceViewModel
    {
        [Key]
        public int ProductTypeDesignServiceId { get; set; }
        public double DesignServicePrice { get; set; }
        public int ProductTypeId { get; set; }
        public string ProductTypeName { get; set; }
        public int DesignServiceId { get; set; }
        public string DesignServiceName { get; set; }
    }
}