using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace online_shop_anc.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        [Required]
        public Payment PaymentMethod { get; set; }
        public decimal GrandTotal { get; set; }
        public DateTime OrderDateTime { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Required]
        public string CustomerAddress { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string OrderComment { get; set; }
        public Status OrderStatus { get; set; }
        public List<Product> Products { get; set; }
    }
}
