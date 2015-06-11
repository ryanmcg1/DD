<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Header.ascx.cs" Inherits="DDWebApp.Templates.website.UserControls.Header" %>


    <div class="miniNav">
        <div class="row">
            <div class="medium-9 columns">
                <ul class="inline-list">
                    <li class="hide-for-small"><i class="icon-location"></i>Belfast, N. Ireland</li>
                    <li><i class="icon-phone"></i>+44 (0)28 9012 3456</li>
                    <li class="hide-for-small"><i class="icon-mail-alt"></i>hello@rmg.com</li>
                </ul>
            </div>
            <asp:Panel ID="pnlUserInfo" runat="server" EnableViewState="false" CssClass="medium-3 columns hide-for-small" Visible="false">
                <ul class="inline-list right">
                    <li><a href="/Templates/Website/user/Manage"><strong> <%=UserName %></strong></a></li>
                    <li><a href="#"><i class="icon-youtube"></i></a></li>
                    <li><asp:Button ID="btnLogout" runat="server" EnableViewState="false" OnClick="btnLogout_Click" Text="Logout"  /></li>
                </ul>

            </asp:Panel>
            
                
           

        </div>
    </div> <!-- end of miniNav -->

    <div class="contain-to-grid">
        <nav class="top-bar" data-topbar role="navigation">
            <ul class="title-area">
                <li class="name"><a href="index.html">
                    <img src="http://placehold.it/200x55" alt="#"></a></li>
                <li class="toggle-topbar menu-icon"><a href="#"><span>Menu</span></a></li>
            </ul>

            <section class="top-bar-section">
                <!-- Right Nav Section -->
                <ul class="right">
                    <li><a href="/Default.aspx">Home</a></li>
                    <li><a href="/Admin/Venues">Venues</a></li>
                    <li><a href="/Admin/Events">Events</a></li>
                    <li><a href="/Admin/Artists">Artists</a></li>
                    <li><a href="/Admin/roles">roles</a></li>
                    <li><a href="/Admin/users">users</a></li>
                    <li><a href="/Admin/">def</a></li>
       
                </ul>
            </section>
        </nav>
    </div>
    <!-- end of header -->
 