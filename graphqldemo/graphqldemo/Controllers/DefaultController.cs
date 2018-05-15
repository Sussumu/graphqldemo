using graphqldemo.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace graphqldemo.Controllers
{
    [Route("api/user")]
    public class DefaultController : Controller
    {
        private readonly IUserService _userService;

        public DefaultController(IUserService userService)
        {
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
        }

        [Route("")]
        public async Task<ActionResult> Get(string query)
        {
            return Ok(await _userService.Get(query));
        }
    }
}