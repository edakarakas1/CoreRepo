using CoreRepo.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreRepo.Models.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>options):base(options)
        {

        }

        public DbSet<Request> Requests { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Egitmen> Egitmen { get; set; }
        public DbSet<Adres> Adres { get; set; }
        public DbSet<Admin> Admin { get; set; }


    }
}
