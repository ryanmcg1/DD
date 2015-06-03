<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ArtistsAdd.aspx.cs" Inherits="DDWebApp.Templates.website.Artists.ArtistsAdd" MasterPageFile="~/Templates/website/Master/Content.master"  %>
<asp:Content ContentPlaceHolderID="main" runat="server" EnableViewState="false">

       <asp:UpdatePanel ID="upnlInfo" runat="server" EnableViewState="false">
        <ContentTemplate>

            <asp:Literal ID="lblError" runat="server" EnableViewState="false"></asp:Literal>


            <asp:Label ID="lblArtistName" runat="server" AssociatedControlID="txtArtistName" Text="Artist Name: "></asp:Label>
            <asp:TextBox ID="txtArtistName" runat="server"/>
            <br />
    
            <asp:Label ID="lblArtistEmail" runat="server" AssociatedControlID="txtArtistEmail" Text="Artist Email: "></asp:Label>
            <asp:TextBox ID="txtArtistEmail" runat="server" EnableViewState="false"></asp:TextBox>
            <br />

            <asp:Label ID="lblArtistWebsite" runat="server" AssociatedControlID="txtArtistWebsite" Text="Artist Website: "></asp:Label>
            <asp:TextBox ID="txtArtistWebsite" runat="server" EnableViewState="false"></asp:TextBox>

            <asp:Label ID="lblArtistPhoneNumber" runat="server" AssociatedControlID="txtArtistPhoneNumber" Text="Artist Website: "></asp:Label>
            <asp:TextBox ID="txtArtistPhoneNumber" runat="server" EnableViewState="false"></asp:TextBox>

            <asp:Button ID="btnSubmit" UseSubmitBehavior="true" runat="server" Text="Add Artist" OnClick="btnSubmit_Click"/>

        </ContentTemplate>
    </asp:UpdatePanel>



</asp:Content>