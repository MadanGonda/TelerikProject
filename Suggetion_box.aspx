<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.master" AutoEventWireup="true" CodeFile="Suggetion_box.aspx.cs" Inherits="Suggetion_box" ValidateRequest="false" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
   
   
    <link href="CSS/Suggetion_Box.css" rel="stylesheet" type="text/css" />
    <!--script src="Validations/Suggetion_Box_Validation.js" type="text/javascript"></script-->
    
    <script type="text/javascript">

        function validation() {
            //debugger;

            var txt_name = document.getElementById('<%= Rad_Txt_Name.ClientID %>');
            //var fnamerge = /^[a-zA-Z'.]{1,40}$/;
            var fnamerge = /^[^<>]*$/;
            if (txt_name.value == "" || txt_name.value == null) {
                alert("Plaese Enter The Name.");
                txt_name.focus();
                return false;
            }
            if (fnamerge.test(txt_name.value) == false) {
                alert("Enter Proper Name .");
                txt_name.focus();
                return false;
            }
            var email1 = document.getElementById('<%= Rad_Txt_Email.ClientID %>');
            var rgf = /^([_a-zA-Z0-9-]+)(\.[_a-zA-Z0-9-]+)*@([a-zA-Z0-9-]+\.)+([a-zA-Z]{2,3})$/;

            if (email1.value == "" || email1.value == null) {
                alert("Please Enter The email");
                email1.focus();
                return false;
            }
            if (rgf.test(email1.value) == false) {
                alert("Please Enter Proper email ");
                email1.focus();
                return false;
            }

            var age = document.getElementById('<%= Rad_Age_Value.ClientID %>');
            var ageregx = /^[0-9]{1,2}$/;
            if (age.value == "" || age.value == null) {
                alert("Please Enter The Age.");
                age.focus();
                return false;
            }
            if (ageregx.test(age.value) == false) {
                alert("Please Enter Numari Value");
                age.focus();
                return false;
            }

            var select_country = document.getElementById('<%= RadComboBox_Country.ClientID %>');
            if (select_country.value == "---SELECT COUNTRY---") {
                alert("Please Select The country.");
                select_country.focus();
                return false;

            }

            
            var states = document.getElementById('<%= RadComboBox_State.ClientID %>');
            
            if (states.value == "" || states.value == null) {
                alert("Please Select The State.");
                states.focus();
                return false;
            }

            var Suggetion = document.getElementById('<%= Rad_Txt_Suggetion.ClientID %>');
             //var suggetionrge = /^[a-zA-Z'.]{1,40}$/;
             var suggetionrge=/^[^<>]*$/;
             if (suggetionrge.test(Suggetion.value) == false) {
                 alert("Plsease Enter proper Suggetion");
                 Suggetion.focus();
                 return false;
             }
           /* if (Suggetion.value == "" || Suggetion.value == null) { 
            alert("Please Enter The Suggetion")
            }*/
            //}
            //return true;
        }
   </script>

    <style type="text/css">
        .style172
        {
            width: 618px;
            height: 8px;
        }
        .style173
        {
            width: 618px;
            height: 12px;
        }
        .style174
        {
            width: 618px;
            height: 28px;
        }
        .style175
        {
            width: 618px;
            height: 14px;
        }
        .style176
        {
            width: 618px;
            height: 7px;
        }
        .style178
        {
            width: 618px;
            height: 23px;
        }
        .style179
        {
            width: 618px;
            height: 39px;
        }
        .style182
        {
            width: 779px;
            height: 5px;
        }
        .style183
        {
            width: 285px;
            height: 5px;
        }
        .style184
        {
            width: 292px;
            height: 5px;
        }
        .style185
        {
            width: 618px;
            height: 5px;
        }
    </style>

