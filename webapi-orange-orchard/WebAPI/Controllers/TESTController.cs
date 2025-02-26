using Microsoft.AspNetCore.Mvc;
using Model.DataBase;
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
            var list = new List<Letter_Info>();
            foreach (var i in result.ListData)
            {
                //var a = new Letter_Info();
                //a.FillData(i);
            }
            var b = result.ListData.Select((dynamic x) => new Letter_Info().FillData(x));
            var a = result.ListData.Select((dynamic x)=>new Letter_Info().FillData(x)).Cast<Letter_Info>();

            return Ok(result.ListData);
        }
    }
}
