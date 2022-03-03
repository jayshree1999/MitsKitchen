using Microsoft.AspNetCore.Http;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MitsKitchen.Models
{
    [Table("Category")]
    public class Category
    {

        [Display(Name = "Category ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }

        [Display(Name = "Name of the Category")]
        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string CategoryName { get; set; }

        

    }
}
