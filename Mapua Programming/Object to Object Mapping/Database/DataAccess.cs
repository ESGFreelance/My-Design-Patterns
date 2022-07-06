using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_to_Object_Mapping.Database
{
    public abstract class DataAccess
    {
        protected static string conUserInformationDB = ConfigurationManager.ConnectionStrings["UserInformationDB"].ConnectionString.ToString();
        protected static string conClientManagementDB = ConfigurationManager.ConnectionStrings["ClientManagementDB"].ConnectionString.ToString();
        protected static string conSchoolDB = ConfigurationManager.ConnectionStrings["SchoolDB"].ConnectionString.ToString();


        protected static SqlConnection con;
        protected static SqlCommand cmd;
        protected static SqlDataAdapter da;
        protected static SqlDataReader dr;
        protected static SqlTransaction trx;
    }
}
