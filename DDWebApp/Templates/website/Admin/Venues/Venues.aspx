<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Venues.aspx.cs" Inherits="DDWebApp.Templates.website.Admin.Venues.Default" MasterPageFile="~/Templates/Website/Master/content.master" %>

<asp:Content runat="server" ContentPlaceHolderID="main">


      <asp:UpdatePanel ID="upnlInfo" runat="server" EnableViewState="false">
        <ContentTemplate>

            <asp:Literal ID="lblError" runat="server" EnableViewState="false"></asp:Literal>


            <asp:Label ID="lblVenueName" runat="server" AssociatedControlID="txtVenueName" Text="Venue Name: "></asp:Label>
            <asp:TextBox ID="txtVenueName" runat="server"/>
            <br />
    
            <asp:Label ID="lvlVenueEmail" runat="server" AssociatedControlID="txtVenueEmail" Text="Venue Email: "></asp:Label>
            <asp:TextBox ID="txtVenueEmail" runat="server" EnableViewState="false"></asp:TextBox>
            <br />

            <asp:Label ID="lblVenueWebsite" runat="server" AssociatedControlID="txtVenueWebsite" Text="Venue Website: "></asp:Label>
            <asp:TextBox ID="txtVenueWebsite" runat="server" EnableViewState="false"></asp:TextBox>

            <asp:Button ID="btnSubmit" UseSubmitBehavior="true" runat="server" OnClick="btnSubmit_Click"/>

        </ContentTemplate>
    </asp:UpdatePanel>
    


    <h2>List venues</h2>
    <br />
     <asp:Repeater ID="rptVenue" runat="server" EnableViewState="false" >
        <ItemTemplate>
            <div class="panel">
                <div class="row">
                    <div class="medium-3 columns">
                        <a href="#"><img src="http://placehold.it/235x170" alt="#"></a>
                    </div>
                    <div class="medium-9 columns">
                        <h3>Venue Name:<%# Eval("VenueName") %></h3>
                        <p>Venue Website:<%# Eval("VenueWebsite") %> <br /></p>
                        <p>Venue Email:<%# Eval("VenueEmail") %> <br /></p>
                        <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc feugiat dui pharetra justo molestie, vel tincidunt nisl malesuada. Proin tempor augue ac erat imperdiet faucibus. Morbi sed justo sed mauris lacinia lacinia at id dolor. Donec sit amet diam magna. Duis ac lacus tristique, sagittis ex quis, ultrices nunc. Nam a accumsan lectus. Duis neque nunc, aliquet eget diam eget, viverra viverra ante. In vehicula ex quis sem maximus, quis auctor felis porttitor. Ut venenatis consectetur enim, feugiat ultricies lorem egestas quis. Morbi ut purus at justo posuere blandit.  </p>
                        <a href="servicesLower.html">Read more</a>
                    </div>
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>


</asp:Content>