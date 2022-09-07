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

                };
        }

        public static List<Tickets> GetAll() => Ticket;

        public static Tickets? Get(int id) => Ticket.FirstOrDefault(p => p.Id == id);

        public static void Add(Tickets pizza)
        {
            pizza.Id = nextId++;
            Ticket.Add(pizza);
        }

        public static void Delete(int id)
        {
            var pizza = Get(id);
            if (pizza is null)
                return;

            Ticket.Remove(pizza);
        }

        public static void Update(Tickets pizza)
        {
            var index = Ticket.FindIndex(p => p.Id == pizza.Id);
            if (index == -1)
                return;

            Ticket[index] = pizza;
        }
    }
}
