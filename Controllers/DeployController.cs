using apAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace apAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DeployController : ControllerBase
    {

        [HttpPost]
        public String Post(Activity Activity)
        {
            Deploy d = new Deploy(Activity);

            return d.GetURL();
        }

    }
}