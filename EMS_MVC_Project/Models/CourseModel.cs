using EMS_MVC_Project.Models.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace EMS_MVC_Project.Models
{
    public class CourseModel
    {
        public CourseModel()
        {
            CourseCategoryList = new List<SelectListItem>();
            var catlist = new EMSDBDataContext().TCategories.ToList();

            foreach (var item in catlist)
            {
                CourseCategoryList.Add(new SelectListItem()
                { Text = item.CategoryName, Value = item.CategoryId.ToString() });
            }
        }
        public int CourseId { get; set; }

        [Required(ErrorMessage ="Please Enter Course Name")]
        [RegularExpression("[a-zA-Z\\s]*",ErrorMessage ="only Alphabest allowed")]
        public string CourseName { get; set; }

        [Required]
        [Range(3,9,ErrorMessage ="Please enter the valid duration")]
        public int CourseDuration { get; set; }

        [Required]
        public int CourseFee { get; set; }

        [Required]
        public int CourseCategoryId { get; set; }
        public List<SelectListItem> CourseCategoryList { get; set; }
    }
}