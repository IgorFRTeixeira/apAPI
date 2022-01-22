using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class APController : ControllerBase
    {
        [Route("/GetConfig")]
        [HttpGet]
        public ContentResult GetConfig() {
            ConfigController c = new ConfigController();
            
            return c.Get();
        }

        [Route("/PostAnalytics")]
        [HttpPost]
        public List<Analytics> PostAnalytics(string activityID)
        {
            if (activityID == "")
                return null;

            AnalyticsController ac = new AnalyticsController();

            return ac.Post(activityID);
        }

        [Route("/PostDeploy")]
        [HttpPost]
        public String PostDeploy(Activity activity)
        {
            DeployController d = new DeployController();

            return d.Post(activity);
        }

    }
}
