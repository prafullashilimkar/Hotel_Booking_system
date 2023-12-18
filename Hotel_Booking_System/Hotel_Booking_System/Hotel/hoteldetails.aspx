<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="hoteldetails.aspx.cs" Inherits="Hotel_Booking_System.Hotel.hoteldetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="keywords" content="Hotel Booking Widget Responsive, Login Form Web Template, Flat Pricing Tables, Flat Drop-Downs, Sign-Up Web Templates, Flat Web Templates, Login Sign-up Responsive Web Template, Smartphone Compatible Web Template, Free Web Designs for Nokia, Samsung, LG, Sony Ericsson, Motorola Web Design" />
<script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
<!-- //For-Mobile-Apps -->

<!-- Style --> <link rel="stylesheet" href="css/style.css" type="text/css" media="all" />
</head>
<body runat="server" id="body">
    <form id="form1" runat="server">
       <div class="hotel-container">
        <div class="hotel-video">
            <video autoplay ="autoplay" loop="loop">
                <source id="videoSource" runat="server" type="video/mp4" />
            </video>
        </div>
        <div class="hotel-info">
            <h1 id="hotelTitle" runat="server" style="color: #FFFFFF">Welcome to Hayatt</h1>
            <p id="hotelDescription" runat="server" aria-orientation="horizontal" style="color: #FFFFFF">
                Experience the charm, well-suited for business and leisure travel. Explore open, relaxed spaces at our downtown hotel, close to the airport. Well-appointed rooms offer large windows and in-room amenities. Experience wellness and varied cuisine, set in serenity.
            </p>
        </div>
        <div class="hotel-buttons">
            <asp:Button ID="btnBook" runat="server" Text="Book Now" CssClass="hotel-button" OnClick="btnBook_Click" Font-Bold="True" BorderStyle="Groove" BackColor="#FFCC00" BorderColor="#FF9900" BorderWidth="5" />
            <asp:Button ID="btnBack" runat="server" Text="Back" CssClass="hotel-button" OnClick="btnBack_Click" Font-Bold="True" BorderStyle="Groove" BackColor="#FFCC00" BorderColor="#FF9900" BorderWidth="5" />
        </div>
    </div>
            
     </form>   
    
   
    </body>
</html>
