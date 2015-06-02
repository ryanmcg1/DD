<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" 
    Inherits="DDWebApp.Templates.website.User.Register"
     MasterPageFile="~/Templates/Website/Master/content.master"    %>

<asp:Content runat="server" ContentPlaceHolderID="main">

    <asp:Label ID="ErrorMessage" runat="server"></asp:Label>

    <asp:Label ID="lblUserName" runat="server" EnableViewState="false" AssociatedControlID="txtUserName" />
    <asp:TextBox ID="txtUserName" runat="server" EnableViewState="false" />

    <asp:Label ID="lblUserPassword" runat="server" EnableViewState="false" AssociatedControlID="txtUserPassword" />
    <asp:TextBox ID="txtUserPassword" runat="server" EnableViewState="false" />

    <asp:Button ID="btnSubmit" runat="server" EnableViewState="false" Text="Register" OnClick="btnSubmit_Click" />

</asp:Content>