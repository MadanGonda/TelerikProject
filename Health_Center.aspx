<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.master" AutoEventWireup="true" CodeFile="Health_Center.aspx.cs" Inherits="Health_Center" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style60
        {
            height: 78px;
        }
        .style61
        {
            height: 69px;
        }
        .style62
        {
            height: 69px;
            width: 163px;
        }
        .style63
        {
            height: 78px;
            width: 163px;
        }
        .style64
        {
            width: 163px;
        }
        .style65
        {
            height: 81px;
        }
        .style66
        {
            height: 81px;
            width: 163px;
        }
        .style67
        {
            height: 69px;
            width: 256px;
        }
        .style68
        {
            height: 78px;
            width: 256px;
        }
        .style69
        {
            height: 81px;
            width: 256px;
        }
        .style70
        {
            width: 256px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <table style="width: 116%; height: 404px;">
            <tr>
                <td class="style67">
                </td>
                <td class="style61">
                </td>
                <td class="style62">
                    &nbsp;</td>
                <td class="style61">
                </td>
            </tr>
            <tr>
                <td class="style68">
                    <asp:Label ID="Label1" runat="server" Text="Your Name :"></asp:Label>
                </td>
                <td class="style60">
                    <telerik:RadComboBox ID="Rad_Combo_Heath_Dsk_Name" Runat="server">
                    </telerik:RadComboBox>
                </td>
                <td class="style63">
                    &nbsp;</td>
                <td class="style60">
                </td>
            </tr>
            <tr>
                <td class="style69">
                </td>
                <td class="style65">
                </td>
                <td class="style66">
                </td>
                <td class="style65">
                </td>
            </tr>
            <tr>
                <td class="style70">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="style64">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
        <br />
        <br />
</asp:Content>

