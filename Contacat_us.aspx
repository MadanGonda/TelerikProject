<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.master" AutoEventWireup="true" CodeFile="Contacat_us.aspx.cs" Inherits="Contacat_us" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<script src="http://maps.google.com/maps?file=api&amp;v=2&amp;sensor=false&amp;key=ABQIAAAAuPsJpk3MBtDpJ4G8cqBnjRRaGTYH6UMl8mADNa0YKuWNNa8VNxQCzVBXTx2DYyXGsTOxpWhvIG7Djw" type="text/javascript"></script>
    <script type="text/javascript">

    function initialize() {
      if (GBrowserIsCompatible()) {
        var map = new GMap2(document.getElementById("map_canvas"));
        map.setCenter(new GLatLng(37.4419, -122.1019), 13);
      }
    }
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server" >
<!--body onload="initialize()" onunload="GUnload()" style="font-family: Arial;border: 0 none;"> 
    <div id="map_canvas" style="width: 500px; height: 300px"></div>
  </body-->
  <table cellspacing="0" cellpadding="2" border="0"><tr><td><iframe src="http://www.map-generator.net/extmap.php?name=asd&amp;address=Infotech%20park%20%2CVashi%2CNavi%20Mumabi%20400703&amp;width=500&amp;height=400&amp;maptype=map&amp;zoom=14&amp;hl=en&amp;t=1328245381" width="500" height="400" marginwidth="0" marginheight="0" frameborder="0" scrolling="no"></iframe>
      </td></tr><tr><td align="right">by V2 Tech venture</td></tr></table>
    <br/>  
     <h2 style="height: 93px">V2 Tech venture Pvt. Ltd,<br/>
Infotech Park,Tower 1,Above Railway Complex,<br/>
Vashi,Navi Mumabi 400703,<br/>
Email: madan.gonda@in.v2solution.com</h2>
   
 <img src="Image/images%20(1).jpg"  />
<h1 style="height: 1px"></h1>
</asp:Content>