</asp:Content >
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server" >
     
    <div>
        <table style="width: 100%; height: 490px;" align="center" border="0">
            <tr>
                <td class="style138">
                    </td>
                <td class="style135">
                    <asp:Label ID="Label14" runat="server" Text="Fields with the"></asp:Label>&nbsp;
                    <asp:Label ID="Label15" runat="server" Text="*" ForeColor="#FF3300"></asp:Label>&nbsp;
                    <asp:Label ID="Label16" runat="server" Text="are mandatory"></asp:Label>
                    </td>
                <td class="style172">
                    </td>
                <td class="style137">
                    </td>
            </tr>
            <tr>
                <td class="style158">
                    <asp:Label ID="Label1" runat="server" Text="Enter Name :"></asp:Label>
                </td>
                <td class="style159">
                    <telerik:RadTextBox ID="Rad_Txt_Name" Runat="server" 
                        EmptyMessage="Enter Your Name" Width="125px" MaxLength="30" Skin="Forest">
                    </telerik:RadTextBox>
                    <asp:Label ID="Label8" runat="server" ForeColor="#FF9966" Text="*"></asp:Label>
                    </td>
                <td class="style173">
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                        ControlToValidate="Rad_Txt_Name" ErrorMessage="Please Enter The Proper Name" 
                        ForeColor="#FF9966" 
                        ValidationExpression="^[A-Za-z'\-\p{L}\p{Zs}\p{Lu}\p{Ll}\']+$"></asp:RegularExpressionValidator>
                    </td>
                <td class="style157">
                    </td>
            </tr>
            <tr>
                <td class="style162">
                    <asp:Label ID="Label2" runat="server" Text="Enter Email:"></asp:Label>
                </td>
                <td class="style163">
                    <telerik:RadTextBox ID="Rad_Txt_Email" Runat="server" 
                        EmptyMessage="Enter Your Email" Width="125px" MaxLength="30" Skin="Forest">
                    </telerik:RadTextBox>
                    <asp:Label ID="Label9" runat="server" ForeColor="#FF9966" Text="*"></asp:Label>
                    </td>
                <td class="style174">
                    <asp:RegularExpressionValidator ID="RegularExpressionEmail" runat="server" 
                        ControlToValidate="Rad_Txt_Email" ErrorMessage="Please Enter Proper Email" 
                        ForeColor="#FF9966" 
                        ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
                <td class="style161">
                    </td>
            </tr>
            <tr>
                <td class="style124">
                    <asp:Label ID="Label3" runat="server" Text="Age:"></asp:Label>
                </td>
                <td class="style126" >
                    <telerik:RadTextBox ID="Rad_Age_Value" Runat="server" MaxLength="2" 
                        Skin="Forest">
                    </telerik:RadTextBox>
                    <asp:Label ID="Label10" runat="server" ForeColor="#FF9966" Text="*"></asp:Label>
                </td>
                <td class="style175" >
                    &nbsp;</td>
                <td class="style127">
                    <telerik:radnumerictextbox ID="Rad_Numaric_txt_Age" Runat="server" 
                        Culture="en-US" Width="147px" ShowSpinButtons="true" MaxValue="100" 
                        MinValue="12" DataType="12"  
                        ShouldResetWidthInPixels="true" Height="21px" Visible="False" >
                    </telerik:radnumerictextbox>
                    </td>
            </tr>
            <tr>
                <td class="style165">
                    <asp:Label ID="Label4" runat="server" Text="Select Country:"></asp:Label>
                </td>
                <td class="style166" >
                    <telerik:radcombobox ID="RadComboBox_Country" Runat="server" 
                        AutoPostBack="True" 
                        onselectedindexchanged="RadComboBox_Country_SelectedIndexChanged" 
                        Skin="Forest">
                    </telerik:radcombobox>
                    <asp:Label ID="Label12" runat="server" ForeColor="#FF9966" Text="*"></asp:Label>
                </td>
                <td class="style176" >
                    <telerik:RadButton ID="Rad_Country_Button" runat="server" Text="Country" 
                        Visible="False">
                    </telerik:RadButton>
                </td>
                <td class="style168">
                    </td>
            </tr>
            <tr>
                <td class="style183">
                    <asp:Label ID="Label6" runat="server" Text="Select State :"></asp:Label>
                </td>
                <td class="style184" align="left" >
                    <!--telerik:RadComboBox ID="RadComboBox_State" >
                    </telerik:RadComboBox-->
                    <telerik:RadComboBox ID="RadComboBox_State" Runat="server" Skin="Forest" Height="80px">
                    </telerik:RadComboBox>
                    <asp:Label ID="Label13" runat="server" ForeColor="#FF9999" Text="*"></asp:Label>
                </td>
                <td class="style185" >
                    <telerik:RadButton ID="Rad_Sate_Button" runat="server" Text="State">
                    </telerik:RadButton>
                </td>
                <td class="style182">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style138">
                    <asp:Label ID="Label5" runat="server" Text="Suggetion:"></asp:Label>
                </td>
                <td class="style135" >
                    <telerik:radtextbox ID="Rad_Txt_Suggetion" Runat="server" Height="50px" 
                        TextMode="MultiLine" Width="206px" EmptyMessage="Enter Your Suggtion" 
                        MaxLength="159" Regex="[a-zA-Z0-9]" 
                        RegexMessage="Please use only alphabet and numbers" Skin="Forest" >
                    </telerik:radtextbox>
                </td>
                <td class="style172" >
                    &nbsp;</td>
                <td class="style105">
                
                 
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style169">
                    </td>
                <td class="style170" >
                    &nbsp;<asp:Button ID="Btn_Submit" runat="server" onclick="Btn_Submit_Click" OnClientClick= "return validation()" 
                        Text="Submit" Height="25px" Width="56px" />
                      &nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Reset" />
                </td>
                <td class="style178" >
                    <telerik:radbutton ID="Rad_suggetion_submit" runat="server" value="Reject" 
                        Text="Submit" onclick="RadButton1_Click1" Visible="False" >
                    </telerik:radbutton>
                    <telerik:RadButton ID="RadButton3" runat="server" Text="Reset" 
                        onclick="RadButton3_Click1" Visible="False">
                    </telerik:RadButton>
                      </td>
                <td class="style117">
                    </td>
            </tr>
            <tr>
                <td class="style139">
                    </td>
                <td class="style143" >
                    <asp:Label ID="Label17" runat="server" Font-Size="Large" 
                        Text="Thank you very much !"></asp:Label>
                </td>
                <td class="style179" >
                <telerik:RadWindowManager ID="RadWindowManager1" runat="server"><Windows>
                    <telerik:RadWindow ID="RadWindow1" runat="server" Height="34px" Modal="True" 
                        Overlay="True" Width="284px" BorderColor="White" 
                        IconUrl="D:/Practs/ASP Projects/Telerik_Project/Image/Health_logo_Icon_s.jpg" 
                        Title="Confirmation Box" AutoSize="false" Behaviors="Close">
                        <ContentTemplate>
                            <table style="width: 100%; height: 100px;">
                                <tr>
                                    <td class="style70">
                                    </td>
                                    <td class="style71" colspan="2">
                                        <asp:Label ID="Label7" runat="server" Text="Are You Sure ?"></asp:Label>
                                    </td>
                                    <td class="style71">
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style67">
                                        &nbsp;</td>
                                  
                                    <td class="style82">
                                        <telerik:RadButton ID="Rad_Yes_Btn" runat="server" onclick="RadButton3_Click" 
                                            Text="Ok">
                                        </telerik:RadButton>&nbsp;&nbsp; &nbsp;
                                        <telerik:RadButton ID="Rad_No_Btn" runat="server" onclick="RadButton4_Click" 
                                            Text="Cancle">
                                        </telerik:RadButton>
                                    </td>
                                    <td class="style83">
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="style67">
                                        &nbsp;</td>
                                    <td class="style82">
                                        &nbsp;</td>
                                    <td class="style83">
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                            </table>
                        </ContentTemplate>
                    </telerik:RadWindow>
                   </Windows></telerik:RadWindowManager>
                    </td>
                <td class="style142">
                    <telerik:RadListBox runat="server" ID="telerik_listbox" Height="64px" 
                        Width="141px" style="margin-bottom: 10px" AutoPostBack="True" 
                        Skin="Forest" Visible="False" ></telerik:RadListBox>
                    </td>
            </tr>
        </table>
        </div>
        
    

</asp:Content>

