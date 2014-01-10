<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.master" AutoEventWireup="true" CodeFile="Servicesaspx.aspx.cs" Inherits="Servicesaspx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        
        /**
 * Slideshow style rules.
 */
#slideshow {
	margin:0 auto;
	width:745px;
	height:320px;
	/*background:transparent url(img/bg_slideshow.jpg) no-repeat 0 0;*/
	position:relative;
            top: 3px;
            left: -3px;
        }
#slideshow #slidesContainer {
  margin:0 auto;
  width:511px;
  height:295px;
  overflow:auto; /* allow scrollbar */
  position:relative;
            top: -3px;
            left: 7px;
        }
#slideshow #slidesContainer .slide {
  margin:0 auto;
  width:387px; /* reduce by 20 pixels of #slidesContainer to avoid horizontal scroll */
  height:293px;
}

/** 
 * Slideshow controls style rules.
 */
.control {
  display:block;
  width:92px;
  height:210px;
  text-indent:-10000px;
  position:absolute;
  cursor: pointer;
}
#leftControl {
  top:0;
  left:0;width:92;
	height:105;
  background:transparent url(Image/left_navigatio.jpg) no-repeat 0 0;
}
#rightControl {
  top:0;
  right:0;width:92;
	height:105;
  background:transparent url(Image/right_navigatio.jpg) no-repeat 0 0;
}

/** 
 * Style rules for Demo page
 */
 {
  margin:0;
  padding:0;
 /* font:normal 11px Verdana, Geneva, sans-serif;*/
  color:#ccc;
}
/*a {
  color: #fff;
  font-weight:bold;
  text-decoration:none;
}
a:hover {
  text-decoration:underline;
}
body {
  background:#393737 url(img/bg_body.jpg) repeat-x top left;
}*/
/*#pageContainer {
  margin:0 auto;
  width:960px;
}
#pageContainer h1 {
  display:block;
  width:960px;
  height:114px;
  background:transparent url(img/bg_pagecontainer_h1.jpg) no-repeat top left;
  text-indent: -10000px;
}*/
.slide h2, .slide p {
  margin:15px;
            height: 330px;
        }/*
.slide h2 {
  //font:italic 24px Georgia, "Times New Roman", Times, serif;
  color:#ccc;
  letter-spacing:-1px;
}
.slide img {
  float:right;
  margin:0 15px;
}*/
#footer {
  height:100px;
}
#footer p {
  margin:30px auto 0 auto;
  display:block;
  width:560px;
  height:40px;
}



       
        .style13
        {
            width: 139px;
        }
        .style15
        {
            width: 8px;
        }
        .style20
        {
            width: 139px;
            height: 308px;
        }
        .style21
        {
            width: 219px;
            }
        .style22
        {
            width: 8px;
            height: 308px;
        }
        .style23
        {
            width: 219px;
        }
    .style59
    {
    }
    </style>
    <!--link href="CSS/Services.css" rel="stylesheet" type="text/css" /-->
<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.3.2/jquery.min.js"></script>
<script type="text/javascript">
    $(document).ready(function () {
        var currentPosition = 0;
        var slideWidth = 560;
        var slides = $('.slide');
        var numberOfSlides = slides.length;

        // Remove scrollbar in JS
        $('#slidesContainer').css('overflow', 'hidden');

        // Wrap all .slides with #slideInner div
        slides
    .wrapAll('<div id="slideInner"></div>')
        // Float left to display horizontally, readjust .slides width
	.css({
	    'float': 'left',
	    'width': slideWidth
	});

        // Set #slideInner width equal to total width of all slides
        $('#slideInner').css('width', slideWidth * numberOfSlides);

        // Insert controls in the DOM
        $('#slideshow')
    .prepend('<span class="control" id="leftControl">Clicking moves left</span>')
    .append('<span class="control" id="rightControl">Clicking moves right</span>');

        // Hide left arrow control on first load
        manageControls(currentPosition);

        // Create event listeners for .controls clicks
        $('.control')
    .bind('click', function () {
        // Determine new position
        currentPosition = ($(this).attr('id') == 'rightControl') ? currentPosition + 1 : currentPosition - 1;

        // Hide / show controls
        manageControls(currentPosition);
        // Move slideInner using margin-left
        $('#slideInner').animate({
            'marginLeft': slideWidth * (-currentPosition)
        });
    });

        // manageControls: Hides and Shows controls depending on currentPosition
        function manageControls(position) {
            // Hide left arrow if position is first slide
            if (position == 0) { $('#leftControl').hide() } else { $('#leftControl').show() }
            // Hide right arrow if position is last slide
            if (position == numberOfSlides - 1) { $('#rightControl').hide() } else { $('#rightControl').show() }
        }
    });
