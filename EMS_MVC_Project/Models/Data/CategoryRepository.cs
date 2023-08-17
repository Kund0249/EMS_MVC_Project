using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EMS_MVC_Project.Models.DataAccess;

namespace EMS_MVC_Project.Models.Data
{
    public class CategoryRepository
    {
        EMSDBDataContext context = new EMSDBDataContext();
        public List<CategoryModel> Categories
        {
            get
            {
                List<CategoryModel> _categoryModels = new List<CategoryModel>();
                //Fetch data from Server and add in list

                List<TCategory> categories = context.TCategories.ToList();
               
                if (categories != null)
                {
                    if (categories.Count > 0)
                    {
                        foreach (TCategory item in categories)
                        {
                            _categoryModels.Add(CategoryModel.Convert(item));
                        }
                    }
                    return _categoryModels;
                }
                return null;

            }
        }

        public void Save(CategoryModel categoryModel)
        {
            TCategory category = new TCategory()
            {
                CategoryName = categoryModel.CategoryName
            };
            context.TCategories.InsertOnSubmit(category);
            context.SubmitChanges();
        }

        public CategoryModel GetCategory(int id)
        {
            TCategory category = context.TCategories.
                FirstOrDefault(x => x.CategoryId == id);

            if (category != null)
            {
                return CategoryModel.Convert(category);
            }

            return null;
        }

        public void Update(CategoryModel categoryModel)
        {
            TCategory category = context.TCategories.
                 FirstOrDefault(x => x.CategoryId == categoryModel.CategoryId);
            if (category != null)
            {
                category.CategoryName = categoryModel.CategoryName;
                context.SubmitChanges();
            }
        }

        public void Remove(int id)
        {
            TCategory category = context.TCategories.
                FirstOrDefault(x => x.CategoryId == id);

            if (category != null)
            {
                context.TCategories.DeleteOnSubmit(category);
                context.SubmitChanges();
            }

        }
    }
}