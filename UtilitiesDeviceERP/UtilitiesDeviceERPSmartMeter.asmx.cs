using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Web.UI;
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
        public string query, constr;
        SqlCommand cmd;
        
        [SoapDocumentMethod(OneWay = true)]
        [WebMethod]
        public void UtilitiesDeviceERPSmartMeterCreateRequest_Out(abc.UtilsDvceERPSmrtMtrCrteReqMsg utilitiesDeviceERPSmartMeterCreateRequest)
        {
            try
            {         
                CisAdaptorLog cisAdaptorLog = new CisAdaptorLog();
                Adaptor adaptor = new Adaptor();
                adaptor.UUID = utilitiesDeviceERPSmartMeterCreateRequest.MessageHeader.UUID.Value;
                adaptor.LogDateTime = utilitiesDeviceERPSmartMeterCreateRequest.MessageHeader.CreationDateTime;
                adaptor.Request_Type = "utilitiesDeviceERPSmartMeterCreateRequest";
                cisAdaptorLog.AdaptorLog(adaptor);
                HES hES = new HES();
                int hesCode = hES.HesCode(utilitiesDeviceERPSmartMeterCreateRequest.UtilitiesDevice.SmartMeter.UtilitiesAdvancedMeteringSystemID.Value);
                constr = ConfigurationManager.ConnectionStrings["Tata"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(constr))
                {
                    connection.Open();
                    cmd = connection.CreateCommand();
                    cmd.CommandText = "insert into equipment (Utility_ID,Manufacturer_ID,Meter_ID,StartDate,EndDate,Material_ID,Name_Plate_ID,HES_ID) values('" + utilitiesDeviceERPSmartMeterCreateRequest.UtilitiesDevice.ID.Value + "','" + utilitiesDeviceERPSmartMeterCreateRequest.UtilitiesDevice.IndividualMaterialManufacturerInformation.PartyInternalID.Value + "'," +
                        "'" + utilitiesDeviceERPSmartMeterCreateRequest.UtilitiesDevice.SerialID + "','" + utilitiesDeviceERPSmartMeterCreateRequest.UtilitiesDevice.StartDate + "'," +
                        "'" + utilitiesDeviceERPSmartMeterCreateRequest.UtilitiesDevice.EndDate + "','" + utilitiesDeviceERPSmartMeterCreateRequest.UtilitiesDevice.MaterialID.Value + "'," +
                        "'" + utilitiesDeviceERPSmartMeterCreateRequest.UtilitiesDevice.SerialID + "','" + hesCode + "')";
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        [WebMethod]
        public string UtilitiesDeviceERPSmartMeterCreateRequest_In()
        {
            return "Hello World";
        }
    }
}
