using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apAPI
{
    public class Analytics
    {
        public int ActivityId { get; set; }
        public int InveniraStdID { get; set; }
        public List<QuantAnalytic> QuantAnalytics { get; set; }
        public string Studentactivityprofile { get; set; }
        public string ActitivyHeatMap { get; set; }
    }
}
