using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Design2PrintAPIServer.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        [ForeignKey("Cart")]
        public int CartId { get; set; }
        public string PaymentMessage { get; set; }
        public virtual Cart Cart { get; set; }
    }
}
