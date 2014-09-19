using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using stafix24.pl.Models;
using stafix24.pl.Services;
using System.Web.Configuration;
using System.Text;

namespace stafix24.pl.Controllers
{
    public class HomeController : Controller
    {
        string senderEmailAddress;
        string targetEmailAddress;

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(ContactModel model)
        {
            //var msg = String.Format("Nadawca: {1}{0}Email: {2}{0}Komentarz: {3}{0}",
            //    Environment.NewLine+"\n",
            //    model.name,
            //    model.email,
            //    model.comment);

            var msg=String.Format(@"<table style='width: 600px'><tr><td width='30px'>Nadawca</td><td>{1}</td></tr><tr><td>Email</td><td>{2}</td></tr><tr><td>Wiadomość</td><td>{3}</td></tr></table>",
                Environment.NewLine+"\n",
                model.name,
                model.email,
                model.comment);

            string senderEmailAddress = WebConfigurationManager.AppSettings["SenderEmailAddress"].ToString();
            string targetEmailAddress = WebConfigurationManager.AppSettings["TargetEmailAddress"].ToString();

            var svc = new MailService();
            if (svc.SendMail(senderEmailAddress, targetEmailAddress, model.email.ToString(), "::Informacja z witryny Stafix24.pl::", msg))
            {
                 ViewBag.MailSent = true;
            }

            return View(); 
        }

        public ActionResult ProductDetailsSec1()
        {
            return View();
        }
        public ActionResult ProductDetailsSec2()
        {
            return View();
        }
        public ActionResult ProductDetailsSec3()
        {
            return View();
        }
        public ActionResult ProductDetailsSec4()
        {
            return View();
        }
        public ActionResult ProductDetailsSec5()
        {
            return View();
        }
        public ActionResult CommercialOffer()
        {
            return View();
        }
        public ActionResult RulesOfService()
        {
            return View();
        }
    }
}
