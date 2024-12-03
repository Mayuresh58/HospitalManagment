using HospitalManagment.DAL.HospitalManagment.Models;
using HospitalManagment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HospitalManagment.DAL;
using HospitalManagment.Models;


namespace HospitalManagment.Web_Pages
{
    public partial class Billings : System.Web.UI.Page
    {
      
        
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            HospitalManagment.Models.Billing billing = new HospitalManagment.Models.Billing
            {
                PatientID = int.Parse(TxtPatientID.Text),
                Amount = decimal.Parse(txtAmount.Text),
                PaymentStatus = ddlPaymentStatus.SelectedValue,
                PaymentDate = DateTime.Now
            };
           
            BillingDAL billingDAL = new BillingDAL();
            billingDAL.AddBill(billing);

            // Show success message or clear form
        }
    }
}