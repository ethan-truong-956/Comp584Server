using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using WorldModel;

namespace Comp584Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeedController(Comp584DbContext context) : ControllerBase
    {
        [HttpPost("Countries")]
        public async Task<ActionResult> PostCountries()
        {
            await context.SaveChangesAsync();

            return Ok();
        }

        [HttpPost("Cities")]
        public async Task<ActionResult> PostCities()
        {
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}
