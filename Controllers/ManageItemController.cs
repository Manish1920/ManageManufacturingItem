using Microsoft.AspNetCore.Mvc;

namespace ManufacturingAPI.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("ManufacturingItem")]
    public class ManageItemController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
