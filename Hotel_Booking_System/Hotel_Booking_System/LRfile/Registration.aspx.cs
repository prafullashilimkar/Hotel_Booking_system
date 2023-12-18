using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;

namespace Hotel_Booking_System.LRfile
{
    public partial class Registration : System.Web.UI.Page
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=G:\Hotel Booking System\HotelBook.mdb");
        OleDbCommand cmd;
        string str;
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataSet ds = new DataSet();
       

        protected void Page_Load(object sender, EventArgs e)

        {
            con.Open();
            int id1 = 0;
            str = "select max(UID) as UID from UserTbl";
            da = new OleDbDataAdapter(str, con);
            da.Fill(ds);

            id1 = 1;

            if (ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0]["UID"] != DBNull.Value)
            {
                id1 = int.Parse(ds.Tables[0].Rows[0]["UID"].ToString());
                id1++;
            }
            else
            {
                id1 = 1;
            }

            lblid.Text = id1.ToString();

            if (!IsPostBack)
            {
                // Initialize the event handler when the page is loaded for the first time.
                txt_username.TextChanged += new EventHandler(this.txt_username_TextChanged);
            }

        }



        protected void Btn_submit_Click(object sender, EventArgs e)
        {


            try { 
               string enteredUsername = txt_username.Text;

                if (IsUsernameDuplicate(enteredUsername))
                {
                    Response.Write("<script>alert('Username is already in use. Please choose a different one.')</script>");
                }
                else
                {
                    string str1 = "insert into UserTbl values(" + lblid.Text + ",'" + txt_username.Text + "'," + txt_mobile.Text + ",'" + txt_email.Text + "','" + txt_password.Text + "','" + txt_name.Text + "')";
                    cmd = new OleDbCommand(str1, con);
                    cmd.ExecuteNonQuery();

                    Response.Write("<script>alert('Registration Successfully')</script>");
                    con.Close();
                    Response.Write("../LRfile/Login.aspx");


                }
            }
             catch (Exception ex)
             {
                 Response.Write("<script>alert('Please fill All field')</script>");
                Response.Write(ex.ToString());
             }

        }


        protected void txt_username_TextChanged(object sender, EventArgs e)
        {
            string enteredUsername = txt_username.Text;

            if (IsUsernameDuplicate(enteredUsername))
            {
                // Username is a duplicate; set the error message in the label.
                errorLabel.Text = "Username is already in use. Please choose a different one.";
            }
            else
            {
                // Clear the error message if validation passes.
                errorLabel.Text = "";
            }
        }
        private bool IsUsernameDuplicate(string username)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Highrsie DOC\Prafulla\Hotel Booking System\Hotel Booking System\HotelBook.mdb";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                // Define a SQL query to check for duplicate usernames.
                string query = "SELECT COUNT(*) FROM UserTbl WHERE Uname = @Username";

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Uname", username);

                    int count = (int)command.ExecuteScalar();

                    // If count is greater than 0, the username is a duplicate.
                    return count > 0;
                }
            }
        }
        
    }
}
