using Common.Model.DBEntity;
using Common.Tool;
using Microsoft.AspNetCore.Mvc;
using Service.Interface;
using WebAPI.Controllers.Base;

namespace WebAPI.Controllers
{
    public class TESTController : BaseController
    {
        private readonly ILogger<TESTController> _logger;
        private readonly ITESTService _ITESTService;
        private readonly IService _IService;

        public TESTController(ILogger<TESTController> logger, ITESTService ITESTService, IService IService)
        {
            _logger = logger;
            _ITESTService = ITESTService;
            _IService = IService;
        }

        [HttpPost]
        public IActionResult Test([FromBody] List<Products> productsList)
        {
            foreach (var products in productsList)
            {
                var result = _IService.INSERT(products);
                if (result.IsFail)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, result.Message);
                }

            }

            return Ok();
        }

        [HttpGet]
        public IActionResult TestLog()
        {
            var result = _IService.SELECT(new Products());
            if (result.IsFail)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, result.Message);
            }

            var a = result.ListData?.Cast<Products>();

            return Ok(a);
        }
    }
}
