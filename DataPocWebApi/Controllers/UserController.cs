using BusinessManagerPOC.BusinessManager;
using BusinessManagerPOC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DataPocWebApi.Controllers
{
    [ApiController]
    [Produces("application/json")]
    public class UserController : ControllerBase
    {
        private readonly IUserManager _userManager;

        public UserController(IUserManager userManager)
        {
            _userManager = userManager;
        }

        [HttpPost]
        [Route("addUser")]
        public async Task<IActionResult> CreateUser(RequestUser user)
        {
            try
            {
                var insertUser = await _userManager.CreateUserAsync(user);
                return Ok(insertUser);
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet]
        [Route("users")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var users = await _userManager.GetAllUsersAsync();
                return Ok(users);
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
