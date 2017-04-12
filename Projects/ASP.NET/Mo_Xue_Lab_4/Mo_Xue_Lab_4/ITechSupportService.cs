using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Mo_Xue_Lab_4
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITechSupportService" in both code and config file together.
    [ServiceContract]
    public interface ITechSupportService
    {
        [OperationContract]
        List<Technician> GetAllTechnicians();

        [OperationContract]
        List<Incident> GetOpenTechIncidents(int techID);

        [OperationContract]
        List<Customer> GetAllCustomers();

        [OperationContract]
        List<Incident> GetIncidentsByCustomer(int customerID);
    }

    // technician class
    [Serializable]
    [DataContract]
    public class Technician
    {
        [DataMember]
        public int TechID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Phone { get; set; }
    }

    // customer class
    [DataContract][Serializable]
    public class Customer
    {
        [DataMember]
        public int CustomerID { get; set; }
        [DataMember]
        public string Name { get; set; }
    }

    // incident class
    [DataContract][Serializable]
    public class Incident
    {
        [DataMember(Order = 0)]
        public int IncidentID { get; set; }
        [DataMember(Order = 1)]
        public DateTime DateOpened { get; set; }
        [DataMember]
        public string CustomerName { get; set; }
        [DataMember]
        public string ProductName { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public int TechID { get; set; }
        [DataMember]
        public DateTime? DateClosed { get; set; }
    }
}
