using Common.Model.DBEntity;
using Common.Tool;
using Microsoft.AspNetCore.Mvc;
using Service.Interface;

namespace WebAPI.Controllers
{
    public class TESTController : BaseController
    {
        private readonly ILogger<TESTController> _logger;
        private readonly ITESTService _ITESTService;

        public TESTController(ILogger<TESTController> logger, ITESTService ITESTService)
        {
            _logger = logger;
            _ITESTService = ITESTService;
        }

        [HttpPost]
        public IActionResult Test()
        {
            var result = _ITESTService.TEST();

            var re = result.ListData.SetTo<IEnumerable<Products>>();

            return Ok(re);
        }
    }
}
