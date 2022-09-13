using APIDemo1.Models;
using APIDemo1.Controllers;

namespace APIDemo1.Services.NewFolder
{
    public class TicketService
    {
         static List<Ticket> Tickets { get; }

        static TicketService()
        {
            Tickets = new List<Ticket>
                {
                      new Ticket {Id=1, BookedFor="Platinum Plus",Price=5000,Qty=200000 },
                      new Ticket {Id=2, BookedFor = "Platinum ", Price = 4000, Qty = 300000 },
                      new Ticket {Id=3, BookedFor="Gold",Price=3000,Qty=500000 },
                      new Ticket {Id=4, BookedFor="Platinum Plus",Price=2000,Qty=500000 },
                      new Ticket {Id=5, BookedFor="Platinum Plus",Price=800,Qty=100000 }
                };
        }

        public static List<Ticket> GetAll() => Tickets;
        public static Ticket Get(int id)
        {
            Ticket ticket = Tickets.FirstOrDefault(x => x.Id == id);
            return ticket;
        }
    }
}
