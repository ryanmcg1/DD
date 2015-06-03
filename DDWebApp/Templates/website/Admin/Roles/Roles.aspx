<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Roles.aspx.cs" Inherits="DDWebApp.Templates.website.Admin.Roles.Default" MasterPageFile="~/Templates/Website/Master/content.master" %>

<asp:Content runat="server" ContentPlaceHolderID="main">


    <asp:UpdatePanel ID="updatepanel" runat="server">
        <Triggers>
            
            <asp:PostBackTrigger ControlID="btnAddRole" />
        </Triggers>
        <ContentTemplate>
            

        <asp:Panel ID="pnlMessasge" runat="server" EnableViewState="false" >
            <asp:Literal ID="ltlMessage" runat="server" EnableViewState="false" />
        </asp:Panel>

        <asp:Panel ID="pnlUserRoles" runat="server" EnableViewState="false">
            <asp:Label ID="lblRoleName" runat="server" EnableViewState="false" AssociatedControlID="txtRoleName" Text="Role Name" />
            <asp:TextBox ID="txtRoleName" runat="server" EnableViewState="false" />
            <asp:Label ID="lblRoleDescription" runat="server" EnableViewState="false" AssociatedControlID="txtRoleDescription" Text="RoleD escription" />
            <asp:TextBox ID="txtRoleDescription" runat="server" EnableViewState="false" />
    
            <br />
            <asp:Button id="btnAddRole" runat="server" EnableViewState="false" Text="Add Role" OnClick="btnAddRole_Click"/>
        </asp:Panel>

        <asp:Panel ID="pnlUserRoleList" runat="server" EnableViewState="false">
            <h2><asp:Literal ID="lblUserRoleHeader" runat="server" EnableViewState="false" Text="Roles List"/></h2>
            <asp:GridView ID="gvRoles" runat="server" EnableViewState="false" />
        </asp:Panel>
        </ContentTemplate>
    </asp:UpdatePanel>


    

</asp:Content>