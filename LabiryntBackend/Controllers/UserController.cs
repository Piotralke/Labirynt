using LabiryntBackend.Models;
using Microsoft.AspNetCore.Mvc;
using SimpleHashing.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LabiryntBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly GBMazeContext _context;

        public UserController(GBMazeContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _context.Users.ToArray();
        }

        [HttpGet("{id}")]
        public User Get(long id)
        {
            return _context.Users.Find(id);
        }

        [HttpGet("Login/{login}/{password}")]
        public User Login(string login, string password)
        {
            var user = _context.Users.Where(u=>u.login.Equals(login)).FirstOrDefault();
            if (user != null)
            {
                ISimpleHash simpleHash = new SimpleHash();
                bool isPasswordValid = simpleHash.Verify(password, user.password);
                if(isPasswordValid)
                {
                    return user;
                }
                return null;
            }
            return null;
        }

        [HttpPost]
        public void Post([FromBody] User user)
        {
            ISimpleHash simpleHash = new SimpleHash();
            user.password = simpleHash.Compute(user.password);
            _context.Add(user);
            _context.SaveChanges();
        }

        [HttpPut("{id}")]
        public void Put(long id, [FromBody] User user)
        {
        }

    }
}
