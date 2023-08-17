using EMS_MVC_Project.Models;
using EMS_MVC_Project.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace EMS_MVC_Project.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        private readonly CourseRepository Db = new CourseRepository();
        private readonly CategoryRepository CatDb = new CategoryRepository();
        public async Task<ActionResult> Index()
        {

            using (var client = new HttpClient())
            {
                //Passing service base url
                client.BaseAddress = new Uri("http://localhost:61218/");
                client.DefaultRequestHeaders.Clear();

                HttpResponseMessage Res = await client.GetAsync("api/Stuent");
                
                if (Res.IsSuccessStatusCode)
                {
                    var data = Res.Content.ReadAsStringAsync().Result;
                }

                CourseViewModelWrapper viewModelWrapper = new CourseViewModelWrapper()
                {
                    Categories = CatDb.Categories,
                    courses = Db.GetCourses
                };
                //List<CourseViewModel> data = Db.GetCourses;
                // return View(data);
                //throw new Exception("There is some error while reteriving data from DB");
                return View(viewModelWrapper);
            }
        }
        public ActionResult Create()
        {

            return View(new CourseModel());
        }

        [HttpPost]
        public ActionResult Create(CourseModel model)
        {

            if (ModelState.IsValid)
            {
                Db.Save(model);
                return RedirectToAction("Index");
            }
            return View(new CourseModel());

        }

        public ActionResult Test()
        {
            return RedirectToAction("Index");
        }

    }
}