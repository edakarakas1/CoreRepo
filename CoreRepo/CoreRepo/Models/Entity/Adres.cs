using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace CoreRepo.Models.Entity
{
    public class Adres
    {
        public int AdresId { get; set; }
        [DisplayName("Şehir")]
        public string Sehir { get; set; }
        public string Ülke { get; set; }
    }
}
