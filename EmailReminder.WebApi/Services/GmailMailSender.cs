using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using EmailReminder.Shared.Models;
using Mailjet.Client;

namespace EmailReminder.WebApi.Services
{
    public class GmailMailSender : IMailSender
    {
        public GmailMailSender()
        {
        }

        public void SendLoginToken(string email, string token)
        {
            throw new NotImplementedException();
        }

        public void SendMail(string subject, string body, string to)
        {
            using (var client = new SmtpClient("smtp.gmail.com", 587))
            {
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("YOUR_EMAIL", "YOUR_PASSWORD");
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.EnableSsl = true;

                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("YOUR_EMAIL");
                mailMessage.To.Add(to);
                mailMessage.Subject = subject;
                mailMessage.Body = body;
                client.Send(mailMessage);
            }
        }

        public void SendReminder(Reminder reminder)
        {

            SendMail(
                $"Your reminder for {reminder.DateTime.ToShortDateString()}",
                reminder.Message,
                reminder.EmailAddress);
        }

        public void SendVerification(string email, string token)
        {
            throw new NotImplementedException();
        }
    }
}
