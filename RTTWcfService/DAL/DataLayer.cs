using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using RTTWcfService.DBConn;
using RTTWcfService.Models;

namespace RTTWcfService.DAL
{
    public class DataLayer
    {
        private DBConnection dbConn = new DBConnection();
        private string sqlQuery;
        public int AddClient(Client client, Address address, Contact contact)
        {
            //Adding Client personal details
            sqlQuery = "INSERT INTO Client(firstName, lastName, gender, idNumber, nationality) OUTPUT INSERTED.clientID "
                       + "VALUES (@firstName, @lastName, @gender, @idNumber, @nationality)";

            SqlParameter[] sqlClientParameters = new SqlParameter[5];

            sqlClientParameters[0] = new SqlParameter("@firstName", SqlDbType.VarChar);
            sqlClientParameters[0].Value = Convert.ToString(client.FirstName);
            /*sqlClientParameters[0] = new SqlParameter()
            {
                ParameterName = "@firstName", SqlDbType = SqlDbType.VarChar, Value = client.FirstName
            };*/
            sqlClientParameters[1] = new SqlParameter()
            {
                ParameterName = "@lastName", SqlDbType = SqlDbType.VarChar,  Value = client.LastName
            };
            sqlClientParameters[2] = new SqlParameter()
            {
                ParameterName = "@gender", SqlDbType = SqlDbType.VarChar, Value = client.FirstName
            };
            sqlClientParameters[3] = new SqlParameter()
            {
                ParameterName = "@idNumber",
                SqlDbType = SqlDbType.VarChar,Value = client.LastName
            };
            sqlClientParameters[4] = new SqlParameter()
            {
                ParameterName = "@nationality", SqlDbType = SqlDbType.VarChar, Value = client.FirstName
            };
            dbConn.setSqlQuery(sqlQuery);
            int clientID = dbConn.executeInsertQuery(sqlClientParameters);
            if(clientID > 0)
            {
                return 200;
            }

            //Adding Client Address
            sqlQuery = "INSERT INTO Address "
                       + "VALUES (@clientID, @residentialAddress, @postalAddress, @workAddress)";
            dbConn.setSqlQuery(sqlQuery);

            SqlParameter[] sqlAddressParameters = new SqlParameter[3];
            sqlClientParameters[0] = new SqlParameter()
            {
                ParameterName = "@clientID", SqlDbType = SqlDbType.VarChar, Value = clientID
            };
            sqlClientParameters[1] = new SqlParameter()
            {
                ParameterName = "@residentialAddress", SqlDbType = SqlDbType.VarChar, Value = address.ResidentialAddress
            };
            sqlClientParameters[2] = new SqlParameter()
            {
                ParameterName = "@postalAddress", SqlDbType = SqlDbType.VarChar, Value = address.PostalAddress
            };
            sqlClientParameters[3] = new SqlParameter()
            {
                ParameterName = "@workAddress", SqlDbType = SqlDbType.VarChar, Value = address.WorkAddress
            };
           int r2 = dbConn.executeInsertQuery(sqlAddressParameters);
            if (r2 > 0)
            {
                return 300;
            }
            //Adding Client Contact details
            sqlQuery = "INSERT INTO Contact "
                       + "VALUES (@clientID, @cellPhone, @workPhone, @homePhone, @email)";
            dbConn.setSqlQuery(sqlQuery);

            SqlParameter[] sqlAddContactParameters = new SqlParameter[4];
            sqlClientParameters[0] = new SqlParameter()
            {
                ParameterName = "@cellPhone", SqlDbType = SqlDbType.VarChar, Value = contact.CellPhone
            };
            sqlClientParameters[1] = new SqlParameter()
            {
                ParameterName = "@workPhone", SqlDbType = SqlDbType.VarChar, Value = contact.WorkPhone
            };
            sqlClientParameters[2] = new SqlParameter()
            {
                ParameterName = "@homePhone", SqlDbType = SqlDbType.VarChar, Value = contact.HomePhone
            };
            sqlClientParameters[3] = new SqlParameter()
            {
                ParameterName = "@email", SqlDbType = SqlDbType.VarChar, Value = contact.Email
            };
            sqlClientParameters[4] = new SqlParameter()
            {
                ParameterName = "@clientID", SqlDbType = SqlDbType.VarChar, Value = clientID


            };
            int r3 = dbConn.executeInsertQuery(sqlAddContactParameters);
            if (r3 > 0)
            {
                return 200;
            }

            return r3;
        }
        public DataTable GetClients()
        {
            sqlQuery = "SELECT Client.clientID, Client.firstName, Client.lastName, Client.gender, Client.idNumber, Client.nationality,"
                      + "Address.residentialAddress,  Address.postalAddress,  Address.workAddress,"
                      + "Contact.cellPhone, Contact.workPhone, Contact.homePhone, Contact.email "
                      + "FROM Client"
                      + "INNER JOIN Address ON Client.clientID = Address.clientID "
                      + "INNER JOIN Contact ON Client.clientID = Contact.clientID";
            dbConn.setSqlQuery(sqlQuery);
            return dbConn.executeSelectQuery();
        }


        public string UpdateClient(int value)
        {
            throw new NotImplementedException();
        }
        public string DeleteteClient(int value)
        {
            throw new NotImplementedException();
        }
    }
}