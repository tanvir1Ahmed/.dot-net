using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExcelOpertationInMVC.Model
{
    public class AccessLog
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int UserID { get; set; }
        public string Name { get; set; }
        public int EmployeeID { get; set; }
        public string Mode { get; set; }
        public string CardSerialNo { get; set; }
        public string Result { get; set; }
        public string ExternalDevice { get; set; }
    }

}