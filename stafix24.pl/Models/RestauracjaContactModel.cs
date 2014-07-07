using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace stafix24.pl.Models
{
    public class RestauracjaContactModel
    {
        [Required]
        [Display(Name = "Kontakt")]
        [MinLength(5)]
        public string ContactName { get; set; }

        [Required]
        [Display(Name = "Adres e-Mail")]
        [EmailAddress]
        public string eMailAddress { get; set; }

        [Display(Name = "Telefon")]
        [MinLength(9)]
        public string Telephone { get; set; }


        [Display(Name = "Obsługa rezerwacji gości")]
        public bool q1 { get; set; }

        [Display(Name = "Zarządzanie urlopami")]
        public bool q2 { get; set; }

        [Display(Name= "Zarządzanie grafikami pracy")]
        public bool q3 { get; set; }

        [Display(Name = "Rozliczanie czasu pracy")]
        public bool q4 { get; set; }

        [Display(Name = "Zarządzanie zadaniami do wykonania")]
        public bool q5 { get; set; }

        [Display(Name = "Zarządzanie bazą dostawców")]
        public bool q6 { get; set; }

        [Display(Name = "Obsługa magazynu surowców")]
        public bool q7 { get; set; }

        [Display(Name = "Rapory sprzedaży")]
        public bool q8 { get; set; }

        [Display(Name = "Archiwum dokumentów")]
        public bool q9 { get; set; }

        [Display(Name = "Komunikacja z pracownikami")]
        public bool q10 { get; set; }

        [Display(Name = "Integracja z Facebook")]
        public bool q11 { get; set; }

        [Display(Name = "Inny obszar...")]
        public bool q0 { get; set; }

        [Display(Name = "Wiadomość")]
        public string MessageBody { get; set; }
        
    }
}