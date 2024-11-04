<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterChild.aspx.cs" Inherits="TinyTotsWebApp.Home_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Kindergarten Redistration Form</title>
    <style>
        .green-title{
            color:green;
        }

        .form-element{
            margin-bottom:10px;
        }

        .nav-menu{
            background-color:#f1f1f1;
            padding: 10px;
            text-align:center;
        }

        .nav-menu a{
            margin: 0 15px;
            text-decoration: none;
            font-weight: bold;
            color: #333;
        }

        .nav-menu a:hover{
            color:green;
        }

        .grid-container{
            display:flex;
            justify-content:center;
        }

        .grid-container .gridview-style {
            width: 80%; /* Set a desired width, adjust as necessary */
        }

    </style>
</head>
<body>
    <form id="form1" runat="server" class="form-container">

        <div class="nav-menu">
            <a href="RegisterChild.aspx">Register Child</a> |
            <a href="RegistrationList.aspx">Registration List</a>
        </div>

        <h2 style="color:green">Kindergarten Registration Form</h2>
        <asp:HiddenField ID="hfRegistrationId" runat="server" />

        <label for="txtFirstName">First Name:</label>
        <asp:TextBox ID="txtFirstName" runat="server" placeholder="First Name" CssClass="formelement"></asp:TextBox><br /><br />

        <label for="txtSecondName">Second Name:</label>
        <asp:TextBox ID="txtSecondName" runat="server" placeholder="Second Name" CssClass="form-element"></asp:TextBox><br /><br />

        <label for="ddlRace">Race:</label> 
        <asp:DropDownList ID="ddlRace" runat="server" CssClass="form-element">
            <asp:ListItem >Select</asp:ListItem>
            <asp:ListItem Value="Malay">Malay</asp:ListItem>
            <asp:ListItem Value="Chinese">Chinese</asp:ListItem>
            <asp:ListItem Value="Indian">Indian</asp:ListItem>
            <asp:ListItem Value="Other">Other</asp:ListItem>
        </asp:DropDownList><br /><br />

       <label for="rblGender">Gender:</label>
        <asp:RadioButtonList ID="rblGender" runat="server">
            <asp:ListItem runat="server" Value="Male">Male</asp:ListItem>
            <asp:ListItem runat="server" Value="Female">Female</asp:ListItem>
        </asp:RadioButtonList><br />

        <label for="cblAllergies" >Food Allergies:</label>
        <asp:CheckBoxList ID="cblAllergies" runat="server" CssClass="form-element">
            <asp:ListItem>None</asp:ListItem>
            <asp:ListItem Value="Dairy">Dairy</asp:ListItem>
            <asp:ListItem Value="Peanut">Peanut</asp:ListItem>
            <asp:ListItem Value="Soybean">Soybean</asp:ListItem>
            <asp:ListItem Value="Wheat">Wheat</asp:ListItem>
        </asp:CheckBoxList><br />

        <asp:Button ID="btnRegister" runat="server" Text="Register" CssClass="form-element" OnClick="btnRegister_Click" />
        <br />
        <asp:Label ID="MyLabel" runat="server" Text="Time and date will be displayed here"></asp:Label>
    </form>
</body>
</html>
