using ChillyBenchMarkNet.Model.ApiRequest;
using ChillyBenchMarkNet.Model.ApiResponse;
using Microsoft.AspNetCore.Mvc;


namespace ChillyBenchMarkNet.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class BenchMarkController : ControllerBase
    {
        private readonly ILogger<BenchMarkController> _logger;

        public BenchMarkController(ILogger<BenchMarkController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public ApiBaseResponse RegisterAccount(RegisterAccountReq registerAccountReq)
        {
            return new ApiBaseResponse { Success = true };
        }

        public String Test()
        {
            return "";
        }
    }
}
