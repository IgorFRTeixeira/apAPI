using apAPI.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace apAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AnalyticsController : ControllerBase
    {        
        // POST api/<AnalyticsController>
        [HttpPost]
        public List<Analytics> Post(int ActivityId)
        {
            if (ActivityId <= 0)
                return null;

 
            AnalyticsDal a = new AnalyticsDal();

            return a.LoadAnalytics(ActivityId);
        }
    }
}