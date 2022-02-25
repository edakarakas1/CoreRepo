using CoreRepo.Controllers.Repository;
using CoreRepo.Models.Data;
using CoreRepo.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreRepo.Controllers
{
    public class CourseController : Controller
    {
        COURSEMODEL model = new COURSEMODEL();
        private ICourseRepository rep;
        private IEgitmenRepository repegt;

        public CourseController(ICourseRepository _rep, IEgitmenRepository _repegt)
        {
            rep = _rep;
            repegt = _repegt;
        }
        //public IActionResult Index()
        //{
        //    //var courses = rep.GetCourses().Where(x => x.Aktif == true);
        //    var courses = rep.GetCoursesByActive(false);
        //    return View(courses);
        //}
        //Filtreleme Listeleme
        COURSEMODEL Egitmen = new COURSEMODEL();
        public IActionResult Index(string name = null, decimal? price = null, string isActive = null)
        {
            model.clist = rep.GetCoursesAll().Include(x => x.Egitmen).ToList();
            model.clist = rep.GetCoursesByFilters(name, price, isActive).ToList();
            ViewBag.Name = name;
            ViewBag.Price = price;
            ViewBag.isActive = isActive == "on" ? true : false;
            return View(model);
        }
        public IActionResult Guncelle(int id)
        {
            ViewBag.Actionmode = "Guncelle";
            model.Course = rep.GetById(id);
            model.egtlist = repegt.GetAvailableEgitmen().Select(x => new SelectListItem
            {
                Text = x.İsim + " " + x.Soyisim,
                Value = x.Id.ToString()
            });
            return View(model);
        }
        [HttpPost]
        public IActionResult Guncelle(int id, COURSEMODEL entity)
        {
            Course c = rep.GetById(id);
            c.Ad = entity.Course.Ad;
            c.Aktif = entity.Course.Aktif;
            c.Fiyat = entity.Course.Fiyat;
            c.EgitmenId =entity.Course.EgitmenId;
            rep.UpdateCourse(c);

            return RedirectToAction("Index");
        }
        public IActionResult Ekle()
        {
            ViewBag.Actionmode = "Ekle";
            model.egtlist = repegt.GetAvailableEgitmen().Select(x => new SelectListItem
            {
                Text = x.İsim + x.Soyisim,
                Value = x.Id.ToString()
            });
            return View("Guncelle", model);
        }
        [HttpPost]
        public IActionResult Ekle(COURSEMODEL cm)
        {
            Course c = new Course();
            c.Ad = cm.Course.Ad;
            c.Aktif = cm.Course.Aktif;
            c.Fiyat = cm.Course.Fiyat;

            var a = rep.GetCourseEgitmenExist(cm.Course.EgitmenId);
            //if (a == null)
            //{
                c.EgitmenId = cm.Course.EgitmenId;
                rep.CreateCourse(c);
            //}
            //else
            //{
            //    return View("Hata");
            //}
            return RedirectToAction("Index");
        }
        public IActionResult Sil(int id)
        {
            rep.DeleteCourse(id);
            return RedirectToAction("Index");
        }
        public IActionResult Detay(int id)
        {
            model.Course = rep.GetById(id);
            model.elist = repegt.GetEgitmens().ToList();
            return View(model);
        }
    }
}
