using stafix24.pl.Models;
using stafix24.pl.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace stafix24.pl.Controllers
{
    public class PromoController : Controller
    {
        #region Restauracja
        
        public ActionResult Restauracja()
        {
            ViewBag.Message = "Jeżeli chcesz uzyskać więcej infomacji na dany temat, jesteś zainteresowany ofertą wspomagającą obsługę Twojej restauracji/kawiarni\n - skorzystaj z poniższego formularza kontaktowego lub zadzwoń do nas.";

            return View();
        }

        [HttpPost]
        public ActionResult Restauracja(RestauracjaContactModel model)
        {
            var msg = String.Format("Nadawcal od: {1}{0}Email: {2}{0}Telefon: {3}{0} Wiadomość: {4}{0}{0}Obsługa rezerwacji gości: {5}{0}Zarządzanie urlopami: {6}{0}Zarządzanie grafikami pracy: {7}{0}Rozliczanie czasu pracy: {8}{0}Zarządzanie zadaniami do wykonania: {8}{0}Zarządzanie bazą dostawców: {8}{0}Obsługa magazynu surowców: {11}{0}Rapory sprzedaży: {12}{0}Archiwum dokumentów: {13}{0}Komunikacja z pracownikami: {14}{0}Integracja z Facebook: {15}{0}Inny obszar...: {16}{0} ",
                Environment.NewLine + "\n",
                model.ContactName,
                model.eMailAddress, 
                model.Telephone,
                model.MessageBody,
                model.q1,model.q2,model.q3,model.q4,model.q5,model.q6,model.q7,model.q8,model.q9,model.q10,model.q11,model.q0);

            var svc = new MailService();
            if (svc.SendMail("stafix-restauracja@stafix24.pl", "biuro@rawcom24.pl", "::Informacja z witryny Stafix24.pl::Restauracja::", msg))
            {
                ViewBag.MailSent = true;
            }

            return View();
        }

        #endregion

        #region Biuro Wirtualne

        public ActionResult BiuroWirtualne()
        {
            ViewBag.Message = "Jeżeli chcesz uzyskać więcej infomacji na dany temat, jesteś zainteresowany ofertą wspomagającą obsługę biura wirtualnego - skorzystaj z poniższego formularza kontaktowego lub zadzwoń do nas.";

            return View();
        }

        [HttpPost]
        public ActionResult BiuroWirtualne(BiuroWirtualneContactModel model)
        {
            var msg = String.Format("Nadawcal od: {1}{0}Email: {2}{0}Telefon: {3}{0} Wiadomość: {4}{0}{0}Obsługa korespondencji: {5}{0}Skanowanie korespondencji: {6}{0}Zarządzanie bazą klientów/usług: {7}{0}Rozliczanie usług: {8}{0}Zarządzanie zadaniami/sprawami: {8}{0}Współpraca z biurem księgowym: {8}{0}Zlecenia do podwykonawców: {11}{0}Panel Klienta: {12}{0}Inny obszar...: {13}{0} ",
                Environment.NewLine + "\n",
                model.ContactName,
                model.eMailAddress,
                model.Telephone,
                model.MessageBody,
                model.q1, model.q2, model.q3, model.q4, model.q5, model.q6, model.q7, model.q8, model.q0);

            var svc = new MailService();
            if (svc.SendMail("stafix-biuro-wirtualne@stafix24.pl", "biuro@rawcom24.pl", "::Informacja z witryny Stafix24.pl::Biuro Wirtualne::", msg))
            {
                ViewBag.MailSent = true;
            }

            return View();
        }

        #endregion

    }
}
