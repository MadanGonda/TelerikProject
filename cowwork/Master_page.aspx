<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Master_page.aspx.cs" Inherits="Master_page" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="Stylesheet" type="text/css" href="Main_page_StyleSheet.css" />
    <style type="text/css">
        .style1
        {
            height: 109px;
        }
        .style2
        {
        }
        .style5
        {
        }
        </style>
</head>
<body style="height: 662px">
    <form id="form1" runat="server">
    <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
    </telerik:RadScriptManager>
    <table style="width: 87%; height: 447px;" align="center" border="0">
        <tr>
            <td class="style1" colspan="5">
                <h1 align="center" >Head</h1>
            </td>
        </tr>
        <tr>
            <td class="style5">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style5" colspan="5" >
                &nbsp; <!--a href="Master_page.aspx"> Home</a-->&nbsp;<!--a href="Master_page.aspx"> About Us</a-->&nbsp;<!--a href="Master_page.aspx"> Services</a-->&nbsp;<!--a href="Master_page.aspx"> Registreation</a-->&nbsp;<!--a href="Master_page.aspx"> Contact Us </a--></td>
        </tr>
        <tr>
            <td class="style2" colspan="5" align="center">
                <telerik:RadMenu ID="RadMenu1" Runat="server" 
                    style="top: -77px; left: 263px; height: 23px; width: 889px">
                    <Items>
                        <telerik:RadMenuItem runat="server" BorderStyle="None" Height="40px" 
                        NavigateUrl="~/Master_page.aspx" Text="Home" Width="220px">
                        </telerik:RadMenuItem>
                        <telerik:RadMenuItem runat="server" Height="40px" 
                        NavigateUrl="~/About_us.aspx" Text="About Us" Width="220px">
                        </telerik:RadMenuItem>
                        <telerik:RadMenuItem runat="server" Height="40px" Text="Services" Width="220px">
                        </telerik:RadMenuItem>
                        <telerik:RadMenuItem runat="server" Height="40px" Text="Contact Us" 
                            Width="220px">
                        </telerik:RadMenuItem>
                    </Items>
                </telerik:RadMenu>
            </td>
        </tr>
        <tr>
            <td class="style5">
                &nbsp;
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="style5">
                &nbsp;
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
    </table>
   
    <div style="height: 51px"><h4>Div</h4></div>
    </form>
</body>
</html>
