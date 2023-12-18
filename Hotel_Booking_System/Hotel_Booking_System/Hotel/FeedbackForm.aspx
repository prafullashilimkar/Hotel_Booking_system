<%@ Page Language="C#" UnobtrusiveValidationMode="None"AutoEventWireup="true" CodeBehind="FeedbackForm.aspx.cs" Inherits="Hotel_Booking_System.LRfile.FeedbackForm" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Feedback form</title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="keywords" content="Hotel Booking Widget Responsive, Login Form Web Template, Flat Pricing Tables, Flat Drop-Downs, Sign-Up Web Templates, Flat Web Templates, Login Sign-up Responsive Web Template, Smartphone Compatible Web Template, Free Web Designs for Nokia, Samsung, LG, Sony Ericsson, Motorola Web Design" />
<script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
<!-- //For-Mobile-Apps -->

<!-- Style --> <link rel="stylesheet" href="css/style.css" type="text/css" media="all" />
    </head>
<body class ="body1">
    <center>
    <form id="form1" runat="server">

    <div class =">

        <fieldset style="width: 40%;" >

            <legend>Feedback</legend>
            Form
            <asp:Label ID="lblid1"  runat="server" Text="Label"></asp:Label>

            <table cellpadding="2" cellspacing="5" aria-orientation="horizontal">

               

                <tr>

                    <td width="100px">

                    </td>

                    <td>

                    </td>

                </tr>

                <tr>

                    <td width="80px">

                        Name<span style="color: #CC3300"> *</span>

                    </td>

                    <td>

                        <asp:TextBox ID="txtName" runat="server" Width="200px"></asp:TextBox>

                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"

                            ErrorMessage="Name Required" ForeColor="#FF3300"

                            ControlToValidate="txtName"></asp:RequiredFieldValidator>

                    </td>

                </tr>

                <tr>

                    <td>

                        Subject <span class="style1">*</span>

                    </td>

                    <td>

                        <asp:TextBox ID="txtSubject" runat="server" Width="200px"></asp:TextBox>

                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"


                            ErrorMessage="Subject Required" ForeColor="#FF3300"


                            ControlToValidate="txtSubject"></asp:RequiredFieldValidator>

                    </td>

                </tr>

                <tr>

                    <td>

                        E-mail<span style="color: #CC3300"> *</span>

                    </td>

                    <td>

                        <asp:TextBox ID="txtEmail" runat="server" Width="300px"></asp:TextBox>

                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"

                            ErrorMessage="Email Required" ForeColor="#FF3300"

                            ControlToValidate="txtEmail"></asp:RequiredFieldValidator>

                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"

                            ErrorMessage="Not a valid email" ControlToValidate="txtEmail"

                            ForeColor="#FF3300"

                            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>

                    </td>

                </tr>

                <tr>

                    <td>

                        Discription</td>

                    <td>

                        <asp:TextBox ID="txtInquiry" runat="server" Height="100px" TextMode="MultiLine" Width="400px"></asp:TextBox>

                    </td>

                </tr>

                <tr>

                    <td>

                        &nbsp;

                    </td>

                    <td>

                        <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>

                    </td>

                </tr>

                <tr>

                    <td>

                        &nbsp;

                    </td>

                    <td>

                        <asp:Button ID="btnSubmit" runat="server" Text="Send" Width="100px" OnClick="btnSubmit_Click1" />

                    </td>

                </tr>

                <tr>

                    <td>

                        &nbsp;

                    </td>

                    <td>

                        &nbsp;

                    </td>

                </tr>

            </table>

        </fieldset>

    </div>

    </form>
        </center>
</body>
</html>
