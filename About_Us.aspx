<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.master" AutoEventWireup="true" CodeFile="About_Us.aspx.cs" Inherits="About_Us" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
    <link href="CSS/About_us.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
    <table style="width:100%; height: 455px;">
        <tr>
            <td class="style74">
            </td>
            <td class="style75">
                </td>
            <td class="style76" align="right" colspan="2">
                &nbsp;<!--img alt="Plus_symbol" class="style60" src="Image/Plus%20symbol.jpg" /></td-->&nbsp;&nbsp; 
                <telerik:RadButton ID="Rad_Button_Sign_In" runat="server" Text="Sign In" 
                    ButtonType="LinkButton" OnClick="RadButton1_Click" Font-Bold="true" 
                    Font-Size="Large" Visible="False">
                </telerik:RadButton>
                 
                </td>
            <td class="style76">
                <telerik:RadButton ID="Rad_Button_Sign_Up" runat="server" 
                    ButtonType="LinkButton" Font-Bold="True" Font-Size="Large" 
                    onclick="Rad_Button_Sign_Up_Click" Text="Sign Up" Visible="False">
                </telerik:RadButton></td>
        </tr>
        <tr>
            <td class="style64">
                <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="X-Large" 
                    
                    Text="We are group of hard working people trying to create Web Based Application which will work as SOFTWARE AS A SERVICE (SaaS) for Human Health Management. Now how to grow up this service is depend on your response.looking forward to you response"></asp:Label>
            </td>
            <td class="style72">
                </td>
            <td colspan="3" class="style73">
                <img src="Image/about_Us.jpg" 
                    style="height: 301px; margin-left: 0px; margin-top: 0px" /></td>
        </tr>
        <tr>
            <td class="style69">
                </td>
            <td class="style70">
                </td>
            <td class="style71">
                </td>
            <td class="style66">
                </td>
            <td class="style71">
                </td>
        </tr>
    </table>
    <br />
</asp:Content>

