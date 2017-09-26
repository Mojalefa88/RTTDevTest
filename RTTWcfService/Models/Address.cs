using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace RTTWcfService.Models
{
    [DataContract]
    public class Address
    {
        private int addressID;
        private int clientID;
        private string residentialAddress;
        private string postalAddress;
        private string workAddress;

        [DataMember]
        public int AddressID { get => addressID; set => addressID = value; }
        [DataMember]
        public int ClientID { get => clientID; set => clientID = value; }
        [DataMember]
        public string ResidentialAddress { get => residentialAddress; set => residentialAddress = value; }
        [DataMember]
        public string PostalAddress { get => postalAddress; set => postalAddress = value; }
        [DataMember]
        public string WorkAddress { get => workAddress; set => workAddress = value; }
        
    }
}