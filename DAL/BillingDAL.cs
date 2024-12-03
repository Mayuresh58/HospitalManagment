using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using HospitalManagment.Models;

namespace HospitalManagment.DAL
{
    public class BillingDAL
    {
        string connectionString = "Data Source=DESKTOP-KNL5H8M\\SQLEXPRESS01;Initial Catalog=HospitalDB;Integrated Security=True;TrustServerCertificate=True";

        public void AddBill(Billing billing)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Billing(PatientID,Amount,PaymentStatus,PaymentDate) VALUES(@PatientID,@Amount,@PaymentStatus,@PaymentDate)", con);

                cmd.Parameters.AddWithValue("@PatientID", billing.PatientID);
                cmd.Parameters.AddWithValue("@Amount", billing.Amount);
                cmd.Parameters.AddWithValue("@PaymentStatus",billing.PaymentStatus);
                cmd.Parameters.AddWithValue("@PaymentDate",billing.PaymentDate);

                cmd.ExecuteNonQuery();
                con.Close();

            }
        }
    }
}