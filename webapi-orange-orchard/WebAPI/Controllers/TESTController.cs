using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    public class TESTController : BaseController
    {
        private readonly ILogger<TESTController> _logger;

        public TESTController(ILogger<TESTController> logger)
        {
            _logger = logger;
        }
    }
}
