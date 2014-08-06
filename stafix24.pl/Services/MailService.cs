using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

using System.Text;
using System.Net.Mime;
using System.Web.Configuration;

namespace stafix24.pl.Services
{
    public class MailService : IMailService
    {
        public bool SendMail(string from, string to, string subject, string body)
        {

            try
            {
            MailMessage mailMsg = new MailMessage();

            // To
            mailMsg.To.Add(new MailAddress(to.ToString(), "Administrator witryny STAFix24.pl"));

            // From
            mailMsg.From = new MailAddress(from.ToString(), "Witryna STAFix24.pl");

            // Subject and multipart/alternative Body
            mailMsg.Subject = subject.ToString();
            string text = body;
            string html = @"<p>"+body+"</p>";
            mailMsg.AlternateViews.Add(AlternateView.CreateAlternateViewFromString(text, null, MediaTypeNames.Text.Plain));
            //mailMsg.AlternateViews.Add(AlternateView.CreateAlternateViewFromString(html, null, MediaTypeNames.Text.Html));

            //get config params
            string sMTPServerName = WebConfigurationManager.AppSettings["SMTPServerName"].ToString();
            string sMTPLoginName = WebConfigurationManager.AppSettings["SMTPLoginName"].ToString();
            string sMTPPassword = WebConfigurationManager.AppSettings["SMTPPassword"].ToString();

            // Init SmtpClient and send
            SmtpClient smtpClient = new SmtpClient(sMTPServerName, Convert.ToInt32(587));
            System.Net.NetworkCredential credentials = new System.Net.NetworkCredential(sMTPLoginName, sMTPPassword);
            smtpClient.Credentials = credentials;

            smtpClient.Send(mailMsg);
            }
            catch (Exception)
            {
            return false;
            }

            return true;

        }
    }
}