<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DDWebApp.Templates.website.Admin.Users.Default" MasterPageFile="~/Templates/Website/Master/content.master" %>

<asp:Content runat="server" ContentPlaceHolderID="main">
    
<asp:UpdatePanel ID="updatePanel" runat="server" EnableViewState="false">
    <ContentTemplate>

    <asp:Panel ID="pnlMessage" runat="server" EnableViewState="false">
        <asp:Literal ID="ltlMessage" runat="server" EnableViewState="false"/>
        <asp:Literal ID="ltlError" runat="server" EnableViewState="false"/>
    </asp:Panel>

    <asp:Panel ID="pnlUser" runat="server" EnableViewState="false">
        <asp:Label ID="lblUser" runat="server" EnableViewState="false" AssociatedControlID="txtUserName" Text="Username" />
        <asp:TextBox ID="txtUserName" runat="server" EnableViewState="false" />
        
        <asp:Label ID="lblUserEmail" runat="server" EnableViewState="false" AssociatedControlID="txtUserEmail" Text="Email"/>
        <asp:TextBox ID="txtUserEmail" runat="server" EnableViewState="false" />

        <asp:Label ID="lblUserPassword" runat="server" EnableViewState="false" AssociatedControlID="txtUserPassword" Text="Password" />
        <asp:TextBox ID="txtUserPassword" runat="server" EnableViewState="false" />
    
        <br />
        <asp:Button id="btnAddUser" runat="server" EnableViewState="false" Text="Add User" OnClick="btnAddUser_Click"/>
    </asp:Panel>

    <asp:Panel ID="pnlUserList" runat="server" EnableViewState="false">
        <h2><asp:Literal ID="lblUserHeader" runat="server" EnableViewState="false" Text="User List"/></h2>
        <asp:GridView ID="gvUserList" runat="server" EnableViewState="false" />
    </asp:Panel>

    </ContentTemplate>
</asp:UpdatePanel>
    
  

</asp:Content>