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
        }

        public string URL() {
            if (Atividade == null)
            {
                return null;
            }

            return "https://aps-it.herokuapp.com/Config";
        }
    }
}