</script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
          <table style="width: 71%; height: 491px;" align="center">
             <tr>
                <td class="style20">
                  <!-- <img alt="" src="Images/left_navigatio_small.jpg" />--></td>
                 <td class="style21" rowspan="2">
                    &nbsp;
                   <div id="pageContainer">
<!--<div>-->
  <!--<h1><a href="http://sixrevisions.com/tutorials/javascript_tutorial/create-a-slick-and-accessible-slideshow-using-jquery/">Select The Service Catagory</a></h1><br>-->
                         <table style="width: 338%; height: 50px;">
                             <tr>
                                 <td class="style59">
                                     &nbsp;</td>
                                 <td>
  <h1 align="left" style="width: 569px">Select The Service Catagory</h1>
                                 </td>
                                 <td>
                                     &nbsp;</td>
                             </tr>
                             <!--tr>
                                 <td class="style59" colspan="3">
                                     &nbsp;</td>
                             </tr-->
                             </table>
  
  <!-- Slideshow HTML -->
 <div id="slideshow"> 
<!--<div>-->
    <div id="slidesContainer">
<!--<div>-->     
 <div class="slide">
       <!-- <h2>Web Development Tutorial</h2>-->
         <h3 align="left" style="width: 384px">&nbsp;&nbsp;&nbsp; Health Desk</h3> 
         <p><a href="Copy%20of%20Helth_CheckUp_Desk.aspx">
        <img src="Image/Health_CheckUp399_199.jpg" alt="An image that says educational cds." 
                 height="230" style="width: 350px" /></a>
        <!--This service for educational services <a href="~/Services/Services_Edu.aspx">Click for Educatioan CDs Services</a>
        " In this page you will get differnt type of services for educational learning!</p>-->
        </div>
      <div class="slide">
        <h3>&nbsp;&nbsp;&nbsp; Medicine Bank</h3>
        <p><a href="Medicine_Bank.aspx">
        <img src="Image/Medicine 2.jpg" width="320" height="230" alt="Software services" /></a>
        <!--In this area you will get software CDs services <a href="~/Services/Services_Software.aspx">Software CDs Services</a>,
         which will help you to understand the Software services</p>-->
         
      </div>
      <div class="slide">
        <h3>&nbsp;&nbsp;&nbsp; Research Work</h3>
        <p><a href="Research_Work.aspx"><img src="Image/Scientists 3.jpg" width="320" height="230" alt="musical CDs" /></a>
        Musical CDs</p>
        <!--<p>In this page you will get the musical CDs informationation <a href="~/Services/Services_Music.aspx">Musical CDs</a> 
        this page is dedicated to the Music library <a href="~/Services/Services_Music.aspx">Musical CDs information</a> for music related CDs</p>-->
      </div>
     <div class="slide">
        <h3>&nbsp;&nbsp;&nbsp; Admin Login</h3>
        <p><a href="Admin_page.aspx"><img src="Image/Login_Cartoon_pic.jpg" width="320" height="230" alt="Admin_Login" /></a>
        <!--This page will give you different movie Cds.</p>
        <p>Movies CDs &quot;<a href="~/Services/Services_Movies.aspx">Movies CDs</a>&quot; which give you deatails about the CDs <a href="~/Services/Services_Movies.aspx">Movie Cds</a> Movies.</p>-->
      </div>
    
   <!-- <div class="slide">
        <h2>Other CDs</h2>
        <p><a href="~/Services/Services_Other.aspx"><img src="Images/other.jpg" width="215" height="145" alt="musical CDs" /></a>
        Other CDs</p>
        <p>In this page you will get the other CDs informationation like spiritual and yoga <a href="~/Services/Services_Music.aspx">Other CDs</a> 
        this page is dedicated to the Other CDs library <a href="~/Services/Services_Other.aspx">Other CDs information</a> for other related CDs</p>
      </div> -->
    
    </div>
  </div>
  <!-- Slideshow HTML -->
 <!-- <div id="footer">
    <p><a href="http://sixrevisions.com/tutorials/javascript_tutorial/create-a-slick-and-accessible-slideshow-using-jquery/">Create a Slick and Accessible Slideshow Using  jQuery</a> by Jacob Gube (<a href="http://sixrevisions.com/">Six Revisions</a>)</p>
  </div>-->
</div>
                    
                  </td>
                
                         <td class="style22">
                    &nbsp;&nbsp;&nbsp;&nbsp;<!--<img alt="" src="Images/right_navigatio_small.jpg" />--></td>
            </tr>
            <tr>
                <td class="style13">
                    &nbsp;</td>
                <td class="style15">
                    &nbsp;</td>
            </tr>
        </table>
   
</asp:Content>

