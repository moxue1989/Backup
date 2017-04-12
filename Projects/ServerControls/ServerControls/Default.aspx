<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ServerControls.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:TreeView ID="TreeView1" runat="server" ImageSet="Contacts" ExpandDepth="0" NodeIndent="10">
        <HoverNodeStyle Font-Underline="False" />
        <Nodes>
            <asp:TreeNode Text="Parent Node" Value="Parent Node">
                <asp:TreeNode Text="Logout" Value="Logout" NavigateUrl="Login.aspx"></asp:TreeNode>
            </asp:TreeNode>
            <asp:TreeNode Text="Parent Node 2" Value="Parent Node 2">
                <asp:TreeNode Text="Child Node" Value="Child Node">
                    <asp:TreeNode Text="Baby Node" Value="Baby Node" ></asp:TreeNode>
                    <asp:TreeNode Text="Baby Node" Value="Baby Node"></asp:TreeNode>
                </asp:TreeNode>
            </asp:TreeNode>
        </Nodes>
        <NodeStyle Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
        <ParentNodeStyle Font-Bold="True" ForeColor="#5555DD" />
        <SelectedNodeStyle Font-Underline="True" HorizontalPadding="0px" VerticalPadding="0px" />
    </asp:TreeView>
</asp:Content>
