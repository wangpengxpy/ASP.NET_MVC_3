using ASP.NET_MVC_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_3.Controllers
{
    public class BlogController : Controller
    {
        public ActionResult Index()
        {
            List<Blog> blogs = new List<Blog>()
            {
                new Blog { Id =1, Name ="xpy0928 1",BlogAddress="http://www.cnblogs.com/CreateMyself/", Description ="出生非贫即贵，你我无能为力"},
                new Blog { Id =2, Name ="xpy0928 2", BlogAddress="http://www.cnblogs.com/CreateMyself/",Description ="后天若不加以努力赶之超之，又能怪谁呢！"},
                new Blog { Id =3, Name ="xpy0928 3",BlogAddress="http://www.cnblogs.com/CreateMyself/", Description ="自己都靠不住不靠谱，又能靠谁呢！" },
                new Blog { Id =4, Name ="xpy0928 4", BlogAddress="http://www.cnblogs.com/CreateMyself/",Description ="靠自己！"}
            };
            return View(blogs);
        }

        [ChildActionOnly]
        public ActionResult DisplayBlog(Blog blog)
        {
            switch (blog.Id)
            {
                case 1:
                    blog.Name = "Child Action Blog 1";
                    blog.Description = "Child Action Description 1";
                    break;
                case 2:
                    blog.Name = "Child Action Blog 2";
                    blog.Description = "Child Action Description 2";
                    break;
                case 3:
                    blog.Name = "Child Action Blog 3";
                    blog.Description = "Child Action Description 3";
                    break;
                case 4:
                    blog.Name = "Child Action Blog 4";
                    blog.Description = "Child Action Description 4";
                    break;
                default:
                    break;
            }

            return PartialView("BlogDetails", blog);
        }
    }
}