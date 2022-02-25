using CoreRepo.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreRepo.Controllers.Repository
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
        Course GetById(int id);
        IQueryable<Course> GetCoursesAll();
        IEnumerable<Course> GetCoursesByActive(bool isActive);
        IEnumerable<Course> GetCoursesByFilters(string name = null, decimal? price = null, string isActive = null);
        void UpdateCourse(Course entity);
        void CreateCourse(Course entity);
        void DeleteCourse(int Courseid);
        Course GetCourseEgitmenExist(int id);
    }
}
