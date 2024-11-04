using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TinyTotsWebApp.Models;

namespace TinyTotsWebApp
{
    public partial class EditRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Get the RegistrationId from the query string
                int registrationID = Convert.ToInt32(Request.QueryString["registrationID"]);

                // Load the data for the specific registration
                LoadRegistration(registrationID);
            }
        }

        private void LoadRegistration(int registrationID)
        {
            using (var db = new TinyTotsDBContext()) 
            {
                var registration = db.TinyTotsTable.SingleOrDefault(c=>c.RegistrationId == registrationID);

                if (registration != null) 
                {
                    hfRegistrationId.Value = registration.RegistrationId.ToString();
                    txtFirstName.Text = registration.FirstName;
                    txtSecondName.Text = registration.SecondName;
                    ddlRace.SelectedValue = registration.Race;
                    rblGender.SelectedValue = registration.Gender;

                    //Populate the allergies CheckBoxList
                    string[] allergies = registration.FoodAllergies.Split(new[]{","},StringSplitOptions.None);
                    foreach (ListItem item in cblAllergies.Items) 
                    {
                        item.Selected = true;
                    }
                }
            }
        }

        //Method to handle the Save button clcik event
        protected void btnEdit_Click(object sender, EventArgs e) 
        {
            int registrationId = Convert.ToInt32(hfRegistrationId.Value);

            using (var db = new TinyTotsDBContext()) 
            {
                var registrationToUpdate = db.TinyTotsTable.SingleOrDefault(c=>c.RegistrationId==registrationId);

                if (registrationToUpdate != null) 
                {
                    // Update the properties with the values from the form fields
                    registrationToUpdate.FirstName = txtFirstName.Text;
                    registrationToUpdate.SecondName = txtSecondName.Text;
                    registrationToUpdate.Race = ddlRace.SelectedValue;
                    registrationToUpdate.Gender = rblGender.SelectedValue;

                    //Update the Food Allergies
                    registrationToUpdate.FoodAllergies = string.Join(",", cblAllergies.Items.Cast<ListItem>().Where(i=>i.Selected).Select(i=>i.Value));

                    //Save changes to databases
                    db.SaveChanges();

                    //Show success message
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Update failed!');",true);

                    //Redirect to registrationList.aspx after update
                    Response.Redirect("RegistrationList.aspx");
                }
            }
        }
    }
}