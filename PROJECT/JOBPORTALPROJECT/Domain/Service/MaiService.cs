using System;
using System.Threading.Tasks;
using Domain.Helpers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using MimeKit;
using MailKit.Net.Smtp;
using Domain.Helpers; // ✅ Add this for SmtpClient

namespace Domain.Service
{
    public class EmailService : IEmailService
    {
        private readonly MailSettings _mailSettings;
        private readonly IConfiguration _config;

        public EmailService(IOptions<MailSettings> mailSettings, IConfiguration config)
        {
            _mailSettings = mailSettings.Value;
            _config = config;
        }

        public async Task SendEmailAsync(MailRequest mailRequest)
        {
            try
            {
                var fromMail = _config.GetSection("MailSettings")["FromMail"];
                var displayName = _config.GetSection("MailSettings")["DisplayName"];

                var email = new MimeMessage();
                email.From.Add(new MailboxAddress(displayName, fromMail));
                email.To.Add(MailboxAddress.Parse(mailRequest.ToEmail));
                email.Subject = mailRequest.Subject;

                var builder = new BodyBuilder
                {
                    HtmlBody = mailRequest.Body
                };
                email.Body = builder.ToMessageBody();

                using var smtp = new SmtpClient();
                smtp.Connect(_mailSettings.Host, _mailSettings.Port, _mailSettings.UseSSL);

                // Optional: Only authenticate if required
                if (_mailSettings.DoAuthenticate)
                {
                    smtp.Authenticate(_mailSettings.UserMail, _mailSettings.Password);
                }

                await smtp.SendAsync(email);
                smtp.Disconnect(true);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Email sending failed: {ex.Message}");
                // Optional: Log the exception or rethrow
            }
        }
    }
}
