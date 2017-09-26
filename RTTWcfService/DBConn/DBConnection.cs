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
        private SqlDataAdapter dataAdapter;
        public SqlConnection connection;
        private SqlCommand command;
        private DataTable dataTable;
        private DataSet dataSet;
        public string query;

        public DBConnection()
        {
            dataAdapter = new SqlDataAdapter();
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

        public void setSqlQuery(string strQuery)
        {
            query = strQuery;
        }
        public DataTable executeSelectQuery()
        {
            command = new SqlCommand();
            openConnection();
            dataTable = new DataTable();
            dataSet = new DataSet();
            try
            {
                command.Connection = connection;
                command.CommandText = query;
                //command.Parameters.AddRange(sqlParameter);
                command.ExecuteNonQuery();
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dataSet);
                dataTable = dataSet.Tables[0];
            }
            catch (Exception ex)
            {

               
            }
            return dataTable;
        }
        public int executeInsertQuery(SqlParameter[] sqlParameter)
        {
            command = new SqlCommand();
            openConnection();
            int result = 0;
            // try
            //{
           


            command.Connection = connection;
                command.CommandText = query;
                result = (int)command.ExecuteScalar();
            command.Parameters.AddRange(sqlParameter);
                dataAdapter.InsertCommand = command;

           // }
           // catch (Exception ex)
           // {

                
           // }
            return result;
        }

        public bool executeUpdateQuery(SqlParameter[] sqlParameter)
        {
            command = new SqlCommand();
            openConnection();
            try
            {
                command.Connection = connection;
                command.CommandText = query;
                command.Parameters.AddRange(sqlParameter);
                command.ExecuteNonQuery();
                dataAdapter.UpdateCommand = command;
            }
            catch (Exception ex)
            {

               
            }
            return true;
        }
        public bool executeDeleteQuery(SqlParameter[] sqlParameter)
        {
            command = new SqlCommand();
            openConnection();
            try
            {
                command.Connection = connection;
                command.CommandText = query;
                command.Parameters.AddRange(sqlParameter);
                command.ExecuteNonQuery();
                dataAdapter.DeleteCommand = command;
            }
            catch (Exception ex)
            {


            }
            return true;
        }

    }
}