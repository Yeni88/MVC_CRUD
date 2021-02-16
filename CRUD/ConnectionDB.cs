using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CRUD
{
    public class ConnectionDB
    {
        public IDbConnection GetConnection(string ConnDB)
        {
            return new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings[string.Format("{0}", ConnDB)].ConnectionString);
        }
    }
}