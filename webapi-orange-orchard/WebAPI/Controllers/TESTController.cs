using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Interface;
using Tool.DataBase;

namespace WebAPI.Controllers
{
    public class TESTController : BaseController
    {
        private readonly ILogger<TESTController> _logger;
        private readonly ITESTService aaa;

        public TESTController(ILogger<TESTController> logger, ITESTService aaaa)
        {
            _logger = logger;
            aaa = aaaa;
        }

        [HttpPost]
        public IActionResult Test()
        {
            aaa.TEST();

            return Ok();
        }
    }
}
