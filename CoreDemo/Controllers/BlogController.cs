using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
	public class BlogController : Controller
	{
		BlogReadAll bm = new BlogReadAll(new EfBlogRepository());
		public IActionResult Index()
		{
			var values = bm.GetAllBlogsByCategory();
			return View(values);
		}
		public IActionResult BlogReadAll(int id)
		{
			var values = bm.GetBlogByID(id);
			return View(values);
		}
	}
}
