using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apAPI
{
    public class Analytics: BaseAnalytics
    {       
        public Analytics(int InveniraStdID, List<QuantAnalytic> QuantAnalytics, List<QualAnalytic> QualAnalytics)
        {
            this.InveniraStdID = InveniraStdID;
            this.QuantAnalytics = QuantAnalytics;
            this.QualAnalytics = QualAnalytics;
        }

        public override BaseAnalytics Clone()
        {
            return (BaseAnalytics)MemberwiseClone();              
        }

        public Analytics()
        {
        }
    }
}
