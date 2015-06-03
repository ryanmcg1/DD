<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DDWebApp.Templates.website.User.Login" MasterPageFile="~/Templates/Website/Master/content.master"    %>

<asp:Content runat="server" ContentPlaceHolderID="main">
    
    <h2>Login Page</h2>

    <asp:Panel ID="pnlMessage" runat="server" EnableViewState="false">

        <asp:Literal ID="ltlMessage" runat="server" EnableViewState="false"></asp:Literal>

    </asp:Panel>

    <asp:Label ID="lblUserName" runat="server" EnableViewState="false" AssociatedControlID="txtUsername" Text="Email username" />
    <asp:TextBox ID="txtUsername" runat="server" EnableViewState="false" />
    <br />
    
    <asp:Label ID="lblPassword" runat="server" EnableViewState="false" AssociatedControlID="txtPassword" Text="Passsword" />
    <asp:TextBox ID="txtPassword" runat="server" EnableViewState="false" />
    <asp:CheckBox ID="chkRememberMe" runat="server" />
    <br />
    <asp:Button id="btnLogin" runat="server" EnableViewState="false" Text="Login" OnClick="btnLogin_Click" />

    <asp:Literal ID="ltlErrorMessage" runat="server" EnableViewState="false" />
    <asp:Literal ID="ltlFailureText" runat="server" EnableViewState="false" />
    <asp:Literal ID="Literal2" runat="server" EnableViewState="false" />a
</asp:Content>