using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EvidencePojisteni.Models
{
    public class Klient
    {
        [Display(Name ="Id")]
        public int Id { get; set; }
        [Display(Name = "Jméno")]
        [Required(ErrorMessage = "Vyplňte jméno")]
        public string Jmeno { get; set; }
        [Required(ErrorMessage = "Vyplňte příjmení")]
        [Display(Name = "Příjmení")]
        public string Prijmeni { get; set; }
        [Required(ErrorMessage = "Vyplňte telefon")]
        [Display(Name = "Telefon")]
        public string Telefon { get; set; }
        [Required(ErrorMessage = "Vyplňte email")]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
