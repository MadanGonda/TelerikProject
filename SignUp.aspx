<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.master" AutoEventWireup="true"
    CodeFile="SignUp.aspx.cs" Inherits="SignUp" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
   
    <link href="CSS/Sign_up.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript">
       
              function validation2() {
                  //debugger;

                  var fname = document.getElementById("<%= Rad_Txt_FName.ClientID %>");
                  //  var namereg = /^[\p{L} \.\-]+$/;
                  //var namereg = /^[a-zA-Z'.]{1,40}$/;
                  var namereg = /^[^<>]*$/;
                  if (fname.value == "" || fname.value == null) {
                      alert("Plaese Enter The First Name.");
                      fname.focus();
                      return false;
                  }
                  if (namereg.test(fname.value) == false) {
                      alert("Plaese Enter Proper First Name.");
                      fname.focus();
                      return false;
                  }

                  var lname = document.getElementById('<%=Rat_Txt_Lname.ClientID %>');
                  //var lnamereg = /^[a-zA-Z'.]{1,40}$/;
                  var lnamereg = /^[^<>]*$/;
                  if (lname.value == "" || lname.value == null) {
                      alert("Plaese Enter The Last Name.");
                      lname.focus();
                      return false;
                  }
                  if (lnamereg.test(lname.value) == false) {
                      alert("Plaese Enter Proper Last Name.");
                      fname.focus();
                      return false;
                  }

                  var email = document.getElementById('<%= Rad_Txt_Email.ClientID %>');
                  var rgf = /^([_a-zA-Z0-9-]+)(\.[_a-zA-Z0-9-]+)*@([a-zA-Z0-9-]+\.)+([a-zA-Z]{2,3})$/;
                  if (email.value == "" || email.value == null) {
                      alert("Please Enter The Email ");
                      email.focus();
                      return false;
                  }
                  if (rgf.test(email.value) == false) {
                      alert("Incorrect Email address ");
                      return false;
                  }

                  
                 
                  var b_date = document.getElementById('<%=Rad_Date_time_picker.ClientID %>');
                  if (b_date.value == "" || b_date.value == null) {
                      alert("Please Enter The Birth Date");
                      b_date.focus();
                      return false;
                      }
                      
                                          
                  /*debugger;
                  var gender_male = document.getElementById('<%= Radio_Gender_male.ClientID %>');
                  var gender_female = document.getElementById('<%= Radio_Gender_female.ClientID%>');
                  if (gender_male.value == "" || gender_female.value == "" || gender_male.value == null || gender_female.value == null) {
                  alert("Please Select The Gender");
                  return false;
                  }*/
                  var gender_male = $find("<%=Radio_Gender_male.ClientID %>")
                  var gender_female = $find("<%=Radio_Gender_female.ClientID %>")
                  {
                      if (gender_male._checked == false && gender_female._checked == false) {
                          alert("Select a gender");
                          return false;
                      }
                  }
                  
                  var country = document.getElementById('<%=Rad_Combo_Country.ClientID %>');
                  if (country.value == "---SELECT COUNTRY---") {
                      alert("Please Select The country.");
                      country.focus();
                      return false;

                  }
                  var state = document.getElementById('<%=RadComboBox_State.ClientID %>');
                  if (state.value == "" || state.value == null) {
                      alert("Please Select The State");
                      state.focus();
                      return false;
                  }
                  var address = document.getElementById('<%= Rad_Txt_Address.ClientID%>');
                  var addressregx=/^[^<>]*$/;
                  if (addressregx.test(address.value) == false) {
                      alert("Plsease Enter Proper Address.");
                      address.focus();
                      return false;
                  }
                  //second_page
         
                  var blgroup = document.getElementById("<%=Rad_Combo_Blood_Group.ClientID %>");
                  if (blgroup.value == "----SELECT----") {
                      alert("Please Select The Blood Group");
                      blgroup.focus();
                      return false;
                  }

                  var smoking_never = $find("<%= Rad_radio_smk_Never.ClientID %>");
                  var smoking_Occasionally = $find("<%= Rad_radio_smk_Occasionally.ClientID%>");
                  var smoking_rgular = $find("<%= Rad_radio_smk_Regular.ClientID%>");
                  if (smoking_never._checked == false && smoking_Occasionally._checked == false && smoking_rgular._checked == false) {
                      alert("please one smoking habit");
                      //smoking_never.focus();
                      return false;

                  }
                  var alcohol_never = $find("<%= Rad_radio_alchol_Never.ClientID%>");
                  var alcohol_occasionally = $find("<%= Rad_radio_alchol_Occasionally.ClientID%>");
                  var alcohol_regular = $find("<%= Rad_radio_alchol_Regular.ClientID%>");
                  if (alcohol_never._checked == false && alcohol_occasionally._checked == false && alcohol_regular._checked == false) {
                      alert("please one alcohol habit");
                      //alcohol_never.focus();
                      return false;
                  }

                 
                  var drugs = document.getElementById("<%=Rad_Combo_Drugs.ClientID %>");
                  if (drugs.value == "----SELECT----") {
                      alert("Please Select The Drugs History");
                      drugs.focus();
                      return false;
                  }

                  var no_allergies = $find("<%=Allergies_no.ClientID %>");
                  var food_allergies = $find("<%=Allergies_food.ClientID %>");
                  var skin_allergies = $find("<%=Allergies_Skin.ClientID %>");
                  var medicinal_allergies = $find("<%=Allergies_medicine.ClientID %>");
                  if (no_allergies._checked == false && food_allergies._checked == false && skin_allergies._checked == false && medicinal_allergies._checked == false) {
                      alert("Please Select One Allergies Type");
                      return false;
                  }

                  var hereditary_diseases = document.getElementById("<%= Rad_Combo_Hereditery_Diseases.ClientID %>")
                  if (hereditary_diseases.value == "----SELECT----") {
                      alert("Please Select The Hereditary Disease !");
                      hereditary_diseases.focus();
                      return false;
                  }

                  var profession = document.getElementById("<%= Rad_Combo_Nature_Profession.ClientID%>");
                  if (profession.value == "----SELECT----") {
                      alert("Please Select the profession ");
                      profession.focus();
                      return false;
                  }
                  var socially_active = document.getElementById("<%= Rad_Combo_Socially_Active.ClientID%>");
                  if (socially_active.value == "----SELECT----") {
                      alert("Please select The Rate Of socially active");
                      socially_active.focus();
                      return false;
                  }
                 
                  var any_prob = document.getElementById("<%= Txt_other_problem.ClientID%>");
                  var any_prob_regx = /^[^<>]*$/;
                  if (any_prob_regx.test(any_prob.value) == false) {
                      alert("Please Enter Proper Health Problem");
                      any_prob.focus();
                      return false;
                  }

                  var any_medical_prob = document.getElementById("<%= Txt_Medical_History.ClientID%>");
                  var any_medical_prob_regx = /^[^<>]*$/;
                  if (any_medical_prob_regx.test(any_medical_prob.value) == false) {
                      alert("Please Enter Proper Medical Problem");
                      any_medical_prob.focus();
                      return false;
                  }

                  var p1 = document.getElementById("<%= RadTxtPassword.ClientID%>");
                  var p2 = document.getElementById("<%=RadTxtConfirmPass.ClientID %>");
                  var pass_rgx = /^[^<>]*$/;
                  if (p1.value == "" || p1.value == null) {
                      alert("Please Enter The password");
                      p1.focus();
                      return false;
                  }
                  if (p2.value == "" || p2.value == null) {
                      alert("Please Enter The password");
                      p2.focus();
                      return false;
                  }
                  if (p1.value != p2.value) {
                      alert("Enter The correct password");
                      p2.focus();
                      return false;
                  }
                  if (pass_rgx.test(p1.value) == false) {
                      alert("Enter proper character");
                      p1.focus();
                      return false;
                  }
                  if (pass_rgx.test(p2.value) == false) {
                      alert("Enter proper character");
                      p2.focus();
                      return false;
                  }
                 // return true;

              }
                  
    </script>
    <style type="text/css">
        .style154
        {
            width: 403px;
            height: 35px;
        }
        .style155
        {
            width: 385px;
        }
        .style156
        {
            width: 385px;
            height: 35px;
        }
        .style158
        {
            width: 302px;
            height: 35px;
        }
        .style159
        {
            width: 302px;
        }
        .style160
        {
            height: 35px;
            width: 869px;
        }
    .style166
    {
        width: 491px;
        height: 15px;
    }
    .style167
    {
        width: 1239px;
        height: 15px;
    }
    .style168
    {
        height: 15px;
    }
        .style169
        {
            width: 403px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table style="width: 100%; height: 487px;">
        <tr>
            <td class="style60">
            </td>
            <td class="style59">
            </td>
            <td class="style60">
            </td>
        </tr>
        <tr>
            <td class="style51">
            </td>
            <td class="style87" align="left">
                <telerik:RadAjaxPanel ID="RadAjaxPanel1" runat="server" Height="339px" Style="margin-left: 0px"
                    Width="603px">
                    <telerik:RadTabStrip ID="RadTabStrip1" runat="server" SelectedIndex="0" MultiPageID="RadMultiPage1"
                        Width="719px">
                        <Tabs>
                            <telerik:RadTab runat="server" Text="Basic Information" Selected="True">
                            </telerik:RadTab>
                            <telerik:RadTab runat="server" Text="Health Information">
                            </telerik:RadTab>
                            <telerik:RadTab runat="server" Text="Other Information" >
                            </telerik:RadTab>
                        </Tabs>
                    </telerik:RadTabStrip>
                    <telerik:RadMultiPage ID="RadMultiPage1" runat="server" SelectedIndex="0" Width="109%"
                        Height="102%" RegisterWithScriptManager="true">
                        <telerik:RadPageView ID="RadPageView1" runat="server" Height="16px" 
                            Width="922px">
                            <table style="width: 99%; height: 428px">
                                <tr>
                                    <td class="style166">
                                        <asp:Label ID="Label1" runat="server" Text="First Name :"></asp:Label>
                                    </td>
                                    <td class="style167">
                                        <telerik:RadTextBox ID="Rad_Txt_FName" runat="server" EmptyMessage="First Name" 
                                            Width="125px" MaxLength="29" Skin="Forest">
                                        </telerik:RadTextBox>
                                        <asp:Label ID="Label22" runat="server" ForeColor="#FF9966" Text="*"></asp:Label>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                                            ControlToValidate="Rad_Txt_FName" ErrorMessage="Please Enter Proper Name" 
                                            ForeColor="#FF9966" 
                                            ValidationExpression="^[A-Za-z'\-\p{L}\p{Zs}\p{Lu}\p{Ll}\']+$"></asp:RegularExpressionValidator>
                                    </td>
                                    <td class="style168">
                                        &nbsp;&nbsp;<telerik:RadButton ID="RadButton2" runat="server" Text="-&gt;" 
                                            OnClick="RadButton2_Click" Visible="False">
                                        </telerik:RadButton>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style134">
                                        <asp:Label ID="Label2" runat="server" Text="Last Name :"></asp:Label>
                                    </td>
                                    <td class="style135">
                                        <telerik:RadTextBox ID="Rat_Txt_Lname" runat="server" EmptyMessage="Last Name" 
                                            Width="125px" MaxLength="29" Skin="Forest">
                                        </telerik:RadTextBox>
                                        <asp:Label ID="Label23" runat="server" ForeColor="#FF9966" Text="*"></asp:Label>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
                                            ControlToValidate="Rat_Txt_Lname" ErrorMessage="Please Enter Proper Name " 
                                            ForeColor="#FF9966" 
                                            ValidationExpression="^[A-Za-z'\-\p{L}\p{Zs}\p{Lu}\p{Ll}\']+$"></asp:RegularExpressionValidator>
                                    </td>
                                    <td class="style136">
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style115">
                                        <asp:Label ID="Label6" runat="server" Text="Email Address :"></asp:Label>
                                    </td>
                                    <td class="style64">
                                        <telerik:RadTextBox ID="Rad_Txt_Email" runat="server" 
                                            EmptyMessage="Email Address" MaxLength="29"
                                            Width="125px" Skin="Forest">
                                        </telerik:RadTextBox>
                                        <asp:Label ID="Label24" runat="server" ForeColor="#FF9966" Text="*"></asp:Label>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                            ControlToValidate="Rad_Txt_Email" ErrorMessage="Please Enter Proper Email" 
                                            ForeColor="#FF9966" 
                                            ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                                    </td>
                                    <td class="style116">
                                        &nbsp;
                                        </td>
                                </tr>
                                <tr>
                                    <td class="style89">
                                        <asp:Label ID="Label7" runat="server" Text="Birth Date :"></asp:Label>
                                    </td>
                                    <td class="style90">
                                        <telerik:RadDatePicker ID="Rad_Date_time_picker" runat="server" AutoPostBack="True"
                                            Culture="en-US" MaxDate="2000-12-31" MinDate="1900-01-01" Skin="Forest">
                                            <Calendar runat="server" UseColumnHeadersAsSelectors="False" UseRowHeadersAsSelectors="False"
                                                ViewSelectorText="x" Skin="Forest">
                                            </Calendar>
                                            <DateInput runat="server" AutoPostBack="True" DateFormat="M/d/yyyy" DisplayDateFormat="M/d/yyyy">
                                            </DateInput>
                                            <DatePopupButton HoverImageUrl="" ImageUrl="" />
                                        </telerik:RadDatePicker>
                                        <asp:Label ID="Label25" runat="server" ForeColor="#FF9966" Text="*"></asp:Label>
                                        <asp:Label ID="Label35" runat="server" Text="(MM/DD/YYYY)" ForeColor="Silver"></asp:Label>&nbsp;&nbsp;
                                        <asp:Label ID="Label39" runat="server" Text="The Age Must Be Greater Than  11" 
                                            ForeColor="Gray"></asp:Label>
                                    </td>
                                    <td class="style137">
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style141">
                                        <asp:Label ID="Label3" runat="server" Text="Gender :"></asp:Label>
                                    </td>
                                    <td class="style142">
                                        <telerik:RadButton ID="Radio_Gender_male" runat="server" 
                                            ButtonType="ToggleButton" GroupName="Gender" Text="Male" 
                                            ToggleType="Radio" Skin="Forest">
                                        </telerik:RadButton>
                                        <telerik:RadButton ID="Radio_Gender_female" runat="server" 
                                            ButtonType="ToggleButton" GroupName="Gender" Text="female" 
                                            ToggleType="Radio" Skin="Forest">
                                        </telerik:RadButton>
                                        <asp:Label ID="Label40" runat="server" ForeColor="#FF9966" Text="*"></asp:Label>
                                    </td>
                                    <td class="style143">
                                        </td>
                                </tr>
                                <tr>
                                    <td class="style81">
                                        <asp:Label ID="Label4" runat="server" Text="Country :"></asp:Label>
                                    </td>
                                    <td class="style82">
                                        <telerik:RadComboBox ID="Rad_Combo_Country" runat="server" AutoPostBack="True" 
                                            OnSelectedIndexChanged="Rad_Combo_Country_SelectedIndexChanged" Skin="Forest">
                                        </telerik:RadComboBox>
                                        <asp:Label ID="Label26" runat="server" ForeColor="#FF9966" Text="*"></asp:Label>
                                    </td>
                                    <td class="style83">
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style130">
                                        <asp:Label ID="Label5" runat="server" Text="State :"></asp:Label>
                                    </td>
                                    <td class="style131">
                                        <telerik:RadListBox ID="Rad_ListBox_State" runat="server" Height="65px" Width="160px"
                                            AutoPostBack="true" Skin="Forest">
                                        </telerik:RadListBox>
                                        <telerik:RadComboBox ID="RadComboBox_State" Runat="server" Skin="Forest" Height="80px">
                                        </telerik:RadComboBox>
                                        <asp:Label ID="Label27" runat="server" ForeColor="#FF9966" Text="*"></asp:Label>
                                    </td>
                                    <td class="style132">
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style144">
                                        <asp:Label ID="Label8" runat="server" Text="Address :"></asp:Label>
                                    </td>
                                    <td class="style145">
                                        <telerik:RadTextBox ID="Rad_Txt_Address" runat="server" TextMode="MultiLine" Width="195px"
                                            EmptyMessage="Enter Your Address" MaxLength="139" Skin="Forest">
                                        </telerik:RadTextBox>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" 
                                            ControlToValidate="Rad_Txt_Address" ErrorMessage="Please Enter Proper Address" 
                                            ForeColor="#FF9966" ValidationExpression="^[^&lt;&gt;]*$"></asp:RegularExpressionValidator>
                                    </td>
                                    <td class="style146">
                                        <asp:Button ID="Btn_first_tab" runat="server" Text="-&gt;" 
                                             onclick="Btn_first_tab_Click" 
                                            Visible="False" />
                                            <!-- OnClientClick="javascript:return hello();"-->
                                        <asp:Button ID="Button1" runat="server" Text="-&gt;" 
                                             onclick="Button1_Click" 
                                            Visible="False"/>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style117">
                                    </td>
                                    <td class="style118">
                                        &nbsp;
                                    </td>
                                    <td class="style119">
                                        <asp:Button ID="Button6" runat="server" Text="email" 
                                            OnClientClick="return em();" Visible="False"  />
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style117">
                                        &nbsp;</td>
                                    <td class="style118">
                                        &nbsp;</td>
                                    <td class="style119">
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="style117">
                                        &nbsp;</td>
                                    <td class="style118">
                                        &nbsp;</td>
                                    <td class="style119">
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="style117">
                                        &nbsp;</td>
                                    <td class="style118">
                                        &nbsp;</td>
                                    <td class="style119">
                                        &nbsp;</td>
                                </tr>
                            </table>
                        </telerik:RadPageView>
                        <telerik:RadPageView ID="RadPageView2" runat="server">
                            <!--ul><li>x2</li><li>x3</li></ul-->
                            <table style="width: 100%;">
                                <tr>
                                    <td class="style71">
                                        <asp:Label ID="Label9" runat="server" Text="Blood Group :"></asp:Label>
                                    </td>
                                    <td class="style75">
                                        <telerik:RadComboBox ID="Rad_Combo_Blood_Group" runat="server" 
                                            AutoPostBack="True" Skin="Forest">
                                        </telerik:RadComboBox>
                                        <asp:Label ID="Label28" runat="server" ForeColor="#FF9966" Text="*"></asp:Label>
                                    </td>
                                    <td>
                                        <telerik:RadButton ID="RadButton3" runat="server" Text="&lt;-" 
                                            OnClick="RadButton3_Click" Visible="False">
                                        </telerik:RadButton>
                                        <telerik:RadButton ID="RadButton4" runat="server" Text="-&gt;" 
                                            OnClick="RadButton4_Click" Visible="False">
                                        </telerik:RadButton>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style128">
                                        <asp:Label ID="Label10" runat="server" Text="Smoking Habits  :"></asp:Label>
                                    </td>
                                    <td class="style129">
                                        &nbsp;
                                        <telerik:RadButton runat="server" ID="Rad_radio_smk_Never" ButtonType="ToggleButton"
                                            ToggleType="Radio" Text="Never" GroupName="Smk" Skin="Forest">
                                        </telerik:RadButton>
                                        &nbsp;<telerik:RadButton runat="server" ID="Rad_radio_smk_Occasionally" ButtonType="ToggleButton"
                                            ToggleType="Radio" Text="Occasionally" GroupName="Smk" Skin="Forest">
                                        </telerik:RadButton>
                                        &nbsp;<telerik:RadButton runat="server" ID="Rad_radio_smk_Regular" ButtonType="ToggleButton"
                                            ToggleType="Radio" Text="Regular" GroupName="Smk" Skin="Forest">
                                        </telerik:RadButton>
                                        <asp:Label ID="Label36" runat="server" ForeColor="#FF9966" Text="*"></asp:Label>
                                    </td>
                                    <td class="style83">
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style71">
                                        <asp:Label ID="Label11" runat="server" Text="Alcohol Consumption :"></asp:Label>
                                    </td>
                                    <td class="style75">
                                        &nbsp;
                                        <telerik:RadButton runat="server" ID="Rad_radio_alchol_Never" ButtonType="ToggleButton"
                                            ToggleType="Radio" Text="Never" GroupName="alchol" Skin="Forest">
                                        </telerik:RadButton>
                                        &nbsp;<telerik:RadButton runat="server" ID="Rad_radio_alchol_Occasionally" ButtonType="ToggleButton"
                                            ToggleType="Radio" Text="Occasionally" GroupName="alchol" Skin="Forest">
                                        </telerik:RadButton>
                                        &nbsp;<telerik:RadButton runat="server" ID="Rad_radio_alchol_Regular" ButtonType="ToggleButton"
                                            ToggleType="Radio" Text="Regular" GroupName="alchol" Skin="Forest">
                                        </telerik:RadButton>
                                        <asp:Label ID="Label37" runat="server" ForeColor="#FF6600" Text="*"></asp:Label>
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style71">
                                        <asp:Label ID="Label12" runat="server" Text="Illegal Drugs Consumption:"></asp:Label>
                                    </td>
                                    <td class="style75">
                                        <telerik:RadComboBox ID="Rad_Combo_Drugs" runat="server" OnSelectedIndexChanged="Rad_Combo_Drugs_SelectedIndexChanged"
                                            AutoPostBack="True" Skin="Forest">
                                        </telerik:RadComboBox>
                                        <asp:Label ID="Label29" runat="server" ForeColor="#FF9966" Text="*"></asp:Label>
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style71">
                                        <asp:Label ID="Label13" runat="server" Text="Rate of Consumtion :" 
                                            Visible="False"></asp:Label>
                                    </td>
                                    <td class="style75">
                                        &nbsp;
                                        <telerik:RadButton runat="server" ID="Rad_drugs_never" ButtonType="ToggleButton"
                                            ToggleType="Radio" Text="Never" GroupName="drugs" Visible="False" 
                                            Skin="Forest">
                                        </telerik:RadButton>
                                        &nbsp;<telerik:RadButton runat="server" ID="Rad_drugs_Occasionally" ButtonType="ToggleButton"
                                            ToggleType="Radio" Text="Occasionally" GroupName="drugs" Visible="False" 
                                            Skin="Forest">
                                        </telerik:RadButton>
                                        &nbsp;<telerik:RadButton runat="server" ID="Rad_drugs_regullar" ButtonType="ToggleButton"
                                            ToggleType="Radio" Text="Regular" GroupName="drugs" Visible="False" 
                                            Skin="Forest">
                                        </telerik:RadButton>
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style77">
                                        <asp:Label ID="Label14" runat="server" Text="Allergies :"></asp:Label>
                                    </td>
                                    <td class="style78">
                                        &nbsp;<telerik:RadButton runat="server" ID="Allergies_no" ButtonType="ToggleButton"
                                            ToggleType="Radio" Text="No" GroupName="allergies" Skin="Forest">
                                        </telerik:RadButton>
                                        &nbsp;<telerik:RadButton runat="server" ID="Allergies_food" ButtonType="ToggleButton"
                                            ToggleType="Radio" Text="Food" GroupName="allergies" Skin="Forest">
                                        </telerik:RadButton>
                                        &nbsp;<telerik:RadButton runat="server" ID="Allergies_Skin" ButtonType="ToggleButton"
                                            ToggleType="Radio" Text="Skin" GroupName="allergies" Skin="Forest">
                                        </telerik:RadButton>
                                        &nbsp;<telerik:RadButton runat="server" ID="Allergies_medicine" ButtonType="ToggleButton"
                                            ToggleType="Radio" Text="Medicinal" GroupName="allergies" Skin="Forest">
                                        </telerik:RadButton>
                                        <asp:Label ID="Label38" runat="server" ForeColor="#FF6600" Text="*"></asp:Label>
                                    </td>
                                    <td class="style79">
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style71">
                                        <asp:Label ID="Label15" runat="server" Text="Hereditary  Diseases :"></asp:Label>
                                    </td>
                                    <td class="style75">
                                        <telerik:RadComboBox ID="Rad_Combo_Hereditery_Diseases" runat="server" 
                                            Skin="Forest">
                                        </telerik:RadComboBox>
                                        <asp:Label ID="Label30" runat="server" ForeColor="#FF9966" Text="*"></asp:Label>
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style71">
                                        &nbsp;
                                    </td>
                                    <td class="style75">
                                        &nbsp;
                                    </td>
                                    <td>
                                        &nbsp;
                                        <asp:Button ID="Button2" runat="server" Text="-&gt;" 
                                            OnClientClick=" return validation2();" onclick="Button2_Click" 
                                            Visible="False" />
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style71">
                                        &nbsp;
                                    </td>
                                    <td class="style75">
                                        &nbsp;
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                            </table>
                        </telerik:RadPageView>
                        <telerik:RadPageView ID="RadPageView3" runat="server" Height="68px">
                            <!--ul><li>x3</li><li>x4</li></ul-->
                            <table style="width: 100%; height: 106px;">
                                <tr>
                                    <td class="style159">
                                        <asp:Label ID="Label17" runat="server" Text="Nature of Profession  :"></asp:Label>
                                    </td>
                                    <td class="style155">
                                        <telerik:RadComboBox ID="Rad_Combo_Nature_Profession" runat="server" 
                                            Skin="Forest">
                                        </telerik:RadComboBox>
                                        <asp:Label ID="Label31" runat="server" ForeColor="#FF9966" Text="*"></asp:Label>
                                    </td>
                                    <td align="right" class="style169">
                                        &nbsp;
                                    </td>
                                    <td align="right">
                                        <telerik:RadButton ID="RadButton6" runat="server" Text="&lt;-" 
                                            OnClick="RadButton6_Click" Visible="False">
                                        </telerik:RadButton>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style159">
                                        <asp:Label ID="Rad_Lable_Socialy_Active" runat="server" Text="Socially Active :"></asp:Label>
                                    </td>
                                    <td class="style155">
                                        <telerik:RadComboBox ID="Rad_Combo_Socially_Active" runat="server" 
                                            Skin="Forest">
                                        </telerik:RadComboBox>
                                        <asp:Label ID="Label32" runat="server" ForeColor="#FF9966" Text="*"></asp:Label>
                                    </td>
                                    <td class="style169">
                                        &nbsp;
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style158">
                                        <asp:Label ID="Label18" runat="server" Text="Any Other Problem:"></asp:Label>
                                    </td>
                                    <td class="style156">
                                        <telerik:RadTextBox ID="Txt_other_problem" runat="server" TextMode="MultiLine" 
                                            MaxLength="139" Skin="Forest">
                                        </telerik:RadTextBox>
                                    </td>
                                    <td class="style154">
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" 
                                            ControlToValidate="Txt_other_problem" ErrorMessage="Please Enter Proper Data" 
                                            ForeColor="#FF9966" ValidationExpression="^[^&lt;&gt;]*$"></asp:RegularExpressionValidator>
                                    </td>
                                    <td class="style160">
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style159">
                                        <asp:Label ID="Label19" runat="server" Text="Any Medical History :"></asp:Label>
                                    </td>
                                    <td class="style155">
                                        <telerik:RadTextBox ID="Txt_Medical_History" runat="server" 
                                            TextMode="MultiLine" MaxLength="139" Skin="Forest">
                                        </telerik:RadTextBox>
                                    </td>
                                    <td class="style169">
                                        &nbsp;
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" 
                                            ControlToValidate="Txt_Medical_History" ErrorMessage="Please Enter Proper Data" 
                                            ForeColor="#FF9966" ValidationExpression="^[^&lt;&gt;]*$"></asp:RegularExpressionValidator>
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style159">
                                        <asp:Label ID="Label20" runat="server" Text="Password :"></asp:Label>
                                    </td>
                                    <td class="style155">
                                        <telerik:RadTextBox ID="RadTxtPassword" runat="server" TextMode="Password" 
                                            MaxLength="29" Skin="Forest">
                                        </telerik:RadTextBox>
                                        <asp:Label ID="Label33" runat="server" ForeColor="#FF9999" Text="*"></asp:Label>
                                    </td>
                                    <td class="style169">
                                        &nbsp;
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style159">
                                        <asp:Label ID="Label21" runat="server" Text="Confirm Password :"></asp:Label>
                                    </td>
                                    <td class="style155">
                                        <telerik:RadTextBox ID="RadTxtConfirmPass" runat="server" TextMode="Password" 
                                            MaxLength="29" Skin="Forest">
                                        </telerik:RadTextBox>
                                        <asp:Label ID="Label34" runat="server" ForeColor="#FF9966" Text="*"></asp:Label>
                                    </td>
                                    <td class="style169">
                                        &nbsp;
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style159">
                                        &nbsp;
                                    </td>
                                    <td class="style155">
                                        &nbsp;
                                    </td>
                                    <td class="style169" align="right">
                                        <telerik:RadButton ID="RadButton5" runat="server" Text="Submit" 
                                            OnClick="RadButton5_Click" Visible="False">
                                        </telerik:RadButton>
                                    </td>
                                    <td>
                                        &nbsp;<asp:Button ID="Button5" runat="server" Text="pass" 
                                            OnClientClick="return passx();" Visible="False" />&nbsp;
                                        </td>
                                </tr>
                            </table>
                            <br />
                            <br />
                        </telerik:RadPageView>
                    </telerik:RadMultiPage>
                </telerik:RadAjaxPanel>
            </td>
            <td class="style51">
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
            <td class="style87">
                &nbsp;
                                        <asp:Button ID="btn_data_send" runat="server" Text="Submit"  
                                            OnClientClick="return validation2()" 
                    onclick="btn_data_send_Click"/> &nbsp;
                <asp:Label ID="Label41" runat="server" Text="Fields with the "></asp:Label>&nbsp;
                <asp:Label ID="Label42" runat="server" ForeColor="#FF9966" Text="*"></asp:Label>&nbsp;
                <asp:Label ID="Label43" runat="server" Text="Are Mandatory"></asp:Label>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
    </table>
</asp:Content>
