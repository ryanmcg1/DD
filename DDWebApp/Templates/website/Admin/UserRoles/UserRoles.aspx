<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserRoles.aspx.cs" Inherits="DDWebApp.Templates.website.Admin.UserRoles.Default" MasterPageFile="~/Templates/Website/Master/content.master" %>

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
            <asp:DropDownList ID="drpUserRoleUser" runat="server"  />
            <asp:CheckBoxList ID="chkUserRoleRole" runat="server"  />
            <asp:Button ID="btnAddUserRole" runat="server" EnableViewState="false" OnClick="btnAddUserRole_Click" />
        </asp:Panel>

        <asp:Panel ID="pnlUserRoleList" runat="server" EnableViewState="false">
            <h2><asp:Literal ID="lblUserRoleHeader" runat="server" EnableViewState="false" Text="Roles List"/></h2>
            <asp:GridView ID="gvUserRoles" runat="server" EnableViewState="false" />
        </asp:Panel>
        </ContentTemplate>
    </asp:UpdatePanel>















    
   
</asp:Content>