using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mrbatri.Models;

namespace mrbatri.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserContext _context;

        public UsersController(UserContext context)
        {
            _context = context;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
  
            try {
                
                IEnumerable<User> users= await _context.Users.ToListAsync();
                
                if (users.Count() == 0)
                {
                    return Problem("Not Found!", "", 404);
                }

                return Ok(users);
            } catch (Exception e) {

                return Problem("DB Connection Error!", "", 503);
            }                
        }
    }
    
}
