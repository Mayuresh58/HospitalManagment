using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalManagment.Models
{
    public class Billing
    {
        public int BillID { get; set; }
        public int PatientID { get; set; }
        public decimal Amount { get; set; }
        public string PaymentStatus { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}