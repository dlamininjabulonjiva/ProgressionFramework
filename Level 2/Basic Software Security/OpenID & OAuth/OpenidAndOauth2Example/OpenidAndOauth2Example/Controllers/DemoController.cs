using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OpenidAndOauth2Example.Clients;

namespace OpenidAndOauth2Example.Controllers
{
    [Route("[controller]")]
    [Authorize("authenticatedUser")]
    public class DemoController : ControllerBase
    {
        private readonly IDuendeClient _duendeClient;

        public DemoController(IDuendeClient duendeClient)
        {
            _duendeClient = duendeClient;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response = await _duendeClient.GetTest();
            var responseContent = response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                return BadRequest(responseContent);
            }

            return Ok(responseContent);
        }
    }
}