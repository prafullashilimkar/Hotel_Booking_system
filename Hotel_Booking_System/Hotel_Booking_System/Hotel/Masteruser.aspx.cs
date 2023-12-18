using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hotel_Booking_System.Hotel
{
    public partial class MasterUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Uname"] != null)
                {
                    string Uname = Session["Uname"].ToString();

                    // Now, you have the user's ID, and you can display it as needed.
                    // For example, you can display it in a label or any other control.
                    
                }
                else
                {
                    // User is not logged in or session has expired. Handle as needed.
                }
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Write("Booking.aspx");
        }
    }
}