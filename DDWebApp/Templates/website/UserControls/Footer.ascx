<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Footer.ascx.cs" Inherits="DDWebApp.Templates.website.UserControls.Footer" %>


    <div class="footerSmall">
        <div class="row">
            <div class="medium-4 columns">
                <img src="http://placehold.it/200x55" alt="#" />
            </div>
            <div class="medium-8 columns hide-for-small-only">
                <ul class="inline-list right">
                    <li><a href="#">Home</a></li>
                    <li><a href="#">Events</a></li>
                    <li><a href="#">About Us</a></li>
                    <li><a href="#">News</a></li>
                </ul>
            </div>
        </div>
    </div>




    <div class="footer">
        <div class="row">
            <div class="medium-4 columns">
                <h4>About DiddlyDee</h4>
                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud.</p>
            </div>

            <div class="medium-3 columns">
                <h4>Get in touch!</h4>
                <p>
                    Street,
                    <br />
                    Belfast,  BT971JW
                    <br />
                    T: +44(0)28 9099999
                </p>
            </div>

            <div class="medium-3 columns">
                <h4>Connect With Us</h4>
                <p><a href="#"><i class="icon-youtube"></i>YouTube</a></p>
            </div>

            <div class="medium-2 columns">
                <img src="/Templates/img/bar.jpg" alt="#" />
                <br />
                <br />
                <img src="/Templates/img/iso.png" alt="#" />
            </div>

        </div>

        <div class="row copyright">
            <div class="medium-10 columns">
                <p>&copy; Copyright 2015 DiddlyDee. All Rights Reserved.</p>
            </div>
            <div class="medium-2 columns text-right">
                <a href="#0" class="cd-top"><i class="icon-up-open-mini"></i></a>
            </div>
        </div>

    </div>





    <script src="/js/vendor/jquery.js"></script>
    <script src="/js/foundation.min.js"></script>
    <script src="/js/foundation/foundation.topbar.js"></script>
    <script src="/js/vendor/modernizr.js"></script>

    <script>
        $(document).foundation({
            orbit: {
                timer_speed: 5000,
                navigation_arrows: false,
                pause_on_hover: true,
                resume_on_mouseout: true,
                slide_number: false,
                slide_number_text: 'of',
                swipe: true
            }
        });

    </script>


    <script>
        $('.hpServices div').on("click", function (e) {
            var $this = $(this),
                $id = $this.attr('id'),
                $class = '.' + $('.about-' + $id).attr('class').replace('hide', '');

            $('.about-' + $id).removeClass('hide');
            $('div[class*=about]').not($class).addClass('hide');
            $('div.hpSection').removeClass('hpActive');
            $('#' + $id).addClass('hpActive');
            

        });
    </script>


    <script src="/js/foundation/foundation.topbar.js"></script>
    <script src="/js/main.js"></script>
    <!-- Gem jQuery -->

