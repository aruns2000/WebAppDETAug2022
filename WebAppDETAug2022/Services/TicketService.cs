using System.Xml.Linq;
using WebAppDETAug2022.Models;
using WebAppDETAug2022.Pages;

namespace WebAppDETAug2022.Services
{
    public static class TicketService
    {
        static List<Tickets> Ticket { get; }
        static int nextId = 3;
        static TicketService()
        {
            Ticket = new List<Tickets>
                {
                      new Tickets {Id=1, Category="Platinum Plus",Price=5000,MaxLimit=200000 },
                      new Tickets {Id=2, Category = "Platinum ", Price = 4000, MaxLimit = 300000 },
                      new Tickets {Id=3, Category="Gold",Price=3000,MaxLimit=500000 },
                      new Tickets {Id=4, Category="Platinum Plus",Price=2000,MaxLimit=500000 },
                      new Tickets {Id=5, Category="Platinum Plus",Price=800,MaxLimit=100000 }
                };
        }

        public static List<Tickets> GetAll() => Ticket;

        public static Tickets? Get(int id) => Ticket.FirstOrDefault(p => p.Id == id);

        public static void Add(Tickets ticket)
        {
            ticket.Id = nextId++;
            Ticket.Add(ticket);
        }

        public static void Delete(int id)
        {
            var ticket = Get(id);
            if (ticket is null)
                return;

            Ticket.Remove(ticket);
        }

        public static void Update(Tickets ticket)
        {
            var index = Ticket.FindIndex(p => p.Id == ticket.Id);
            if (index == -1)
                return;

            Ticket[index] = ticket;
        }
    }
}
