﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
	public class BlogController : Controller
	{
		BlogManager bm = new BlogManager(new EfBlogRepository());
		public IActionResult Index()
		{
			var values = bm.GetAllBlogsByCategory();
			return View(values);
		}
		public IActionResult BlogDetails(int id)
		{
			return View();
		}
	}
}
