using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Design2PrintAPIServer.Models
{
    public class ProductTypePage
    {
        [Key]
        public int ProductTypePageId { get; set; }
        [ForeignKey("ProductType")]
        public int ProductTypeId { get; set; }
        [ForeignKey("Pages")]
        public int PageId { get; set; }
        public double PagePrice { get; set; }
        public virtual ProductType ProductType { get; set; }
        public virtual Pages Pages { get; set; }
    }
}
