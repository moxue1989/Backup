<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="StateDemo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        I am on page 1<br />
        <br />
        <asp:Label ID="lblClicks" runat="server">Clicks:</asp:Label>
        <br />
        <asp:TextBox ID="txtClicks" runat="server" Enabled="False"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnClick" runat="server" OnClick="btnClick_Click" Text="Click Me!" />
        <br />
        <br />
        <asp:Button ID="btnGo" runat="server" PostBackUrl="~/WebForm2.aspx" Text="Go" />
    
    </div>
    </form>
</body>
</html>
