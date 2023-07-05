using Microsoft.AspNetCore.Mvc;

namespace AgendaAPI.Controllers
{
    [Controller]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class UserController : ControllerBase
    {
        private readonly IUserHandler _userHandler;
        public UserController(IUserHandler userHandler)
        {

        }
      [HttpGet("{id}")] 
      public async Task<IActionResult> Get(int id)
        {
           var entity await _userHandler.GetById(id);
            if(entity == null) return NotFound();

            return Ok(entity);
            
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] UserPasswordDto user)
        {
            try
            {
                
            }
        }
    }
}
