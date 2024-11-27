using BusinessLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;        

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void AddCategory(Category category)
        {
            _categoryDal.Insert(category);
        }

        public void DeleteCategory(Category category)
        {
            _categoryDal.Delete(category);
        }

        public List<Category> GetAllCategories()
        {
            return _categoryDal.GetAll();
        }

        public Category GetCategoryById(int id)
        {
            return _categoryDal.GetByID(id);
        }

        public void UpdateCategory(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}
