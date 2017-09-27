using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RTT.RTTServiceReference;
using RTT.ViewModels;
using System.Data;
using System.Text;

namespace RTT.Controllers
{
    public class ClientManagementController : Controller
    {
        RTTServiceReference.ClientClient clientServiceRef = new ClientClient();
        public ActionResult Index()
        {
            DataSet ds = clientServiceRef.GetClients();
            ViewBag.ClientList = ds.Tables[0];
            clientServiceRef.Close();
            return View();
           
        }

        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(ClientViewModel clientViewModel)
        {
            //Inserting Client Details
            Client client = new Client
            {
                FirstName = clientViewModel.FirstName,
                LastName = clientViewModel.LastName,
                Gender = clientViewModel.Gender,
                IdNumber = clientViewModel.IdNumber,
                Nationality = clientViewModel.Nationality
            };
            //Inserting Address 
            Address address = new Address
            {
                ResidentialAddress = clientViewModel.ResidentialAddress,
                PostalAddress = clientViewModel.PostalAddress,
                WorkAddress = clientViewModel.WorkAddress
            };
            //Inserting Contacts
            Contact contact = new Contact
            {
                CellPhone = clientViewModel.CellPhone,
                WorkPhone = clientViewModel.WorkPhone,
                HomePhone = clientViewModel.HomePhone,
                Email = clientViewModel.Email
            };

            clientServiceRef.InsertClient(client, address, contact);
           
            
            return RedirectToAction("Index", "ClientManagement");
        }

        public ActionResult Delete(int id)
        {
            clientServiceRef.DeleteteClient(id);
            return RedirectToAction("Index", "ClientManagement"); 
        }

        public ActionResult Update(int id)
        {
            DataSet ds = clientServiceRef.GetClient(id);
            var client = ds.Tables[0];
            ClientViewModel clientViewModel = new ClientViewModel();
            //foreach(System.Data.DataRow item in ViewBag.ClientList.Rows)
            foreach (DataRow item in client.Rows)
            {
                clientViewModel = new ClientViewModel
                {
                    FirstName = item["firstName"].ToString(),
                    LastName = item["lastName"].ToString(),
                    Gender = item["gender"].ToString(),
                    IdNumber = item["idNumber"].ToString(),
                    Nationality = item["nationality"].ToString(),
                    ResidentialAddress = item["residentialAddress"].ToString(),
                    PostalAddress = item["postalAddress"].ToString(),
                    WorkAddress = item["workAddress"].ToString(),
                    CellPhone = item["cellPhone"].ToString(),
                    HomePhone = item["homePhone"].ToString(),
                    WorkPhone = item["workPhone"].ToString(),
                    Email = item["email"].ToString()
                };
            }
            clientServiceRef.Close();
            return View(clientViewModel);
        }

        [HttpPost]
        public ActionResult Update(int id, ClientViewModel clientViewModel)
        {
            //Updating Client 
            Client client = new Client
            {
                FirstName = clientViewModel.FirstName,
                LastName = clientViewModel.LastName,
                Gender = clientViewModel.Gender,
                IdNumber = clientViewModel.IdNumber,
                Nationality = clientViewModel.Nationality
            };
            //Updating Address 
            Address address = new Address
            {
                ResidentialAddress = clientViewModel.ResidentialAddress,
                PostalAddress = clientViewModel.PostalAddress,
                WorkAddress = clientViewModel.WorkAddress
            };
            //Updating Contacts
            Contact contact = new Contact
            {
                CellPhone = clientViewModel.CellPhone,
                WorkPhone = clientViewModel.WorkPhone,
                HomePhone = clientViewModel.HomePhone,
                Email = clientViewModel.Email
            };

            clientServiceRef.UpdateClient(id, client, address, contact);


            return RedirectToAction("Index", "ClientManagement");
        }

        public FileResult Export()
        {
            DataSet dataSet = clientServiceRef.GetClients();
            var clientData = dataSet.Tables[0];
            var sb = new StringBuilder();
            foreach (DataRow data in clientData.Rows)
            {

                sb.AppendLine(data["clientID"].ToString() + ","+ data["lastName"].ToString()+" " + data["firstName"].ToString() 
                                  + "," + data["gender"].ToString() + ", " + data["idNumber"].ToString() 
                                  + ", " + data["nationality"].ToString() + ", " + data["residentialAddress"].ToString()
                                  + ", " + data["postalAddress"].ToString() + ", " + data["workAddress"].ToString()
                                  + ", " + data["cellPhone"].ToString() + ", " + data["homePhone"].ToString()
                                  + ", " + data["workPhone"].ToString() + ", " + data["email"].ToString());
            }
            return File(new UTF8Encoding().GetBytes(sb.ToString()), "application/txt", "clientData_" + DateTime.Now + ".txt");
        }


    }
}