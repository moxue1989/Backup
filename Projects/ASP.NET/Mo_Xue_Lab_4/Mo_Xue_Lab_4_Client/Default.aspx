<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Mo_Xue_Lab_4_Client.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: center;
        }
        .auto-style3 {
            font-size: x-large;
            color: #FF0000;
        }
        .auto-style4 {
            font-size: large;
        }
        .auto-style5 {
            font-size: xx-large;
            color: #009900;
        }
        .auto-style6 {
            width: 363px;
            height: 167px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style2">
    <div class="auto-style2">
    
        <div class="auto-style2">
            <strong><span class="auto-style5">Tech Support Incidents<br />
            </span></strong>
            <br />
            <img alt="imgSpace" class="auto-style6" src="spaceship.gif" /><br />
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2"><strong><span class="auto-style4">Select Technician:<br />
                    </span></strong>
                    <br />
                    <asp:DropDownList ID="ddlTech" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlTech_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td class="auto-style2"><strong>OR</strong></td>
                <td class="auto-style2"><strong><span class="auto-style4">Select Customer:<br />
                    </span></strong>
                    <br />
                    <asp:DropDownList ID="ddlCustomer" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlCustomer_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
        <div class="auto-style2">
            <br />
            <br />
            <strong><span class="auto-style3">Here are your Incidents:</span></strong></div>
    
    </div>
            <asp:GridView ID="gvIncidents" runat="server" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                <RowStyle BackColor="White" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#808080" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>
            <asp:Label ID="lblIncidents" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
