using apAPI.Models;
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
    public class ConfigController : ControllerBase
    {

        [HttpGet]
        public ContentResult Get()
        {
            var config = new Config();

            return config.GetConfig();
            ;
        }
    }
}