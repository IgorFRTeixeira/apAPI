using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apAPI
{
    public abstract class BaseAnalytics
    {
        public int InveniraStdID { get; set; }
        public List<QuantAnalytic> QuantAnalytics { get; set; }
        public List<QualAnalytic> QualAnalytics { get; set; }

        //Método a ser implementado pela subclasse
        public abstract BaseAnalytics Clone();
    }
}
