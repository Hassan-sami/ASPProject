using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Booking.viewModel
{
    public class SignInViewModel
    {
        [Required]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Please, enter valid email")]
        public string Email { get; set; }


        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("Remeber this Device")]
        public bool RememberMe { get; set; }
    }
}
