using Microsoft.AspNetCore.Mvc;

namespace TMS.Scheme.Controllers
{
    [Route("Scheme")]
    public class SchemeController : Controller
    {
        [HttpGet]
        [Route("Index")]
        public string Index()
        {
            return "SchemeControllers";
        }
    }
}
