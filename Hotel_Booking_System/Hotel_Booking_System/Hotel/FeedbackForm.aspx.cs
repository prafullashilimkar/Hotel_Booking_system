using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hotel_Booking_System.LRfile
{
    public partial class FeedbackForm : System.Web.UI.Page
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=G:\Hotel Booking System\HotelBook.mdb");
        OleDbCommand cmd1;
        String str;
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
            int id1 = 0;
            str = "select max(ID) as ID from FeedbackTbl";
            da = new OleDbDataAdapter(str, con);
            da.Fill(ds);

            id1 = 1;

            if (ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0]["ID"] != DBNull.Value)
            {
                id1 = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                id1++;
            }
            else
            {
                id1 = 1;
            }
            lblid1.Text = id1.ToString();
        }
        private void Clear()

        {
            txtName.Text = string.Empty;
            txtSubject.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtInquiry.Text = string.Empty;
        }
        private void EmailFeedback()

        {
            //create the mail message
            MailMessage mail = new MailMessage();

            //set the addresses
            mail.From = new MailAddress(txtEmail.Text.Trim());
            mail.To.Add("anwar@csharpexample.com");

            //set the content
            mail.Subject = "Enquiry Form";

            //Body to be displayed
            mail.Body = "<h2>" + "Enquiry from " + " " + txtName.Text + "</h2>" + "<br><br>" +
                    "Subject: " + txtSubject.Text + "<br>" +
                    "Email : " + txtEmail.Text.Trim() + "<br>" +
                    "InQuiry: " + txtInquiry.Text.Trim() + "<br>" +
                    "Thank You";

            mail.IsBodyHtml = true;

            // smtp settings

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");

            NetworkCredential SMTPUserInfo = new NetworkCredential("anwar@csharpexample.com", "Aic12234@");

            smtp.Credentials = SMTPUserInfo;

            smtp.Send(mail);

        }
        protected void btnSubmit_Click1(object sender, EventArgs e)
        {
            // EmailFeedback();

            lblMsg.ForeColor = Color.Green;

            try { 

            string str1 = "insert into FeedbackTbl values(" + lblid1.Text + ",'" + txtName.Text + "','" + txtSubject.Text + "','" + txtEmail.Text + "','" + txtInquiry.Text + "')";
            cmd1 = new OleDbCommand(str1, con);
            cmd1.ExecuteNonQuery();
            con.Close();

            Clear();

             lblMsg.Text = "Thank You for Your Feedback";
                Response.Write("<script>alert('Thank You for Your feedback')</script>");

                //Response.Redirect("../Hotel/homepage.aspx");
            }
              catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }
        }
    }
}