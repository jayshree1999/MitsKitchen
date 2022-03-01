using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
namespace MitsKitchen.Models
{
    public class MyIdentityUser
        :IdentityUser<Guid>
    {
        [Display(Name = "Display Name")]
        [Required]
        [MinLength(3)]
        [StringLength(60)]
        public string DisplayName { get; set; }

        [Display(Name = "Date of birth")]
        [PersonalData]
        [Required]
        [Column(TypeName = "smalldatetime")]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Is Admin User")]
        [Required]
        public Boolean IsAdminUser { get; set; }

    }
}
