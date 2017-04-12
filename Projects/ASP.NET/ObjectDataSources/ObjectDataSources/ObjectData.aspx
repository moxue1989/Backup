<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ObjectData.aspx.cs" Inherits="ObjectDataSources.ObjectData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="ObjectDataSource1" DataTextField="StateName" DataValueField="StateCode">
        </asp:DropDownList>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetStates" TypeName="ObjectDataSources.StateDB"></asp:ObjectDataSource>
    
    </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource2">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" SortExpression="CustomerID" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
                <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                <asp:BoundField DataField="State" HeaderText="State" SortExpression="State" />
                <asp:BoundField DataField="ZipCode" HeaderText="ZipCode" SortExpression="ZipCode" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" DataObjectTypeName="ObjectDataSources.Customer" DeleteMethod="DeleteCustomer" InsertMethod="AddCustomer" OldValuesParameterFormatString="oldCustomer" SelectMethod="GetCustomerByState" TypeName="ObjectDataSources.CustomerDB" UpdateMethod="UpdateCustomer" ConflictDetection="CompareAllValues">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" Name="stateCode" PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="oldCustomer" Type="Object" />
                <asp:Parameter Name="newCustomer" Type="Object" />
            </UpdateParameters>
        </asp:ObjectDataSource>
    </form>
</body>
</html>
