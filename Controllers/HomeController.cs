using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models;
using Ninject;

namespace WebApplication6.Controllers
{
    public class HomeController : Controller
    {
        IRepository repository;
        public HomeController(IRepository repository)
        {
            this.repository = repository;
        }
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Book book)
        {
            if (ModelState.IsValid)
            {
                
                repository.Add(book);
                ViewBag.count = repository.Count;
                return View("Thanks");
            }
            else
                return RedirectToAction("Index");
        }
    }
}