using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace RTTWcfService.Models
{
    [DataContract]
    public class Contact
    {
        private int contactID;
        private int clientID;
        private string cellPhone;
        private string workPhone;
        private string homePhone;
        private string email;

        [DataMember]
        public int ContactID { get => contactID; set => contactID = value; }
        [DataMember]
        public int ClientID { get => clientID; set => clientID = value; }
        [DataMember]
        public string CellPhone { get => cellPhone; set => cellPhone = value; }
        [DataMember]
        public string WorkPhone { get => workPhone; set => workPhone = value; }
        [DataMember]
        public string HomePhone { get => homePhone; set => homePhone = value; }
        [DataMember]
        public string Email { get => email; set => email = value; }
    }
}