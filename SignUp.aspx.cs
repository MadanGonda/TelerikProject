using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BOL_Management_Namespace;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using Telerik;
using Telerik.Web;

public partial class SignUp : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BOL_Management_Class1 b = new BOL_Management_Class1();
            b.bindDB();
            Rad_Combo_Country.DataSource = b.dt;
           // Rad_Combo_Country.DataTextField = "Name";
            Rad_Combo_Country.DataTextField = "COUNTRY";
            Rad_Combo_Country.DataBind();
            Rad_Txt_FName.Focus();

            //b.Helthinfo_con();
            b.Blood_Group_Con();
            Rad_Combo_Blood_Group.DataSource = b.dt;
            Rad_Combo_Blood_Group.DataTextField = "Blood_Group";
            Rad_Combo_Blood_Group.DataBind();
            
            b.Drugs_Names_con();
            Rad_Combo_Drugs.DataSource = b.dt;
            Rad_Combo_Drugs.DataTextField = "Drugs_Name";
            Rad_Combo_Drugs.DataBind();

            b.Hereditory_Disease_con();
            Rad_Combo_Hereditery_Diseases.DataSource = b.dt;
            Rad_Combo_Hereditery_Diseases.DataTextField = "Hereditory_Disease";
            Rad_Combo_Hereditery_Diseases.DataBind();
            
            b.profesion_con();
            Rad_Combo_Nature_Profession.DataSource = b.dt;
            Rad_Combo_Nature_Profession.DataTextField = "Profession";
            Rad_Combo_Nature_Profession.DataBind();
            
            b.socio_act_con();
            Rad_Combo_Socially_Active.DataSource = b.dt;
            Rad_Combo_Socially_Active.DataTextField = "Socially_Active";
            Rad_Combo_Socially_Active.DataBind();
            
            Label5.Visible = false;
            Rad_ListBox_State.Visible = false;
            RadComboBox_State.Visible = false;
            Label27.Visible = false;		
            Rad_drugs_never.Visible = false;
            Rad_drugs_Occasionally.Visible = false;
            Rad_drugs_regullar.Visible = false;
            Label13.Visible = false;

            //Rad_Lable_Socialy_Active.Visible = false;
            //Rad_txt_Another_Hobby.Visible = false;
            
            //tab2
            /*Label9.Visible = false;
            Label10.Visible = false;
            Label11.Visible = false;
            Label12.Visible = false;
            Label13.Visible = false;
            Label14.Visible = false;
            Label15.Visible = false;
            Label16.Visible = false;
            RadComboBox3.Visible = false;
            RadComboBox4.Visible = false;*/
            //RadPageView2.Visible = false;
            //RadPageView3.Visible = false;
            //RadTabStrip1.Tabs.Remove(RadTabStrip1.Tabs[1]);
            //RadTabStrip1.Tabs.Remove(RadTabStrip1.Tabs[2]);
        }
    }
    protected void RadButton2_Click(object sender, EventArgs e)
    {
        
        //RadPageView2.Visible = true;
        //RadTabStrip1.Tabs[1].Enabled = true;
        RadPageView2.Selected = true;
        RadTabStrip1.Tabs[1].Selected = true;
       // RadTabStrip1.Tabs.Add(RadTabStrip1.Tabs[1]);
       // RadTabStrip1.Tabs.Remove(RadTabStrip1.Tabs[2]);
        //RadTabStrip1.Tabs.Remove(RadTabStrip1.Tabs[0]);
       /* BOL_Management_Class1 b_signUp=new BOL_Management_Class1();
        b_signUp.SignUp_con();
        b_signUp.mydatarow=b_signUp.dt.NewRow();
        b_signUp.mydatarow["FName"]=Rad_Txt_FName.Text;
        b_signUp.mydatarow["LName"]=Rat_Txt_Lname.Text;
        b_signUp.mydatarow["Email"]=Rad_Txt_Email.Text;
        b_signUp.mydatarow["BirthDate"]=Rad_Date_time_picker.ValidationDate;
        if (Radio_Gender_female.Checked)
        {
            b_signUp.mydatarow["Gender"] = "Female";
        }
        if (Radio_Gender_male.Checked)
        {
            b_signUp.mydatarow["Gender"] = "Male";
        }
        b_signUp.mydatarow["Country"]=Rad_Combo_Country.Text;
        b_signUp.mydatarow["States"] = Rad_ListBox_State.SelectedItem.Text;
        b_signUp.mydatarow["User_Address"]=Rad_Txt_Address.Text;
        b_signUp.mydatarow["Inserted_Date"] = DateTime.Now;
        b_signUp.mydatarow["User_Ip"] = Convert.ToString(Request.UserHostAddress);
        b_signUp.dt.Rows.Add(b_signUp.mydatarow);
        b_signUp.da.Update(b_signUp.ds, "[Sign_up_page]");*/
    }
    protected void Rad_Combo_Country_SelectedIndexChanged(object sender, Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs e)
    {
        Label5.Visible = true;
        Rad_ListBox_State.Visible = false;
        RadComboBox_State.Visible = true;
	    Label27.Visible = true;
        if (Rad_Combo_Country.SelectedIndex == 0)
        {
            Label5.Visible = false;
            Rad_ListBox_State.Visible = false;
        }
        int selected_State_value;
        BOL_Management_Class1 b1 = new BOL_Management_Class1();
        selected_State_value = Rad_Combo_Country.SelectedIndex;
        b1.bindState(selected_State_value);
        // telerik_listbox.Items.Clear();
        /*Rad_ListBox_State.DataSource = b1.dt;
        Rad_ListBox_State.DataTextField = "STATES";
        Rad_ListBox_State.DataBind();*/

        RadComboBox_State.DataSource = b1.dt;
        RadComboBox_State.DataTextField = "STATES";
        RadComboBox_State.DataBind();
    }
    protected void RadButton7_Click(object sender, EventArgs e)
    {
       
        //Rad_txt_Another_Hobby.Visible = true;
        Rad_Lable_Socialy_Active.Visible = true;
    }
    protected void RadButton3_Click(object sender, EventArgs e)
    {
        RadPageView1.Selected = true;
        RadTabStrip1.Tabs[0].Selected = true;
       // RadTabStrip1.Tabs.Contains(RadTabStrip1.Tabs[0]);
       // RadTabStrip1.Tabs.Remove(RadTabStrip1.Tabs[2]);
       // RadTabStrip1.Tabs.Remove(RadTabStrip1.Tabs[1]);
    }
    protected void RadButton4_Click(object sender, EventArgs e)
    {
        RadPageView3.Selected = true;
        RadTabStrip1.Tabs[2].Selected = true;
        //RadTabStrip1.Tabs.Remove(RadTabStrip1.Tabs[0]);
        //RadTabStrip1.Tabs.Remove(RadTabStrip1.Tabs[1]);
    }
    protected void RadButton6_Click(object sender, EventArgs e)
    {
        RadPageView2.Selected = true;
        RadTabStrip1.Tabs[1].Selected = true;
    }
    protected void RadButton5_Click(object sender, EventArgs e)
    {
        /*BOL_Management_Class1 b_signUp = new BOL_Management_Class1();
        b_signUp.SignUp_con();
        b_signUp.mydatarow = b_signUp.dt.NewRow();
        b_signUp.mydatarow["FName"] = Rad_Txt_FName.Text;
        b_signUp.mydatarow["LName"] = Rat_Txt_Lname.Text;
        b_signUp.mydatarow["Email"] = Rad_Txt_Email.Text;
        b_signUp.mydatarow["Password"] = RadTxtPassword.Text;
        b_signUp.mydatarow["ConfPassword"] = RadTxtConfirmPass.Text;
        b_signUp.mydatarow["BirthDate"] = Rad_Date_time_picker.ValidationDate;
        if (Radio_Gender_female.Checked)
        {
            b_signUp.mydatarow["Gender"] = "Female";
        }
        if (Radio_Gender_male.Checked)
        {
            b_signUp.mydatarow["Gender"] = "Male";
        }
        if (Rad_Combo_Country.SelectedIndex == 0)
        { b_signUp.mydatarow["Country"] = "None"; }
        else
        {
            b_signUp.mydatarow["Country"] = Rad_Combo_Country.Text;
        }
        if (Rad_Combo_Country.SelectedIndex == 0)
        { 
            b_signUp.mydatarow["States"] = "None"; 
        }
        else
        {
            //b_signUp.mydatarow["States"] = Rad_ListBox_State.SelectedItem.Text;
            b_signUp.mydatarow["States"] = RadComboBox_State.Text;
        }
        b_signUp.mydatarow["User_Address"] = Rad_Txt_Address.Text;
        b_signUp.mydatarow["Blood_Group"] = Rad_Combo_Blood_Group.Text;
        if (Rad_radio_smk_Never.Checked)
        {
            b_signUp.mydatarow["Smoking_Habit"] = "Never";
        }
        if (Rad_radio_smk_Occasionally.Checked)
        {
            b_signUp.mydatarow["Smoking_Habit"] = "Occasionally";
        }
        if(Rad_radio_smk_Regular.Checked)
        {
            b_signUp.mydatarow["Smoking_Habit"] = "Regular";
        }
        if (Rad_radio_alchol_Never.Checked)
        {
            b_signUp.mydatarow["Alcohol_Consumption"] = "Never";
        }
        if (Rad_radio_alchol_Occasionally.Checked)
        {
            b_signUp.mydatarow["Alcohol_Consumption"] = "Occasionally";
        }
        if (Rad_radio_alchol_Regular.Checked)
        {
            b_signUp.mydatarow["Alcohol_Consumption"] = "Regular";
        }
        b_signUp.mydatarow["Drugs_Name"] = Rad_Combo_Drugs.Text;
        if (Rad_drugs_never.Checked)
        {
            b_signUp.mydatarow["Rate_of_Consumtion"] = "Never";
        }
        if (Rad_drugs_Occasionally.Checked)
        {
            b_signUp.mydatarow["Rate_of_Consumtion"] = "Occasionally";
        }
        if (Rad_drugs_regullar.Checked)
        {
            b_signUp.mydatarow["Rate_of_Consumtion"] = "Regular";
        }
        if (Allergies_no.Checked)
        {
            b_signUp.mydatarow["Allergies"] = "No Allergies";
        }
        if (Allergies_food.Checked)
        {
            b_signUp.mydatarow["Allergies"] = "Food Allergies";
        }
        if (Allergies_Skin .Checked)
        {
            b_signUp.mydatarow["Allergies"] = "Skin Allergies";
        }
        if (Allergies_medicine.Checked)
        {
            b_signUp.mydatarow["Allergies"] = "Medicine Allergies";
        }
        b_signUp.mydatarow["Hereditory_Disease"] = Rad_Combo_Hereditery_Diseases.Text;
        b_signUp.mydatarow["Profession"] = Rad_Combo_Nature_Profession.Text;
        b_signUp.mydatarow["Socially_Active"] = Rad_Combo_Socially_Active.Text;
        b_signUp.mydatarow["Other_Problem"] = Txt_other_problem.Text;
        b_signUp.mydatarow["Mediacal_History"] = Txt_Medical_History.Text;
        b_signUp.mydatarow["Inserted_Date"] = DateTime.Now;
        b_signUp.mydatarow["User_Ip"] = Convert.ToString(Request.UserHostAddress);
        b_signUp.dt.Rows.Add(b_signUp.mydatarow);
        b_signUp.da.Update(b_signUp.ds, "[Sign_up_page]");
        Response.Redirect("Signup_Thanking.aspx");*/
      }
    protected void Rad_Combo_Drugs_SelectedIndexChanged(object sender, Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs e)
    {
        /*Rad_drugs_never.Visible = true;
        Rad_drugs_Occasionally.Visible = true;
        Rad_drugs_regullar.Visible = true;
        Label13.Visible = true;*/
        /*if (Rad_Combo_Drugs.SelectedIndex == 10)
        {
            Rad_drugs_never.Visible = false;
            Rad_drugs_Occasionally.Visible = false;
            Rad_drugs_regullar.Visible = false;
            Label13.Visible = false;
        }*/
    }
    /*protected void Btn_first_tab_Click(object sender, EventArgs e)
    {
        RadPageView2.Selected = true;
        RadTabStrip1.Tabs[1].Selected = true;
    }*/
    protected void Btn_first_tab_Click(object sender, EventArgs e)
    {
        //Response.Write("hi");
        RadPageView2.Selected = true;
        RadTabStrip1.Tabs[1].Selected = true;
    }
    protected void rbtnNext_Click(object sender, EventArgs e)
    {
        RadPageView2.Selected = true;
        RadTabStrip1.Tabs[1].Selected = true;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        RadPageView2.Selected = true;
        RadTabStrip1.Tabs[1].Selected = true;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        RadPageView3.Selected = true;
        RadTabStrip1.Tabs[2].Selected = true;
    }
   
    protected void Button4_Click(object sender, EventArgs e)
    {
        /*BOL_Management_Class1 b_signUp = new BOL_Management_Class1();
        b_signUp.SignUp_con();
        b_signUp.mydatarow = b_signUp.dt.NewRow();
        b_signUp.mydatarow["FName"] = Rad_Txt_FName.Text;
        b_signUp.mydatarow["LName"] = Rat_Txt_Lname.Text;
        b_signUp.mydatarow["Email"] = Rad_Txt_Email.Text;
        b_signUp.mydatarow["Password"] = RadTxtPassword.Text;
        b_signUp.mydatarow["ConfPassword"] = RadTxtConfirmPass.Text;
        b_signUp.mydatarow["BirthDate"] = Rad_Date_time_picker.ValidationDate;
        if (Radio_Gender_female.Checked)
        {
            b_signUp.mydatarow["Gender"] = "Female";
        }
        if (Radio_Gender_male.Checked)
        {
            b_signUp.mydatarow["Gender"] = "Male";
        }
        if (Rad_Combo_Country.SelectedIndex == 0)
        { b_signUp.mydatarow["Country"] = "None"; }
        else
        {
            b_signUp.mydatarow["Country"] = Rad_Combo_Country.Text;
        }
        if (Rad_Combo_Country.SelectedIndex == 0)
        {
            b_signUp.mydatarow["States"] = "None";
        }
        else
        {
            b_signUp.mydatarow["States"] = Rad_ListBox_State.SelectedItem.Text;
        }
        b_signUp.mydatarow["User_Address"] = Rad_Txt_Address.Text;
        b_signUp.mydatarow["Blood_Group"] = Rad_Combo_Blood_Group.Text;
        if (Rad_radio_smk_Never.Checked)
        {
            b_signUp.mydatarow["Smoking_Habit"] = "Never";
        }
        if (Rad_radio_smk_Occasionally.Checked)
        {
            b_signUp.mydatarow["Smoking_Habit"] = "Occasionally";
        }
        if (Rad_radio_smk_Regular.Checked)
        {
            b_signUp.mydatarow["Smoking_Habit"] = "Regular";
        }
        if (Rad_radio_alchol_Never.Checked)
        {
            b_signUp.mydatarow["Alcohol_Consumption"] = "Never";
        }
        if (Rad_radio_alchol_Occasionally.Checked)
        {
            b_signUp.mydatarow["Alcohol_Consumption"] = "Occasionally";
        }
        if (Rad_radio_alchol_Regular.Checked)
        {
            b_signUp.mydatarow["Alcohol_Consumption"] = "Regular";
        }
        b_signUp.mydatarow["Drugs_Name"] = Rad_Combo_Drugs.Text;
        if (Rad_drugs_never.Checked)
        {
            b_signUp.mydatarow["Rate_of_Consumtion"] = "Never";
        }
        if (Rad_drugs_Occasionally.Checked)
        {
            b_signUp.mydatarow["Rate_of_Consumtion"] = "Occasionally";
        }
        if (Rad_drugs_regullar.Checked)
        {
            b_signUp.mydatarow["Rate_of_Consumtion"] = "Regular";
        }
        if (Allergies_no.Checked)
        {
            b_signUp.mydatarow["Allergies"] = "No Allergies";
        }
        if (Allergies_food.Checked)
        {
            b_signUp.mydatarow["Allergies"] = "Food Allergies";
        }
        if (Allergies_Skin.Checked)
        {
            b_signUp.mydatarow["Allergies"] = "Skin Allergies";
        }
        if (Allergies_medicine.Checked)
        {
            b_signUp.mydatarow["Allergies"] = "Medicine Allergies";
        }
        b_signUp.mydatarow["Hereditory_Disease"] = Rad_Combo_Hereditery_Diseases.Text;
        b_signUp.mydatarow["Profession"] = Rad_Combo_Nature_Profession.Text;
        b_signUp.mydatarow["Socially_Active"] = Rad_Combo_Socially_Active.Text;
        b_signUp.mydatarow["Other_Problem"] = Txt_other_problem.Text;
        //b_signUp.mydatarow["Other_Problem"] = Rad_txt_probs.Text;
        b_signUp.mydatarow["Mediacal_History"] = Txt_Medical_History.Text;
        b_signUp.mydatarow["Inserted_Date"] = DateTime.Now;
        b_signUp.mydatarow["User_Ip"] = Convert.ToString(Request.UserHostAddress);
        b_signUp.dt.Rows.Add(b_signUp.mydatarow);
        b_signUp.da.Update(b_signUp.ds, "[Sign_up_page]");
        Response.Redirect("Signup_Thanking.aspx");*/
    }
    protected void btn_data_send_Click(object sender, EventArgs e)
    {
        BOL_Management_Class1 b_signUp = new BOL_Management_Class1();
        b_signUp.SignUp_con();
        b_signUp.mydatarow = b_signUp.dt.NewRow();
        b_signUp.mydatarow["FName"] = Rad_Txt_FName.Text;
        b_signUp.mydatarow["LName"] = Rat_Txt_Lname.Text;
        b_signUp.mydatarow["Email"] = Rad_Txt_Email.Text;
        b_signUp.mydatarow["Password"] = RadTxtPassword.Text;
        b_signUp.mydatarow["ConfPassword"] = RadTxtConfirmPass.Text;
        b_signUp.mydatarow["BirthDate"] = Rad_Date_time_picker.ValidationDate;
        if (Radio_Gender_female.Checked)
        {
            b_signUp.mydatarow["Gender"] = "Female";
        }
        if (Radio_Gender_male.Checked)
        {
            b_signUp.mydatarow["Gender"] = "Male";
        }
        /*if (Rad_Combo_Country.SelectedIndex == 0)
        { b_signUp.mydatarow["Country"] = "None"; }
        else
        {
            b_signUp.mydatarow["Country"] = Rad_Combo_Country.Text;
        }
        if (Rad_Combo_Country.SelectedIndex == 0)
        {
            b_signUp.mydatarow["States"] = "None";
        }
        else
        {
            //b_signUp.mydatarow["States"] = Rad_ListBox_State.SelectedItem.Text;
            b_signUp.mydatarow["States"] = RadComboBox_State.Text;
        }*/
        b_signUp.mydatarow["States"] = RadComboBox_State.Text;
        b_signUp.mydatarow["Country"] = Rad_Combo_Country.Text;
        b_signUp.mydatarow["User_Address"] = Rad_Txt_Address.Text;
        b_signUp.mydatarow["Blood_Group"] = Rad_Combo_Blood_Group.Text;
        if (Rad_radio_smk_Never.Checked)
                    b_signUp.mydatarow["Smoking_Habit"] = "Never";
        if (Rad_radio_smk_Occasionally.Checked)
                    b_signUp.mydatarow["Smoking_Habit"] = "Occasionally";
        if (Rad_radio_smk_Regular.Checked)
                    b_signUp.mydatarow["Smoking_Habit"] = "Regular";
        
        if (Rad_radio_alchol_Never.Checked)
                    b_signUp.mydatarow["Alcohol_Consumption"] = "Never";
        
        if (Rad_radio_alchol_Occasionally.Checked)
                    b_signUp.mydatarow["Alcohol_Consumption"] = "Occasionally";
        
        if (Rad_radio_alchol_Regular.Checked)
                    b_signUp.mydatarow["Alcohol_Consumption"] = "Regular";
        
        b_signUp.mydatarow["Drugs_Name"] = Rad_Combo_Drugs.Text;
        if (Rad_drugs_never.Checked)
                    b_signUp.mydatarow["Rate_of_Consumtion"] = "Never";
        
        if (Rad_drugs_Occasionally.Checked)
                    b_signUp.mydatarow["Rate_of_Consumtion"] = "Occasionally";
        
        if (Rad_drugs_regullar.Checked)
                    b_signUp.mydatarow["Rate_of_Consumtion"] = "Regular";
        
        if (Allergies_no.Checked)
                    b_signUp.mydatarow["Allergies"] = "No Allergies";
        
        if (Allergies_food.Checked)
                    b_signUp.mydatarow["Allergies"] = "Food Allergies";
        
        if (Allergies_Skin.Checked)
                    b_signUp.mydatarow["Allergies"] = "Skin Allergies";
        
        if (Allergies_medicine.Checked)
                    b_signUp.mydatarow["Allergies"] = "Medicine Allergies";
        
        b_signUp.mydatarow["Hereditory_Disease"] = Rad_Combo_Hereditery_Diseases.Text;
        b_signUp.mydatarow["Profession"] = Rad_Combo_Nature_Profession.Text;
        b_signUp.mydatarow["Socially_Active"] = Rad_Combo_Socially_Active.Text;
        b_signUp.mydatarow["Other_Problem"] = Txt_other_problem.Text;
        b_signUp.mydatarow["Mediacal_History"] = Txt_Medical_History.Text;
        b_signUp.mydatarow["Inserted_Date"] = DateTime.Now;
        b_signUp.mydatarow["User_Ip"] = Convert.ToString(Request.UserHostAddress);
        b_signUp.dt.Rows.Add(b_signUp.mydatarow);
        b_signUp.da.Update(b_signUp.ds, "[Sign_up_page]");
        Response.Redirect("Signup_Thanking.aspx");
    }
    
}