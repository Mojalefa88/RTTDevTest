using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace RTTWcfService.Models
{
    [DataContract]
    public class Client
    {
        private int clientID;
        private string firstName;
        private string lastName;
        private string gender;
        private string idNumber;
        private string nationality;

        [DataMember]
        public int ClientID { get => clientID; set => clientID = value; }
        [DataMember]
        public string FirstName { get => firstName; set => firstName = value; }
        [DataMember]
        public string LastName { get => lastName; set => lastName = value; }
        [DataMember]
        public string Gender { get => gender; set => gender = value; }
        [DataMember]
        public string IdNumber { get => idNumber; set => idNumber = value; }
        [DataMember]
        public string Nationality { get => nationality; set => nationality = value; }
       
    }
}