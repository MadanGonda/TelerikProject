using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BOL_Management_Namespace;
using Telerik;
using Telerik.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

public partial class Sign_In : System.Web.UI.Page
{
    public string compare;

    public string FName ;
    public string Password ;
        
    
    protected void Page_Load(object sender, EventArgs e)
    {

        FName = Rad_txt_username.Text;
        Password = Rad_txt_password.Text;
        Session["wllcomeFname"] = FName;
        Session["user_password"] = Password;

       /* if (Session["wllcomeFname"] != null && Session["wllcomeFname"] != "")
        {
            Rad_txt_username.Text = FName;
            Rad_txt_username.ReadOnly = true;
            Rad_txt_username.Enabled = false;
        }*/
       
        //Response.Cache.SetCacheability(HttpCacheability.NoCache);
        //this.Form.DefaultButton = Button1.UniqueID;
        this.Page.Form.DefaultButton = this.Button1.UniqueID;
        
        if (!IsPostBack)
        {
            RadWindow1.VisibleOnPageLoad = false;
            lbl_error.Visible = false;
            Rad_txt_username.Focus();
        }
    }
    protected void RadButton1_Click(object sender, EventArgs e)
    {
        //string fname, password;
        Session["UserId"] = 1;    
        //Session.Timeout = 1;
        BOL_Management_Class1 db_sigh_bind = new BOL_Management_Class1();
        db_sigh_bind.name = Rad_txt_username.Text;
        db_sigh_bind.Passwordss = Rad_txt_password.Text;
        //password = Rad_txt_password.Text;
       // Session["time_out"] = db_sigh_bind.name;
        db_sigh_bind=db_sigh_bind.Sign_in_con(db_sigh_bind.name,db_sigh_bind.Passwordss);
        //Rad_txt_password.DataBind();
        //Rad_txt_username.DataBinding 
       /* if (db_sigh_bind.valid_user == true)
            Response.Redirect("Home.aspx");
        else
            Response.Write("Sign_In.aspx");*/
        if (db_sigh_bind.Passwordss=="" )//&& db_sigh_bind.name ==null)
        {
            //RadWindow1.VisibleOnPageLoad = true;
            lbl_error.Visible = true;
            compare = "x";
            Session["comparison"] = compare;
           // Response.Redirect("Sign_In.aspx");
           // Response.Write("Invalide Password");
            
        }
       // else
        if(db_sigh_bind.Passwordss!="")
        {
            //Response.Redirect("Sign_In.aspx");
            //Response.Write("correct");
            compare = "y";
            Session["comparison"] = compare;
            Response.Redirect("Helth_CheckUp_Desk.aspx",false);
            
        }
    }
    protected void RadButton2_Click(object sender, EventArgs e)
    {
        RadWindow1.VisibleOnPageLoad = true;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["UserId"] = 1;    
        string username = Rad_txt_username.Text;
        string password_match = Rad_txt_password.Text;

        BOL_Management_Class1 sign_in_permision = new BOL_Management_Class1();
        sign_in_permision.password_compare_case(username, password_match);

        if (sign_in_permision.dt.Rows.Count == 0)
        {
            lbl_error.Visible = true;
            compare = "x";
            Session["comparison"] = compare;
        }
        else
        {
            FName = Rad_txt_username.Text;
            Session["wllcomeFname"] = FName;
            compare = "y";
            Session["comparison"] = compare; 
            //Response.Redirect("Helth_CheckUp_Desk.aspx"); 
            Response.Redirect("Signin_in_going.aspx",false);
            
           /*  if (Session["UserId"] != null)
             {
                Rad_txt_username.Text = FName;
                Rad_txt_username.ReadOnly = true;
                Rad_txt_username.Enabled = false;
             }*/
        }
        
    }
}