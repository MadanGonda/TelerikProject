<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.master" AutoEventWireup="true" CodeFile="Medicine_Bank.aspx.cs" Inherits="Medicine_Bank" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style60
        {
            width: 15px;
        }
        .style61
        {
            width: 203px;
            height: 71px;
        }
        .style62
        {
            height: 71px;
        }
        .style63
        {
            height: 71px;
        }
        .style64
        {
            width: 203px;
        }
        .style70
        {
            width: 479px;
            height: 79px;
        }
        .style72
        {
            width: 651px;
            height: 79px;
        }
        .style73
        {
            width: 845px;
            height: 79px;
        }
        .style74
        {
            width: 15px;
            height: 6px;
        }
        .style79
        {
            height: 6px;
        }
        .style80
        {
            width: 479px;
            height: 6px;
        }
        .style81
        {
            width: 15px;
            height: 7px;
        }
        .style82
        {
            height: 7px;
        }
        .style83
        {
            width: 479px;
            height: 7px;
        }
        .onfocus
        {
            border-color:red;
        }
        .onblur
        {
            border-color:;
        }
    </style>
    <script type="text/javascript">
        function search_box_validation() {
            var search_box = document.getElementById("<%=Rad_Search_TextBox.ClientID %>");
            var reg_exp = /^[A-Za-z][A-Za-z._'']*$/;
            if (reg_exp.test(search_box.value) == false) {
                alert("Please enter proper name");
                return false;
                search_box.focus();
            }
        }
        function Change(obj, evt) {//debugger;
            if (evt.type == "focus")
               // obj.style.borderColor = "red";
                obj.className = "onfocus";
            else if (evt.type == "blur")
                obj.className = "onblur";
                //obj.style.borderColor = "green";
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        &nbsp;</p>
        <table style="width:100%; height:460px">
            <tr>
                <td class="style83">
                    <asp:Label ID="Label1" runat="server" Text="Enter Alphabet Of Medicine :"></asp:Label>
                </td>
                <td class="style81">
                    <telerik:RadTextBox ID="Rad_Search_TextBox" Runat="server" Skin="Forest">
                    
                    </telerik:RadTextBox>
                </td>
                <td class="style82">
                    <telerik:RadButton ID="RadButton1" runat="server" Text="Search" 
                        onclick="RadButton1_Click" Visible="False">
                    </telerik:RadButton>
                    <asp:Button ID="Btn_Search" runat="server" onclick="Button1_Click" OnClientClick="return search_box_validation()"
                        Text="Search" />
                </td>
                <td class="style82">
                    </td>
                <td class="style82">
                    </td>
            </tr>
            <tr>
                <td class="style83">
                    &nbsp;</td>
                <td class="style60">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style80">
                    </td>
                <td class="style74">
                    </td>
                <td class="style79">
                    </td>
                <td class="style79">
                    </td>
                <td class="style79">
                    </td>
            </tr>
            <tr>
                <td class="style70">
                    </td>
                <td class="style72" colspan="3">
                    <telerik:RadGrid ID="RadGrid1" runat="server" Width="500px" Height="181px">
                    <ClientSettings>
                    <Scrolling AllowScroll="true" EnableVirtualScrollPaging="true" />
                    </ClientSettings>
                    </telerik:RadGrid>
                </td>
                <td class="style73">
                    </td>
            </tr>
            <tr>
                <td class="style83">
                    &nbsp;</td>
                <td class="style60">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
    </table>
        <br />
        <br />
</asp:Content>

