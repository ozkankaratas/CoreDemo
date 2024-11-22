using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        EfCategoryRepository efCategoryRepository;
        // Contructor metot oluşturacağız !
        public CategoryManager()
        {
            efCategoryRepository = new EfCategoryRepository();
        }

        public void AddCategory(Category category)
        {
            efCategoryRepository.Insert(category);
        }

        public void DeleteCategory(Category category)
        {
            efCategoryRepository.Delete(category);
        }

        public List<Category> GetAllCategories()
        {
            return efCategoryRepository.GetAll();
        }

        public Category GetCategoryById(int id)
        {
            return efCategoryRepository.GetByID(id);
        }

        public void UpdateCategory(Category category)
        {
            efCategoryRepository.Update(category);
        }
    }
}
