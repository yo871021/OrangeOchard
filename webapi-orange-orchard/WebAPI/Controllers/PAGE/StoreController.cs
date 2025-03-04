using Common.Model.DBEntity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Interface;
using WebAPI.Controllers.Base;

namespace WebAPI.Controllers.PAGE
{
    public class StoreController : BaseController
    {
        private readonly ILogger<StoreController> _logger;
        private readonly IService _IService;

        public StoreController(ILogger<StoreController> logger, IService IService)
        {
            _logger = logger;
            _IService = IService;
        }

        [HttpPost]
        public IActionResult GetProducts()
        {
            var result = _IService.SELECT(new Products());
            if (result.IsFail)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, result.Message);
            }

            return Ok(result.ListData);
        }
    }
}
