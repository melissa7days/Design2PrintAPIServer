using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Design2PrintAPIServer.Models
{
    public class Pages
    {
        [Key]
        public int PageId { get; set; }
        public string PageName { get; set; }
    }
}
