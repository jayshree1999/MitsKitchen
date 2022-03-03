using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MitsKitchen.Models
{
    [Table("Product")]
    public class Product
    {
        
        [Display(Name = "Product ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        [Display(Name = "Name of the Product")]
        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string ProductName { get; set; }

        [Display(Name = "Description of the Product")]
        [Required]
        [StringLength(150)]
        [Column(TypeName = "varchar")]
        public string ProductDescription { get; set; }

       
        [Display(Name = "Product Price")]
        [Required]
        public decimal ProductPrice { get; set; }

        
        [DisplayName("Upload File")]
        public string Image { get; set; }

        [DisplayName("Available")]
        [Required]
        public bool IsAvailable { get; set; }

        [DisplayName("Category Type")]
        [Required]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category CategoryName { get; set; }
    }
}
