using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EMS_MVC_Project.Models
{
    public class CourseViewModel
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int CourseDuration { get; set; }
        public int CourseFee { get; set; }
        public string CategoryName { get; set; }
    }
}