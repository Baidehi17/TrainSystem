using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrainGR.Models;
using TrainGR.Repository;

namespace TrainGR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private IRepository<Ticket> _ticket;

        public TicketController()
        {
            _ticket = new Repository<Ticket>();
        }
        [HttpGet]
        public IEnumerable<Ticket> GetTrain()
        {
            var result = _ticket.GetAll();
            return result;
        }
        [HttpGet("{id}")]
        public Ticket GetById(int id)
        {
            var result = _ticket.GetByID(id);
            return result;
        }
        [HttpPost]
        public Ticket Insert(Ticket ticket)
        {
            var result = _ticket.ADD(ticket);
            return result;
        }
        [HttpPut("{id}")]
        public Ticket UpdateTrain(Ticket ticket)
        {
            var result = _ticket.UPDATE(ticket);
            return result;

        }
        [HttpDelete("{id}")]
        public Ticket Delete(Ticket ticket)
        {
            var result = _ticket.Deletes(ticket);
            return result;
        }
    }
}

