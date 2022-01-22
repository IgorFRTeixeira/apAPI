using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apAPI
{
    public class QualAnalytic
    {
        public string Studentactivityprofile { get; set; }
        public string ActitivyHeatMap { get; set; }

        public QualAnalytic(string Studentactivityprofile, string ActitivyHeatMap)
        {

            this.Studentactivityprofile = Studentactivityprofile;
            this.ActitivyHeatMap = ActitivyHeatMap;
        }
    }
}
