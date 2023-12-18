<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Forgotpassd.aspx.cs" Inherits="Hotel_Booking_System.LRfile.Forgotpassd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Forgot Passwoard</title>
     <!-- meta tags -->
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta name="keywords" content="Art Sign Up Form Responsive Widget, Audio and Video players, Login Form Web Template, Flat Pricing Tables, Flat Drop-Downs, Sign-Up Web Templates, 
		Flat Web Templates, Login Sign-up Responsive Web Template, Smartphone Compatible Web Template, Free Web Designs for Nokia, Samsung, LG, Sony Ericsson, Motorola Web Design"
    />
    <!-- /meta tags -->
    <!-- custom style sheet -->
    <link href="css/style.css" rel="stylesheet" type="text/css" />
    <!-- /custom style sheet -->
    <!-- fontawesome css -->
    <link href="css/fontawesome-all.css" rel="stylesheet" />
    <!-- /fontawesome css -->
    <!-- google fonts-->
    <link href="//fonts.googleapis.com/css?family=Raleway:100,100i,200,200i,300,300i,400,400i,500,500i,600,600i,700,700i,800,800i,900,900i"
        rel="stylesheet"/>
    <!-- /google fonts-->
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <h1>Online Hotel Booking </h1>
    <div class=" w3l-login-form">
        <h2>Forgot Password Here</h2>
        <form action="#" method="POST">           
           <div class=" w3l-form-group">
                <label>Mobile:</label>
                <div class="group">
                    <i class="fas fa-user"></i>
                    <asp:TextBox ID="txt_fpass_mobile" class="form-control" placeholder="Mobile Number" runat="server"></asp:TextBox>
                    
                </div>
            </div>
            
            
            <div class=" w3l-form-group">
                <label>Email ID:</label>
                <div class="group">
                    <i class="fas fa-user"></i>
                    <asp:TextBox ID="txt_fpasss_email" class="form-control" placeholder="Email ID" runat="server"></asp:TextBox>
                    
                </div>
            </div>
            
            
            <div class=" w3l-form-group">
                <label>Password:</label>
                <div class="group">
                    <i class="fas fa-unlock"></i>
                     <asp:TextBox ID="txt_new_password" TextMode="Password" class="form-control" placeholder="New Password" runat="server"></asp:TextBox>
                    
                </div>
            </div>
            
              <div class=" w3l-form-group">
                <label>Confirm Password:</label>
                <div class="group">
                    <i class="fas fa-unlock"></i>
                     <asp:TextBox ID="txt_c_pass" TextMode="Password" class="form-control" placeholder="Con Password" runat="server"></asp:TextBox>
                  
                </div>
            </div>
            
            <div class="forgot">
              
                <p>
                   <%-- <asp:CheckBox ID="CheckBox1" runat="server" />Remember Me--%></p>
            </div>
            <asp:Button ID="btn_Forgot_password" runat="server" Text="Forgot Password" BackColor="Blue" 
                Font-Bold="True" Font-Size="Medium" ForeColor="#FFFFCC" OnClick="btn_Forgot_password_Click" 
               />
          
        </form>
        <p class=" w3l-register-p">
            <asp:Button ID="btn_Forgot_signin" runat="server" Text="Sign In" BackColor="Blue" 
                Font-Bold="True" Font-Size="Medium" ForeColor="#FFFFCC" OnClick="btn_Forgot_signin_Click" 
               />
    </div>
    <footer>
        <p></p>
    </footer>
        </div>
    </form>
</body>
</html>
