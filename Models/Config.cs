using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apAPI.Models
{
    public class Config
    {
        public ContentResult GetConfig()
        {
            return new ContentResult
            {
                ContentType = "text/html",
                StatusCode = (int)System.Net.HttpStatusCode.OK,
                Content = "<html><body>Config Web Page</body></html>"
            };
            ;
        }
    }
}
