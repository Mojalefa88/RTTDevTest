using RTTWcfService.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RTTWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IClient
    {
        [OperationContract]
        string InsertClient(Client client, Address address, Contact contact);
        [OperationContract]
        DataSet GetClient(int clientID);
        [OperationContract]
        DataSet GetClients();
        [OperationContract]
        int UpdateClient(int clientID, Client client, Address address, Contact contact);
        [OperationContract]
        int DeleteteClient(int clientID);
    }


   
}
