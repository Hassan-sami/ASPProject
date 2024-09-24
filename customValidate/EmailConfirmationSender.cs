using Booking.Models.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace Booking.customValidate
{
    public class EmailConfirmationSender : IEmailConfirmationSender
    {
        private readonly IEmailSender _sender;

        public EmailConfirmationSender(IEmailSender sender)
        {
            this._sender = sender;
        }

        public async  Task SendConfirmationEmailAsync(User user, string link)
        {
            string subject = "Confirm Your Email";
            string body = $"<html><body>Please confirm your email by clicking this link: <a href='{link}'>link</a>" +
                $"</body></html>";

            await _sender.SendEmailAsync(user.Email, subject, body);
        }
    }
}
