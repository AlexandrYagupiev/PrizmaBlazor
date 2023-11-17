using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TMS.Operations.Controllers
{
    [Route("Operations")]
    public class OperationsController : Controller
    {
        [HttpGet]
        [Route("Index/{id:int?}")]
        public string Index(int? id)
        {
            return "OperationsController ";
        }

        [Authorize(Roles = "Scheme")]
        [HttpGet]
        [Route("Index2/{id:int?}")]
        public string Index2(int? id)
        {
            return "OperationsController Roles = Scheme ";
        }

        [Authorize(Roles = "Scheme2")]
        [HttpGet]
        [Route("Index3/{id:int?}")]
        public string Index3(int? id)
        {
            return "OperationsController Roles = Scheme2  ";
        }
    }
}
