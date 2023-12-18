using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

namespace Hotel_Booking_System.LRfile
{
    public partial class Forgotpassd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Forgot_signin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void btn_Forgot_password_Click(object sender, EventArgs e)

        {
        
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=G:\Hotel Booking System\HotelBook.mdb");
            OleDbCommand cmd;
            string str = "select Mobile,Email from UserTbl where Mobile=" + txt_fpass_mobile.Text + "and Email='" + txt_fpasss_email.Text + "'";
            OleDbDataAdapter da = new OleDbDataAdapter(str, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                try
                {
                    con.Open();
                    string str1 = "Update UserTbl set Pass='" + txt_new_password.Text + "'where Mobile=" + txt_fpass_mobile.Text + "and Email='" + txt_fpasss_email.Text + "'";
                    cmd = new OleDbCommand(str1, con);
                    cmd.Parameters.AddWithValue("Pass", txt_new_password.Text);
                    cmd.Parameters.AddWithValue("Mobile", txt_fpass_mobile.Text);
                    cmd.Parameters.AddWithValue("Email", txt_fpasss_email.Text);
                    int rowsUpdated=cmd.ExecuteNonQuery();

                    Response.Write("<script>alert('Forgot Password Successfully..')</script>");
                    
                }
                catch (Exception ex)
                {
                    Response.Write(ex.ToString());
                    con.Close();
                }
            }
        }
    }
}