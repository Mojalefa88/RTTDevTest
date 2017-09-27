using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace RTTWcfService.DBConn
{
    public class DBConnection
    {
      
        public SqlConnection connection;
       

        public DBConnection()
        { 
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["pnpConnectionString"].ConnectionString);
        }
        public SqlConnection openConnection()
        {
            if(connection.State == ConnectionState.Closed || connection.State == ConnectionState.Broken)
            {
                try
                {
                    connection.Open();
                }
                catch (Exception ex)
                {

                }
                
            }
            return connection;
        }

        private SqlConnection closeConnection()
        {
            if(connection.State == ConnectionState.Open)
            {
                connection.Close();
            }

            return connection;
        }

       

    }
}