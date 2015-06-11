<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Events.aspx.cs" Inherits="DDWebApp.Templates.website.Admin.Events.Default" MasterPageFile="~/Templates/Website/Master/content.master" %>

<asp:Content runat="server" ContentPlaceHolderID="main">

    
      <asp:UpdatePanel ID="upnlInfo" runat="server" EnableViewState="false">
        <ContentTemplate>

            <asp:Literal ID="lblError" runat="server" EnableViewState="false"></asp:Literal>
            <br />
            <asp:Literal ID="lblMessage" runat="server" EnableViewState="false"></asp:Literal>
            <br />

            <asp:Label ID="lblEventName" runat="server" AssociatedControlID="txtEventName" Text="Event Name: "></asp:Label>
            <asp:TextBox ID="txtEventName" runat="server"/>
            <br />
    

            <asp:Label ID="lblEventDate" runat="server" AssociatedControlID="txtEventDate" Text="Event Website: "></asp:Label>
            <asp:TextBox ID="txtEventDate" runat="server" EnableViewState="false" Text="25/07/2015"></asp:TextBox>

            <asp:Button ID="btnSubmit" UseSubmitBehavior="true" runat="server" Text="Add Event" OnClick="btnSubmit_Click"/>


            <asp:Repeater ID="rptEvents" runat="server" EnableViewState="false">
                <ItemTemplate>

                    Event Name : <%# Eval("EventName") %>
                    <br />
                    Event Date: <%# Eval("EventDate") %>
                    <br />

                </ItemTemplate>
            </asp:Repeater>

        </ContentTemplate>
    </asp:UpdatePanel>
            

</asp:Content>