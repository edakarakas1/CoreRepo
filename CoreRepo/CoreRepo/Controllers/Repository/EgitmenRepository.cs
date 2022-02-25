using CoreRepo.Models.Data;
using CoreRepo.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreRepo.Controllers.Repository
{
    public class EgitmenRepository : IEgitmenRepository
    {
        private DataContext db;
        public EgitmenRepository(DataContext _db)
        {
            db = _db;
        }

        public void CreateEgitmen(Egitmen egitmen)
        {
            db.Egitmen.Add(egitmen);
            db.SaveChanges();
        }

        public void DeleteEgitmen(int id)
        {
            var entity = GetById(id);
            int adresid = entity.Adres.AdresId;       
            db.Egitmen.Remove(entity);
            db.SaveChanges();
            db.Database.ExecuteSqlInterpolated($"EXEC DeleteAddress @ID={adresid}");
            db.SaveChanges();
        }
        public Egitmen GetById(int id)
        {
            return db.Egitmen.
               AsQueryable().Include(x => x.Adres).FirstOrDefault(x => x.Id == x.Id);
        }
        /// <summary>
        /// ///
        /// </summary>
        /// <returns></returns>
        public IQueryable<Egitmen> GetEgitmenAll()
        {
            return db.Egitmen.AsQueryable();
        }

        public IEnumerable<Egitmen> GetEgitmens()
        {
            return db.Egitmen.ToList();
        }

        public IQueryable<Egitmen> GetAvailableEgitmen()
        {
            return db.Egitmen.AsQueryable().Where(x => x.Course.EgitmenId != x.Id);
        }

        public void UpdateEgitmen()
        {
            db.SaveChanges();
        }
    }
}
