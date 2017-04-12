<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Results.aspx.cs" Inherits="Mo_Xue_Lab_2.Results" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Voting Results</title>
    <link href="PartyStyle.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <strong><span class="Heading">Current Voting Results:</span></strong>
        <br />
        <img alt="imgFrog" class="Banner" src="frog.gif" /><br />
        <br />
    </div>
        <asp:Label ID="lblChoice1" runat="server" Text="Label"></asp:Label>
        <br/>
        <asp:TextBox ID="tbResult1" runat="server" Enabled="False"></asp:TextBox>
        <br/>
        <br/>
        <asp:Label ID="lblChoice2" runat="server" Text="Label"></asp:Label>
        <br/>
        <asp:TextBox ID="tbResult2" runat="server" Enabled="False"></asp:TextBox>
        <br/>
        <br/>
        <asp:Label ID="lblChoice3" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:TextBox ID="tbResult3" runat="server" Enabled="False"></asp:TextBox>
        <br />
        <br/>
        <asp:Button ID="btnReturn" runat="server" OnClick="btnReturn_Click" Text="Return" />
    </form>
</body>
</html>
