using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apAPI.DAL
{
    public class AnalyticsDal
    {
        private string fileName = "DB.json";

        public List<Analytics> LoadAnalytics(int ActivityId)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile(fileName).Build();

            var section = config.GetSection(nameof(Analytics));

            var analytics = section.Get<List<Analytics>>()
                .Where(analitcs => analitcs.ActivityId == ActivityId).ToList();

            return analytics;
        }

    }
}
