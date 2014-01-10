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
    public string newFname;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserId"] == null)
            Response.Redirect("Sign_In.aspx");
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

            Label5.Visible = true;
            //Rad_ListBox_State.Visible = true;
            Label27.Visible = true;
            Rad_drugs_never.Visible = false;
            Rad_drugs_Occasionally.Visible = false;
            Rad_drugs_regullar.Visible = false;
            Label13.Visible = false;

            RadWindow1.VisibleOnPageLoad = false;

            string user_ID1 = (string)Session["userid"];
            Label46.Text = user_ID1;

            string userName = (string)Session["wllcomeFname"];
            Label45.Text = userName;

            string FName = (string)Session["wllcomeFname"];
            string Passward = (string)Session["user_password"];
            //b.send_user_sign_up_data(FName, Passward);

            b.send_user_sign_up_data_by_id(user_ID1);

            //Control form1 = new Control();
            /*Control myform = Page.FindControl("form1");
            foreach(Control c in myform.Controls)
            {
                if(c.GetType().ToString().Equals("System.Web.UI.WebControls.TextBox"))
                {
                    radtxtbo
                }
            
            }*/

            Rad_Txt_FName.Enabled = false; Rat_Txt_Lname.Enabled = false; Rad_Txt_Email.Enabled = false; Rad_Date_time_picker.Enabled = false; Radio_Gender_male.Enabled = false;
            Radio_Gender_female.Enabled = false; Rad_Combo_Country.Enabled = false; RadComboBox_State.Enabled = false;
            Rad_Txt_Address.Enabled = false; Rad_Combo_Blood_Group.Enabled = false; Rad_radio_smk_Never.Enabled = false; Rad_radio_smk_Occasionally.Enabled = false; Rad_radio_smk_Regular.Enabled = false; Rad_radio_alchol_Never.Enabled = false;
            Rad_radio_alchol_Occasionally.Enabled = false; Rad_radio_alchol_Regular.Enabled = false; Rad_Combo_Drugs.SelectedItem.Enabled = false; Allergies_no.Enabled = false;
            Allergies_food.Enabled = false; Allergies_Skin.Enabled = false; Allergies_medicine.Enabled = false; Rad_Combo_Hereditery_Diseases.Enabled = false;
            Rad_Combo_Nature_Profession.Enabled = false; Rad_Combo_Socially_Active.SelectedItem.Enabled = false; Txt_other_problem.Enabled = false; Txt_Medical_History.Enabled = false;
            Rad_Combo_Drugs.Enabled = false; Rad_Combo_Socially_Active.Enabled = false; btn_data_send.Visible = false;


            if (b.dt.Rows.Count > 0)
            {
                Rad_Txt_FName.Text = b.dt.Rows[0]["FName"].ToString().TrimEnd();
                Rat_Txt_Lname.Text = b.dt.Rows[0]["LName"].ToString();
                Rad_Txt_Email.Text = b.dt.Rows[0]["Email"].ToString();
                //string b_date=Convert.ToDateTime) Rad_Date_time_picker ;
                Rad_Date_time_picker.SelectedDate = Convert.ToDateTime(b.dt.Rows[0]["BirthDate"].ToString());
                if ((string)b.dt.Rows[0]["Gender"] == (string)"Male")
                    Radio_Gender_male.Checked = true;
                else if ((string)b.dt.Rows[0]["Gender"] == (string)"Female")
                    Radio_Gender_female.Checked = true;

                string country_choos = b.dt.Rows[0]["Country"].ToString();
                Rad_Combo_Country.SelectedItem.Text = country_choos;
                string selected_state = b.dt.Rows[0]["States"].ToString();
                //string selected_Country = country_choos;
                BOL_Management_Class1 b_state = new BOL_Management_Class1();
                b_state.bindState_by_country(country_choos);
                /*Rad_ListBox_State.DataSource = b_state.dt;
                Rad_ListBox_State.DataTextField = "States";
                Rad_ListBox_State.DataBind();*/

                RadComboBox_State.DataSource = b_state.dt;
                RadComboBox_State.DataTextField = "States";
                RadComboBox_State.DataBind();

                //Rad_ListBox_State.Items.Add(b.dt.Rows[0]["States"]);
                //Rad_ListBox_State.SelectedItem.Text =selected_state;
                Rad_Txt_Address.Text = b.dt.Rows[0]["User_Address"].ToString();
                string Select_blood_group = b.dt.Rows[0]["Blood_Group"].ToString();
                Rad_Combo_Blood_Group.SelectedItem.Text = Select_blood_group;

                if ((string)b.dt.Rows[0]["Smoking_Habit"] == (string)"Never")
                    Rad_radio_smk_Never.Checked = true;
                else if ((string)b.dt.Rows[0]["Smoking_Habit"] == (string)"Occasionally")
                    Rad_radio_smk_Occasionally.Checked = true;
                else if ((string)b.dt.Rows[0]["Smoking_Habit"] == (string)"Regular")
                    Rad_radio_smk_Regular.Checked = true;

                if ((string)b.dt.Rows[0]["Alcohol_Consumption"] == (string)"Never")
                    Rad_radio_alchol_Never.Checked = true;
                else if ((string)b.dt.Rows[0]["Alcohol_Consumption"] == (string)"Occasionally")
                    Rad_radio_alchol_Occasionally.Checked = true;
                else if ((string)b.dt.Rows[0]["Alcohol_Consumption"] == (string)"Regular")
                    Rad_radio_alchol_Regular.Checked = true;

                string drugs_consumtion = b.dt.Rows[0]["Drugs_Name"].ToString();
                Rad_Combo_Drugs.SelectedItem.Text = drugs_consumtion;

                if ((string)b.dt.Rows[0]["Allergies"] == (string)"No Allergies")
                    Allergies_no.Checked = true;
                else if ((string)b.dt.Rows[0]["Allergies"] == (string)"Food Allergies")
                    Allergies_food.Checked = true;
                else if ((string)b.dt.Rows[0]["Allergies"] == (string)"Skin Allergies")
                    Allergies_Skin.Checked = true;
                else if ((string)b.dt.Rows[0]["Allergies"] == (string)"Medicine Allergies")
                    Allergies_medicine.Checked = true;

                string Hereditory_Diseases = b.dt.Rows[0]["Hereditory_Disease"].ToString();
                Rad_Combo_Hereditery_Diseases.SelectedItem.Text = Hereditory_Diseases;

                string Nature_Profession = b.dt.Rows[0]["Profession"].ToString();
                Rad_Combo_Nature_Profession.SelectedItem.Text = Nature_Profession;

                string socially_activity_rate = b.dt.Rows[0]["Socially_Active"].ToString();
                Rad_Combo_Socially_Active.SelectedItem.Text = socially_activity_rate;

                Txt_other_problem.Text = b.dt.Rows[0]["Other_Problem"].ToString();
                Txt_Medical_History.Text = b.dt.Rows[0]["Mediacal_History"].ToString();
                /*Rad_ListBox_State.Items.Add(selected_state);
                Session["states"] = selected_state;
                Rad_ListBox_State.Items.Add(new ListItem(b.dt.Rows[0]["States"]));
                Rad_ListBox_State.SelectedItem.Text = selected_state;
                Rad_ListBox_State.SelectedValue = selected_state;*/
            }

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
        //Rad_ListBox_State.Visible = false;

        Label27.Visible = true;
        if (Rad_Combo_Country.SelectedIndex == 0)
        {
            Label5.Visible = false;
            //Rad_ListBox_State.Visible = false;
        }
        //int selected_State_value;
        string selected_states;
        BOL_Management_Class1 b1 = new BOL_Management_Class1();
        //selected_State_value = Rad_Combo_Country.SelectedIndex;
        selected_states = Rad_Combo_Country.Text;
        b1.bindState_by_country(selected_states);
        //b1.bindState(selected_State_value);
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
        //b_signUp.mydatarow = b_signUp.dt.NewRow();
        string user_ID1 = (string)Session["userid"];
        Label46.Text = user_ID1;
        DataRow myrow;
        myrow = b_signUp.dt.Rows.Find(user_ID1);


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
        //b_signUp.dt.Rows.Add(b_signUp.mydatarow);
        
        
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
        /* BOL_Management_Class1 b_signUp = new BOL_Management_Class1();
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
        string user_ID1 = (string)Session["userid"];
        Label46.Text = user_ID1;
        int user_id_int = Convert.ToInt32(Label46.Text);
        DataRow myrow;
        myrow = b_signUp.dt.Rows.Find(user_id_int);


        //myrow = user_ID1;
        //b_signUp.mydatarow = b_signUp.dt.NewRow();

        myrow["FName"] = Rad_Txt_FName.Text;
        myrow["LName"] = Rat_Txt_Lname.Text;
        myrow["Email"] = Rad_Txt_Email.Text;
        /*myrow["Password"] = RadTxtPassword.Text;
        myrow["ConfPassword"] = RadTxtConfirmPass.Text;*/
        myrow["BirthDate"] = Rad_Date_time_picker.ValidationDate;
        if (Radio_Gender_female.Checked)
            myrow["Gender"] = "Female";
        if (Radio_Gender_male.Checked)
            myrow["Gender"] = "Male";
        /* if (Rad_Combo_Country.SelectedIndex == 0)
         { myrow["Country"] = "None"; }
         else
         {
             myrow["Country"] = Rad_Combo_Country.Text;
         }*/
        myrow["Country"] = Rad_Combo_Country.Text;

        //myrow["States"] = Rad_ListBox_State.SelectedItem.Text;
        myrow["States"] = RadComboBox_State.Text;
        /*if (Rad_Combo_Country.SelectedIndex == 0)
        {
            myrow["States"] = "None";
        }
        else
        {
            myrow["States"] = Rad_ListBox_State.SelectedItem.Text;
        }*/
        myrow["User_Address"] = Rad_Txt_Address.Text;
        myrow["Blood_Group"] = Rad_Combo_Blood_Group.Text;
        if (Rad_radio_smk_Never.Checked)
            myrow["Smoking_Habit"] = "Never";
        if (Rad_radio_smk_Occasionally.Checked)
            myrow["Smoking_Habit"] = "Occasionally";
        if (Rad_radio_smk_Regular.Checked)
            myrow["Smoking_Habit"] = "Regular";
        if (Rad_radio_alchol_Never.Checked)
            myrow["Alcohol_Consumption"] = "Never";
        if (Rad_radio_alchol_Occasionally.Checked)
            myrow["Alcohol_Consumption"] = "Occasionally";
        if (Rad_radio_alchol_Regular.Checked)
            myrow["Alcohol_Consumption"] = "Regular";

        myrow["Drugs_Name"] = Rad_Combo_Drugs.Text;
        /*if (Rad_drugs_never.Checked)
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
        }*/
        if (Allergies_no.Checked)
            myrow["Allergies"] = "No Allergies";
        if (Allergies_food.Checked)
            myrow["Allergies"] = "Food Allergies";
        if (Allergies_Skin.Checked)
            myrow["Allergies"] = "Skin Allergies";
        if (Allergies_medicine.Checked)
            myrow["Allergies"] = "Medicine Allergies";
        myrow["Hereditory_Disease"] = Rad_Combo_Hereditery_Diseases.Text;
        myrow["Profession"] = Rad_Combo_Nature_Profession.Text;
        myrow["Socially_Active"] = Rad_Combo_Socially_Active.Text;
        myrow["Other_Problem"] = Txt_other_problem.Text;
        myrow["Mediacal_History"] = Txt_Medical_History.Text;
        myrow["Inserted_Date"] = DateTime.Now;
        myrow["User_Ip"] = Convert.ToString(Request.UserHostAddress);
        //b_signUp.dt.Rows.Add(b_signUp.mydatarow);
        b_signUp.da.Update(b_signUp.ds, "[Sign_up_page]");
        RadWindow1.VisibleOnPageLoad = true;

        //newFname = Rad_Txt_FName.Text;
        newFname = myrow.ItemArray[0].ToString();
        Session["newUserNeme"] = newFname;
        //Session["mysession"] = myrow;
        /*RadButton1.Enabled = true;
        RadButton8.Enabled = true;
        RadButton9.Enabled = true;*/
        //Response.Redirect("Signup_Thanking.aspx");
        //Response.Write("Data Is Updated");
    }
    protected void RadButton1_Click(object sender, EventArgs e)
    {
        Rad_Txt_FName.Enabled = true; Rat_Txt_Lname.Enabled = true; Rad_Txt_Email.Enabled = true; Rad_Date_time_picker.Enabled = true; Radio_Gender_male.Enabled = true;
        Radio_Gender_female.Enabled = true; Rad_Combo_Country.Enabled = true; RadComboBox_State.Enabled = true;
        Rad_Txt_Address.Enabled = true; Rad_Combo_Blood_Group.Enabled = true; Rad_radio_smk_Never.Enabled = true; Rad_radio_smk_Occasionally.Enabled = true; Rad_radio_smk_Regular.Enabled = true; Rad_radio_alchol_Never.Enabled = true;
        Rad_radio_alchol_Occasionally.Enabled = true; Rad_radio_alchol_Regular.Enabled = true; Rad_Combo_Drugs.SelectedItem.Enabled = true; Allergies_no.Enabled = true;
        Allergies_food.Enabled = true; Allergies_Skin.Enabled = true; Allergies_medicine.Enabled = true; Rad_Combo_Hereditery_Diseases.Enabled = true;
        Rad_Combo_Nature_Profession.Enabled = true; Rad_Combo_Socially_Active.SelectedItem.Enabled = true; Txt_other_problem.Enabled = true; Txt_Medical_History.Enabled = true;
        Rad_Combo_Drugs.Enabled = true; Rad_Combo_Socially_Active.Enabled = true; btn_data_send.Visible = true;

        RadButton1.Enabled = false;
        RadButton8.Enabled = false;
        RadButton9.Enabled = false;
        Rad_Txt_FName.Focus();
    }
    protected void RadButton8_Click(object sender, EventArgs e)
    {
        Response.Redirect("Change_Password.aspx");
    }
    protected void RadButton7_Click1(object sender, EventArgs e)
    {
        RadWindow1.VisibleOnPageLoad = false;
        RadButton1.Enabled = true;
        RadButton8.Enabled = true;
        RadButton9.Enabled = true;

        Rad_Txt_FName.Enabled = false; Rat_Txt_Lname.Enabled = false; Rad_Txt_Email.Enabled = false; Rad_Date_time_picker.Enabled = false; Radio_Gender_male.Enabled = false;
        Radio_Gender_female.Enabled = false; Rad_Combo_Country.Enabled = false; RadComboBox_State.Enabled = false; Rad_Txt_Address.Enabled = false; Rad_Combo_Blood_Group.Enabled = false;
        Rad_radio_smk_Never.Enabled = false; Rad_radio_smk_Occasionally.Enabled = false; Rad_radio_smk_Regular.Enabled = false; Rad_radio_alchol_Never.Enabled = false;
        Rad_radio_alchol_Occasionally.Enabled = false; Rad_radio_alchol_Regular.Enabled = false; Rad_Combo_Drugs.SelectedItem.Enabled = false; Allergies_no.Enabled = false;
        Allergies_food.Enabled = false; Allergies_Skin.Enabled = false; Allergies_medicine.Enabled = false; Rad_Combo_Hereditery_Diseases.Enabled = false;
        Rad_Combo_Nature_Profession.Enabled = false; Rad_Combo_Socially_Active.SelectedItem.Enabled = false; Txt_other_problem.Enabled = false; Txt_Medical_History.Enabled = false;
        Rad_Combo_Drugs.Enabled = false; Rad_Combo_Socially_Active.Enabled = false; btn_data_send.Visible = false;

    }
    protected void RadButton9_Click(object sender, EventArgs e)
    {
        BOL_Management_Class1 delete_prof = new BOL_Management_Class1();
        string user_ID1 = (string)Session["userid"];
        Label46.Text = user_ID1;

        delete_prof.delete_profile(user_ID1);
        Response.Redirect("Home.aspx");

    }

}