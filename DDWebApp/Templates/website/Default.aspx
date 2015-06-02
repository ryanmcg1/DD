<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Templates/Website/Master/Home.master"
     CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content runat="server" ContentPlaceHolderID="main">
    <asp:Label ID="a" runat="server"></asp:Label>
    <ul class="example-orbit" data-orbit>
      <li>
        <img src="../img/mainBanner.jpg" alt="banner"/>
        <div class="orbit-caption">
            <h1>We manage <strong>everything</strong></h1>
            <p>Ireland's premier storage and removal company</p>
            <img src="img/playVideo.png" alt="play video" />
        </div>
      </li>
      <li class="active">
        <img src="img/storage2.jpg" alt="banner" />
        <div class="orbit-caption">
          <h1>Caption Two</h1>
        </div>
      </li>

    </ul>


<!--    <div class="scrollingBanner">
        <div class="row">
            <div class="large-12 columns">

            </div>
        </div>
    </div>-->


    <div class="row hpIntro">
        <div class="medium-9 columns small-centered text-center">
            <h2>Our Services</h2>
            <p class="introText">Coastways is there to help you through your entire process, wether it be a big move or just clearing out some documents that you can't bare to get rid of.</p>
        </div>

        <div class="row">
            <div class="lare-12 columns">

                <div class="hpServices">
                    <div class="medium-4 columns">
                        <div class="panel hpSection hpActive" id="removals">
<!--                            <img src="img/removals_off.png" alt="removals" class="sectionImg imgSwap" />-->
                            <i class="icon-packaging1 largerIcon"></i><h3>Storage </h3>
                            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor.</p>
                        </div>
                    </div>

                    <div class="medium-4 columns">
                        <div class="panel hpSection" id="storage">
<!--                            <img src="img/storage.png" alt="storage" class="sectionImg" />-->
                            <i class="icon-upload25 largerIcon"></i><h3>Records Management </h3>
                            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor.</p>
                        </div>
                    </div>

                    <div class="medium-4 columns">

                        <div class="panel hpSection" id="hire">
