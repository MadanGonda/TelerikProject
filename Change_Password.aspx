<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.master" AutoEventWireup="true" CodeFile="Change_Password.aspx.cs" Inherits="Change_Password" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style69
        {
            width: 405px;
        }
        .style72
        {
            width: 340px;
            height: 196px;
        }
        .style73
        {
            height: 196px;
        }
        .style75
        {
            width: 340px;
            height: 49px;
        }
        .style76
        {
            height: 49px;
        }
        .style77
        {
            width: 340px;
        }
        .style79
        {
            width: 340px;
            height: 56px;
        }
        .style80
        {
            height: 56px;
        }
    .style81
    {
        width: 328px;
        height: 7px;
    }
    .style82
    {
        width: 328px;
        height: 49px;
    }
    .style83
    {
        width: 328px;
        height: 56px;
    }
    .style84
    {
        width: 328px;
        height: 196px;
    }
    </style>
    <script type="text/javascript">
    function validating_pass(){
        var old_password =document.getElementById ("<%=Rad_txt_old_pass.ClientID %>");
        var old_password_reg = /^[^<>]*$/;
        if (old_password_reg.test(old_password.value) == false) {
            alert("Please Enter Porper Character");
            old_password.focus();
            return false;
        }
        if(old_password.value=="" || old_password.value==null){
        alert ("Please Enter Password");
        old_password.focus();
        return false;
        }

    var new_password = document.getElementById("<%=Rad_txt_new_pass.ClientID %>");
    var confirm_pass = document.getElementById("<%=Rad_txt_confirm_pass.ClientID %>");
    var pass_rgx = /^[^<>]*$/;
    if (new_password.value == "" || new_password.value == null) {
        alert("Please Enter New password");
        new_password.focus();
        return false;
    }
    if (confirm_pass.value == "" || confirm_pass.value == null) {
        alert("Please Enter Confirm password");
        confirm_pass.focus();
        return false;
    }
    if (new_password.value != confirm_pass.value) {
        alert("New password & Confirm Password is not matching");
        new_password.focus();
        return false;
    }
    if (pass_rgx.test(new_password.value) == false) {
        alert("Enter proper character");
        new_password.focus();
        return false;
    }
    if (pass_rgx.test(confirm_pass.value) == false) {
        alert("Enter proper character");
        confirm_pass.focus();
        return false;
    }
    }
    
    
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%; height: 146px;">
        <tr>
            <td class="style81">
                &nbsp;</td>
            <td class="style77">
                &nbsp;</td>
            <td align="right">
                <telerik:RadButton ID="RadButton1" runat="server" onclick="RadButton1_Click" 
                    Text="View Profile">
                </telerik:RadButton>
            </td>
        </tr>
        <tr>
            <td class="style81">
                <asp:Label ID="Label1" runat="server" Text="Old Password :"></asp:Label>
            </td>
            <td class="style77">
                <telerik:RadTextBox ID="Rad_txt_old_pass" Runat="server" TextMode="Password">
                </telerik:RadTextBox>
                <asp:Label ID="Label4" runat="server" ForeColor="#FF6666" 
                    Text="Please Enter Correct Password"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style81">
                <asp:Label ID="Label3" runat="server" Text="New Password :"></asp:Label>
            </td>
            <td class="style77">
                <telerik:RadTextBox ID="Rad_txt_new_pass" Runat="server" TextMode="Password">
                </telerik:RadTextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style81">
                <asp:Label ID="Label2" runat="server" Text="Confirm Password :"></asp:Label>
            </td>
            <td class="style77">
                <telerik:RadTextBox ID="Rad_txt_confirm_pass" Runat="server" 
                    TextMode="Password">
                </telerik:RadTextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style82">
            </td>
            <td class="style75">
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Submit" OnClientClick="return validating_pass()" />
            </td>
            <td class="style76">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style83">
                </td>
            <td class="style79">
                <asp:Label ID="lbl_confirmpass" runat="server" Text="Password Is Updated"></asp:Label>
            </td>
            <td class="style80">
                </td>
        </tr>
        <tr>
            <td class="style84">
                &nbsp;</td>
            <td class="style72">
                &nbsp;</td>
            <td class="style73">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

