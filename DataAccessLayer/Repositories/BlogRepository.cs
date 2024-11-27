using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class BlogRepository : IBlogDal
    {
        public void AddBlog(Blog blog)
        {
            using var c = new Context();
            c.Add(blog);
            c.SaveChanges();
        }

        public void Delete(Blog t)
        {
            throw new NotImplementedException();
        }

        public void DeleteBlog(Blog blog)
        {
            using var c = new Context();
            c.Remove(blog);
            c.SaveChanges();
        }

        public List<Blog> GetAll()
        {
            throw new NotImplementedException();
        }

        public Blog GetByID(int id)
        {
            using var c = new Context();
            return c.Blogs.Find(id);
        }

        public void Insert(Blog t)
        {
            throw new NotImplementedException();
        }

        public List<Blog> ListAllBlogs()
        {
            using var c = new Context();
            return c.Blogs.ToList();
        }

        public void Update(Blog t)
        {
            throw new NotImplementedException();
        }

        public void UpdateBlog(Blog blog)
        {
            using var c = new Context();
            c.Update(blog);
            c.SaveChanges();
        }
    }
}
