using Microsoft.AspNet.Identity;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Note.ClassesAnterieures
{
    static class SendGrid
    {
       /* public Task SendAsync(Message message)
        {
            // Indiquez votre service de messagerie ici pour envoyer un e-mail.
            return configSendGridasync(message);
            //return Task.FromResult(0);
        }*/
        private static async Task configSendGridasync(IdentityMessage message)
        {
            try
            {
                var apiKey = Environment.GetEnvironmentVariable("sendgrid");
                var client = new SendGridClient(apiKey);
                var from = new EmailAddress("ksohenou@gmail.com", "STLVV - Togo");
                var subject = message.Subject;
                var to = new EmailAddress(message.Destination, message.Destination);
                var plainTextContent = "";
                var htmlContent = message.Body;
                var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
                var response = await client.SendEmailAsync(msg);
                if (response.IsSuccessStatusCode)
                    await Task.FromResult(0);
            }
            catch (Exception ex)
            { await Task.FromException(ex); }
        }
    }
}
