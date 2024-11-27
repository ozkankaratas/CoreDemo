using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    // ICategoryDal interface'inden miras aldık ve ardından da implemente ettik
    public class CategoryRepository : ICategoryDal
    {
        Context c = new Context(); // ekleme, silme ve güncelleme işlemleri context'den değer türettik.
        public void AddCategory(Category category)
        {
            c.Add(category); // entity framework core'a ait özellikler
            c.SaveChanges();
        }

        public void Delete(Category t)
        {
            throw new NotImplementedException();
        }

        public void DeleteCategory(Category category)
        {
            c.Remove(category);
            c.SaveChanges();
        }

        public List<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public Category GetByID(int id)
        {
            return c.Categories.Find(id);
        }

        public void Insert(Category t)
        {
            throw new NotImplementedException();
        }

        public List<Category> ListAllCategories()
        {
            return c.Categories.ToList();
        }

        public void Update(Category t)
        {
            throw new NotImplementedException();
        }

        public void UpdateCategory(Category category)
        {
            c.Update(category);
            c.SaveChanges();
        }
    }
}
