using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using HospitalManagment.Models;


namespace HospitalManagment.DAL.HospitalManagment.Models
{
    public class PatientDAl
    {
        string connectionString = "Data Source=DESKTOP-KNL5H8M\\SQLEXPRESS01;Initial Catalog=HospitalDB;Integrated Security=True;TrustServerCertificate=True";
        
        public void AddPatient(Patient patient)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Patients (FirstName, LastName, Gender, Age, Contact, Address, MedicalHistory) VALUES (@FirstName, @LastName, @Gender, @Age, @Contact, @Address, @MedicalHistory)", con);
                cmd.Parameters.AddWithValue("@FirstName", patient.FirstName);
                cmd.Parameters.AddWithValue("@LastName", patient.LastName);
                cmd.Parameters.AddWithValue("@Gender", patient.Gender);
                cmd.Parameters.Add("@Age", SqlDbType.Int).Value = patient.Age;
                cmd.Parameters.AddWithValue("@Contact", patient.Contact);
                cmd.Parameters.AddWithValue("@Address", patient.Address);
                cmd.Parameters.AddWithValue("@MedicalHistory", patient.MedicalHistory);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}