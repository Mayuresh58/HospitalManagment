using HospitalManagment.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;

namespace HospitalManagment.DAL
{
    public class AppointmentDAL
    {
        string connectionString = "Data Source=DESKTOP-KNL5H8M\\SQLEXPRESS01;Initial Catalog=HospitalDB;Integrated Security=True;TrustServerCertificate=True";

        public void BookAppointment(Appointment appointment)
        {
            using(SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Appointments(PatientID, DoctorID, AppointmentDate, Status) VALUES (@PatientID, @DoctorID, @AppointmentDate, @Status)", con);

                cmd.Parameters.AddWithValue("@PatientID", appointment.PatientID);
                cmd.Parameters.AddWithValue("@DoctorID", appointment.DoctorID);
                cmd.Parameters.AddWithValue("@AppointmentDate", appointment.AppointmentDate);
                cmd.Parameters.AddWithValue("@Status", appointment.Status);

                cmd.ExecuteNonQuery();

                con.Close();
            }
        }
    }
}