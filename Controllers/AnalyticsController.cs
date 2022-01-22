using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace apAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AnalyticsController : ControllerBase
    {

        const string QuantAnalyticType1 = "Acedeu ao documento com os detalhes da visita de campo";
        const string QuantAnalyticType2 = "Anexou fotografias da recolha no campo";
        const string QuantAnalyticType3 = "Iniciou o questionário";
        const string QuantAnalyticType4 = "Percentagem de respostas efetuadas (%)";

        const string QualAnalyticBaseUrl1 = "http://url1/QualAnalytic01/";
        const string QualAnalyticBaseUrl2 = "http://url1/QualAnalytic02/";

        // POST api/<AnalyticsController>
        [HttpPost]
        public List<Analytics> Post(string activityID)
        {
            if (activityID == "")
                return null;

            return LoadAnalytics(activityID);//simula obtenção do dados numa BD
        }

        private List<Analytics> LoadAnalytics(string activityID)
        {
            //criar dados de teste
            List<Analytics> list = new List<Analytics>();

            BaseAnalytics analytics1 = new Analytics();
            analytics1.InveniraStdID = 1001;
            analytics1.QuantAnalytics = new List<QuantAnalytic> {
                    new QuantAnalytic(QuantAnalyticType1, true),
                    new QuantAnalytic(QuantAnalyticType2, false),
                    new QuantAnalytic(QuantAnalyticType3, false),
                    new QuantAnalytic(QuantAnalyticType4, 0.0)
                    };
            analytics1.QualAnalytics = new List<QualAnalytic> {
                    new QualAnalytic(string.Concat(QualAnalyticBaseUrl1,"11001"), string.Concat(QualAnalyticBaseUrl2,"21001")),
                    };

            BaseAnalytics analytics2 = (Analytics)analytics1.Clone();

            analytics2.InveniraStdID = 1002;
            analytics2.QuantAnalytics = new List<QuantAnalytic> {
                    new QuantAnalytic(QuantAnalyticType1, true),
                    new QuantAnalytic(QuantAnalyticType2, true),
                    new QuantAnalytic(QuantAnalyticType3, true),
                    new QuantAnalytic(QuantAnalyticType4, 50.0)
                    };
            analytics2.QualAnalytics = new List<QualAnalytic> {
                    new QualAnalytic(string.Concat(QualAnalyticBaseUrl1,"11002"), string.Concat(QualAnalyticBaseUrl2,"21002"))
                    };


            list.Add((Analytics)analytics1);
            list.Add((Analytics)analytics2);

            return list;
        }

 //       void testeXML(Analytics Analytics) {

 //           XmlSerializer xsSubmit = new XmlSerializer(typeof(Analytics));
 //       var xml = "";

 //using(var sww = new System.IO.StringWriter())
 //{
 //    using(System.Xml.XmlWriter writer = System.Xml.XmlWriter.Create(sww))
 //    {
 //        xsSubmit.Serialize(writer, Analytics);
 //        xml = sww.ToString(); // Your XML
 //    }
 //}
 //       }

    }
}
