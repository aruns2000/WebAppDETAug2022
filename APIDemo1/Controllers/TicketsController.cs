using APIDemo1.Models;
using APIDemo1.Services.NewFolder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIDemo1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        [HttpGet]
        [Route("all")]
        public List<Ticket>Get()
        {
            return TicketService.GetAll();
        
        }
        [HttpGet]
        [Route("tckets/{id}")]
        public Ticket Get(int id)
        {
            Ticket t = TicketService.Get(id);
            return t;
        }
    }
}
