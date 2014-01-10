using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik;
using Telerik.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using BOL_Management_Namespace;

public partial class Change_Password : System.Web.UI.Page
{
    public string newpassword;
    public int currrec = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserId"] == null)
                    Response.Redirect("Sign_In.aspx");

        if (!IsPostBack)
        {
            Rad_txt_old_pass.Focus();
            lbl_confirmpass.Visible = false;
            Label4.Visible = false;
            
        }
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string user_ID1 = (string)Session["userid"];
        int userID=Convert.ToInt32(user_ID1);
        string old_password = Rad_txt_old_pass.Text;

        BOL_Management_Class1 Change_pass = new BOL_Management_Class1();
        
        Change_pass.Change_password(userID, old_password);
        
        //newpassword = Change_pass.dt.Rows[0]["Password"].ToString();
        if (Change_pass.dt.Rows.Count == 0)
        {
            //Response.Write("Please Enter Correct password");
            Label4.Visible = true;
        }
        else
        {
            
            BOL_Management_Class1 b_signUp = new BOL_Management_Class1();
            b_signUp.SignUp_con();
            DataRow myrow;
            myrow = b_signUp.dt.Rows.Find(user_ID1);
            myrow["Password"] = Rad_txt_new_pass.Text;
            
            myrow["ConfPassword"] = Rad_txt_confirm_pass.Text;
            b_signUp.da.Update(b_signUp.ds, "[Sign_up_page]");
            lbl_confirmpass.Visible = true;
            Label4.Visible = false;

            //newpassword = b_signUp.dt.myrow[0]["Password"].ToString();
            newpassword = myrow.ItemArray[4].ToString();
            Session["confirm_pass"]=newpassword;
            
        }

    }
    protected void RadButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("SignUp_Signin.aspx");
    }
}