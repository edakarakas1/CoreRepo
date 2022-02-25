using CoreRepo.Models.Data;
using CoreRepo.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreRepo.Controllers.Repository
{
    public class LoginRepository : ILoginRepository
    {
        private DataContext db;
        public LoginRepository(DataContext _db)
        {
            db=_db;
        }

        public Admin GetAdmin(string kullanici, string sifre)
        {
            return db.Admin.FirstOrDefault(x => x.KullaniciAdi == kullanici && x.Sifre == sifre);
        }
       


    }
}
