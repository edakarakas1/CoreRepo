using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreRepo.Models.Entity
{
    public class Egitmen
    {
        public int Id { get; set; }
        public string İsim { get; set; }
        public string Soyisim { get; set; }
        public Adres Adres { get; set; }
        public Course Course { get; set; }
    }
}
