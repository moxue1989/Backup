using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Mo_Xue_Lab_4
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TechSupportService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select TechSupportService.svc or TechSupportService.svc.cs at the Solution Explorer and start debugging.
    public class TechSupportService : ITechSupportService
    {
        public List<Technician> GetAllTechnicians()
        {
            return TechnicianDB.GetAllTechnicians();
        }

        public List<Incident> GetOpenTechIncidents(int techID)
        {
            return IncidentDB.GetOpenTechIncidents(techID);
        }
        public List<Customer> GetAllCustomers()
        {
            return CustomerDB.GetAllCustomers();
        }

        public List<Incident> GetIncidentsByCustomer(int customerID)
        {
            return IncidentDB.GetIncidentsByCustomer(customerID);
        }


    }
}
