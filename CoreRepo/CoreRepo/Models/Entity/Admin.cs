﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreRepo.Models.Entity
{
    public class Admin
    {
        public int AdminId { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
    }
}
