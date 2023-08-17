using EMS_MVC_Project.Models.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EMS_MVC_Project.Models.Data
{
    public class CourseRepository
    {
        
        EMSDBDataContext context = new EMSDBDataContext();

        public List<CourseViewModel> GetCourses
        {
            
            get
            {
               
                var _CourseViewModel = (from C in context.TCourses
                            join cat in context.TCategories on C.CourseCategoryId equals cat.CategoryId
                            select new CourseViewModel()
                            {
                                CourseId = C.CourseId,
                                CourseName = C.CourseName,
                                CourseFee = C.CourseFee,
                                CourseDuration = C.CourseDuration,
                                CategoryName = cat.CategoryName
                            }).ToList();

                if(_CourseViewModel != null)
                {
                    if (_CourseViewModel.Count >= 0)
                        return _CourseViewModel;
                }

                return null;
            }
        }

        public void Save(CourseModel course)
        {
            TCourse tCourse = new TCourse()
            {
                CourseName = course.CourseName,
                CourseDuration = course.CourseDuration,
                CourseFee = course.CourseFee,
                CourseCategoryId = course.CourseCategoryId
            };
            context.TCourses.InsertOnSubmit(tCourse);
            context.SubmitChanges();
        }
    }
}