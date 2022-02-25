using CoreRepo.Controllers.Repository;
using CoreRepo.Models;
using CoreRepo.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CoreRepo.Controllers
{
    public class HomeController : Controller
    {
        private IRequestRepository rep;
        public HomeController(IRequestRepository _rep)
        {
            rep = _rep;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Ekle(Request r)
        {
            rep.Insert(r);
            return View("Tesekkur", r);
        }
        public IActionResult Liste()
        {
            return View(rep.GetRequests());
        }
    }
}
