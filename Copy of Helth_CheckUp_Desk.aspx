<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.master" AutoEventWireup="true" CodeFile="Copy of Helth_CheckUp_Desk.aspx.cs" Inherits="Helth_CheckUp_Desk" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style70
        {
            height: 5px;
        }
        .style71
        {
            width: 182px;
        }
        .style72
        {
            height: 30px;
            width: 157px;
        }
        .style76
        {
            width: 42px;
        height: 93px;
    }
        .style77
        {
            width: 135px;
        height: 93px;
    }
        .style80
        {
            width: 142px;
        height: 93px;
    }
        .style83
        {
            width: 3px;
            height: 55px;
        }
        .style92
        {
            height: 7px;
            width: 427px;
        }
        .style93
        {
            height: 6px;
            width: 427px;
        }
        .style96
        {
            width: 42px;
            height: 119px;
        }
        .style97
        {
            width: 135px;
            height: 119px;
        }
        .style98
        {
            width: 142px;
            height: 119px;
        }
        .style99
        {
            height: 119px;
            width: 427px;
        }
        .style100
        {
            width: 42px;
            height: 6px;
        }
        .style101
        {
            width: 135px;
            height: 6px;
        }
        .style102
        {
            width: 142px;
            height: 6px;
        }
        .style106
    {
        height: 93px;
            width: 427px;
        }
        .style108
        {
            width: 3px;
            height: 4px;
        }
        .style110
        {
            height: 4px;
            width: 157px;
        }
        .style111
        {
            width: 131px;
        }
        .style112
        {
            width: 114px;
        }
        .style114
        {
            width: 125px;
        }
        .style117
        {
            width: 14px;
        }
        .style125
        {
            width: 42px;
            height: 51px;
        }
        .style126
        {
            width: 135px;
            height: 51px;
        }
        .style127
        {
            width: 142px;
            height: 51px;
        }
        .style128
        {
            height: 51px;
            width: 427px;
        }
        .style129
        {
            width: 42px;
            height: 16px;
        }
        .style130
        {
            width: 135px;
            height: 16px;
        }
        .style131
        {
            width: 142px;
            height: 16px;
        }
        .style132
        {
            height: 16px;
            width: 427px;
        }
    </style>
    <script type="text/javascript">
        
        function openRadWindow(sender,args) {
            var cid = args.getDataKeyValue("ClientID");
            var oWnd = radopen("Client.aspx?ClientID=" + cid , "RadWindow1");
            oWnd.moveTo(5, 5);
            return false;    
        }

        function alertmsg() {//debugger;
            alert("hi");
            return false;
        }
    
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <table style="width: 109%; height: 512px;" >
        <tr>
            <td class="style100">
                </td>
            <td class="style101">
                </td>
            <td class="style102">
                <asp:Label ID="Label8" runat="server" Text="Wellcome"></asp:Label> &nbsp;
                <asp:Label ID="lbl_wellcome" runat="server" Text="Label"></asp:Label>
                </td>
            <td class="style93">
                <telerik:RadButton ID="RadButton1" runat="server" Text="Submit" 
                    ButtonType="LinkButton" onclick="RadButton1_Click" >
                </telerik:RadButton>
                </td>
        </tr>
        <tr>
            <td class="style125">
                <asp:Label ID="Label2" runat="server" Text="Your Name :"></asp:Label>
            </td>
            <td class="style126">
                <telerik:RadComboBox ID="Rad_Combo_Health_Dsk_Name" Runat="server" 
                    AutoPostBack="True" 
                    onselectedindexchanged="Rad_Combo_Health_Dsk_Name_SelectedIndexChanged">
                </telerik:RadComboBox>
            </td>
            <td class="style127">
                &nbsp;</td>
            <td class="style128">
                </td>
        </tr>
        <tr>
            <td class="style129">
                </td>
            <td class="style130">
                </td>
            <td class="style131">
            </td>
            <td class="style132">
                </td>
        </tr>
        <tr>
            <td class="style76">
                <telerik:RadAjaxPanel ID="RadAjaxPanel1" runat="server" height="16px" 
                    width="300px" >
                    <!--Image ImageUrl="Image/Health_logo.jpg" /-->
                    <telerik:RadWindowManager ID="RadWindowManager1" runat="server" Left="250px" Top="480px" >
                    <Windows> 
                    <telerik:RadWindow ID="RadWindow1" runat="server" Behaviors="Close" 
                            IconUrl="D:/Practs/ASP Projects/Telerik_Project/Image/Health_logo_Icon_s.jpg" >
                    
                        <ContentTemplate>
                            <table style="width: 100%; height: 91px; margin-left: 0px;" >
                             
                                <tr>
                                    <td>
                                        &nbsp;</td>
                                    <td class="style71">
                                        <asp:Label ID="Label3" runat="server" Text="Select The Health Problem"></asp:Label>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td>
                                        &nbsp;</td>
                                    <td class="style71">
                                        &nbsp;
                                        <telerik:RadButton runat="server"  ID="Radio_Comman_Diseases" 
                                        ButtonType="ToggleButton" ToggleType="Radio" Text="Comman Diseases " 
                                            GroupName="Nature_Of_Problem" onclick="Radio_Comman_Diseases_Click"></telerik:RadButton>
                                        </td>
                                    <td>
                                        &nbsp;
                                        
                                        </td>
                                </tr>
                                <tr>
                                    <td class="style70">
                                    </td>
                                    <td class="style72">
                                        &nbsp;
                                        <telerik:RadButton runat="server"  ID="Radio_Body_Parts" 
                                        ButtonType="ToggleButton" ToggleType="Radio" Text="Body Parts " 
                                            GroupName="Nature_Of_Problem" onclick="Radio_Body_Part_Click"></telerik:RadButton>                                      
                                        </td>
                                    <td class="style70">
                                    </td>
                                </tr>
                            </table>
                        </ContentTemplate>
                    </telerik:RadWindow>
                    </Windows>
                    </telerik:RadWindowManager>
                </telerik:RadAjaxPanel>
                
                    
                
            </td>
            <td class="style77">
                
                
                <telerik:RadAjaxPanel ID="RadAjaxPanel2" runat="server" height="36px" 
                    width="300px">
                   <telerik:RadWindowManager ID="RadWindowManager2" runat="server" Left="650px" Top="480px" >
                    <Windows>
                    
                    <telerik:RadWindow ID="RadWindow2" runat="server" Behaviors="Close" 
                            IconUrl="D:/Practs/ASP Projects/Telerik_Project/Image/Health_logo_Icon_s.jpg">
                            
                        <ContentTemplate>
                            <table style="width:100%;">
                                <tr>
                                    <td class="style83">
                                        <asp:Label ID="Label4" runat="server" Text="Select Type :"></asp:Label>
                                    </td>
                                    <td>
                                        <telerik:RadComboBox ID="Rad_Combo_Type_Of_Diseases" Runat="server" 
                                            onselectedindexchanged="Rad_Combo_Type_Of_Diseases_SelectedIndexChanged">
                                        </telerik:RadComboBox>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="style83">
                                        <asp:Label ID="Label5" runat="server" Text="Select The Duration "></asp:Label>
                                    </td>
                                    <td>
                                        <telerik:RadComboBox ID="Rad_Combo_Duration" Runat="server" >
                                        </telerik:RadComboBox>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="style83">
                                        <asp:Label ID="Label7" runat="server" Text="Severity :"></asp:Label>
                                    </td>
                                    <td>
                                            &nbsp;
                                        <telerik:RadButton runat="server"  ID="Radio_Severity_Hegh" 
                                        ButtonType="ToggleButton" ToggleType="Radio" Text="Heigh " 
                                            GroupName="Nature_Of_Severity" onclick="Radio_Severity_Hegh_Click" ></telerik:RadButton>
                                            &nbsp;
                                            <telerik:RadButton runat="server"  ID="Radio_Severity_Moderate" 
                                        ButtonType="ToggleButton" ToggleType="Radio" Text="Moderate " 
                                            GroupName="Nature_Of_Severity" onclick="Radio_Severity_Moderate_Click" ></telerik:RadButton>
                                            &nbsp;
                                            <telerik:RadButton runat="server"  ID="Radio_Severity_Low" 
                                        ButtonType="ToggleButton" ToggleType="Radio" Text="Low" 
                                            GroupName="Nature_Of_Severity" onclick="Radio_Severity_Low_Click" ></telerik:RadButton>
                                        </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="style83">
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="style83">
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                            </table>
                        </ContentTemplate>
                        
                   
                    </telerik:RadWindow>
                    
                    </Windows>
                     </telerik:RadWindowManager>
                </telerik:RadAjaxPanel>
                
                
            </td>
            <td class="style80">
            
             
                
               <telerik:RadAjaxPanel ID="RadAjaxPanel3" runat="server" height="27px" 
                    width="300px">  
            
                <telerik:RadWindowManager ID="RadWindowManager3" runat="server" Left="1050px" Top="480px" >
             <Windows>
                    <telerik:RadWindow ID="RadWindow3" runat="server" Behaviors="Close" 
                        IconUrl="D:/Practs/ASP Projects/Telerik_Project/Image/Health_logo_Icon_s.jpg">
                        <ContentTemplate>
                            <table style="width:100%;">
                                <tr>
                                    <td>
                                        &nbsp;</td>
                                    <td class="style111">
                                        <asp:Label ID="Label6" runat="server" Text="Prescription"></asp:Label>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="Label10" runat="server" Text="Take This Medicine :"></asp:Label>
                                    </td>
                                    <td class="style111">
                                        <asp:Label ID="bl_Prescription" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td>
                                        &nbsp;</td>
                                    <td class="style111">
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                            </table>
                        </ContentTemplate>
                    </telerik:RadWindow>
                   
                   </Windows>
                   </telerik:RadWindowManager> 
                </telerik:RadAjaxPanel>
            
                               
                        
                </td>
            <td class="style106">
                </td>
        </tr>
        <tr>
            <td class="style96">
                </td>
            <td class="style97"> 
             
           
                <telerik:RadAjaxPanel ID="RadAjaxPanel4" runat="server" height="38px" 
                    width="300px">
                    <telerik:RadWindowManager ID="RadWindowManager5" runat="server" Height="500px" Left="650px" Top="400px">
                    <Windows>
                    <telerik:RadWindow ID="RadWindow4" runat="server" Height="550px" Width="400" Behaviors="Close"
                        style="margin-top: 0px; margin-left: 3px;" 
                            IconUrl="D:/Practs/ASP Projects/Telerik_Project/Image/Health_logo_Icon_s.jpg">
                        <ContentTemplate>
                            <table style="width: 93%; height: 252px;">
                                <tr>
                                    <td class="style110">
                                       <telerik:RadButton ID="Rad_flg1" runat="server" ButtonType="ToggleButton" 
                                            GroupName="Body_Part_Severity"  Visible="false"
                                            Text="Tromma" ToggleType="Radio" onclick="Rad_severity_Troma_Click">
                                        </telerik:RadButton>
                                        &nbsp;
                                        <telerik:RadButton ID="Rad_flg2" runat="server" ButtonType="ToggleButton" 
                                            GroupName="Body_Part_Severity"  Visible="false"
                                            Text="Injury" ToggleType="Radio" onclick="Rad_severity_Injury_Click">
                                        </telerik:RadButton>
                                        &nbsp;
                                        <telerik:RadButton ID="Rad_flg3" runat="server" ButtonType="ToggleButton" 
                                            GroupName="Body_Part_Severity"  Text="Fractured" Visible="false" 
                                            ToggleType="Radio" onclick="Rad_severity_Fractured_Click">
                                        </telerik:RadButton>
                                        <telerik:RadButton ID="Rad_flg4" runat="server" ButtonType="ToggleButton" 
                                            GroupName="Body_Part_Severity" Visible="false" 
                                            Text="Tromma" ToggleType="Radio" onclick="Rad_severity_Troma_Click">
                                        </telerik:RadButton>
                                        &nbsp;
                                        <telerik:RadButton ID="Rad_flg5" runat="server" ButtonType="ToggleButton" 
                                            GroupName="Body_Part_Severity" Visible="false" 
                                            Text="Injury" ToggleType="Radio" onclick="Rad_severity_Injury_Click">
                                        </telerik:RadButton>
                                        
                                        </td>
                                    <td class="style108">
                                        <telerik:RadButton ID="RadButton2" runat="server" Height="107px" 
                                            Text="" Width="78px" onclick="RadButton2_Click">
                                            <Image ImageUrl="Image/head_78_107.jpg" />
                                            </telerik:RadButton>
                                    </td>
                                    <td class="style51">
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style110">
                                        <telerik:RadButton ID="Rad_btn_lArm" runat="server" Height="105px" 
                                            Width="143px" onclick="Rad_btn_lArm_Click1" >
                                        <Image ImageUrl="Image/L_hand_141_103.jpg" />
                                        </telerik:RadButton>
                                        
                                    </td>
                                    <td class="style108">
                                        <telerik:RadButton ID="Rad_Abdomen_Btn" runat="server" Height="146px" 
                                            Text="" Width="79px" onclick="_Brn__Click">
                                            <Image ImageUrl="Image/Human_abdom_79_146.jpg" />
                                            
                                        </telerik:RadButton>
                                    </td>
                                    <td class="style51">
                                        <telerik:RadButton ID="Rad_btn_rArm" runat="server" Height="98px"
                                        Width="143px" onclick="Rad_btn_rArm_Click" >
                                            <Image ImageUrl="Image/RHand_143by98.jpg"/>
                                        </telerik:RadButton>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style72">
                                        </td>
                                    <td class="style83">
                                        <telerik:RadButton ID="RadButton6" runat="server" Height="206px" 
                                       Width="79" Text="" onclick="RadButton6_Click">
                                       <Image ImageUrl="Image/Leg_79_206.jpg"/>
                                        </telerik:RadButton>
                                    </td>
                                    <td class="style92">
                                        </td>
                                </tr>
                            </table>
                        </ContentTemplate>
                        
                    </telerik:RadWindow>
                    
                     </Windows>
                     </telerik:RadWindowManager>
                </telerik:RadAjaxPanel>
             
           
                </td>
            <td class="style98">
                <telerik:RadAjaxPanel ID="RadAjaxPanel5" runat="server" height="20px" 
                    width="300px">
                     <telerik:RadWindowManager ID="RadWindowManager6" runat="server" Left="1100px" Top="480px">
                   <Windows>
                    <telerik:RadWindow ID="RadWindow5" runat="server" Behaviors="Close" 
                           IconUrl="D:/Practs/ASP Projects/Telerik_Project/Image/Health_logo_Icon_s.jpg">
                        <ContentTemplate>
                            <table style="width:100%; height: 100px;">
                                <tr>
                                    <td class="style112">
                                        <asp:Label ID="Label11" runat="server" Text="Select Sub Part :"></asp:Label>
                                    </td>
                                    <td class="style114">
                                        <telerik:RadComboBox ID="Rad_combo_sub_parts" Runat="server" Height="21px" 
                                            Width="146px" 
                                            onselectedindexchanged="Rad_combo_sub_parts_SelectedIndexChanged">
                                        </telerik:RadComboBox>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="style112">
                                        <asp:Label ID="Label12" runat="server" Text="Severity :"></asp:Label>
                                    </td>
                                    <td class="style114">
                                        &nbsp;
                                        <telerik:RadButton ID="Rad_severity_Troma" runat="server" ButtonType="ToggleButton" 
                                            GroupName="Body_Part_Severity"  
                                            Text="Tromma" ToggleType="Radio" onclick="Rad_severity_Troma_Click">
                                        </telerik:RadButton>
                                        &nbsp;
                                        <telerik:RadButton ID="Rad_severity_Injury" runat="server" ButtonType="ToggleButton" 
                                            GroupName="Body_Part_Severity"  
                                            Text="Injury" ToggleType="Radio" onclick="Rad_severity_Injury_Click">
                                        </telerik:RadButton>
                                        &nbsp;
                                        <telerik:RadButton ID="Rad_severity_Fractured" runat="server" ButtonType="ToggleButton" 
                                            GroupName="Body_Part_Severity"  Text="Fractured" 
                                            ToggleType="Radio" onclick="Rad_severity_Fractured_Click">
                                        </telerik:RadButton>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="style112">
                                        &nbsp;</td>
                                    <td class="style114">
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                            </table>
                        </ContentTemplate>
                    </telerik:RadWindow>
                   
                    </Windows>
                    </telerik:RadWindowManager>
                </telerik:RadAjaxPanel>
                </td>
            <td class="style99">
                <telerik:RadAjaxPanel ID="RadAjaxPanel6" runat="server" height="28px" 
                    width="329px">
                    <telerik:RadWindowManager ID="RadWindowManager7" runat="server" Left="1450px" Top="480px">
                    <Windows>
                    <telerik:RadWindow ID="RadWindow6" runat="server" Behaviors="Close" 
                            IconUrl="D:/Practs/ASP Projects/Telerik_Project/Image/Health_logo_Icon_s.jpg">
                        <ContentTemplate>
                            <table style="width: 89%; height: 100px;">
                                <tr>
                                    <td class="style117">
                                        &nbsp;</td>
                                    <td>
                                        <asp:Label ID="Label13" runat="server" Text="Meet The Respective Doctor:"></asp:Label>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="style117">
                                        &nbsp;</td>
                                    <td>
                                        <asp:Label ID="Rad_lbl_drname" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="style117">
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                            </table>
                        </ContentTemplate>
                    </telerik:RadWindow>
                    
                    </Windows>
                    </telerik:RadWindowManager>
                </telerik:RadAjaxPanel>
                </td>
        </tr>

        </table>
   <br />
</asp:Content>

