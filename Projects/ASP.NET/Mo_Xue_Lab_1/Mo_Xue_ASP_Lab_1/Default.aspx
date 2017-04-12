<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Mo_Xue_ASP_Lab_1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Temperature Converter</title>
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <link href="TemperatureStyle.css" rel="stylesheet" />
</head>

<body>
<form id="form1" runat="server">

    <div>
        <h1>
            <img alt="imgHorse" src="Images/horse.gif" /></h1>
        <h1>Temperature Converter</h1>
        <table>
            <tr>
                <td>
                    <h3>From:</h3>
                </td>
                <td>
                    <h3>To: </h3>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:DropDownList ID="ddlFrom" runat="server" AutoPostBack="True" Height="16px" OnSelectedIndexChanged="ddlFrom_SelectedIndexChanged">
                        <asp:ListItem>Celsius</asp:ListItem>
                        <asp:ListItem>Farenheit</asp:ListItem>
                        <asp:ListItem>Kelvin</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:DropDownList ID="ddlTo" runat="server">
                        <asp:ListItem>Farenheit</asp:ListItem>
                        <asp:ListItem>Celsius</asp:ListItem>
                        <asp:ListItem>Kelvin</asp:ListItem>
                    </asp:DropDownList>
                </td>
                
            </tr>
            <tr>
                <td>
                    <strong>Input Temperature: </strong>
                </td>
                <td>
                    <asp:TextBox ID="tbInput" runat="server" Width="129px"></asp:TextBox>
                </td>
                <td class ="no-border">
                    
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbInput" CssClass="validator" Display="Dynamic" ErrorMessage="Field Required! "></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidator" runat="server" ControlToValidate="tbInput" CssClass="validator" Display="Dynamic" ErrorMessage="Must be within Range -273.15 and 1000" Type="Double" MaximumValue="1000" MinimumValue="-1000"></asp:RangeValidator>
                    
                </td>
            </tr>
            <tr>
                <td>
                    <strong>Output Temperature: </strong>
                </td>
                <td>
                    <asp:Label ID="lblOutput" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button CssClass="button" ID="btnCalculate" runat="server" Text="Calculate" OnClick="btnCalculate_Click" />
                </td>
                <td>
                    <asp:Button CssClass="button" ID="btnClear" runat="server" Text="Clear" CausesValidation="False" OnClick="btnClear_Click" />
                </td>
            </tr>
        </table>
    </div>
</form>

</body>
</html>
