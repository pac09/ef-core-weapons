using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using WebApi504.Data.Models;

namespace WebApi504.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly FinanceContext _context;

        public UserController(FinanceContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(string username, string password, int personId)
        {
            var newUser = new User()
            {
                UserName = username,
                Password = password,
                PersonId = personId
            };

            _context.Add(newUser);
            await _context.SaveChangesAsync();
            
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteUser(int userId) 
        {
            var user = _context.Users.Find(userId);
            _context.Users.Remove(user);

            await _context.SaveChangesAsync();

            return Ok();
        }

    }
}
