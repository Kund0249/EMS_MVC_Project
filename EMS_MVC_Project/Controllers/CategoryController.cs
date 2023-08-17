using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EMS_MVC_Project.Models;
using EMS_MVC_Project.Models.Data;

namespace EMS_MVC_Project.Controllers
{
    //Filter on Controller Level
    // [HandleError(View = "GenericErrorPage")]
    [Authorize]
    public class CategoryController : Controller
    {
        private readonly CategoryRepository Db = new CategoryRepository();

        //before logic

        //Filter on Action Level
        // [HandleError(View = "GenericErrorPage")]
        public ActionResult Index()
        {
            List<CategoryModel> categoryList = Db.Categories;
            //Error
            //throw new Exception("There is some error while reteriving data from DB");
            return View(categoryList);
        }
        //before logic


        [HttpGet]
        public ActionResult Create()
        {
            // throw new Exception("There is some error while reteriving data from DB");
            return View();
        }


        [HttpPost]
        public ActionResult Create(CategoryModel categoryModel)
        {
            //CategoryModel categoryModel = new CategoryModel()
            //{
            //    CategoryName = CategoryName
            //};
            Db.Save(categoryModel);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            CategoryModel model = Db.GetCategory(id);
            if (model != null)
            {
                return View(model);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Edit(CategoryModel model)
        {
            Db.Update(model);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            Db.Remove(id);
            return RedirectToAction("Index");
        }
    }
}