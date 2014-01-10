<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.master" AutoEventWireup="true" CodeFile="Books.aspx.cs" Inherits="Books" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .style61
        {
            width: 159px;
        }
        .style62
        {
            width: 243px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <h1>Books<table style="width: 100%; height: 269px; margin-top: 6px;" 
                __designer:mapid="538">
                        <tr __designer:mapid="539">
                            <td class="style61" __designer:mapid="53a">
                                <asp:Label ID="Label1" runat="server" Text="First Name :"></asp:Label>
                            </td>
                            <td class="style62" __designer:mapid="53c">
                                <telerik:RadTextBox ID="RadTextBox1" Runat="server">
                                </telerik:RadTextBox>
                            </td>
                            <td __designer:mapid="53e">
                                &nbsp;</td>
                        </tr>
                        <tr __designer:mapid="53f">
                            <td class="style61" __designer:mapid="540">
                                <asp:Label ID="Label2" runat="server" Text="Last Name :"></asp:Label>
                            </td>
                            <td class="style62" __designer:mapid="542">
                                <telerik:RadTextBox ID="RadTextBox2" Runat="server">
                                </telerik:RadTextBox>
                            </td>
                            <td __designer:mapid="544">
                                &nbsp;</td>
                        </tr>
                        <tr __designer:mapid="545">
                            <td class="style61" __designer:mapid="546">
                                <asp:Label ID="Label3" runat="server" Text="Gender :"></asp:Label>
                            </td>
                            <td class="style62" __designer:mapid="548">
                            <telerik:RadButton ID="Radio_gender_m" runat="server" 
                                 ButtonType="ToggleButton" ToggleType="Radio" GroupName="gender_check" 
                                    Checked="false" Text="Male">
                                </telerik:RadButton>&nbsp;
                                <telerik:RadButton ID="Radio_gender_f" runat="server" ButtonType="ToggleButton" 
                                ToggleType="Radio" GroupName="gender_check" Checked="false" Text="Female"></telerik:RadButton>
                              </td>  
                        </tr>
                        
                        <tr __designer:mapid="54b">
                            <td class="style61" __designer:mapid="54c">
                                <asp:Label ID="Label4" runat="server" Text="Country :"></asp:Label>
                            </td>
                            <td class="style62" __designer:mapid="54e">
                                <telerik:RadComboBox ID="RadComboBox1" Runat="server">
                                </telerik:RadComboBox>
                            </td>
                        </tr>
                        <tr __designer:mapid="550">
                            <td class="style61" __designer:mapid="551">
                                <asp:Label ID="Label5" runat="server" Text="State :"></asp:Label>
                            </td>
                            <td class="style62" __designer:mapid="553">
                                <telerik:RadComboBox ID="RadComboBox2" Runat="server">
                                </telerik:RadComboBox>
                            </td>
                        </tr>
                        <tr __designer:mapid="555">
                            <td class="style61" __designer:mapid="556">
                                &nbsp;</td>
                            <td class="style62" __designer:mapid="557">
                            <telerik:RadButton ID="First_next_Button" ButtonType="StandardButton"
                              Text="->" runat="server" Checked="True"></telerik:RadButton>
                                </td>
                        </tr>
                        
                    </table>
                </h1></p>
</asp:Content>

