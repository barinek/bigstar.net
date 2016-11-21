using Microsoft.AspNetCore.Mvc;

namespace Bigstar.Accounts
{
    public class AccountsController : Controller
    {
        [HttpGet]
        [Route("api/accounts")]
        public IActionResult Index()
        {
            Response.ContentType = "application/json";

            return Ok(Json(new AccountsDataGateway().getAccounts()));
        }
    }
}