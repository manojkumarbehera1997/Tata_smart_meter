using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace UtilitiesDeviceERP
{
    /// <summary>
    /// Summary description for UtilitiesDeviceERPSmartMeterCreateRequest_Out
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class UtilitiesDeviceERPSmartMeter : System.Web.Services.WebService
    {

        [WebMethod]
        public string UtilitiesDeviceERPSmartMeterCreateRequest_Out(string name)
        {
            return "Hello World"+ name;
        }
    }
}
