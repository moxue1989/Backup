<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="PageTransfer.WebForm2" %>

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
        <asp:Label ID="lblDesc" runat="server" Text="Your name is: "></asp:Label>
        <asp:Label ID="lblName" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnGoBack" runat="server" Text="Go Back" OnClick="btnGoBack_Click" />
    
    </div>
    </form>
</body>
</html>
