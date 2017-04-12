using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mo_Xue_LAB_3
{
    // incident class
    public class Incident
    {
        public int IncidentID { get; set; }
        public DateTime DateOpened { get; set; }
        public string CustomerName { get; set; }
        public string ProductName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int TechID { get; set; }
        public DateTime? DateClosed { get; set; }
    }
}