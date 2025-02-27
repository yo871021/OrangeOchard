using Microsoft.AspNetCore.Mvc;
using Model.DataBase;
using Service.Interface;
using Tool;

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
            var re = result.ListData.SetTo<IEnumerable<Letter_Info>>();

            return Ok(re);
        }
    }
}
