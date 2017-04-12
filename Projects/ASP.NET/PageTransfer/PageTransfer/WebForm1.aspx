<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="PageTransfer.WebForm1" %>

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
        Enter your name:<br />
        <asp:TextBox ID="tbName" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnGo" runat="server" Text="Go" OnClick="btnGo_Click" />
    
        <br />
        <br />
        <asp:Button ID="btnSait" runat="server" OnClick="btnSait_Click" Text="Go to SAIT" />
    
    </div>
    </form>
</body>
</html>
