using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using UtilitiesDeviceERP.Models;

namespace UtilitiesDeviceERP
{
    /// <summary>
    /// Summary description for UtilitiesDeviceERPSmartMeterCreateRequest_Out
    /// </summary>
    [WebService(Namespace = "http://tpddl.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class UtilitiesDeviceERPSmartMeter : System.Web.Services.WebService
    {
        [SoapDocumentMethod(OneWay = true)]
        [WebMethod]
        public void UtilitiesDeviceERPSmartMeterCreateRequest_Out(abc.UtilsDvceERPSmrtMtrCrteReqMsg utilitiesDeviceERPSmartMeterCreateRequest)
        {
            //utilitiesDeviceERPSmartMeterCreateRequest.MessageHeader.UUID
            //do stuffs...


        }


        [WebMethod]
        public string UtilitiesDeviceERPSmartMeterCreateRequest_In()
        {

            //do stuffs...


            return "Hello World";
        }
    }
}
