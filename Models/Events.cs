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
    public class Events
    {
        [Display(Name = "Id události")]
        public int Id { get; set; }
        [Display(Name = "Id klienta")]
        public int KlientId { get; set; }
        [Display(Name = "Id pojištění")]
        public int InsuranceId { get; set; }
        [Required(ErrorMessage = "Vyplňte datum nahlášení pojistné události")]
        [Display(Name = "Datum nahlášení")]
        public DateTime Nahlaseno { get; set; }
        [Required(ErrorMessage = "Vyplňte typ události")]
        [Display(Name = "Typ události")]
        public string Typ { get; set; }
        [Required(ErrorMessage = "Vyplňte odhad škody")]
        [Display(Name = "Odhadovaná škoda")]
        public int Odhad { get; set; }
        [Required(ErrorMessage = "Vyplňte vyplacenou částku")]
        [Display(Name = "Vyplacená částka")]
        public int VyplacenaCastka { get; set; }
        [Required(ErrorMessage = "Vyplňte datum vyplacení plnění")]
        [Display(Name = "Datum vyplacení")]
        public DateTime VyplacenoDatum { get; set; }
    }
}
