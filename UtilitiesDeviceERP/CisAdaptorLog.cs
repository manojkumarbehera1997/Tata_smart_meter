using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using UtilitiesDeviceERP.Models;

namespace UtilitiesDeviceERP
{
    public class CisAdaptorLog
    {
        public string query, constr;       
        public void AdaptorLog(Adaptor adaptor)
        {
            try
            {
                constr = System.Configuration.ConfigurationManager.ConnectionStrings["Tata"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(constr))
                {
                    connection.Open();
                    query = "insert into CIS_ADAPTOR_LOG (UUID,Log_DateTime,Request_Type) values('" + adaptor.UUID + "','" + adaptor.LogDateTime + "','" + adaptor.Request_Type + "')";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}