using Microsoft.AspNetCore.Mvc;

namespace WebAPI.GenericCRUD_D8.Controllers
{
    [Route("api/userlist")]
    [ApiController]
    public class StaticDataController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var uerlist= await Task.FromResult(new string[] { "Virat", "Messi", "Ozil", "Lara", "MS Dhoni" });
            return Ok(uerlist);
        }
    }
}
