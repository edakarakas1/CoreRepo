using CoreRepo.Controllers.Repository;
using CoreRepo.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreRepo.Controllers
{
    public class EgitmenController : Controller
    {

        private IEgitmenRepository rep;
        private ICourseRepository repgt;
        public EgitmenController(IEgitmenRepository _rep/*, ICourseRepository _repgt*/)
        {
            rep = _rep;
            //repgt = _repgt;
        }
        COURSEMODEL model = new COURSEMODEL();
        public IActionResult Index()
        {
            model.elist = rep.GetEgitmenAll().Include(x => x.Adres).ToList();
            return View(model);
        }
        public IActionResult Ekle()
        {
            ViewBag.Actionmode = "Ekle";
            return View();
        }
        [HttpPost]
        public IActionResult Ekle(COURSEMODEL cm)
        {
            Egitmen e = new Egitmen();
            e.İsim = cm.egitmen.İsim;
            e.Soyisim = cm.egitmen.Soyisim;
            e.Adres = cm.egitmen.Adres;
            rep.CreateEgitmen(e);
            return RedirectToAction("Index");
        }
        public ActionResult Guncelle(int id)
        {
            model.egitmen = rep.GetById(id);
            ViewBag.Actionmode = "Guncelle";
            return View("Ekle", model);
        }
        [HttpPost]
        public IActionResult Guncelle(int id, COURSEMODEL cm)
        {
            Egitmen e = rep.GetById(id);
            e.İsim = cm.egitmen.İsim;
            e.Soyisim = cm.egitmen.Soyisim;
            e.Adres = cm.egitmen.Adres;
            rep.UpdateEgitmen();
            return RedirectToAction("Index");
        }
        public IActionResult Detay(int id)
        {
            model.egitmen = rep.GetById(id);        
            return View(model);
        }
        public IActionResult Sil(int id)
        {
            rep.DeleteEgitmen(id);
            return RedirectToAction("Index");
        }

    }
}