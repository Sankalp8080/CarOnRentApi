using CarOnRentApi.Data;
using CarOnRentApi.Infrastructure;
using CarOnRentApi.Model.InputModel;
using CarOnRentApi.Model.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarOnRentApi.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class UserContactController : ControllerBase
    {
        public IConfiguration _config;
        public IUserContact _usercontact;
        public UserContactController(IConfiguration configuration, IUserContact userContact)
        {
            _config = configuration;
            _usercontact = userContact;
        }
        [AllowAnonymous]
        [HttpPost("usercontact")]
        public async Task<IActionResult> ContactUs(UserContactIM userContactIM)
        {
            try
            {
                var data = await _usercontact.GetUserContact(userContactIM);
                if (data == null || data.Count == 0)
                {
                    return BadRequest();
                }
                else
                {
                    return Ok(data[0].status);
                }
            }
            catch { throw; }
        }
    }
}
