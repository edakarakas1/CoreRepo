using CoreRepo.Models.Data;
using CoreRepo.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreRepo.Controllers.Repository
{
    public class RequestRepository : IRequestRepository
    {
        private DataContext db;
        public RequestRepository(DataContext _db)
        {
            db = _db;
        }

        public List<Request> GetRequests()
        {
            return db.Requests.ToList();
        }

        public IQueryable<Request> GetRequestsAll()
        {
            return db.Requests.AsQueryable();
        }

        public void Insert(Request entity)
        {
            db.Requests.Add(entity);
            db.SaveChanges();
        }
    }
}
