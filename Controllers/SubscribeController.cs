using CarOnRentApi.Infrastructure;
using CarOnRentApi.Model.InputModel;
using CarOnRentApi.Model.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarOnRentApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeController : ControllerBase
    {
        private IConfiguration _configuration;
        private ISubscribe _sub;

        public SubscribeController(IConfiguration configuration, ISubscribe sub)
        {
            _configuration = configuration;
            _sub = sub;
        }

        [AllowAnonymous]
        [HttpPost("subscribe")]
        public async Task<IActionResult> GetSubscribe(SubscribeIM subscribeIM)
        {
            try
            {
                var data = await _sub.GetSubscribeStatus(subscribeIM);
                if (data == null || data.Count == 0)
                {
                    return BadRequest();
                }
                else
                {
                    return Ok(data);
                }
            }
            catch { throw; }
        }

    }
}
