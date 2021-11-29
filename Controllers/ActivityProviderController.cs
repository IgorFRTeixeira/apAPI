using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ActivityProviderController : ControllerBase
    {
        //private static readonly string[] Summaries = new[]
        //{
        //    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        //};

        private readonly ILogger<ActivityProviderController> _logger;

        public ActivityProviderController(ILogger<ActivityProviderController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActivityProvider Get()
        {
            var ap = new ActivityProvider
            {
                ActivityID = "1",
                InveniRAstdID = "75038",
                Json_params = new List<string> { "", "" }
            };

            return ap;
            ;
        }
    }
}
