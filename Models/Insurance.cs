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
    public class Insurance
    {
        [Display(Name = "Id pojištění")]
        public int Id { get; set; }
        [Display(Name = "Id klienta")]
        public int KlientId { get; set; }
        [Display(Name = "Typ pojistky")]
        [Required(ErrorMessage = "Vyplňte typ pojistky (Povinné ručení, Havarijní, Domácnosti, Nemovitosti, Cestovní, Životní)")]
        public string Typ { get; set; }
        [Required(ErrorMessage = "Vyplňte predmet pojištění")]
        [Display(Name = "Předmět pojištění")]
        public string Predmet { get; set; }
        [Display(Name = "Platnost od")]
        [Required(ErrorMessage = "Vyplňte datum")]
        public DateTime PlatnostOd { get; set; }
        [Display(Name = "Platnost do")]
        [Required(ErrorMessage = "Vyplňte datum")]
        public DateTime PlatnostDo { get; set; }
        [Required(ErrorMessage = "Vyplňte částku")]
        [Display(Name = "Částka")]
        public int RocniCastka { get; set; }

    }
}
