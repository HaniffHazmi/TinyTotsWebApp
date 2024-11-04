using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TinyTotsWebApp.Models;


namespace TinyTotsWebApp
{
    public partial class Home_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MyLabel.Text = "Hello friends! The time is now " + DateTime.Now.ToString();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            using (var db = new TinyTotsDBContext())
            {
                var registration = new TinyTots
                {
                    FirstName = txtFirstName.Text,
                    SecondName = txtSecondName.Text,
                    Race = ddlRace.SelectedValue,
                    Gender = rblGender.SelectedValue,
                    FoodAllergies = string.Join(",", cblAllergies.Items.Cast<ListItem>().Where(i => i.Selected).Select(i => i.Text))
                };
                
                db.TinyTotsTable.Add(registration);
                db.SaveChanges();
            }
        }
    }
}