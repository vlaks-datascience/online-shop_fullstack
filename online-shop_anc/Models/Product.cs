using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace online_shop_anc.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [Required]
        public string ProductName { get; set; }
        public int SellerId { get; set; }
        public Seller Seller { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int ProductQuantity { get; set; }
        [Column(TypeName = "nvarchar(150)")]
        [Required]
        public string ProductDescription { get; set; }
        public string ProductPhoto { get; set; }    
    }
}
