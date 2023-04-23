using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace online_shop_anc.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Column(TypeName = "nvarchar(75)")]
        [Required]
        public string CustomerUsername { get; set; }
        [Column(TypeName = "nvarchar(75)")]
        [Required]
        public string CustomerEmail { get; set; }
        [Required]
        public string CustomerPassword { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Required]
        public string CustomerFullname { get; set; }
        [Required]
        public DateTime CustomerDate { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Required]
        public string CustomerAddress { get; set; }
        public string CustomerPicture { get; set; }
        public List<Order> Orders { get; set; }
    }
}
