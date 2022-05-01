using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoffeeShopRegistrationLab.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Must enter First Name.")]
        [Display(Name = "First Name")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]

        public string Password { get; set; }



        [NotMapped]
        [DataType(DataType.Password)]
        [Display(Name = "Confirmed Password")]
        [Compare("Password")]

        public string ConfirmPassword { get; set; }

    }
}
