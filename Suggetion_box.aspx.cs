using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BOL_Management_Namespace;
using Telerik;
using Telerik.Web.UI;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Net;
//using System.Web.HttpRequest;

    public partial class Suggetion_box : System.Web.UI.Page
    {
        //string x1;
        //private RadComboBoxItem Maharashtra;
       public DataRow mydatarow;
        protected void Page_Load(object sender, EventArgs e)
        {
            /*string uniqname = (string)Session["uniqName"];
            if (uniqname != null && uniqname != "")
            { Rad_Txt_Name.Text = uniqname;
            Rad_Txt_Name.Enabled = false;
            }*/
            //string v1;

            /*BOL_Management_Class1 binding_sessio_value = new BOL_Management_Class1();
            binding_sessio_value.SignUp_con();
            string user_ID1 = (string)Session["userid"];
            myrow = b_signUp.dt.Rows.Find(user_id_int);*/
            mydatarow =(DataRow) Session["mysession"];
            
            Rad_Sate_Button.Visible = false;
            if (!IsPostBack)
            {
                BOL_Management_Class1 b = new BOL_Management_Class1();
                b.bindDB();
                RadComboBox_Country.DataSource = b.dt;
                RadComboBox_Country.DataTextField = "Name";
                RadComboBox_Country.DataTextField = "COUNTRY";
                RadComboBox_Country.DataBind();
                Label6.Visible = false;
                telerik_listbox.Visible = false;
                RadComboBox_State.Visible = false;
                Label13.Visible = false;
                Rad_Sate_Button.Visible = false;
                Rad_Country_Button.Visible = false;
                Label17.Visible = false;
                Rad_Txt_Name.Focus();
            }
            
            if (mydatarow != null)
            {
                Rad_Txt_Name.Text = mydatarow.ItemArray[0].ToString();
                Rad_Txt_Name.Enabled = false;
                Rad_Txt_Email.Text = mydatarow.ItemArray[2].ToString();
                Rad_Txt_Email.Enabled = false;
                //RadComboBox_Country.Text = mydatarow.ItemArray[7].ToString();
                string country_selected = mydatarow["Country"].ToString();
                RadComboBox_Country.SelectedItem.Text = country_selected;
                
                //RadComboBox_Country.SelectedValue = country_selected;
                RadComboBox_State.Visible = true;
                RadComboBox_State.Enabled = false;
                Label6.Visible = true; Label13.Visible = true;
                BOL_Management_Class1 b_state = new BOL_Management_Class1();
                b_state.bindState_by_country(country_selected);
                RadComboBox_State.DataSource = b_state.dt;
                RadComboBox_State.DataTextField = "States";
                RadComboBox_State.DataBind();
                RadComboBox_State.SelectedItem.Text = mydatarow.ItemArray[8].ToString();
                RadComboBox_Country.Enabled = false;

                BOL_Management_Class1 binding_sessio_value = new BOL_Management_Class1();
                //binding_sessio_value.SignUp_con();
                string user_ID1 = (string)Session["userid"];
                binding_sessio_value.user_age(user_ID1);
                string s = binding_sessio_value.dt.Rows[0]["Age"].ToString();
                //string s = binding_sessio_value.dt.DataSet.DefaultViewManager.ToString();
                Rad_Age_Value.Text=s;
                Rad_Age_Value.Enabled = false;
            }
            
         }

        protected void RadComboBox_Country_SelectedIndexChanged(object sender, Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs e)
        {
            int selected_value;
            Label6.Visible = true;
            Label13.Visible = true;
            telerik_listbox.Visible = false;
            RadComboBox_State.Visible = true;
            selected_value = RadComboBox_Country.SelectedIndex;
            BOL_Management_Class1 b1 = new BOL_Management_Class1();
            b1.bindState(selected_value);
            //telerik_listbox.Items.Clear();
            telerik_listbox.DataSource = b1.dt;
            telerik_listbox.DataTextField = "STATES";
            telerik_listbox.DataBind();

            RadComboBox_State.DataSource = b1.dt;
            RadComboBox_State.DataTextField = "STATES";
            RadComboBox_State.DataBind();
       }

        protected void RadButton1_Click1(object sender, EventArgs e)
        {                           
            /*BOL_Management_Class1 submit1 = new BOL_Management_Class1();
            submit1.suggetion_box_con();
            submit1.mydatarow = submit1.dt.NewRow();
            submit1.mydatarow["Name"] = Rad_Txt_Name.Text;
            submit1.mydatarow["Email"] = Rad_Txt_Email.Text;
            submit1.mydatarow["Age"] = Rad_Numaric_txt_Age.Text;
            submit1.mydatarow["Country"] = RadComboBox_Country.Text;
            submit1.mydatarow["Stats"] = telerik_listbox.SelectedItem.Text;
            submit1.mydatarow["Suggetion"] = Rad_Txt_Suggetion.Text;
            submit1.mydatarow["Inserted_Date"] = DateTime.Now;
            submit1.mydatarow["User_Ip"] = Convert.ToString( Request.UserHostAddress);*/
            RadWindow1.VisibleOnPageLoad = true;
            //submit1.mydatarow["SessionId_user"] = Convert.ToString(Request);
           // Session.Abandon();
            //Response.Cookies.Add(new HttpCookie("ASP.NET_SE"))
            //submit1.mydatarow["User_Ip"] = Convert.ToString(Request.ServerVariables);
           /* string ip;

            ip = Request.ServerVariables("HTTP_X_FORWARDED_FOR");
            if (ip == string.Empty)
            {
                ip = Request.ServerVariables("REMOTE_ADDR");
            }
            */
           /* submit1.dt.Rows.Add(submit1.mydatarow);
            submit1.da.Update(submit1.ds, "[Suggetion_Box]");*/
            //submit1.da.Update(submit1.ds, "proc_Suggetion_box");
        }
        protected void RadButton4_Click(object sender, EventArgs e)
        {
            //No btn
            RadWindow1.VisibleOnPageLoad = false;
        }
        protected void RadButton3_Click(object sender, EventArgs e)
        {
            //Yes BTN
            RadWindow1.VisibleOnPageLoad = false;
            BOL_Management_Class1 submit1 = new BOL_Management_Class1();
            submit1.suggetion_box_con();
            submit1.mydatarow = submit1.dt.NewRow();
            submit1.mydatarow["Name"] = Rad_Txt_Name.Text;
            submit1.mydatarow["Email"] = Rad_Txt_Email.Text;
            submit1.mydatarow["Age"] = Rad_Numaric_txt_Age.Text;
            submit1.mydatarow["Country"] = RadComboBox_Country.Text;
            submit1.mydatarow["Stats"] = telerik_listbox.SelectedItem.Text;
            submit1.mydatarow["Suggetion"] = Rad_Txt_Suggetion.Text;
            submit1.mydatarow["Inserted_Date"] = DateTime.Now;
            submit1.mydatarow["User_Ip"] = Convert.ToString(Request.UserHostAddress);
            submit1.dt.Rows.Add(submit1.mydatarow);
            submit1.da.Update(submit1.ds, "[Suggetion_Box]");
        }
        protected void RadButton3_Click1(object sender, EventArgs e)
        {
            Rad_Txt_Name.Text = "";
            Rad_Txt_Email.Text = "";
            Rad_Numaric_txt_Age.Value = 12;
            RadComboBox_Country.SelectedIndex = 0;
            telerik_listbox.Visible = false;
            Label13.Visible = false;
            Label6.Visible = false;
            Rad_Txt_Suggetion.Text = "";
        }
        protected void Btn_Submit_Click(object sender, EventArgs e)
        {
            BOL_Management_Class1 submit1 = new BOL_Management_Class1();
            submit1.suggetion_box_con();
            submit1.mydatarow = submit1.dt.NewRow();
            submit1.mydatarow["Name"] = Rad_Txt_Name.Text;
            submit1.mydatarow["Email"] = Rad_Txt_Email.Text;
            //submit1.mydatarow["Age"] = Rad_Numaric_txt_Age.Text;
            submit1.mydatarow["Age"] = Rad_Age_Value.Text;
            submit1.mydatarow["Country"] = RadComboBox_Country.Text;
            //submit1.mydatarow["Stats"] = telerik_listbox.SelectedItem.Text;
            submit1.mydatarow["Stats"] = RadComboBox_State.Text;
            submit1.mydatarow["Suggetion"] = Rad_Txt_Suggetion.Text;
            submit1.mydatarow["Inserted_Date"] = DateTime.Now;
            submit1.mydatarow["User_Ip"] = Convert.ToString(Request.UserHostAddress);
            submit1.dt.Rows.Add(submit1.mydatarow);
            submit1.da.Update(submit1.ds, "[Suggetion_Box]");
            Label17.Visible = true;
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Rad_Txt_Name.Text = "";
            Rad_Txt_Email.Text = "";
            Rad_Numaric_txt_Age.Value = 12;
            RadComboBox_Country.SelectedIndex = 0;
            telerik_listbox.Visible = false;
            Label13.Visible = false;
            Label6.Visible = false;
            Rad_Txt_Suggetion.Text = "";
            Label17.Visible = false;
        }
}
