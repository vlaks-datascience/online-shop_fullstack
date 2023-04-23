using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace online_shop_anc.Models
{
    public class Seller
    {
        [Key]
        public int SellerId { get; set; }
        [Column(TypeName = "nvarchar(75)")]
        [Required]
        public string SellerUsername { get; set; }
        [Column(TypeName = "nvarchar(75)")]
        [Required]
        public string SellerEmail { get; set; }
        [Required]
        public string SellerPassword { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Required]
        public string SellerFullname { get; set; }
        [Required]
        public DateTime SellerDate { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Required]
        public string SellerAddress { get; set; }
        public string SellerPicture { get; set; }
        public bool SellerApproved { get; set; }
    }
}
