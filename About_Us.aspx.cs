using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class About_Us : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void RadButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Sign_In.aspx");
    }
    protected void Rad_Button_Sign_Up_Click(object sender, EventArgs e)
    {
        Response.Redirect("SignUp.aspx");
    }
}