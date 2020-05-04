using Microsoft.AspNetCore.Mvc;
using UserService.Extensions;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using UserService.Manager;
using BUYERDB.Entity;
using System.Threading.Tasks;

namespace UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserManager _iUserManager;
        private readonly ILogger<UserController> _logger;

        public UserController(IUserManager iUserManager, ILogger<UserController> logger)
        {
            _iUserManager = iUserManager;
            _logger = logger;
        }
        /// <summary>
        /// Register buyer
        /// </summary>
        /// <param name="buyer"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Buyer(Buyer buyer)
        {
            try
            {

                _logger.LogInformation("Register");

                return Ok(await _iUserManager.BuyerRegister(buyer));
            }
            catch (MyAppException ex)
            {
                throw ex;
            }

        }
        /// <summary>
        /// Login Buyer
        /// </summary>
        /// <param name="uname"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Login/{uname}/{pwd}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> BuyerLogin(string uname, string pwd)
        {
            try
            {
                _logger.LogInformation("User Login");

                Buyer buyer = await _iUserManager.ValidateBuyer(uname, pwd);

                return Ok(buyer);
            }
            catch (MyAppException ex)
            {
                throw ex;
            }
        }
    }
}