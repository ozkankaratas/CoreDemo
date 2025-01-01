using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class BlogManager : IBlogService
	{
		IBlogDal _blogDal;

		public BlogManager(IBlogDal blogDal)
		{
			_blogDal = blogDal;
		}

		public void AddBlog(Blog category)
		{
			throw new NotImplementedException();
		}

		public void DeleteBlog(Blog category)
		{
			throw new NotImplementedException();
		}

		public List<Blog> GetAllBlogs()
		{
			return _blogDal.GetAll();
		}

        public List<Blog> GetAllBlogsByCategory()
        {
			return _blogDal.GetWithCategory();
        }

        public Blog GetBlogById(int id)
		{
			throw new NotImplementedException();
		}

		public void UpdateBlog(Blog category)
		{
			throw new NotImplementedException();
		}
	}
}
