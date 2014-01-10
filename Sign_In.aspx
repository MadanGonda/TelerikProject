<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.master" AutoEventWireup="true" CodeFile="Sign_In.aspx.cs" Inherits="Sign_In" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <!--meta http-equiv="refresh" content="1; url=Sign_In.aspx" />--> 
    <link href="CSS/Sign_in.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript">
// <![CDATA[

        function Button1_onclick() {
       
        }

        function Button1_onclick() {

        }

// ]]>
    </script>
    <style type="text/css">
        .style75
        {
            width: 2352px;
            height: 29px;
        }
        .style76
        {
            width: 152px;
            height: 29px;
        }
        .style77
        {
            height: 29px;
        }
        .style79
        {
            width: 2352px;
            height: 9px;
        }
        .style81
        {
            width: 2352px;
            height: 2px;
        }
        .style82
        {
            height: 2px;
        }
        .style87
        {
            width: 152px;
            height: 1px;
        }
        .style88
        {
            width: 2352px;
            height: 1px;
        }
        .style89
        {
            height: 1px;
        }
        .style90
        {
            width: 152px;
            height: 9px;
        }
        .style91
        {
            height: 9px;
        }
    </style>
    <script type="text/javascript">
        function Pass_special_char() {
            //debugger;
            var user_name = document.getElementById("<%= Rad_txt_username.ClientID %>");
            //var user_name_reg = /^[^<>]*$/;
            var user_name_reg = /^[A-Za-z0-9][A-Za-z0-9._'']*$/; 
            if (user_name_reg.test(user_name.value) == false)
            //if(user_name.value=="" || user_name.value== null)
            {
                alert("Please enter Proper Caharacters");
                user_name.focus();
                return false;
            }

            var password_txt_box = document.getElementById("<%= Rad_txt_password.ClientID %>");
            var password_reg_exp = /^[A-Za-z0-9][A-Za-z0-9._'']*$/;
            if (password_reg_exp.test(password_txt_box.value) == false) {
                alert("Please enter Proper Caharacters");
                password_txt_box.focus();
                return false;
            }
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%; height: 494px; margin-top: 0px;">
        <tr>
            <td class="style79">
                
                </td>
            <td class="style90">
                <asp:Label ID="Label1" runat="server" Text="User Name:"></asp:Label>
            </td>
            <td class="style91">
                <telerik:RadTextBox ID="Rad_txt_username" Runat="server" Font-Size="Large" Skin="Forest">
                </telerik:RadTextBox>
                <%-- <asp:TextBox ID="Rad_txt_username" runat="server" Font-Size="Large" SkinID="Forest"></asp:TextBox>--%>
            </td>
        </tr>
        <tr>
            <td class="style79">
                </td>
            <td class="style90">
                <asp:Label ID="Label2" runat="server" Text="Password:"></asp:Label>
            </td>
            <td class="style91">
                <telerik:RadTextBox ID="Rad_txt_password" Runat="server" TextMode="Password" 
                    Font-Size="Large" Skin="Forest">
                </telerik:RadTextBox>
            </td>
        </tr>
        <tr>
            <td class="style81">
                </td>
            <td class="style82" colspan="2">
                <asp:Label ID="lbl_error" runat="server" ForeColor="#FF9999" 
                    Text="* Invalide User Name Or Password"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style88">
                &nbsp;</td>
            <td class="style87">
                <telerik:RadButton ID="RadButton1" runat="server" Text="Sign In" 
                    onclick="RadButton1_Click" Font-Bold="True" Font-Size="Small" 
                    Visible="False">
                </telerik:RadButton>
                </td>
            <td class="style89">
                <asp:Button ID="Button1" runat="server" OnClientClick="return Pass_special_char();" onclick="Button1_Click" 
                    Text="Sign In" style="height: 26px" />
            </td>
        </tr>
        <tr>
            <td class="style75">
                <telerik:RadWindow ID="RadWindow1" runat="server" Behaviors="Close" 
                    Height="193px" Modal="True">
                    <ContentTemplate>
                        <table style="width:96%; height:50%">
                            <tr>
                                <td class="style70">
                                    </td>
                                <td class="style65" colspan="3">
                                    <asp:Label ID="Label4" runat="server" Text="Invalide User Name Or Password"></asp:Label>
                                    <asp:Label ID="Label3" runat="server" Text=" "></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="style68">
                                    &nbsp;</td>
                                <td class="style69">
                                    &nbsp;</td>
                                <td class="style63">
                                    <telerik:RadButton ID="RadButton2" runat="server" onclick="RadButton2_Click" 
                                        Text="OK">
                                    </telerik:RadButton>
                                </td>
                                <td class="style64"></td>
                                
                            </tr>
                            <tr>
                                <td class="style68">
                                    &nbsp;</td>
                                <td class="style69">
                                    &nbsp;</td>
                                <td class="style63">
                                    &nbsp;</td>
                                <td class="style64">
                                    &nbsp;</td>
                            </tr>
                        </table>
                    </ContentTemplate>
                </telerik:RadWindow>
            </td>
            <td class="style76">
                </td>
            <td class="style77">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style79">
                &nbsp;</td>
            <td class="style74">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

