using CoreRepo.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreRepo.Controllers.Repository
{
    public interface IEgitmenRepository
    {
        IEnumerable<Egitmen> GetEgitmens();
        Egitmen GetById(int id);
        IQueryable<Egitmen> GetEgitmenAll();


        void UpdateEgitmen();
        void CreateEgitmen(Egitmen egitmen);
        void DeleteEgitmen(int id);
        IQueryable<Egitmen> GetAvailableEgitmen();
    }
}
