<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Hotel_Booking_System.LRfile.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sign Up</title>
      !-- meta tags -->
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
             <h1>Online Hotel Booking Registration</h1>
    <div class=" w3l-login-form">
        <h2>Sign Up Here</h2>
        <form action="#" method="POST">
            
            <div class=" w3l-form-group">
                <label>ID:</label>
                <div class="group">
                    <i class="fas fa-user"></i>
                    <asp:Label ID="lblid"  runat="server" Text="Label"></asp:Label>
                    
                </div>
            </div>
            <div class=" w3l-form-group">
                <label>name:</label>
                <div class="group">
                    <i class="fas fa-user"></i>
                    <asp:TextBox ID="txt_name" class="form-control" placeholder="Full name" runat="server"></asp:TextBox>
                    <%--<input type="text" class="form-control" placeholder="Username" required="required" />--%>
                </div>
            </div>
            
            <div class=" w3l-form-group">
                <label>Mobile:</label>
                <div class="group">
                    <i class="fas fa-user"></i>
                    <asp:TextBox ID="txt_mobile" class="form-control" placeholder="Mobile Number" runat="server"></asp:TextBox>
     
                </div>
            </div>

            <div class=" w3l-form-group">
                <label>Email ID:</label>
                <div class="group">
                    <i class="fas fa-user"></i>
                    <asp:TextBox ID="txt_email" class="form-control" placeholder="Email ID" runat="server"></asp:TextBox>
                    
                </div>
            </div>

            <div class=" w3l-form-group">
                <label>Username:</label>
                <div class="group">
                    <i class="fas fa-user"></i>
                    <asp:TextBox ID="txt_username" class="form-control" placeholder="Username" runat="server" OnTextChanged="txt_username_TextChanged"></asp:TextBox>
                    <%--<input type="text" class="form-control" placeholder="Username" required="required" />--%>
                </div>
            </div>
            
            
            <div class=" w3l-form-group">
                <label>Password:</label>
                <div class="group">
                    <i class="fas fa-unlock"></i>
                     <asp:TextBox ID="txt_password" TextMode="Password" class="form-control" placeholder="Password" runat="server"></asp:TextBox>
                   
                </div>
            </div>
            
              <div class=" w3l-form-group">
                <label>Confirm Password:</label>
                <div class="group">
                    <i class="fas fa-unlock"></i>
                     <asp:TextBox ID="txt_cpass" TextMode="Password" class="form-control" placeholder="Confirm Password" runat="server"></asp:TextBox>
                
                </div>
            </div>
            
            <div class="forgot">
              
                <p>
                    <asp:CheckBox ID="CheckBox1" runat="server" />Remember Me</p>
            </div>
            <asp:Button ID="Btn_submit" runat="server" Text="Registration" BackColor="Blue" 
                Font-Bold="True" Font-Size="Medium" ForeColor="#FFFFCC" 
                onclick="Btn_submit_Click" />

            <asp:Label ID="errorLabel" runat="server" ForeColor="Red"></asp:Label>

          
        </form>
        <p class=" w3l-register-p">Sign IN<a href="Login.aspx" class="register"> Login</a></p>
    </div>
    <footer>
        <p></p>
    </footer>

        </div>
    </form>
</body>
</html>
