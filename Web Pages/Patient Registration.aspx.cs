using HospitalManagment.DAL.HospitalManagment.Models;
using HospitalManagment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HospitalManagment.DAL;


namespace HospitalManagment.Web_Pages
{
    public partial class Patient_Registration : System.Web.UI.Page
    {
    
        protected void txtButton_Click(object sender, EventArgs e)
        {
            

            Patient patient = new Patient
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Gender = lblGender.Text,
                Age = int.Parse(txtAge.Text),
                Contact = txtContact.Text,
                Address = txtAddress.Text,
                MedicalHistory = txtMedicalHistory.Text
            };


            PatientDAl patientDAL = new PatientDAl();
            patientDAL.AddPatient(patient);

            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAge.Text = "";
            lblGender.Text = "";
            txtAddress.Text = "";
            txtContact.Text = "";
            txtMedicalHistory.Text = "";
        }
    }
}