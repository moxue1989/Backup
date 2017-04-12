<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="StateDemo.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        I am on page 2<br />
        <br />
        <asp:Label ID="lblClicks" runat="server" Text="Clicks"></asp:Label>
        <br />
        <asp:TextBox ID="txtClicks" runat="server" Enabled="False"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnClick" runat="server" OnClick="btnClick_Click" Text="Click Me!" />
        <br />
        <br />
        <asp:Button ID="btnGoBack" runat="server" PostBackUrl="~/WebForm1.aspx" Text="Go Back" />
    
    </div>
    </form>
</body>
</html>
