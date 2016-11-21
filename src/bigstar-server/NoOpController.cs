using Microsoft.AspNetCore.Mvc;

namespace Bigstar.Server
{
    public class NoOpController : Controller
    {
        [HttpGet]
        public IActionResult NoOp()
        {
            Response.ContentType = "application/json";

            return Json(new { method = "NoOp" });
        }
    }
}