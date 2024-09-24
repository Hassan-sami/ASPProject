using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Booking.viewModel
{
    public class RegisterViewModel
    {
        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required]
        [DisplayName("User Name")]
        public string UserName { get; set; }


        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        [DisplayName("Confirm Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$",ErrorMessage ="Please, enter valid email")]
        public string Email { get; set; }

        


    }
}
