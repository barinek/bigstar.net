using Microsoft.AspNetCore.Mvc;

namespace Bigstar.Metrics
{
    public class MetricsController : Controller
    {
        [HttpGet]
        [Route("api/metrics")]
        public IActionResult Index()
        {
            Response.ContentType = "application/json";

            return Ok(Json(new MetricsDataGateway().getMetrics()));
        }
    }
}