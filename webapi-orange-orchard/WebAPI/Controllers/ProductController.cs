using Common.Model.DBEntity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Service.Interface;
using WebAPI.Controllers.Base;

namespace WebAPI.Controllers
{
    public class ProductController : BaseController
    {
        private readonly ILogger<ProductController> _logger;
        private readonly ITESTService _ITESTService;
        private readonly IService _IService;

        public ProductController(ILogger<ProductController> logger, ITESTService ITESTService, IService IService)
        {
            _logger = logger;
            _ITESTService = ITESTService;
            _IService = IService;
        }

        [HttpGet]
        public IActionResult Select([FromQuery] Dictionary<string, string> condition)
        {
            var _condition = new Products();
            _condition.FillData(condition);

            var result = _IService.SELECT(_condition);
            if (result.IsFail)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, result.Message);
            }

            return Ok(result.ListData);
        }
        [HttpPost]
        public IActionResult Insert([FromBody] Dictionary<string, string> data)
        {
            var _data = new Products();
            _data.FillData(data);

            var result = _IService.INSERT(_data);
            if (result.IsFail)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, result.Message);
            }

            return Ok();
        }
        [HttpPut]
        public IActionResult Update([FromQuery] Dictionary<string, string> condition, [FromBody] Dictionary<string, string> data)
        {
            var _condition = new Products();
            _condition.FillData(condition);

            var _data = new Products();
            _data.FillData(data);
            _data.SetFullDirty();

            var result = _IService.UPDATE(_data, _condition);
            if (result.IsFail)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, result.Message);
            }

            return Ok();
        }
        [HttpPatch]
        public IActionResult Modify([FromQuery] Dictionary<string, string> condition, [FromBody] Dictionary<string, string> data)
        {
            var _condition = new Products();
            _condition.FillData(condition);

            var _data = new Products();
            _data.FillData(data);

            var result = _IService.UPDATE(_data, _condition);
            if (result.IsFail)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, result.Message);
            }

            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete([FromQuery] Dictionary<string, string> condition)
        {
            var _condition = new Products();
            _condition.FillData(condition);

            var result = _IService.DELETE(_condition);
            if (result.IsFail)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, result.Message);
            }

            return Ok();
        }
    }
}
