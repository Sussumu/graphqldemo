using graphqldemo.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace graphqldemo.Controllers
{
    [Produces("application/json")]
    [Route("api/user")]
    public class DefaultController : Controller
    {
        private readonly IUserService _userService;

        public DefaultController(IUserService userService)
        {
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
        }

        [Route("")]
        public ActionResult GetUsers()
        {
            return Ok(_userService.Get());
        }
    }
}