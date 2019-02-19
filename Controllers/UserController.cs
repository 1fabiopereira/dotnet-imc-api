using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using IMC.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace IMC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class User : ControllerBase
    {
        private readonly IMCContext _context;
        
        public User(IMCContext context) 
        {
            _context = context;

            if (_context.Users.Count() == 0)
            {
                _context.Users.Add(new Models.User {
                    Name = "Fábio Pereira",
                    Height = 1.71,
                    Weight = 98.4,
                    Imc = Models.User.CalculateIMC(1.71, 98.4),
                    Status = Models.User.CalculateStatus(Models.User.CalculateIMC(1.71, 98.4))
                });

                _context.Users.Add(new Models.User {
                    Name = "Larissa Luanny",
                    Height = 1.62,
                    Weight = 84,
                    Imc = Models.User.CalculateIMC(1.62, 84),
                    Status = Models.User.CalculateStatus(Models.User.CalculateIMC(1.62, 84))
                });

                _context.SaveChanges();
            }
        }

        // GET api/user
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Models.User>>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }

        // POST api/user
        [HttpPost]
        public async Task<ActionResult<IEnumerable<Models.User>>> AddUser([FromBody] Models.User Incoming)
        {
            _context.Users.Add(new Models.User {
                Name = Incoming.Name,
                Height = Incoming.Height,
                Weight = Incoming.Weight,
                Imc = Models.User.CalculateIMC(Incoming.Height, Incoming.Weight),
                Status = Models.User.CalculateStatus(Models.User.CalculateIMC(Incoming.Height, Incoming.Weight))
            });
            
            _context.SaveChanges();
            
            return await _context.Users.ToListAsync();
        }
    }
}
