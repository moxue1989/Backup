<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Mo_Xue_LAB_3.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tech Support</title>
    <link href="StyleSheet.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <span class="header">Tech Support Incidents</span><br />
            <br />
            <img alt="imgSheep" class="image" src="sheep2.gif" /><img alt="imgsheep2" class="image" src="sheep2.gif" /><img alt="imgsheep3" class="image" src="sheep2.gif" /><img alt="imgsheep4" class="image" src="sheep2.gif" /><br />
            <br />
            <div class="subheader">Select Technician:</div><br />
            <br />
            <asp:DropDownList CssClass="dropdown" ID="ddlTechs" runat="server" AutoPostBack="True" DataSourceID="ObjectDataSource1" DataTextField="Name" DataValueField="TechID">
            </asp:DropDownList>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetAllTechnicians" TypeName="Mo_Xue_LAB_3.TechnicianDB"></asp:ObjectDataSource>
            <br />
            <br />
            <br />
            <br />
            <br />
            <div>
                <asp:GridView ID="dvIncidents" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="ObjectDataSource3" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="IncidentID" HeaderText="IncidentID" SortExpression="IncidentID" />
                        <asp:BoundField DataField="DateOpened" HeaderText="DateOpened" SortExpression="DateOpened" DataFormatString="{0:d}" />
                        <asp:BoundField DataField="CustomerName" HeaderText="CustomerName" SortExpression="CustomerName" />
                        <asp:BoundField DataField="ProductName" HeaderText="ProductName" SortExpression="ProductName" />
                        <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
                        <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                        <asp:BoundField DataField="TechID" HeaderText="TechID" SortExpression="TechID" />
                        <asp:BoundField DataField="DateClosed" DataFormatString="{0:d}" HeaderText="DateClosed" SortExpression="DateClosed" />
                    </Columns>
                    <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                    <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                    <SortedAscendingCellStyle BackColor="#FDF5AC" />
                    <SortedAscendingHeaderStyle BackColor="#4D0000" />
                    <SortedDescendingCellStyle BackColor="#FCF6C0" />
                    <SortedDescendingHeaderStyle BackColor="#820000" />
                </asp:GridView>
                <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetOpenTechIncidents" TypeName="Mo_Xue_LAB_3.IncidentDB">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="ddlTechs" Name="techID" PropertyName="SelectedValue" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </div>
        </div>
    </form>
</body>
</html>
