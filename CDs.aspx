<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.master" AutoEventWireup="true" CodeFile="CDs.aspx.cs" Inherits="CDs" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
        <h5>cd lib</h5>
<telerik:RadAjaxPanel ID="RadAjaxPanel1" runat="server" height="200px" 
    width="340px">
    <telerik:RadTabStrip ID="RadTabStrip1" runat="server" SelectedIndex="2">
        <Tabs>
            <telerik:RadTab runat="server" Text="Root RadTab1">
            </telerik:RadTab>
            <telerik:RadTab runat="server" Text="Root RadTab2">
            </telerik:RadTab>
            <telerik:RadTab runat="server" Selected="True" Text="Root RadTab3">
            </telerik:RadTab>
        </Tabs>
    </telerik:RadTabStrip>
    <table style="width:100%;">
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</telerik:RadAjaxPanel>
<br />

        
</asp:Content>

