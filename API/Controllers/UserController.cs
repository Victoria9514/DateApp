using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController
    {
        public DataContext _context;
        public UsersController(DataContext context)
        {
            this._context = context;

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }

        [HttpGet("{id}")]
        public ActionResult<AppUser> GetUser(int id)
        {

            return _context.Users.Find(id);
        }
    }
}