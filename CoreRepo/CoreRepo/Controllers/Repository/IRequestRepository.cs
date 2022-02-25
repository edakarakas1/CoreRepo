using CoreRepo.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreRepo.Controllers.Repository
{
    public interface IRequestRepository
    {
        void Insert(Request entity);
        List<Request> GetRequests();
        IQueryable<Request> GetRequestsAll();

    }
}
