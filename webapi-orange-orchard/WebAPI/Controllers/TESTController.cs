using Common.Model.DBEntity;
using Common.Tool;
using DataBase.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Service.Implement;
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

            return Ok();
        }

        [HttpGet]
        public IActionResult Test()
        {

            return Ok();
        }
    }
}
