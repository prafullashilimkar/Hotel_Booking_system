<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="homepage.aspx.cs" Inherits="Hotel_Booking_System.Hotel.homepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home Page </title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="keywords" content="Hotel Booking Widget Responsive, Login Form Web Template, Flat Pricing Tables, Flat Drop-Downs, Sign-Up Web Templates, Flat Web Templates, Login Sign-up Responsive Web Template, Smartphone Compatible Web Template, Free Web Designs for Nokia, Samsung, LG, Sony Ericsson, Motorola Web Design" />
<script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
<!-- //For-Mobile-Apps -->

<!-- Style --> <link rel="stylesheet" href="css/style.css" type="text/css" media="all" />
    
</head>
<body class="body2">
    <form id="form1" runat="server">
        <div class="homepage-container">
        <div class="centered-image">
          <asp:Image ID="Image1" runat="server" Height="141px" ImageAlign="Left" ImageUrl="~/Hotel/images/logo.jpg" Width="142px" />  

        </div>
        <div class="home-line">
                 <h1 style="text-decoration: blink; color: #FFFFFF; text-align: center; width: 519px;">Book. Stay. Enjoy.</h1>
            </div>
      
        <div class="home-buttons">
        
            <asp:Button ID="Button1" runat="server" BackColor="#CC6600" BorderColor="#FFCC00" Font-Bold="True" Font-Underline="True" ForeColor="#FF9900" OnClick="Button1_Click" Text="Book Now" CssClass="golden-button" 
            OnMouseOver="this.style.backgroundColor='#FFD700'; this.style.transform='translate(0, -2px) scale(1.05)'; this.style.boxShadow='0 4px 6px rgba(0, 0, 0, 0.1)';"
    OnMouseOut="this.style.backgroundColor='#CC6600'; this.style.transform='none'; this.style.boxShadow='none';" />
               <asp:Button ID="Button2" runat="server" BackColor="#CC6600" BorderColor="#FFCC00" Font-Bold="True" Font-Underline="True" ForeColor="#FF9900" OnClick="Button2_Click" Text="Feedback" CssClass="golden-button" 
            OnMouseOver="this.style.backgroundColor='#FFD700'; this.style.transform='translate(0, -2px) scale(1.05)'; this.style.boxShadow='0 4px 6px rgba(0, 0, 0, 0.1)';"
    OnMouseOut="this.style.backgroundColor='#CC6600'; this.style.transform='none'; this.style.boxShadow='none';" />
        
        </div>
         
      </div>
        
    </form>
</body>
</html>
