using CoreRepo.Models.Data;
using CoreRepo.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreRepo.Controllers.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private DataContext db;
        public CourseRepository(DataContext _db)
        {
            db = _db;
        }

        public void CreateCourse(Course entity)
        {
            db.Courses.Add(entity);
            db.SaveChanges();
        }

        public void DeleteCourse(int Courseid)
        {
            var entity = GetById(Courseid);
            db.Courses.Remove(entity);
            db.SaveChanges();
        }

        public Course GetById(int id)
        {
            return db.Courses.FirstOrDefault(x => x.Id == id);
        }

        public Course GetCourseEgitmenExist(int id)
        {
            return db.Courses.FirstOrDefault(x => x.EgitmenId == id);
        }

        public IEnumerable<Course> GetCourses()
        {
            return db.Courses.ToList();
        }

        public IQueryable<Course> GetCoursesAll()
        {
            return db.Courses.AsQueryable();
        }

        public IEnumerable<Course> GetCoursesByActive(bool isActive)
        {
            return db.Courses.Where(x => x.Aktif == isActive).ToList();
        }

        public IEnumerable<Course> GetCoursesByFilters(string name = null, decimal? price = null, string isActive = null)
        {
            IQueryable<Course> query = db.Courses;
            if (name != null)
            {
                query = query.Where(i => i.Ad.Contains(name));
            }
            if (price != null)
            {
                query = query.Where(i => i.Fiyat >= price);
            }
            if (isActive=="on")
            {
                query = query.Where(i => i.Aktif == true);
            }
            return query.ToList();
        }

        public void UpdateCourse(Course entity)
        {
            //var c = GetById(entity.Id);
            //if (c!=null)
            //{
            //    c.Ad = entity.Ad;
            //    c.Aciklama = entity.Aciklama;
            //    c.Fiyat = entity.Fiyat;
            //    c.Aktif = entity.Aktif;
                db.SaveChanges();
            //}
        }
    }
}
