using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Web.Mvc;


namespace Ekub.Controllers
{
    public class NotificationController : Controller
    {
        // GET: Notification
        public ActionResult SendMultipleEmails(string subject,string body)
        {
            
            var recipients = new List<string>
            {
                "fayomuhe5@gmail.com",
                "famiti06@gmail.com",
                
            };

            foreach (var recipient in recipients)
            {
                SendEmail(recipient, subject, body);
            }

            ViewBag.Message = "Emails sent successfully to recipients.";

            return View();
        }

        private void SendEmail(string to, string subject, string body)
        {
            using (var message = new MailMessage())
            {
                message.From = new MailAddress("fayomuh5@gmail.com");
                message.To.Add(new MailAddress(to));
                message.Subject = subject;
                message.Body = body;
                message.IsBodyHtml = true;

                using (var smtpClient = new SmtpClient())
                {
                    smtpClient.EnableSsl = true;
                    smtpClient.Host = "smtp.gmail.com"; 
                    smtpClient.Port = 587; 
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = new NetworkCredential("fayomuhe5@gmail.com", "weledmftsjveulqz");

                    try
                    {
                        smtpClient.Send(message);
                    }
                    catch (Exception ex)
                    {
                        // Handle exceptions or log errors
                    }
                }
            }
        }

    }
}