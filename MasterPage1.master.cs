using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage1 : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Rad_Button_Sign_out.Visible = false;
        string compare_master = (string)Session["comparison"];
        //string FName = (string)Session["wllcomeFname"];
        //string Passward = (string)Session["user_password"];
        if (!IsPostBack)
        {
            /* if (FName == "" && Passward=="" ) 
             {
                 Rad_Button_Sign_out.Visible = false;
                 Rad_Button_Sign_In.Visible = true;
             }*/

            /*if (FName == null && Passward == null)
            {
                Rad_Button_Sign_out.Visible = false;
                Rad_Button_Sign_In.Visible = true;
            }*/

            /*if (FName != "" && Passward != "") 
            {
                Rad_Button_Sign_In.Visible = false;
                Rad_Button_Sign_out.Visible = true;
            }*/

            if (compare_master == "x" || compare_master == "" || compare_master == null)
            {
                Rad_Button_Sign_out.Visible = false;
                Rad_Mydesk_prof.Visible = false;
                Rad_Button_Sign_In.Visible = true;
                Rad_Button_Sign_Up.Visible = true;
            }
           
            else
            {
                Rad_Button_Sign_In.Visible = false;
                Rad_Button_Sign_out.Visible = true;
                Rad_Mydesk_prof.Visible = true;
                Rad_Button_Sign_Up.Visible = false;
            }
        }
                    
    }
    protected void RadButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Sign_In.aspx");
    }
    protected void Rad_Button_Sign_Up_Click(object sender, EventArgs e)
    {
        Response.Redirect("SignUp.aspx");
    }
    protected void Rad_Home_Link_Click(object sender, EventArgs e)
    {
        Response.Redirect("Home.aspx");
    }
    protected void Rad_Button_Sign_out_Click(object sender, EventArgs e)
    {
        Rad_Button_Sign_out.Visible = false;
        Session.Abandon();
        //Session["comparison"]
        //string compare_master = (string)Session["comparison"];
        //compare_master = "x";
        //Response.Redirect("Sign_In.aspx");
        Response.Redirect("Signin_out_going.aspx");
        /*string compare_master = (string)Session["comparison"];
        compare_master = "x";*/
       
    }
    protected void Rad_Mydesk_prof_Click(object sender, EventArgs e)
    {
        Response.Redirect("Helth_CheckUp_Desk.aspx");
    }
}
