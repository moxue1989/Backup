<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Mo_Xue_Lab_2.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Party Voter</title>
    <link href="PartyStyle.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <strong><span class="Heading">Good Time Celebration Party</span></strong><br />
        <br />
        <img alt="imgSpaceship" class="Banner" src="spaceship.gif" /><br />
        <br />
        Select a date and cast your vote:</div>
        <div class="Calender"><asp:Calendar ID="Calender" runat="server" OnDayRender="Calendar1_DayRender" OnSelectionChanged="Calender_SelectionChanged"></asp:Calendar></div>
        <br />
        <asp:Label ID="lblDate" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnVote" runat="server" OnClick="btnVote_Click" Text="Vote!" />
    </form>
</body>
</html>
