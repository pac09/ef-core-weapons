using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi504.Data.Models;
using System.Linq;

namespace WebApi504.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly FinanceContext _context;

        public PersonController(FinanceContext context) 
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get() 
        {
            var people = _context.People.ToList();
            return Ok(people);
        }
    }
}
