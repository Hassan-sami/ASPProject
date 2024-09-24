using Booking.Models.Data;
using Microsoft.AspNetCore.Identity;

namespace Booking.customValidate
{
    public interface IEmailConfirmationSender
    {
        Task SendConfirmationEmailAsync(User user, string link);
    }
}