using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Design2PrintAPIServer.Models.CustomModels
{
    public class ProductTypePageViewModel
    {
        [Key]
        public int ProductTypePageId { get; set; }
        public double PagePrice { get; set; }
        public int ProductTypeId { get; set; }
        public string ProductTypeName { get; set; }
        public int PageId { get; set; }
        public string PageName { get; set; }
    }
}