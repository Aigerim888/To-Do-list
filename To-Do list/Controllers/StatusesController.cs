using Microsoft.AspNetCore.Mvc;
using To_Do_list.Data;
using To_Do_list.Models;

namespace To_Do_list.Controllers
{
    public class StatusesController : Controller
    {
        private readonly ListFormContext _formContext;
        public StatusesController(ListFormContext formContext)
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
        public IActionResult Create(Status status)
        {
            if (ModelState.IsValid)
            {
                _formContext.Add(status);
                _formContext.SaveChanges();
                RedirectToAction("Index");
            }
            return View(status);
        }

        [HttpPost]
        public IActionResult Edit(Status status)
        {
            if (status.Name == null)
            {
                return NotFound();
            }
            return View(status);

        }
    
    }
}
