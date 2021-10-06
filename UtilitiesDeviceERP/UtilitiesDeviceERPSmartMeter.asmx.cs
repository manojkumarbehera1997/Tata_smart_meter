using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
        public string query, constr;
        public SqlConnection con;
        public void connection()
        {
            constr = ConfigurationManager.ConnectionStrings["Tata"].ToString();
            con = new SqlConnection(constr);
            con.Open();
        }

        [SoapDocumentMethod(OneWay = true)]
        [WebMethod]
        public void UtilitiesDeviceERPSmartMeterCreateRequest_Out(abc.UtilsDvceERPSmrtMtrCrteReqMsg utilitiesDeviceERPSmartMeterCreateRequest)
        {
            connection();
            query = "Insert_Equipment";
            SqlCommand com = new SqlCommand(query, con);
            com.CommandType = CommandType.StoredProcedure;
           // com.Parameters.AddWithValue("@ID", );
            com.Parameters.AddWithValue("@Utility_ID ", utilitiesDeviceERPSmartMeterCreateRequest.UtilitiesDevice.ID);
           // com.Parameters.AddWithValue("@Meter_Class ", null);
           // com.Parameters.AddWithValue("@Manufacturer_ID", null);
           // com.Parameters.AddWithValue("@Status ", null);
            com.Parameters.AddWithValue("@Meter_ID ", utilitiesDeviceERPSmartMeterCreateRequest.UtilitiesDevice.SerialID);
           // com.Parameters.AddWithValue("@Device_Type", null);
            //com.Parameters.AddWithValue("@Model_ID ", null);
            com.Parameters.AddWithValue("@StartDate ", utilitiesDeviceERPSmartMeterCreateRequest.UtilitiesDevice.StartDate);
            com.Parameters.AddWithValue("@EndDate", utilitiesDeviceERPSmartMeterCreateRequest.UtilitiesDevice.EndDate);
            com.Parameters.AddWithValue("@Material_ID ", utilitiesDeviceERPSmartMeterCreateRequest.UtilitiesDevice.MaterialID);
            com.Parameters.AddWithValue("@Name_Plate_ID ", utilitiesDeviceERPSmartMeterCreateRequest.UtilitiesDevice.SerialID);
            //com.Parameters.AddWithValue("@HES_ID", null);
            //com.Parameters.AddWithValue("@Data_Source ", null);
            //com.Parameters.AddWithValue("@Org_ID ", null);
            //com.Parameters.AddWithValue("@Created_by", null);
            //com.Parameters.AddWithValue("@Created_on ", null);
            //com.Parameters.AddWithValue("@changed_by ", null);
            //com.Parameters.AddWithValue("@changed_on ", null);
            com.ExecuteNonQuery();

            // commented fields are missing in the text document.
        }


        [WebMethod]
        public string UtilitiesDeviceERPSmartMeterCreateRequest_In()
        {

            //do stuffs...


            return "Hello World";
        }
    }
}
