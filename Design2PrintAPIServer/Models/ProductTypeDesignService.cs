using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Design2PrintAPIServer.Models
{
    public class ProductTypeDesignService
    {
        [Key]
        public int ProductTypeDesignServiceId { get; set; }
        [ForeignKey("ProductType")]
        public int ProductTypeId { get; set; }
        [ForeignKey("DesignService")]
        public int DesignServiceId { get; set; }
        public double DesignServicePrice { get; set; }
        public virtual ProductType ProductType { get; set; }
        public virtual DesignService DesignService { get; set; }
    }
}
