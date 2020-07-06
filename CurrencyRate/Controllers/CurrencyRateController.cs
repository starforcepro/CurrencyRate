using Microsoft.AspNetCore.Mvc;

namespace CurrencyRate.Controllers
{
    [ApiController]
    [Route("api/CurrencyRate")]
    public class CurrencyRateController : Controller
    {
        [HttpGet("index")]
        public ActionResult<int[]> Index()
        {
            var response = new[] {1, 2, 3, 4, 5, 6, 6, 5, 4, 3, 3, 4, 4};

            return response;
        }
    }
}