<!--                            <img src="img/clock.png" alt="records management" class="sectionImg" />-->
                            <i class="icon-clock14"></i><h3>Crate Hire </h3>
                            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor.</p>
                        </div>
                    </div>

                </div>
            </div>

        </div>


        <div class="medium-11 columns small-centered">
            <div class="about-removals">
                <div class="medium-6 columns">
                    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labor <strong>exercitation ullamco laboris.</strong></p>
                    <p>Incididunt ut labore et dolore magna aliqua. <strong>Ut enim ad minim veniam</strong>, quis nostrud exercitation ullamco laboris.</p>
                    <p>Donec et fringilla ipsum, at laoreet ex. Sed blandit magna eu mollis mollis. <strong>Integer facilisis</strong> ultricies nisl, et egestas leo finibus vel. Cras tempus congue elementum. </p>
                    <a href="#" class="button small">View more</a>

                </div>
                <div class="medium-6 columns hpServiceImg">
                    <img src="img/removals.jpg" alt="#" />
                </div>
            </div>
            <div class="about-storage hide">
                <div class="medium-6 columns">
                    <p>Pellentesque non erat odio. <strong>Aliquam erat volutpat</strong>. Quisque eget cursus libero, ut maximus tellus. Nam scelerisque mi eget facilisis.</p>
                    <p>Incididunt ut labore et dolore magna aliqua. <strong>Ut enim ad minim veniam</strong>, quis nostrud exercitation ullamco laboris.</p>
                    <a href="#" class="button small">View more</a>

                </div>
                <div class="medium-6 columns hpServiceImg">
                    <img src="img/storage.jpg" alt="#" />
                </div>
            </div>
            <div class="about-hire hide">
                <div class="medium-6 columns">
                    <p>Sed rhoncus eu justo volutpat interdum. Ut efficitur dapibus cursus. Curabitur ut diam sit amet augue commodo. <strong>Sed ut fringilla ligula.</strong></p>
                    <p>Incididunt ut labore et dolore magna aliqua. <strong>Ut enim ad minim veniam</strong>, quis nostrud exercitation ullamco laboris. Donec et fringilla ipsum, at laoreet ex. Sed blandit magna eu mollis mollis. <strong>Integer facilisis</strong> ultricies nisl, et egestas leo finibus vel. Cras tempus congue elementum.</p>
                    <a href="#" class="button small">View more</a>

                </div>
                <div class="medium-6 columns hpServiceImg">
                    <img src="http://placehold.it/393x267" alt="#">
                </div>
            </div>
        </div>

    </div> <!-- end of hpIntro -->


    <div class="hpNews">
        <div class="row">

            <div class="medium-9 columns small-centered text-center">
                <h2>Latest News &amp; Events</h2>
                <p class="introText">See what's going on with us</p>
            </div>

            <div class="medium-11 columns small-centered">
                <div class="row">
                    <div class="medium-6 columns">
                        <div class="panel">
                            <p class="newsDate">21 June 2014</p>
                            <h3>test title one goes here</h3>
                            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore. exercitation.</p>
                            <p><a href="#">Read more</a></p>
                        </div>
                    </div>
                    <!-- end news Item -->
                    <div class="medium-6 columns">
                        <div class="panel">
                            <p class="newsDate">21 June 2014</p>
                            <h3>test title one goes here</h3>
                            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore. exercitation.</p>
                            <p><a href="#">Read more</a></p>
                        </div>
                    </div>
                    <!-- end news Item -->

                </div>
            </div>

            <div class="medium-9 columns small-centered text-center">
                <a href="#" class="button small">View More</a>
            </div>

        </div>
    </div>
    <!-- end of hpNews -->


    <div class="customerReview">

        <div class="row">
            <div class="large-11 columns text-center small-centered" style="margin-top: -60px;">
                <ul class="example-orbit-content" data-orbit>
                    <li data-orbit-slide="headline-1">
                        <div>
                            <div class="clip-circle">
                                <img src="img/user.jpg" alt="#" />
                            </div>
                            <h3>Andrew lane <span>- Belfast, N. Ireland</span></h3>
                            <div class="row">
                                <div class="small-1 columns text-right">
                                    <p class="quote">&quot;</p>
                                </div>
                                <div class="small-10 columns">
                                    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</p>
                                </div>
                                <div class="small-1 columns text-left">
                                    <p class="quote">&quot;</p>
                                </div>
                            </div>
                            <!--end of review Text -->
                        </div>
                    </li>
                    <li data-orbit-slide="headline-2">
                        <div>
                            <div class="clip-circle">
                                <img src="img/user.jpg" alt="#" />
                            </div>
                            <h3>David White <span>- Belfast, N. Ireland</span></h3>
                            <div class="row">
                                <div class="small-1 columns text-right">
                                    <p class="quote">&quot;</p>
                                </div>
                                <div class="small-10 columns">
                                    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</p>
                                </div>
                                <div class="small-1 columns text-left">
                                    <p class="quote">&quot;</p>
                                </div>
                            </div>
                            <!--end of review Text -->
                        </div>
                    </li>
                    <li data-orbit-slide="headline-3">
                        <div>
                            <div class="clip-circle">
                                <img src="img/user.jpg" alt="#" />
                            </div>
                            <h3>Simon Parks <span>- Belfast, N. Ireland</span></h3>
                            <div class="row">
                                <div class="small-1 columns text-right">
                                    <p class="quote">&quot;</p>
                                </div>
                                <div class="small-10 columns">
                                    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</p>
                                </div>
                                <div class="small-1 columns text-left">
                                    <p class="quote">&quot;</p>
                                </div>
                            </div>
                            <!--end of review Text -->
                        </div>
                    </li>
                </ul>

            </div>
        </div>

    </div>
    <!-- end of customerReview -->






</asp:Content>