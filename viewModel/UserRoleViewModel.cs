using Microsoft.Build.Framework;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Booking.viewModel
{
    public class UserRoleViewModel
    {
        [System.ComponentModel.DataAnnotations.Required]

        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Please, enter valid email")]
        public string Email { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public string RoleName { get; set; }

        [DisplayName("Roles")]
        public List<string>? Roles { get; set; }
    }
}
