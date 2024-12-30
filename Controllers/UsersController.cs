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
            User[] users = new User[] {
                new User{Id=1,FullName="ali ahmadi",Email="ali@ahmadi.com",RegistrationDate=new DateTime(2019,03,05)},
                new User{Id=2,FullName="asghar jafari",Email="asghar@jafari.com",RegistrationDate=new DateTime(2020,04,05)},
                new User{Id=3,FullName="mojtaba pakzadeh",Email="mojtaba@pakzadeh.com",RegistrationDate=new DateTime(2021,08,09)}
            };

            IEnumerable<User> userEnumerable = users; 
            
            return Ok(userEnumerable);
        }
    }
    
}
