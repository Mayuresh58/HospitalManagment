using HospitalManagment.DAL;
using HospitalManagment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace HospitalManagment.Web_Pages
{
    public partial class Apointment_Booking : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBook_Click(object sender, EventArgs e)
        {
            if (Session["PatientID"] != null)
            {
                int patientID = (int)Session["PatientID"]; 

                Appointment appointment = new Appointment
                {
                    PatientID = patientID, 
                    DoctorID = int.Parse(Doctors.SelectedValue),
                    AppointmentDate = AppointmentDate.SelectedDate,
                    Status = "Booked"
                };

                AppointmentDAL appointmentDAL = new AppointmentDAL();
                appointmentDAL.BookAppointment(appointment);
            }
            else
            {
               // Response.Write("<script>alert(Please log in to book an appointment.)</script>");
                lblError.Text = "Please log in to book an appointment.";
            }
        }
    }
}