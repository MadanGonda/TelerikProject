function validation() {
    debugger;

    //var txt_name = document.getElementById('ctl00_ContentPlaceHolder1_Rad_Txt_Name');
    var txt_name = document.getElementById("<%= Rad_Txt_Name.ClientID %>");
    if (txt_name.get_value == "" || txt_name.get_value == null) {
        alert("Plaese Enter The Name.");
        txt_name.focus();
        return false;
    }
    var email = document.getElementById('<%= Rad_Txt_Email.ClientID %>');
    if (email.value == "" || email.value == null) {
        alert("Plaese Enter the Email. ");
        email.focus();
        return false;
    }
    var age = document.getElementById('<%= Rad_Numaric_txt_Age.ClientID %>');
    if (age.value == "" || age.value == null) {
        alert("Please Enter The Age.");
        age.focus();
        return false;
    }
    var select_country = document.getElementById('<%= RadComboBox_Country.ClientID %>');
    if (select_country.value == "---SELECT COUNTRY---") {
        alert("Please Select The country.");
        select_country.focus();
        return false;

    }

    var states = document.getElementById('<%= telerik_listbox.ClientID %>')
    if (states.value == "" || states.value == null) {
        alert("Please Select The State.");
        states.focus();
        return false;
    }

    /* var Suggetion = document.getElementById('<%= Rad_Txt_Suggetion.ClientID %>')
    if (Suggetion.value == "" || Suggetion.value == null) { 
    alert("Please Enter The Suggetion")
    }*/
    //}
    //return true;
}