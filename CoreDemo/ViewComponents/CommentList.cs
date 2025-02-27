using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>
            {
                new UserComment { Id = 1, Username = "Ozkan" },
                new UserComment { Id = 2, Username = "Samet" },
                new UserComment { Id = 3, Username = "Can" }
            };
            return View(commentvalues);
        }
    }
}
