using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Telerik;
using Telerik.Web;
using BOL_Management_Namespace;

public partial class Medicine_Bank : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        RadGrid1.Visible = false;
        Rad_Search_TextBox.Focus();
    }
    protected void RadButton1_Click(object sender, EventArgs e)
    {
        
       /* String search_text;
        BOL_Management_Class1 Medicine_Bank = new BOL_Management_Class1();
        search_text = Rad_Search_TextBox.Text;
        Medicine_Bank.Medicine_Bank_Con(search_text);
        RadGrid1.DataSource = Medicine_Bank.dt;
        RadGrid1.DataBind();
        RadGrid1.Visible = true;*/
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String search_text;
        BOL_Management_Class1 Medicine_Bank = new BOL_Management_Class1();
        search_text = Rad_Search_TextBox.Text;
        Medicine_Bank.Medicine_Bank_Con(search_text);
        RadGrid1.DataSource = Medicine_Bank.dt;
        RadGrid1.DataBind();
        RadGrid1.Visible = true;
    }
}