using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalManagment.Models
{
    public class Patient
    {
        public int PatientID { get; set; }
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Age {  get; set; }
        public string Contact {  get; set; }
        public string Address {  get; set; }
        public string MedicalHistory {  get; set; }


    }
}