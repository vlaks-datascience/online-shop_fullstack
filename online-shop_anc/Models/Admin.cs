using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace online_shop_anc.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        [Column(TypeName = "nvarchar(75)")]
        [Required]
        public string AdminUsername { get; set; }
        [Column(TypeName = "nvarchar(75)")]
        [Required]
        public string AdminEmail { get; set; }
        [Required]
        public string AdminPassword { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Required]
        public string AdminFullname { get; set; }
        [Required]
        public DateTime AdminDate { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Required]
        public string AdminAddress { get; set; }
        public string AdminPicture { get; set; }
    }
}
