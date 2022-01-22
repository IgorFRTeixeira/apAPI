using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apAPI
{
    public class QuantAnalytic
    {
        public string Name { get; set; }
        public object Value { get; set; }

        public QuantAnalytic(string Name, object Value)
        {
            this.Name = Name;

            this.Value = Value;
        }
    }
}
