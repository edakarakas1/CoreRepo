using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreRepo.Models.Entity
{
    public class Course
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public decimal Fiyat { get; set; }
        public bool Aktif { get; set; }

        [ForeignKey("Eğitmen")]
        public int EgitmenId { get; set; }
        public Egitmen Egitmen{ get; set; }

    }
}
