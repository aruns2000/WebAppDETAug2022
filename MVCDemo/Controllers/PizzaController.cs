using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;
using MVCDemo.Services;

namespace MVCDemo.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            List<Pizza> pizzas = PizzaService.GetAll();

            return View(pizzas);
        }
        public IActionResult Details(int id)
        {
            Pizza p = PizzaService.Get(id);
            return View(p);
        }
        public IActionResult Lists()
        {
            List<Pizza> pizzas = PizzaService.GetAll();

            return View(pizzas);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Pizza p)
        {
            PizzaService.Add(p);

            return RedirectToAction("Lists");
        }
        public IActionResult Delete(int id)
        {
            Pizza p = PizzaService.Get(id);
            if (p != null)
                return View(p);
            else
                return RedirectToAction("Lists");

        }
        [HttpPost]
        public IActionResult Delete(Pizza p)
        {
            PizzaService.Delete(p.Id);
            return RedirectToAction("Lists");
           

        }
        public IActionResult Update(int id)
        {
           
            return View();
        }
        [HttpPost]
        public IActionResult Update(Pizza p)
        {
            PizzaService.Update(p.Id);
            return RedirectToAction("Lists");

        }





    }
}
