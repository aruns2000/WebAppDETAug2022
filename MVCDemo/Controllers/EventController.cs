using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class EventController : Controller
    {
        public List<Booking> events { get; set; }
        public IActionResult Index()
        {
            events = new List<Booking>();
            events.Add(new Booking { EventTitle = "ask CEO", EventDate = DateTime.Today, Qty = 10 });
            events.Add(new Booking { EventTitle = "ask CEO", EventDate = DateTime.Today, Qty = 10 });
            return View(events);
        }
    }
}
