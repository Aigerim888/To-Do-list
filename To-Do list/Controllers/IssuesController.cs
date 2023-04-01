using Microsoft.AspNetCore.Mvc;
using To_Do_list.Data;
using To_Do_list.Models;

namespace To_Do_list.Controllers
{
    public class IssuesController : Controller
    {
        private readonly ListFormContext _formContext;
        public IssuesController(ListFormContext formContext)
        {
            _formContext = formContext;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(Issue issue)
        {
            _formContext.Add(issue);
            _formContext.SaveChanges();
            RedirectToAction("Index");

            return View(issue);
        }
    }
}

