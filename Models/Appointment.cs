using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalManagment.Models
{
    public class Appointment
    {
        public int AppointmentID {  get; set; }
        public int PatientID {  get; set; }
        public int DoctorID {  get; set; }
        public DateTime AppointmentDate { get; set; }
        public string Status {  get; set; }
    }
}