using CoreRepo.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreRepo.Models.Data
{
    public class SeedDatabase
    {//veritabanına test amaclı veri eklemek için yapıyoruz
        public static void Seed(DbContext context)
        {
            if (context.Database.GetPendingMigrations().Count() == 0)
            {//as dersek sen zaten databe sin demiş oluyoruz
                if (context is DataContext)
                {
                    DataContext _context = context as DataContext;
                    if (_context.Courses.Count() == 0)
                    {
                        //ekleme işlemi yapsin
                        _context.Courses.AddRange(Courses);
                    }
                }
                context.SaveChanges();
            }
        }

        private static Course[] Courses =
        {
            new Course()
            {
                Ad="Html", Aciklama="Html hakkında",Fiyat=50,Aktif=true
            },
             new Course()
            {
                Ad="Css", Aciklama="Css hakkında",Fiyat=40,Aktif=false
            },
              new Course()
            {
                Ad="React", Aciklama="React hakkında",Fiyat=60,Aktif=true
            },
               new Course()
            {
                Ad="Java", Aciklama="Java hakkında",Fiyat=60,Aktif=true
            },
                new Course()
            {
                Ad="Javascript", Aciklama="Javascript hakkında",Fiyat=50,Aktif=true
            },
               new Course()
            {
                Ad="Angular", Aciklama="Angular hakkında",Fiyat=50,Aktif=false
            }
        };
    }
}
