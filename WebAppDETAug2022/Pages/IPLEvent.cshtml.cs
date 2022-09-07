using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppDETAug2022.Models;
using WebAppDETAug2022.Services;

namespace WebAppDETAug2022.Pages
{
    public class IPLEventModel : PageModel
    {
        public List<Ticket> Tickets { get; set; }
        public Tickets NewTicket { get; set; } = new();
        public object Category { get; private set; }

        public void OnGet()
        {
            Tickets = new List<Ticket>
            {
                new Ticket { Category="Platinum Plus",Price=5000,MaxLimit=200000 },
               new Ticket { Category = "Platinum ", Price = 4000, MaxLimit = 300000 },
               new Ticket { Category="Gold",Price=3000,MaxLimit=500000 },
               new Ticket { Category="Platinum Plus",Price=2000,MaxLimit=500000 },
               new Ticket { Category="Platinum Plus",Price=800,MaxLimit=100000 },

            };
           

        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            TicketService.Add(NewTicket);
            return RedirectToAction("Get");
        }

        public IActionResult OnPostDelete(int id)
        {
            TicketService.Delete(id);
            return RedirectToAction("Get");
        }
    }
}
