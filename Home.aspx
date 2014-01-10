<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
   
    <link href="CSS/Home.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .style77
        {
            width: 834px;
            height: 7px;
        }
        .style78
        {
            height: 119px;
            width: 834px;
        }
        .style79
        {
            width: 658px;
            height: 29px;
        }
        .style80
        {
            width: 40px;
            height: 56px;
        }
        .style81
        {
            height: 56px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &nbsp;
    <!--h1>Home</h1-->
       <table style="width:100%; height: 367px; margin-right: 0px;">
        <tr>
            <td class="style74">
                </td>
            <td class="style77">
                </td>
            <td class="style71" align="right">
                &nbsp;
                <telerik:RadButton ID="Rad_Button_Sign_In" runat="server" Text="Sign In" 
                        ButtonType="LinkButton" onclick="RadButton1_Click" Font-Bold="True" 
                        Font-Size="Large" Visible="False">
                    </telerik:RadButton></td>
            <td class="style79">
                <telerik:RadButton ID="Rad_Button_Sign_Up" runat="server" 
                    ButtonType="LinkButton" Font-Bold="True" Font-Size="Large" 
                    onclick="Rad_Button_Sign_Up_Click" Text="Sign Up" Visible="False">
                </telerik:RadButton>
            </td>
        </tr>
        <tr>
            <td class="style73">
                &nbsp;</td>
                <td class="style78" align="left">
                <img alt="Plus_symbol" class="style60" src="Image/Plus%20symbol.jpg" /></td>
            <td colspan="2" > 
                &nbsp;
                
                <h2> 
                    <asp:Label ID="Label4" runat="server" Text="Dear Friend,"></asp:Label>
                </h2>
                <asp:Label ID="Label1" runat="server" Text="I am here to take care of your Health.
                I will provide you the 24*7 service even if you don’t have Money." Font-Bold="True" 
                    Font-Italic="False" Font-Names="Century" Font-Size="X-Large"></asp:Label>
                <div align="right">
                <br/><br/>
                <asp:Label
                        ID="Label2" runat="server" Text="Your's Faithfully,"
                         Font-Names="Century" Font-Size="X-Large" Font-Bold="True"></asp:Label>
                         </div><br>
                         <div align="right">
                         <asp:Label ID="Label3" runat="server" Text="Health Management." Font-Bold="True" 
                                 Font-Italic="True" Font-Names="Brush Script MT" Font-Size="Larger"></asp:Label>
                         </div>
                </td>
        </tr>
        <tr>
            <td class="style80">
                </td>
            <td class="style81" colspan="3">
                </td>
        </tr>
    </table>

</asp:Content>

