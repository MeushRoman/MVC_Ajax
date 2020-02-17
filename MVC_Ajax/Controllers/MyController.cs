using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Ajax.Models;

namespace MVC_Ajax.Controllers
{
    public class MyController : Controller
    {
        private readonly List<Books> db;
        // GET: My

        public MyController()
        {
            db = new List<Books>
            {
                new Books { Name = "Энциклопедия", Author = "Marks" },
                new Books { Name = "Война и мир", Author = "Толстой" },
                new Books { Name = "Словарь", Author = "Oksford" },
                new Books { Name = "Bell", Author = "Kunth" },
                new Books { Name = "Test", Author = "Mars" }              
            };
        }
        public ActionResult Index()
        {
            return View();
        }
       
        public ActionResult BookSearch(string name)
        {

            var allbooks = db.Where(z => z.Author.Contains(name)).ToList();
            if (allbooks.Count <= 0)
            {
                return new HttpUnauthorizedResult();
            }
            return PartialView(allbooks);
        }
    }
}