<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.master" AutoEventWireup="true" CodeFile="Admin_page.aspx.cs" Inherits="Admin_page" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Charting" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style59
        {
        }
        .style60
        {
            width: 157px;
        }
        .style61
        {
            width: 112px;
        }
        .style62
        {
            width: 112px;
            height: 23px;
        }
        .style63
        {
            height: 23px;
        }
        .style64
        {
            height: 23px;
        }
        .style66
        {
            width: 136px;
        }
        .style67
        {
            width: 108px;
        }
        .style69
        {
            width: 924px;
            height: 10px;
        }
        .style70
        {
            width: 157px;
            height: 10px;
        }
        .style71
        {
            height: 10px;
        }
        .style72
        {
            width: 924px;
            height: 46px;
        }
        .style73
        {
            width: 157px;
            height: 46px;
        }
        .style74
        {
            height: 46px;
        }
        .style75
        {
            width: 924px;
            height: 158px;
        }
        .style76
        {
            width: 924px;
            height: 119px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <table style="width: 100%; height: 252px;">
        <tr>
            <td class="style72">
                <asp:Label ID="Label1" runat="server" Text="User Name :"></asp:Label>
            </td>
            <td class="style73">
                <telerik:RadComboBox ID="Rad_Combo_user_name" Runat="server">
                </telerik:RadComboBox>
            </td>
            <td class="style74">
                </td>
            <td class="style74">
            </td>
            <td class="style74">
                </td>
            <td class="style74">
                </td>
        </tr>
        <tr>
            <td class="style69">
                </td>
            <td class="style70">
                <telerik:RadButton ID="RadButton1" runat="server" onclick="RadButton1_Click" 
                    Text="Show Data">
                </telerik:RadButton>
            </td>
            <td class="style71">
                </td>
            <td class="style71">
                <telerik:RadButton ID="RadButton3" runat="server" 
                    Text="Edit Data" onclick="RadButton3_Click1" Enabled="False">
                </telerik:RadButton>
            </td>
            <td class="style71">
                <telerik:RadButton ID="RadButton4" runat="server" onclick="RadButton4_Click" 
                    Text="Click Me" Enabled="False">
                </telerik:RadButton>
            </td>
            <td class="style71">
                </td>
        </tr>
        <tr>
            <td class="style75">
                </td>
            <td class="style63" colspan="4">
                
                
                <telerik:RadGrid ID="RadGrid1" runat="server" Width="700px" Height="133px" 
                    style="margin-left: 21px" >
                <ClientSettings>
                <Scrolling AllowScroll="true" />
                </ClientSettings>
                </telerik:RadGrid>
                </td>
            <td class="style64">
                </td>
        </tr>
        <tr>
            <td class="style76">
                &nbsp;</td>
            <td class="style60">
                <telerik:RadWindow ID="RadWindow1" runat="server" Height="173px" Modal="True" Behaviors="Close">
                    <ContentTemplate>
                        <table style="width:100%; height: 87px;">
                            <tr>
                                <td class="style67">
                                    <asp:Label ID="Label2" runat="server" Text="Admin Name:"></asp:Label>
                                </td>
                                <td class="style66">
                                    <telerik:RadTextBox ID="Rad_admin_name" Runat="server">
                                    </telerik:RadTextBox>
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td class="style67">
                                    <asp:Label ID="Label3" runat="server" Text="Password :"></asp:Label>
                                </td>
                                <td class="style66">
                                    <telerik:RadTextBox ID="rad_admin_pass" Runat="server" TextMode="Password">
                                    </telerik:RadTextBox>
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td class="style67">
                                    &nbsp;</td>
                                <td class="style66">
                                    <telerik:RadButton ID="RadButton2" runat="server" Text="Enter" 
                                        onclick="RadButton2_Click">
                                    </telerik:RadButton>
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                        </table>
                    </ContentTemplate>
                </telerik:RadWindow>
            </td>
            <td colspan="4">
                
                
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style76">
                &nbsp;</td>
            <td class="style60">
                <telerik:RadGrid ID="RadGrid3" runat="server" AutoGenerateColumns="false" 
                    onitemupdated="RadGrid3_ItemUpdated" onupdatecommand="RadGrid3_UpdateCommand">
                <MasterTableView DataKeyNames="FName">
                <Columns>
                <telerik:GridButtonColumn UniqueName="DeleteColumn" CommandName="Delete" ButtonType="PushButton" Text="Delete" />
                <telerik:GridBoundColumn UniqueName="FtName" SortExpression="FirstName" HeaderText="First name"
                        DataField="FName" />
                    <telerik:GridBoundColumn UniqueName="LastName" SortExpression="LastName" HeaderText="Last name"
                        DataField="LName" />
                           <telerik:GridEditCommandColumn ButtonType="PushButton" UniqueName="EditCommandColumn">
                        <HeaderStyle Width="85px"></HeaderStyle>
                    </telerik:GridEditCommandColumn>
                </Columns>
                <EditFormSettings CaptionFormatString="Edit details for Fname {0}" CaptionDataField="FName">
                    <FormTableItemStyle Width="100%" Height="29px"></FormTableItemStyle>
                    <FormTableStyle GridLines="None" CellSpacing="0" CellPadding="2"></FormTableStyle>
                    <FormStyle Width="100%" BackColor="#eef2ea"></FormStyle>
                    <EditColumn ButtonType="ImageButton" />
                </EditFormSettings>
                </MasterTableView>
                </telerik:RadGrid>
            </td>
            <td colspan="4">
                
                <telerik:RadGrid ID="RadGrid2" runat="server" AutoGenerateColumns="false" 
                    oncolumncreated="RadGrid2_ColumnCreated" onitemcreated="RadGrid2_ItemCreated" 
                    onitemdatabound="RadGrid2_ItemDataBound" >

                
                <MasterTableView>
                <Columns>
                <telerik:GridTemplateColumn UniqueName="Col1" DataField="Fname">
                <ItemTemplate >

                    <telerik:RadTextBox ID="Rad_txt_Fname" runat="server" > 
                                     </telerik:RadTextBox>
                </ItemTemplate>
                </telerik:GridTemplateColumn  >
                  </Columns>
                </MasterTableView>
                </telerik:RadGrid>
                
                   </td>
        </tr>
        <tr>
            <td class="style59" colspan="6">
                
                
                &nbsp;</td>
        </tr>
    </table>
    <br />
</asp:Content>

