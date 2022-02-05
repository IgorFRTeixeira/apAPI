using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apAPI.Models
{
    public class Deploy
    {
        private Activity Atividade { get; set; }

        public Deploy() { 
        
        }

        public Deploy(Activity Atividade)
        {
            this.Atividade = Atividade;
            //Do something
        }

        public string GetURL() {
            if (Atividade == null)
            {
                return null;
            }

            return "https://aps-it.herokuapp.com/Config";
        }
    }
}
