using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Booking.viewModel
{
    public class ChangePasswordViewModel
    {

        [Required]
        [DataType(DataType.Password)]
        public string OldPassword { get; set; }


        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        [DisplayName("Confirm Password")]
        public string ConfirmPassword { get; set; }

        

        


    }
}
