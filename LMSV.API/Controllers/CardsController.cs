using Microsoft.AspNetCore.Mvc;

namespace LMSV.API.Controllers
{
    [ApiController]
    [Route("api/reporting/cards")]
    public class CardsController : ControllerBase
    {
        [HttpGet]
        public JsonResult GetCards()
        {
            return new JsonResult(
                new List<object>
                {
                    new { id = 1, Name = "New York City" },
                    new { id = 2, Name = "Antwerp" }
                });
        }
    }
}
