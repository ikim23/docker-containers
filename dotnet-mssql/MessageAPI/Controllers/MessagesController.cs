using System.Linq;
using MessageAPI.Data;
using MessageAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MessageAPI.Controllers
{
    [Route("api/[controller]")]
    public class MessagesController : Controller
    {
        private readonly MessageContext _context;

        public MessagesController(MessageContext context)
        {
            _context = context;
        }

        // GET api/messages
        [HttpGet]
        public IActionResult Get()
        {
            var result = _context.Messages.ToArray();
            return new OkObjectResult(result);
        }

        // GET api/messages/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var message = _context.Messages.Find(id);
            return new OkObjectResult(message);
        }

        // POST api/messages
        [HttpPost]
        public IActionResult Post([FromBody] Message message)
        {
            _context.Messages.Add(message);
            _context.SaveChanges();
            return new CreatedResult("api/messages", message);
        }

        // PUT api/messages/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Message message)
        {
            _context.Messages.Update(message);
            _context.SaveChanges();
            return new OkObjectResult(message);
        }

        // DELETE api/messages/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var message = _context.Messages.Find(id);
            _context.Messages.Remove(message);
            _context.SaveChanges();
            return new OkResult();
        }
    }
}
