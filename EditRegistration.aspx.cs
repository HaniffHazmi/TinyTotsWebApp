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
                }
            }
        }
    }
}