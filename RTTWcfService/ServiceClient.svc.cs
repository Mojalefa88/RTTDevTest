using RTTWcfService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using RTTWcfService.DAL;
using System.Data.SqlClient;
using RTTWcfService.DBConn;
using System.Data;

namespace RTTWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
   
    public class ServiceClient : IClient
    {
        private DBConnection dbConn = new DBConnection();
        private string message;

        public string InsertClient(Client client, Address address, Contact contact)
        {
            dbConn.openConnection();
           string sqlClientQuery = "INSERT INTO Client(firstName, lastName, gender, idNumber, nationality) OUTPUT INSERTED.clientID "
                      + "VALUES (@firstName, @lastName, @gender, @idNumber, @nationality)";
            SqlCommand cmdClient = new SqlCommand(sqlClientQuery, dbConn.connection);
            cmdClient.Parameters.AddWithValue("@firstName", client.FirstName);
            cmdClient.Parameters.AddWithValue("@lastName", client.LastName);
            cmdClient.Parameters.AddWithValue("@gender", client.Gender);
            cmdClient.Parameters.AddWithValue("@idNumber", client.IdNumber);
            cmdClient.Parameters.AddWithValue("@nationality", client.Nationality);

            var clientID = (int)cmdClient.ExecuteScalar();
            if(clientID > 0)
            {
                message = "Client Added successfully";
            }
             else
            {
                message = "Client Not Added";
            }

            //Inserting Client Address
           string sqlAddressQuery = "INSERT INTO Address "
                      + "VALUES (@clientID, @residentialAddress, @postalAddress, @workAddress)";
            SqlCommand cmdAddress = new SqlCommand(sqlAddressQuery, dbConn.connection);
            cmdAddress.Parameters.AddWithValue("@clientID", clientID);
            cmdAddress.Parameters.AddWithValue("@residentialAddress", address.ResidentialAddress);
            cmdAddress.Parameters.AddWithValue("@postalAddress", address.PostalAddress);
            cmdAddress.Parameters.AddWithValue("@workAddress", address.WorkAddress);
          

            var result = cmdAddress.ExecuteNonQuery();
            if (result > 0)
            {
                message = "Address Added successfully";
            }
            else
            {
                message = "Address Not Added";
            }

           string sqlContactQuery = "INSERT INTO Contact "
                     + "VALUES (@clientID, @cellPhone, @workPhone, @homePhone, @email)";
            SqlCommand cmdContact = new SqlCommand(sqlContactQuery, dbConn.connection);
            cmdContact.Parameters.AddWithValue("@clientID", clientID);
            cmdContact.Parameters.AddWithValue("@cellPhone", contact.CellPhone);
            cmdContact.Parameters.AddWithValue("@workPhone", contact.WorkPhone);
            cmdContact.Parameters.AddWithValue("@homePhone", contact.HomePhone);
            cmdContact.Parameters.AddWithValue("@email", contact.Email);


            result = cmdContact.ExecuteNonQuery();
            if (result > 0)
            {
                message = "Contact Added successfully";
            }
            else
            {
                message = "Contact Not Added";
            }
            return message;
        }
        public DataSet GetClient(int clientID)
        {
            dbConn.openConnection();
            string sqlQuery = "SELECT Client.clientID, Client.firstName, Client.lastName, Client.gender, Client.idNumber, Client.nationality, "
                       + "Address.residentialAddress,  Address.postalAddress,  Address.workAddress, "
                       + "Contact.cellPhone, Contact.workPhone, Contact.homePhone, Contact.email "
                       + "FROM Client "
                       + "INNER JOIN Address ON Client.clientID = Address.clientID "
                       + "INNER JOIN Contact ON Client.clientID = Contact.clientID "
                       + "WHERE Client.clientID = "+ clientID;
            SqlCommand cmdClients = new SqlCommand(sqlQuery, dbConn.connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmdClients);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            cmdClients.ExecuteNonQuery();

            return dataSet;
        }
        public DataSet GetClients()
        {
            dbConn.openConnection();
           string sqlQuery = "SELECT Client.clientID, Client.firstName, Client.lastName, Client.gender, Client.idNumber, Client.nationality, "
                      + "Address.residentialAddress,  Address.postalAddress,  Address.workAddress, "
                      + "Contact.cellPhone, Contact.workPhone, Contact.homePhone, Contact.email "
                      + "FROM Client "
                      + "INNER JOIN Address ON Client.clientID = Address.clientID "
                      + "INNER JOIN Contact ON Client.clientID = Contact.clientID";
            SqlCommand cmdClients = new SqlCommand(sqlQuery, dbConn.connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmdClients);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            cmdClients.ExecuteNonQuery();
            
            return dataSet;
        }
        public int UpdateClient(int clientID, Client client, Address address, Contact contact)
        {
            dbConn.openConnection();
            string sqlClientUpdate = "UPDATE Client "
                                    + "SET firstName = '"+ client.FirstName +"'"
                                    +", lastName = '"+ client.LastName + "'"
                                    + " WHERE clientID = " + clientID;
            SqlCommand cmdUpdateClient = new SqlCommand(sqlClientUpdate, dbConn.connection);
            cmdUpdateClient.ExecuteNonQuery();

            string sqlAddressUpdate = "UPDATE Address "
                                   + "SET residentialAddress = '" + address.ResidentialAddress + "'"
                                   + ", postalAddress = '" + address.PostalAddress + "'"
                                   + ", workAddress = '" + address.WorkAddress + "'"
                                   + "WHERE clientID = " + clientID;
            SqlCommand cmdUpdateAddress = new SqlCommand(sqlAddressUpdate, dbConn.connection);
            cmdUpdateAddress.ExecuteNonQuery();


            string sqlContactUpdate = "UPDATE Contact "
                                   + "SET cellPhone = '" + contact.CellPhone + "'"
                                   + ", workPhone = '" + contact.WorkPhone + "'"
                                   + ", homePhone = '" + contact.HomePhone + "'"
                                    + ", email = '" + contact.Email + "'"
                                   + "WHERE clientID = " + clientID;
                                
            SqlCommand cmdUpdateContact = new SqlCommand(sqlContactUpdate, dbConn.connection);
             int res = cmdUpdateContact.ExecuteNonQuery();


            return res;
        }
        public int DeleteteClient(int clientID)
        {
            dbConn.openConnection();
            string sqlQuery = "delete from Client where clientID = " + clientID;
            SqlCommand cmdDelete = new SqlCommand(sqlQuery, dbConn.connection);
            

            return cmdDelete.ExecuteNonQuery();
        }

       
    }
}
