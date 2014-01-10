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


public partial class Helth_CheckUp_Desk : System.Web.UI.Page
{
    public int btnckick = 0;
    public string uniFname;
    public DataRow myrow;
    public string user_id;
    protected void Page_Load(object sender, EventArgs e)
    {
        /*if (Session["time_out"] == null)
        {
            Response.Redirect("Sign_In.aspx");
        }*/
        if (Session["UserId"] == null)
        {
            Response.Redirect("Sign_In.aspx");
            //Sign_In_WebUserControl1.Visible = true;
            //RadWindow7.VisibleOnPageLoad = true;
            
        }
        //Response.Cache.SetCacheability(HttpCacheability.NoCache);
        if (!IsPostBack)
        {
           
            BOL_Management_Class1 health_desk_obj = new BOL_Management_Class1();
            health_desk_obj.Helth_Checkup_Combo_con();
            
            Rad_Combo_Health_Dsk_Name.DataSource = health_desk_obj.dt;
            Rad_Combo_Health_Dsk_Name.DataTextField = "FName";
            Rad_Combo_Health_Dsk_Name.DataBind();
            string FName = (string) Session["wllcomeFname"];
            string Passward = (string)Session["user_password"];
            string newpassword = (string)Session["confirm_pass"];
            string newFname= (string) Session["newUserNeme"];
            //RadTextBox1.Text = FName;
            

            lbl_wellcome.Text = FName;
            uniFname = FName;
            Session["uniqName"] = uniFname;

            /*if (newFname != null && newFname != "" && newpassword != null && newpassword != "")
            {
                FName = null;
                Passward = null;
                Lbl_password.Text = newpassword;
                health_desk_obj.send_user_ID(newFname, newpassword);
                lbl_User_ID.Text = health_desk_obj.dt.Rows[0]["UserID"].ToString();
                lbl_User_ID.DataBind();
                string user_id = lbl_User_ID.Text;
                Session["userid"] = user_id;
            }*/

            if (newpassword != null && newpassword != "")
                            Passward = newpassword;

            if (newFname != null && newFname != "")
                FName = newFname;

            if (Passward != null && Passward != "" && FName != null && FName != "")
            {
                newFname = null;
                newpassword = null;
                Lbl_password.Text = Passward;
                health_desk_obj.send_user_ID(FName, Passward);
                lbl_User_ID.Text = health_desk_obj.dt.Rows[0]["UserID"].ToString();
                lbl_User_ID.DataBind();
                user_id = lbl_User_ID.Text;
                Session["userid"] = user_id;
            }


            /*if (newpassword != null && newpassword != "" )
            {
                Passward = null;
                Lbl_password.Text = newpassword;
                health_desk_obj.send_user_ID(FName, newpassword);
                lbl_User_ID.Text = health_desk_obj.dt.Rows[0]["UserID"].ToString();
                lbl_User_ID.DataBind();
                string user_id = lbl_User_ID.Text;
                Session["userid"] = user_id;
            }

            if (newFname != null && newFname != "")
            {
                FName = null;
                Lbl_password.Text = newpassword;
                health_desk_obj.send_user_ID(newFname, Passward);
                lbl_User_ID.Text = health_desk_obj.dt.Rows[0]["UserID"].ToString();
                lbl_User_ID.DataBind();
                string user_id = lbl_User_ID.Text;
                Session["userid"] = user_id;
            }*/

                     
            health_desk_obj.Medical_Drugs_connection();
            Rad_Combo_Type_Of_Diseases.DataSource = health_desk_obj.dt;
            Rad_Combo_Type_Of_Diseases.DataTextField = "Type_Of_Disease";
            Rad_Combo_Type_Of_Diseases.DataBind();

            health_desk_obj.Medical_Duration_Of_Desease();
            Rad_Combo_Duration.DataSource = health_desk_obj.dt;
            Rad_Combo_Duration.DataTextField = "Duration_Of_Desease";
            Rad_Combo_Duration.DataBind();
            //RadButton1.Visible = false;
            RadWindow1.VisibleOnPageLoad = true;
            //RadWindow7.VisibleOnPageLoad = false;
            Rad_Combo_Health_Dsk_Name.Visible = false;
            Label2.Visible = false;

            BOL_Management_Class1 binding_sessio_value = new BOL_Management_Class1();
            binding_sessio_value.SignUp_con();
            string user_ID1 = (string)Session["userid"];
            myrow = binding_sessio_value.dt.Rows.Find(user_id);
            Session["mysession"] = myrow;

            /*health_desk_obj.send_user_ID(FName,Passward);
            lbl_User_ID.Text = health_desk_obj.dt.Rows[0]["UserID"].ToString();
            lbl_User_ID.DataBind();
            string user_id = lbl_User_ID.Text;
            Session ["userid"] = user_id;*/
        }       
    }
    
  
    protected void Rad_Combo_Health_Dsk_Name_SelectedIndexChanged(object sender, Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs e)
    {
        RadWindow1.VisibleOnPageLoad = true;
    }

