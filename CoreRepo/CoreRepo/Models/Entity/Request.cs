using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreRepo.Models.Entity
{
    public class Request
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Mesaj { get; set; }
    }
}
