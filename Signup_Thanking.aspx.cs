using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using BOL_Management_Namespace;
using Telerik;
using Telerik.Web;

public partial class Signup_Thanking : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        if (!IsPostBack)
        {
            //int curr = 0;
            BOL_Management_Class1 thakin_obj=new BOL_Management_Class1();
            thakin_obj.Thank_wellcomeuser();
            //if (thakin_obj.dt.Rows.Count > 0)
            //{
                lbl_Wellcome.Text = thakin_obj.dt.Rows[0]["FName"].ToString();
            //}
        }
        //lbl_Wellcome.Text = "";
    }
    protected void RadButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Helth_CheckUp_Desk.aspx");
    }
    protected void RadButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Sign_In.aspx");
    }


    protected void lbl_Wellcome_Unload(object sender, EventArgs e)
    {
        
    }
}