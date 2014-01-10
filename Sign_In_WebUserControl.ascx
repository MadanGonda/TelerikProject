<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Sign_In_WebUserControl.ascx.cs" Inherits="Sign_In_WebUserControl" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<style type="text/css">
    .style1
    {
        width: 61px;
    }
    .style2
    {
        width: 107px;
    }
</style>

<telerik:RadWindow ID="RadWindow1" runat="server" Height="231px" Modal="True" Behaviors="Close "
    Width="327px">
    <ContentTemplate>
        <table style="width: 100%; height: 144px;">
            <tr>
                <td>
                    &nbsp;</td>
                <td colspan="2">
                    <asp:Label ID="Label1" runat="server" Text="Your Session Has Expired !"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td class="style1">
                    &nbsp;</td>
                    <td class="style2">
                        <telerik:RadButton ID="RadButton1" runat="server" onclick="RadButton1_Click" 
                            Text="Sign In">
                        </telerik:RadButton>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td class="style1">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
            </tr>
        </table>
    </ContentTemplate>
</telerik:RadWindow>

