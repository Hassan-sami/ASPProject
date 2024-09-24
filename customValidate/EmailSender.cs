using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using System.Configuration;
using System.Net;
using System.Net.Mail;

namespace Booking.customValidate
{
    public class EmailSender : IEmailSender
    {
       
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var configuration = new ConfigurationBuilder().
                AddJsonFile("appsettings.json").Build();

            IConfigurationSection section = configuration.GetSection("SmtpSettings");
            var smtpClient = new SmtpClient()
            {
                Port = 587,
                Host = section.GetSection("SmtpServer").Value,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,

                Credentials = new NetworkCredential(section.GetSection("Username").Value,
                                section.GetSection("Password").Value),
               
            };
            

            //var message = new MailMessage();

            //message.Subject = subject;
            //message.Body = htmlMessage;
            ////message.IsBodyHtml = true;
            //message.From = new MailAddress();
            //message.To.Add(email);

            

            await  smtpClient.SendMailAsync(section.GetSection("Username").Value,email,subject,htmlMessage);
           
        }
    }
}