    protected void Radio_Comman_Diseases_Click(object sender, EventArgs e)
    {
        RadWindow2.VisibleOnPageLoad = true;
        RadWindow4.VisibleOnPageLoad = false;
        RadWindow5.VisibleOnPageLoad = false;
        RadWindow6.VisibleOnPageLoad = false;
    }

    protected void Radio_Body_Part_Click(object sender, EventArgs e)
    {
        RadWindow4.VisibleOnPageLoad = true;
        RadWindow2.VisibleOnPageLoad = false;
        RadWindow3.VisibleOnPageLoad = false;
    }
    protected void Radio_Severity_Hegh_Click(object sender, EventArgs e)
    {
        RadWindow3.VisibleOnPageLoad = true;
    }
    protected void Radio_Severity_Moderate_Click(object sender, EventArgs e)
    {
        RadWindow3.VisibleOnPageLoad = true;
    }
    protected void Radio_Severity_Low_Click(object sender, EventArgs e)
    {
        RadWindow3.VisibleOnPageLoad = true;
    }
    protected void Rad_Combo_Type_Of_Diseases_SelectedIndexChanged(object sender, Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs e)
    {
        int Diseases_Index;
        Diseases_Index= Rad_Combo_Type_Of_Diseases.SelectedIndex;
        BOL_Management_Class1 binding_Diseases_Medcn = new BOL_Management_Class1();
        binding_Diseases_Medcn.Prescription(Diseases_Index);
        bl_Prescription.Text = binding_Diseases_Medcn.dt.Rows[0]["Prescription"].ToString();
    }
    protected void RadButton2_Click(object sender, EventArgs e)
    {
        Rad_flg1.Checked = true;
        RadWindow5.VisibleOnPageLoad = true;
        BOL_Management_Class1 head_combo_con = new BOL_Management_Class1();
        head_combo_con.Head_Sub_Body_Parts_con();
        Rad_combo_sub_parts.DataSource = head_combo_con.dt;
        Rad_combo_sub_parts.DataTextField = "Sub_BODY_PARTS";
        Rad_combo_sub_parts.DataBind();

    }
    protected void Rad_combo_sub_parts_SelectedIndexChanged(object sender, Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs e)
    {
        //if( btnckick==5 )
        //if (RadButton6.==true)
        if(Rad_flg5.Checked==true)
        {
                    int dr_name5_Index;
                    dr_name5_Index = Rad_combo_sub_parts.SelectedIndex;
                    BOL_Management_Class1 Body_subpart_Dr = new BOL_Management_Class1();
                    Body_subpart_Dr.Leg_subpart_Dr_Con(dr_name5_Index);
                    Rad_lbl_drname.Text = Body_subpart_Dr.dt.Rows[0]["Prescription"].ToString();
        }
       // if (btnckick == 4)
        //if(_Brn__Click.)
        if(Rad_flg4.Checked==true)
        {
            int dr_name4_Index;
            dr_name4_Index = Rad_combo_sub_parts.SelectedIndex;
            BOL_Management_Class1 Abdomen_subpart_Dr = new BOL_Management_Class1();
            Abdomen_subpart_Dr.Abdomen_subpart_Dr_Con(dr_name4_Index);
            Rad_lbl_drname.Text = Abdomen_subpart_Dr.dt.Rows[0]["Prescription"].ToString();
        }
        if (Rad_flg3.Checked == true)
        {
            int dr_name3_Index;
            dr_name3_Index = Rad_combo_sub_parts.SelectedIndex;
            BOL_Management_Class1 Arm_subpart_Dr = new BOL_Management_Class1();
            Arm_subpart_Dr.Abdomen_subpart_Dr_Con(dr_name3_Index);
            Rad_lbl_drname.Text = Arm_subpart_Dr.dt.Rows[0]["Prescription"].ToString();
        
        }
        if (Rad_flg2.Checked == true)
        {
            int dr_name2_Index;
            dr_name2_Index = Rad_combo_sub_parts.SelectedIndex;
            BOL_Management_Class1 Arm_subpart_Dr = new BOL_Management_Class1();
            Arm_subpart_Dr.Abdomen_subpart_Dr_Con(dr_name2_Index);
            Rad_lbl_drname.Text = Arm_subpart_Dr.dt.Rows[0]["Prescription"].ToString();
       
        }
        if (Rad_flg1.Checked == true)
        {
            int dr_name1_Index;
            dr_name1_Index = Rad_combo_sub_parts.SelectedIndex;
            BOL_Management_Class1 Arm_subpart_Dr = new BOL_Management_Class1();
            Arm_subpart_Dr.Head_Dr_Con(dr_name1_Index);
            Rad_lbl_drname.Text = Arm_subpart_Dr.dt.Rows[0]["Prescription"].ToString();
         }
    }
    protected void Rad_severity_Troma_Click(object sender, EventArgs e)
    {
        RadWindow6.VisibleOnPageLoad = true;
        
    }
    protected void Rad_severity_Injury_Click(object sender, EventArgs e)
    {
        RadWindow6.VisibleOnPageLoad = true;
    }
    protected void Rad_severity_Fractured_Click(object sender, EventArgs e)
    {
        RadWindow6.VisibleOnPageLoad = true;
    }
   /* protected void Rad_btn_lArm_Click(object sender, EventArgs e)
    {

    }*/
    protected void Rad_btn_rArm_Click(object sender, EventArgs e)
    {
        Rad_flg3.Checked = true;
        RadWindow5.VisibleOnPageLoad = true;
        BOL_Management_Class1 Arm_Sub_Body_Part = new BOL_Management_Class1();
        Arm_Sub_Body_Part.Arm_Sub_Body_Parts_con();
        Rad_combo_sub_parts.DataSource = Arm_Sub_Body_Part.dt;
        Rad_combo_sub_parts.DataTextField = "Arm_Sub_Body_PARTS";
        Rad_combo_sub_parts.DataBind();
    }
    protected void _Brn__Click(object sender, EventArgs e)
    {
        Rad_flg4.Checked = true;
        //btnckick = 4;
        RadWindow5.VisibleOnPageLoad = true;
        BOL_Management_Class1 Abdomen_Sub_Body_Parts = new BOL_Management_Class1();
        Abdomen_Sub_Body_Parts.Abdomen_Sub_Body_Parts_con();
        Rad_combo_sub_parts.DataSource = Abdomen_Sub_Body_Parts.dt;
        Rad_combo_sub_parts.DataTextField = "Abdomen_Sub_Body_PARTS";
        Rad_combo_sub_parts.DataBind();
    }
    protected void RadButton6_Click(object sender, EventArgs e)
    {
        Rad_flg5.Checked = true;
        //btnckick = 5;
        RadWindow5.VisibleOnPageLoad = true;
        BOL_Management_Class1 Leg_Sub_Body_Parts = new BOL_Management_Class1();
        Leg_Sub_Body_Parts.Leg_Sub_Body_Parts_con();
        Rad_combo_sub_parts.DataSource = Leg_Sub_Body_Parts.dt;
        Rad_combo_sub_parts.DataTextField = "Leg_Sub_Body_PARTS";
        Rad_combo_sub_parts.DataBind();
    }
    protected void Rad_btn_lArm_Click1(object sender, EventArgs e)
    {
        Rad_flg2.Checked = true;
        RadWindow5.VisibleOnPageLoad = true;
        BOL_Management_Class1 Arm_Sub_Body_Part = new BOL_Management_Class1();
        Arm_Sub_Body_Part.Arm_Sub_Body_Parts_con();
        Rad_combo_sub_parts.DataSource = Arm_Sub_Body_Part.dt;
        Rad_combo_sub_parts.DataTextField = "Arm_Sub_Body_PARTS";
        Rad_combo_sub_parts.DataBind();
    }
    protected void RadButton1_Click(object sender, EventArgs e)
    {
        RadWindow1.VisibleOnPageLoad = true;
        RadWindow2.VisibleOnPageLoad = false;
        RadWindow3.VisibleOnPageLoad = false;
        RadWindow4.VisibleOnPageLoad = false;
        RadWindow5.VisibleOnPageLoad = false;
        RadWindow6.VisibleOnPageLoad = false;

        BOL_Management_Class1 Health_Info = new BOL_Management_Class1();
        Health_Info.Health_Info_Details();
        Health_Info.mydatarow = Health_Info.dt.NewRow();
        Health_Info.mydatarow["FName"] = lbl_wellcome.Text;
        Health_Info.mydatarow["UserId"] = lbl_User_ID.Text;
        Health_Info.mydatarow["userVisited_Date"] = DateTime.Now;
            //.ToString() !=null ? lbl_wellcome.Text.ToString():string.Empty;
        if(Radio_Comman_Diseases.Checked)
        {
            Health_Info.mydatarow["Health_Problem_Area"] = "Comman Diseases";
            Health_Info.mydatarow["Select_Type"] = Rad_Combo_Type_Of_Diseases.Text;
            Health_Info.mydatarow["Selected_Duration"] = Rad_Combo_Duration.Text;
            if (Radio_Severity_Hegh.Checked)
                Health_Info.mydatarow["Severity"] = "Heigh";
            if (Radio_Severity_Moderate.Checked)
                Health_Info.mydatarow["Severity"] = "Moderate";
            if (Radio_Severity_Low.Checked)
                Health_Info.mydatarow["Severity"] = "Low";
            Health_Info.mydatarow["Prescribed"] = bl_Prescription.Text;
        }
        if (Radio_Body_Parts.Checked)
        {
            Health_Info.mydatarow["Health_Problem_Area"] = "Body parts";
            //Health_Info.mydatarow["Health_Problem_Area"] = "Comman Diseases";
            Health_Info.mydatarow["Select_Type"] = Rad_combo_sub_parts.Text;
            //Health_Info.mydatarow["Selected_Duration"] = Rad_Combo_Duration.Text;
            if (Rad_severity_Troma.Checked)
                Health_Info.mydatarow["Severity"] = "Tromma";
            if (Rad_severity_Injury.Checked)
                Health_Info.mydatarow["Severity"] = "Injury";
            if (Rad_severity_Fractured.Checked)
                Health_Info.mydatarow["Severity"] = "Fractured";
            Health_Info.mydatarow["Prescribed"] = Rad_lbl_drname.Text;
        }
        Health_Info.dt.Rows.Add(Health_Info.mydatarow);
        Health_Info.da.Update(Health_Info.ds, "Health_Info");
    }
    
