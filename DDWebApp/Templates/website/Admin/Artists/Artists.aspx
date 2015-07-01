<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Artists.aspx.cs" Inherits="DDWebApp.Templates.website.Admin.Artists.Default" MasterPageFile="~/Templates/Website/Master/content.master" %>

<asp:Content runat="server" ContentPlaceHolderID="main">

    
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

            <asp:Label ID="lblArtistPhoneNumber" runat="server" AssociatedControlID="txtArtistPhoneNumber" Text="Artist Phone : "></asp:Label>
            <asp:TextBox ID="txtArtistPhoneNumber" runat="server" EnableViewState="false"></asp:TextBox>

            <asp:Button ID="btnSubmit" UseSubmitBehavior="true" runat="server" Text="Add Artist" OnClick="btnSubmit_Click"/>

        </ContentTemplate>
    </asp:UpdatePanel>
    


    <h2>List Artists</h2>
    <br />
     <asp:Repeater ID="rptArtist" runat="server" EnableViewState="false" >
        <ItemTemplate>
            <div class="panel">
                <div class="row">
                    <div class="medium-3 columns">
                        <a href="#"><img src="http://placehold.it/235x170" alt="#"></a>
                    </div>
                    <div class="medium-9 columns">
                        <h3>Artist Name:<%# Eval("ArtistName") %></h3>
                        <p>Artist Website:<%# Eval("ArtistWebsite") %> <br /></p>
                        <p>Artist Email:<%# Eval("ArtistEmail") %> <br /></p>
                        <p>Artist PhoneNumber:<%# Eval("ArtistPhoneNumber") %> <br /></p>
                        <p>Artist dateCreated:<%# Eval("CreationTimeStamp") %> <br /></p>
                        <p> Proin tempor augue ac erat imperdiet faucibus. Morbi sed justo sed mauris lacinia lacinia at id dolor. Donec sit amet diam magna. Duis ac lacus tristique, sagittis ex quis, ultrices nunc. Nam a accumsan lectus. Duis neque nunc, aliquet eget diam eget, viverra viverra ante. In vehicula ex quis sem maximus, quis auctor felis porttitor. Ut venenatis consectetur enim, feugiat ultricies lorem egestas quis. Morbi ut purus at justo posuere blandit.  </p>
                        <a href="servicesLower.html">Read more</a>
                    </div>
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>

</asp:Content>