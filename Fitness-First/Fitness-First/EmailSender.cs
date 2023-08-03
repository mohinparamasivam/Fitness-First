using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using MimeKit;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace Fitness_First
{
    public class EmailSender : IEmailSender
    {
        private readonly MailtrapSettings _mailSettings;

        public EmailSender(IOptions<MailtrapSettings> mailSettings)
        {
            _mailSettings = mailSettings.Value;
        }

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(_mailSettings.SenderName, _mailSettings.SenderEmail));
            message.To.Add(new MailboxAddress(email));
            message.Subject = subject;

            message.Body = new TextPart("html")
            {
                Text = htmlMessage
            };

            using (var client = new SmtpClient())
            {
                client.Connect(_mailSettings.Host, _mailSettings.Port, _mailSettings.UseSsl);
                client.Authenticate(_mailSettings.UserName, _mailSettings.Password);
                client.Send(message);
                client.Disconnect(true);
            }

            return Task.CompletedTask;
        }
    }
}
