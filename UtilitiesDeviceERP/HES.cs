using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace UtilitiesDeviceERP
{
    public class HES
    {
        public string query, constr;
        SqlDataReader rr;

        public int HesCode(string hesName)
        {
            try
            {
                constr = ConfigurationManager.ConnectionStrings["Tata"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(constr))
                {
                    int result = 0;
                    connection.Open();
                    query = "select id from hes_master where hes_code='" + hesName + "'";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    rr = cmd.ExecuteReader();
                    while (rr.Read())
                    {
                        result = Convert.ToInt32(rr["id"].ToString());
                    }
                    return result;
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}