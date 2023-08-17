using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EMS_MVC_Project.Models
{
    public class CourseViewModelWrapper
    {
        public List<CategoryModel> Categories { get; set; }
        public List<CourseViewModel> courses { get; set; }
    }
}