using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using System.Net.Mail;
using System.Net;

namespace Hotel_Booking_System.Hotel
{
    public partial class MainBooking : System.Web.UI.Page
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=G:\Hotel Booking System\HotelBook.mdb");
        OleDbCommand cmd;
        String str;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
            int id2 = 0;
            String str1 = "select max(RID) as RID from BookingTbl";
            OleDbDataAdapter da = new OleDbDataAdapter(str1, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            
            //id2 = 1;

            //if (id2 > 1)
            if (ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0]["RID"] != DBNull.Value)
            {
                id2 = int.Parse(ds.Tables[0].Rows[0]["RID"].ToString());
                id2++;
            }
            else
            {

                id2 = 1;
            }
            lblbid.Text = id2.ToString();
            if (!IsPostBack)
            {
                // Check if the "hotelName" query string parameter is present
                if (!string.IsNullOrEmpty(Request.QueryString["hotel"]))
                {
                    string selectedHotel = Request.QueryString["hotel"];

                    // Set the label's text to the selected hotel name
                    lblHotelName.Text = "Welcome To hotel " + selectedHotel;
                }
            }
        }

        protected void Bt_submit_Click(object sender, EventArgs e)
        {

            try
            {
               
                str = "insert into BookingTbl values(" + lblbid.Text + ",'" + DropDownList1.SelectedValue + " ' ,'" + DropDownList2.SelectedValue + "','" + DropDownList3.SelectedValue + "','" + datepicker1.Text + "','" + datepicker2.Text + "','" + RadioButtonList1.SelectedValue + "','" + txt_fulname.Text + "')";
                cmd = new OleDbCommand(str, con);
                cmd.ExecuteNonQuery();

                Response.Write("<script>alert('Booking Successfully..')</script>");
                con.Close();
                

            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.Port = 587; // Use the correct port number for your server
            smtpClient.EnableSsl = true; // Enable SSL/TLS encryption
            smtpClient.Credentials = new NetworkCredential("hbooking1610@gmail.com", "sqwj mmci yjwj kqcc");
            string customerName = GetCustomerName(txt_fulname.Text); // Replace with your actual method
            string selectedHotel = Request.QueryString["hotel"];
            

            // Construct the email body with dynamic data
            string emailBody = $"Dear {txt_fulname.Text},\n\n"
                + $"Your booking for hotel   {selectedHotel}  from date  {datepicker1.Text} to {datepicker2.Text} has been confirmed.\n\n" 
                + "Thank you for choosing our services!\n\nBest regards,\nThe Booking Team";
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress("hbooking1610@gmail.com");
                mail.To.Add("shilimkarp123@gmail.com");
               
                mail.Subject = "Booking Confirmation";
                //mail.Body = "Message Body";
                mail.Body = emailBody;

                try
                {
                    smtpClient.Send(mail);
                    Response.Write("<script>alert('Email sent successfully')</script>");
                    // Email sent successfully
                }
                catch (SmtpException ex)
                {
                    Response.Write("<script>alert('Email Issue....')</script>" + ex.ToString());
                    Console.WriteLine("Error: " + ex.ToString());
                    // Handle the exception, e.g., log or display an error message
                }
            }
        }
        protected void Button_print_Click1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblbid.Text) ||
        string.IsNullOrWhiteSpace(DropDownList1.SelectedValue) ||
        string.IsNullOrWhiteSpace(DropDownList2.SelectedValue) ||
        string.IsNullOrWhiteSpace(DropDownList3.SelectedValue) ||
        string.IsNullOrWhiteSpace(datepicker1.Text) ||
        string.IsNullOrWhiteSpace(datepicker2.Text) ||
        string.IsNullOrWhiteSpace(RadioButtonList1.SelectedValue) ||
        string.IsNullOrWhiteSpace(txt_fulname.Text))
            {
                Response.Write("<script>alert('Please Fill all Details')</script>");
            }
            else
            {
                string cuisine = RadioButtonList1.SelectedItem.Text;
                string suit = DropDownList3.SelectedItem.Text;
                // All fields are filled, so initiate the print operation
                string printScript = "<script type='text/javascript'>"
              + "var printContents = '<div style=\"border: 2px solid #000; padding: 10px;\">'"
              + "+ '<h2>Booking Confirmation</h2>'"
              + "+ '<p><strong>Name:</strong> " + txt_fulname.Text + "</p>'"
              + "+ '<p><strong>Hotel Name:</strong> " + lblHotelName.Text + "</p>'"
              + "+ '<p><strong>Suit:</strong> " + DropDownList3.SelectedValue  + "</p>'"
              + "+ '<p><strong>No Adult:</strong> " + DropDownList1.SelectedItem + "</p>'"
              + "+ '<p><strong>No children:</strong> " +DropDownList2.SelectedItem + "</p>'"
              + "+ '<p><strong>Cuisine:</strong> " + RadioButtonList1.SelectedItem + "</p>'"
              + "+ '<p><strong>Chek In Date:</strong> " + datepicker1.Text + "</p>'"
              + "+ '<p><strong>Chek Out Date:</strong> " + datepicker2.Text + "</p>'"
              + "+ '<p>Thank you</p>'"
              + "+ '</div>';"
              + "var printWindow = window.open('', '', 'width=600,height=600');"
              + "printWindow.document.open();"
              + "printWindow.document.write(printContents);"
              + "printWindow.document.close();"
              + "printWindow.print();"
              + "printWindow.close();"
              + "</script>";
              ClientScript.RegisterStartupScript(this.GetType(), "Print", printScript);
                //Page.ClientScript.RegisterStartupScript(this.GetType(), "Print", "window.print();", true);
            }
        }
        protected void CustomDateValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (string.IsNullOrEmpty(datepicker1.Text))
            {
                // No date selected, validation fails
                args.IsValid = false;
                return;
            }

            // Parse the entered date
            if (DateTime.TryParse(datepicker1.Text, out DateTime selectedDate))
            {
                // Compare the selected date with the current date
                if (selectedDate < DateTime.Today)
                {
                    // Selected date is in the past, validation fails
                    args.IsValid = false;
                }
                else
                {
                    // Selected date is in the future, validation pass
                    args.IsValid = true;
                }
            }
            else
            {
                // Invalid date format, validation fails
                args.IsValid = false;
            }
        }
        private string GetCustomerName(string userName)
        {
            //Assuming you are using OleDb to connect to a database. Replace with your actual connection and query.
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=G:\Hotel Booking System\HotelBook.mdb";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                string query = "SELECT Uname FROM UserTbl WHERE Uname = @userName";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userName", userName);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    connection.Close();
                    return result != null ? result.ToString() : string.Empty;
                }
            }
        }        
    }
}
