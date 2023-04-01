using Microsoft.AspNetCore.Mvc;
using System.Data;
using To_Do_list.Data;
using To_Do_list.Models;

namespace To_Do_list.Controllers
{
    public class PrioritiesController : Controller
    {
        private readonly ListFormContext _formContext;  

        public PrioritiesController(ListFormContext formContext)
        {
            _formContext = formContext;
        }
        public IActionResult Index()
        {
            List<Priority> priorities = _formContext.Priorities.ToList(); 

            return View(priorities);
        }
        public IActionResult Create()
        {
           return View();

        }
        [HttpPost]
        public IActionResult Create(Priority priority)
        {
            if (ModelState.IsValid)
            {
                _formContext.Add(priority);
                _formContext.SaveChanges();
                RedirectToAction("Index");  
            }
            return View(priority);
        }
        public IActionResult Edit(int? id)
        {
            var prioritet = _formContext.Priorities.Find(id);
            if (prioritet == null)
            {
                return NotFound();
            }
            return View(prioritet);

        }
        [HttpPost]
        public IActionResult Edit(Priority priority)
        {
            if (ModelState.IsValid)
            {
                _formContext.Add(priority);
                _formContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(priority);
        }
        public IActionResult Delete(int id)
        {
            var prioritet = _formContext.Priorities.FirstOrDefault(s => s.Id == id);
             if (prioritet == null)
            {
                return NotFound();
            }
            return View(prioritet);
        }
        [HttpPost]
        public IActionResult Delete(Priority priority)
        {
            if (priority != null)
            {
                _formContext.Remove(priority);
                _formContext.SaveChanges();
            }
            return RedirectToAction("Index");
        }



    }
}
