using LabiryntBackend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LabiryntBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MazesController : ControllerBase
    {
        private readonly GBMazeContext _context;

        public MazesController(GBMazeContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Maze> Get()
        {
            return _context.Mazes.ToArray();
        }

        [HttpGet("{id}")]
        public Maze Get(long id)
        {
            return _context.Mazes.Find(id);
        }
        [HttpGet("getUserMazes/{id}")]
        public IEnumerable<Maze> GetUserMazes(long id)
        {
            var result = _context.Mazes.Where(m => m.id_user == id).ToArray();
            if(result.IsNullOrEmpty())
            {
                return null;
            }
            return result;
        }

        [HttpPost]
        public void Post([FromBody] Maze maze)
        {
            _context.Add(maze);
            _context.SaveChanges();
        }

        [HttpPut("{id}")]
        public void Put(long id, [FromBody] Maze maze)
        {
        }

    }
}
