﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hotel_Booking_System.Hotel
{
    public partial class homepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

     

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("../LRfile/Login.aspx");
            }
            catch
            {
            }

        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("../LRFile/FeedbackForm.aspx");
            }
            catch
            {
            }

        }
    }
}