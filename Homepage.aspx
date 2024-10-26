<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="TinyTotsWebApp.Home_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%Response.Write("Welcome to TinyTots Kindergarten"); %> <br />
            <%Response.Write("Description of your web."); %>
        </div>

        <asp:Label ID="MyLabel" runat="server" Text="Time and date will be displayed here"></asp:Label>

        <h2 style="color:green">Kindergarten Registration Form</h2>
        <asp:Label ID="Label1" runat="server" Text="First Name: "></asp:Label>
        <asp:TextBox ID="fname" runat="server"></asp:TextBox><br /><br />
        <asp:Label ID="Label2" runat="server" Text="Second Name: "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br /><br />
        <asp:Label ID="Label3" runat="server" Text="Race: "></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem >Choose</asp:ListItem>
            <asp:ListItem>Malay</asp:ListItem>
            <asp:ListItem>Chinese</asp:ListItem>
            <asp:ListItem>Indian</asp:ListItem>
        </asp:DropDownList><br /><br />
        <asp:Label ID="Label4" runat="server" Text="Gender: "></asp:Label>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem runat="server">Male</asp:ListItem>
            <asp:ListItem runat="server">Female</asp:ListItem>
        </asp:RadioButtonList><br />
        <asp:Label ID="Label5" runat="server" Text="Food allergies: "></asp:Label>
        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
            <asp:ListItem>None</asp:ListItem>
            <asp:ListItem>Dairy Product</asp:ListItem>
            <asp:ListItem>Peanut and Tree Nuts</asp:ListItem>
            <asp:ListItem>Soybean</asp:ListItem>
            <asp:ListItem>Wheat</asp:ListItem>
        </asp:CheckBoxList><br />

        <asp:Button ID="Button1" runat="server" Text="Submit" />
    </form>
</body>
</html>
