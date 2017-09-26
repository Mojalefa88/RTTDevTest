using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RTT.ViewModels
{
    public class ClientViewModel
    {
        //Client details
        private string firstName;
        private string lastName;
        private string gender;
        private string idNumber;
        private string nationality;
        //Address details
        private string residentialAddress;
        private string postalAddress;
        private string workAddress;
        //Contact details
        private string cellPhone;
        private string workPhone;
        private string homePhone;
        private string email;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Gender { get => gender; set => gender = value; }
        public string IdNumber { get => idNumber; set => idNumber = value; }
        public string Nationality { get => nationality; set => nationality = value; }
        public string ResidentialAddress { get => residentialAddress; set => residentialAddress = value; }
        public string PostalAddress { get => postalAddress; set => postalAddress = value; }
        public string WorkAddress { get => workAddress; set => workAddress = value; }
        public string CellPhone { get => cellPhone; set => cellPhone = value; }
        public string WorkPhone { get => workPhone; set => workPhone = value; }
        public string HomePhone { get => homePhone; set => homePhone = value; }
        public string Email { get => email; set => email = value; }
    }
}