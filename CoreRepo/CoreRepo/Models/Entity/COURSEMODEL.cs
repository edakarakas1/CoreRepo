using CoreRepo.Controllers;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreRepo.Models.Entity
{
    public class COURSEMODEL
    {
        public Course Course { get; set; }
        public Egitmen egitmen { get; set; }
        public ICollection<Egitmen> elist { get; set; }
        public ICollection<Course> clist { get; set; }
        public IEnumerable<SelectListItem> egtlist { get; set; }
    }
}
