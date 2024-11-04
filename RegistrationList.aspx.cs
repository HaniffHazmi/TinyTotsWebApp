using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TinyTotsWebApp.Models;

namespace TinyTotsWebApp
{
    public partial class RegistrationList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            using (var db = new TinyTotsDBContext())
            {
                //Just bind all the data in TinyTotsTable as all records are considered registered
                gvRegistrations.DataSource = db.TinyTotsTable.ToList();
                gvRegistrations.DataBind();
            }
        }

        //Handle delete operation
        protected void gvRegistrations_RowDeleting(object sender, GridViewRowEventArgs e)
        {
            //int registerationId = Convert.ToInt32(gvRegistrations.DataKeys[e.RowIndex].Value);
            int registerationId = (int)e.Keys["RegistrationId"];//Assuming Registration Id is an int.

            using (var db = new TinyTotsDBContext())
            {
                //Find and remocve the record with the specified RegistrationId
                var RecordToDelete = db.TinyTotsTable.FirstOrDefault(r => r.RegistrationId == registerationId);
                if (RecordToDelete != null)
                {
                    db.TinyTotsTable.Remove(RecordToDelete);
                    db.SaveChanges();
                }
            }
            //Rebind the GridView to reflect the changes
            BindGrid();
        }
    }
}