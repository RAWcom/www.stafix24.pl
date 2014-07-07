using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace stafix24.pl.Models
{
    public class BiuroWirtualneContactModel
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


        [Display(Name = "Obsługa korespondencji")]
        public bool q1 { get; set; }

        [Display(Name = "Skanowanie korespondencji")]
        public bool q2 { get; set; }

        [Display(Name = "Zarządzanie bazą klientów/usług")]
        public bool q3 { get; set; }

        [Display(Name = "Rozliczanie usług")]
        public bool q4 { get; set; }

        [Display(Name = "Zarządzanie zadaniami/sprawami")]
        public bool q5 { get; set; }

        [Display(Name = "Współpraca z biurem księgowym")]
        public bool q6 { get; set; }

        [Display(Name = "Zlecenia do podwykonawców")]
        public bool q7 { get; set; }

        [Display(Name = "Panel Klienta")]
        public bool q8 { get; set; }

        [Display(Name = "Inny obszar...")]
        public bool q0 { get; set; }

        [Display(Name = "Wiadomość")]
        public string MessageBody { get; set; }
    }
}