    protected void Rad_Comman_Diseases_Click(object sender, EventArgs e)
    {
        RadWindow1.VisibleOnPageLoad = true;
        RadWindow2.VisibleOnPageLoad = false;
        RadWindow3.VisibleOnPageLoad = false;
        RadWindow4.VisibleOnPageLoad = false;
        RadWindow5.VisibleOnPageLoad = false;
        RadWindow6.VisibleOnPageLoad = false;

        BOL_Management_Class1 Health_Info = new BOL_Management_Class1();
        Health_Info.Health_Info_Details();
        Health_Info.mydatarow = Health_Info.dt.NewRow();
        Health_Info.mydatarow["FName"] = lbl_wellcome.Text;
        Health_Info.mydatarow["UserId"] = lbl_User_ID.Text;
        Health_Info.mydatarow["userVisited_Date"] = DateTime.Now;
        //.ToString() !=null ? lbl_wellcome.Text.ToString():string.Empty;

        Health_Info.mydatarow["Health_Problem_Area"] = "Comman Diseases";
        Health_Info.mydatarow["Select_Type"] = Rad_Combo_Type_Of_Diseases.Text;
        Health_Info.mydatarow["Selected_Duration"] = Rad_Combo_Duration.Text;
        if (Radio_Severity_Hegh.Checked)
            Health_Info.mydatarow["Severity"] = "Heigh";
        if (Radio_Severity_Moderate.Checked)
            Health_Info.mydatarow["Severity"] = "Moderate";
        if (Radio_Severity_Low.Checked)
            Health_Info.mydatarow["Severity"] = "Low";
        Health_Info.mydatarow["Prescribed"] = bl_Prescription.Text;

        Health_Info.dt.Rows.Add(Health_Info.mydatarow);
        Health_Info.da.Update(Health_Info.ds, "Health_Info");
    }
    protected void Rad_Body_Parts_Click(object sender, EventArgs e)
    {
        RadWindow1.VisibleOnPageLoad = true;
        RadWindow2.VisibleOnPageLoad = false;
        RadWindow3.VisibleOnPageLoad = false;
        RadWindow4.VisibleOnPageLoad = false;
        RadWindow5.VisibleOnPageLoad = false;
        RadWindow6.VisibleOnPageLoad = false;

        BOL_Management_Class1 Health_Info = new BOL_Management_Class1();
        Health_Info.Health_Info_Details();
        Health_Info.mydatarow = Health_Info.dt.NewRow();
        Health_Info.mydatarow["FName"] = lbl_wellcome.Text;
        Health_Info.mydatarow["UserId"] = lbl_User_ID.Text;
        Health_Info.mydatarow["userVisited_Date"] = DateTime.Now;

        Health_Info.mydatarow["Health_Problem_Area"] = "Body parts";
        //Health_Info.mydatarow["Health_Problem_Area"] = "Comman Diseases";
        Health_Info.mydatarow["Select_Type"] = Rad_combo_sub_parts.Text;
        //Health_Info.mydatarow["Selected_Duration"] = Rad_Combo_Duration.Text;
        if (Rad_severity_Troma.Checked)
            Health_Info.mydatarow["Severity"] = "Tromma";
        if (Rad_severity_Injury.Checked)
            Health_Info.mydatarow["Severity"] = "Injury";
        if (Rad_severity_Fractured.Checked)
            Health_Info.mydatarow["Severity"] = "Fractured";
        Health_Info.mydatarow["Prescribed"] = Rad_lbl_drname.Text;

        Health_Info.dt.Rows.Add(Health_Info.mydatarow);
        Health_Info.da.Update(Health_Info.ds, "Health_Info");
    }
    protected void RadButton7_Click(object sender, EventArgs e)
    {
        Response.Redirect("SignUp_Signin.aspx");
    }
    protected void RadButton8_Click(object sender, EventArgs e)
    {
        Response.Redirect("Sign_In.aspx");
    }
}