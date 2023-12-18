using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.OleDb;


namespace Hotel_Booking_System.Hotel
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=G:\Hotel Booking System\HotelBook.mdb");
            OleDbCommand cmd;
            OleDbDataAdapter da = new OleDbDataAdapter();
            DataTable dt = new DataTable();

            string str = "select Uname,Pass from UserTbl where Uname='" + txt_login_username.Text + "'and Pass='" + txt_login_password.Text + "'";
            da = new OleDbDataAdapter(str, con);
            da.Fill(dt);
            
            if(dt.Rows.Count > 0)

            {
                Session["Username"] = txt_login_username.Text;
                Response.Redirect("../Hotel/Masteruser.aspx");
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("../LRfile/Registration.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("../LRfile/Forgotpassd.aspx");
        }
    }
}