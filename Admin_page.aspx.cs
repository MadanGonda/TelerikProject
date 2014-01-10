using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using Telerik;
using Telerik.Web;
using Telerik.Web.UI;
using BOL_Management_Namespace;



public partial class Admin_page : System.Web.UI.Page
{
    public SqlConnection con;
    public SqlCommand cmd = new SqlCommand();
    public SqlDataAdapter da = new SqlDataAdapter();
    public DataSet ds = new DataSet();
    //public string constr = "Data Source=V2INMUMPC668\\MADAN;Initial Catalog=viwwe_Manegement;Integrated Security=True";
    public string constr = "Data Source=V2VAPC0079;Initial Catalog=viwwe_Manegement;Integrated Security=True";
    public DataTable dt;
    public SqlDataReader dr;
    public DataRow mydatarow;
    public string x;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BOL_Management_Class1 Bind_Data_gird = new BOL_Management_Class1();
            Bind_Data_gird.Bind_Data_Grid();
            Rad_Combo_user_name.DataSource = Bind_Data_gird.dt;
            Rad_Combo_user_name.DataTextField = "Fname";
            Rad_Combo_user_name.DataBind();
            RadGrid1.Visible = false;
            RadGrid2.Visible = false;
            RadGrid3.Visible = false;
            RadWindow1.VisibleOnPageLoad = true;
            Rad_admin_name.Focus();
            
        }

    }
    protected void RadButton1_Click(object sender, EventArgs e)
    {
        //BOL_Management_Class1 Bind_Data_gird = new BOL_Management_Class1();
        /*Bind_Data_gird.Bind_Data_Grid();
        Rad_Combo_user_name.DataSource=Bind_Data_gird.dt;
        Rad_Combo_user_name.DataTextField="Fname";
        Rad_Combo_user_name.DataBind();*/
        con = new SqlConnection();
        con.ConnectionString = constr;
        con.Open();
        string name_show = Rad_Combo_user_name.Text.ToString().Trim();
        cmd.CommandText = "SELECT * FROM All_user_Data_BInding WHERE FName='" + name_show + "'";
        //cmd.CommandText = "SELECT * FROM Sign_up_page WHERE FName='" + name_show + "'";
        cmd.Connection = con;
        da = new SqlDataAdapter(cmd);
        ds = new DataSet();
        da.Fill(ds, "Sign_up_page");
        dt = ds.Tables["Sign_up_page"];
        RadGrid1.DataSource = ds;
        RadGrid1.DataBind();
        RadGrid1.Visible = true;
        
        //RadGrid2.DataSource = ds;
        //RadGrid2.DataBind();
        //RadGrid2.Visible = true;

    }
    protected void RadButton2_Click(object sender, EventArgs e)
    {
        //RadWindow1.VisibleOnPageLoad = false;
        string user_a_name;
        string user_a_password;

        user_a_name = Rad_admin_name.Text;
        user_a_password = rad_admin_pass.Text;
        BOL_Management_Class1 addmin_pop_up = new BOL_Management_Class1();
        addmin_pop_up.Admin_con(user_a_name, user_a_password);
        if (addmin_pop_up.dt.Rows.Count == 0)
        {
            Response.Redirect("Home.aspx");
        }
        else
        {
            RadWindow1.VisibleOnPageLoad = false;
            //Response.Redirect("Admin_page.aspx");

        }

    }
    protected void RadButton3_Click(object sender, EventArgs e)
    {
        /*BOL_Management_Class1 Txt_Grid_Data_Bindin = new BOL_Management_Class1();
        Txt_Grid_Data_Bindin.FLName_Grid_Binding();
        RadGrid2.DataSource = ds;
        RadGrid2.DataBind();
        RadGrid2.Visible=true;*/
        
        //ds.Tables[0].Columns.Add("FName", typeof(string));
       /* int Totalrec = Txt_Grid_Data_Bindin.dt.Rows.Count;
        {
            if (Totalrec > 0)
            {
                for (int currecord = 0; currecord <= Totalrec - 1; currecord++)
                {
                    //TextBox FName_Box = (TextBox)RadGrid2.Rows[currecord].Cells[0].FindControl("Rad_Txt_FName");
                    //TextBox LName_Box = (TextBox)RadGrid2.Rows[currecord].Cells[0].FindControl("Rad_Txt_LName");  
                }

            }
        }

        DataSet ds = new DataSet();
        ds.Tables.Add();
        ds.Tables[0].Columns.Add("FName", typeof(String));
        ds.Tables[0].Columns.Add("Description", typeof(String));
        ds.Tables[0].Columns.Add("SeqNo", typeof(Int32));
        ds.Tables[0].Columns.Add("TargetDate", typeof(DateTime));
        ds.Tables[0].Columns.Add("Completed", typeof(Boolean), "false");

        ds.Tables[0].Rows.Add(ds.Tables[0].NewRow());
        RadGrid2.DataSource = ds.Tables[0]; 
        DataTable dt = (DataTable)RadGrid2.DataSource;
        dt.Rows.Add(dt.NewRow());
        RadGrid2.Rebind();
        RadGrid2.Visible = true;*/
       
        /*ds.Tables.Add();
        ds.Tables[0].Columns.Add("FName", typeof(String));
        //ds.Tables[0].Columns.Add("LName", typeof(String));
        RadGrid2.DataSource = ds.Tables[0];
        ViewState["DataSet"] = ds;
        ds.Tables[0].Rows.Add(ds.Tables[0].NewRow());
        RadGrid2.Rebind();
        RadGrid2.Visible = true;*/

       /* DataTable dt=(DataTable)ViewState["dt"];
        dt.Rows[datai]*/
    }
    protected void RadButton3_Click1(object sender, EventArgs e)
    {
        con = new SqlConnection();
        con.ConnectionString = constr;
        con.Open();
        string name_show = Rad_Combo_user_name.Text.ToString().Trim();
        cmd.CommandText = "SELECT * FROM All_user_Data_BInding WHERE FName='" + name_show + "'";
        //BOL_Management_Class1 Txt_Grid_Data_Bindin = new BOL_Management_Class1();
        //Txt_Grid_Data_Bindin.Bind_Data_Grid();
        //int totalrecord = Txt_Grid_Data_Bindin.dt.Rows.Count;
        //Rad_admin_name.Text = Txt_Grid_Data_Bindin.dt.Rows[0]["FName"].ToString();
        //Rad_admin_name.Text =  ds.Tables["sign_up_page"].Columns["Fname"].ToString();
        /*if (totalrecord > 0)
        {
            for(int currrec=0;currrec<=totalrecord -1;currrec++)
            {
            //Rad_admin_name.Text = Txt_Grid_Data_Bindin.dt.Rows[0]["FName"].ToString();
                Rad_admin_name.Text =Txt_Grid_Data_Bindin.dt.Rows[currrec]["FName"].ToString();
            }
        }*/
            //rad_admin_pass.Text = Txt_Grid_Data_Bindin.dt.Rows[0]["LName"].ToString();
        //RadGrid2.DataSource =Txt_Grid_Data_Bindin.ds;
        cmd.Connection = con;
        da = new SqlDataAdapter(cmd);
        ds = new DataSet();
        
        da.Fill(ds, "Sign_up_page");
        dt = ds.Tables["Sign_up_page"];
        RadGrid2.DataSource = ds;
        //RadTextBox b1 = (RadTextBox)
        //RadGrid2_ItemDataBound()
        ///Rad__name.Text = dt.Rows[0]["FName"].ToString();
        RadGrid2.DataBind();
        //x = Rad_Combo_user_name.Text;
        //GridDataItem gd=(GridDataItem)e.
        //Rad_admin_name.Text = "Fname";
       RadGrid2.Visible = true;           
       
    }
    protected void RadGrid2_ColumnCreated(object sender, Telerik.Web.UI.GridColumnCreatedEventArgs e)
    {

       /* con = new SqlConnection();
        con.ConnectionString = constr;
        con.Open();
        string name_show = Rad_Combo_user_name.Text.ToString().Trim();
        cmd.CommandText = "SELECT * FROM All_user_Data_BInding WHERE FName='" + name_show + "'";
        cmd.Connection = con;
        da = new SqlDataAdapter(cmd);
        ds = new DataSet();

        da.Fill(ds, "Sign_up_page");
        dt = ds.Tables["Sign_up_page"];
        RadGrid2.DataSource = ds;
        
        // rad= dt.Rows[0]["FName"].ToString();
        RadGrid2.DataBind();
        RadGrid2.Visible = true;           
       */

       
    }
    protected void RadGrid2_ItemDataBound(object sender, Telerik.Web.UI.GridItemEventArgs e)
    {
        //if e.Item.item
        
            GridDataItem item = (GridDataItem)e.Item;
            //GridDataItem item = (GridDataItem)e.Item
            string username = item["Fname"].Text;
            item["Rad_txt_Fname"].Text = username;
            //Response.Write(item["FName"].Text);
        
    }
    protected void RadGrid2_ItemCommand(object sender, Telerik.Web.UI.GridCommandEventArgs e)
    {
        GridDataItem item = (GridDataItem)e.Item;
        item["Fname"].Text=x;
    }
    protected void RadGrid2_ItemCreated(object sender, GridItemEventArgs e)
    {
       
        con = new SqlConnection();
        con.ConnectionString = constr;
        con.Open();
        string name_show = Rad_Combo_user_name.Text.ToString().Trim();
        cmd.CommandText = "SELECT * FROM All_user_Data_BInding WHERE FName='" + name_show + "'";
        cmd.Connection = con;
        da = new SqlDataAdapter(cmd);
        ds = new DataSet();
        da.Fill(ds, "Sign_up_page");
        dt = ds.Tables["Sign_up_page"];
        //GridDataItem item = (GridDataItem)e.Item;
        
        
        //Response.Write(item["FName"].Text);
    }

    protected void RadGrid1_ColumnCreated(object sender, GridColumnCreatedEventArgs e)
    {
        
        
    }
    protected void RadGrid1_ItemCommand(object sender, GridCommandEventArgs e)
    {
        GridDataItem item = (GridDataItem)e.Item;
        x=item["Fname"].Text;

    }
    protected void RadGrid2_ItemDataBound1(object sender, GridItemEventArgs e)
    {
        
 
    }
    protected void RadButton4_Click(object sender, EventArgs e)
    {
        BOL_Management_Class1 bind_radgrid3 = new BOL_Management_Class1();
        bind_radgrid3.FLName_Grid_Binding();
        RadGrid3.DataSource = bind_radgrid3.dt;
        RadGrid3.DataBind();
        RadGrid3.Visible = true;
    }
    protected void RadGrid3_UpdateCommand(object sender, GridCommandEventArgs e)
    {
        BOL_Management_Class1 bind_radgrid3 = new BOL_Management_Class1();
        bind_radgrid3.FLName_Grid_Binding();
        GridEditableItem editedItem = e.Item as GridEditableItem;
        GridEditManager editMan = editedItem.EditManager;
        RadGrid3.Visible = false;
        foreach (GridColumn column in e.Item.OwnerTableView.RenderColumns)
        {
            if (column is IGridEditableColumn)
            {
                IGridEditableColumn editableCol = (column as IGridEditableColumn);
                if (editableCol.IsEditable)
                {
                    IGridColumnEditor editor = editMan.GetColumnEditor(editableCol);

                    string editorType = editor.ToString();
                    string editorText = "unknown";
                    object editorValue = null;

                    if (editor is GridTextColumnEditor)
                    {
                        editorText = (editor as GridTextColumnEditor).Text;
                        editorValue = (editor as GridTextColumnEditor).Text;
                    }

                    if (editor is GridBoolColumnEditor)
                    {
                        editorText = (editor as GridBoolColumnEditor).Value.ToString();
                        editorValue = (editor as GridBoolColumnEditor).Value;
                    }

                    if (editor is GridDropDownColumnEditor)
                    {
                        editorText = (editor as GridDropDownColumnEditor).SelectedText + "; " +
                            (editor as GridDropDownColumnEditor).SelectedValue;
                        editorValue = (editor as GridDropDownColumnEditor).SelectedValue;
                    }
                    if (editor is GridDateTimeColumnEditor)
                    {
                        editorText = (editor as GridDateTimeColumnEditor).Text;
                        editorValue = (editor as GridDateTimeColumnEditor).Text;
                    }

                    try
                    {
                        DataRow[] changedRows = bind_radgrid3.ds.Tables["sign_up_page"].Select("FName = " + Convert.ToString(  editedItem.GetDataKeyValue("UserID")));//.OwnerTableView.DataKeyValues[editedItem.ItemIndex]["FName"]);
                        //DataRow[] changedRows = bind_radgrid3.ds.Tables["sign_up_page"].Select("FName = " + editedItem.OwnerTableView.DataKeyValues[editedItem.ItemIndex]["FName"]);
                        changedRows[0][column.UniqueName] = editorValue;
                        this.ds.Tables["sign_up_page"].AcceptChanges();
                    }
                    catch (Exception ex)
                    {
                        RadGrid3.Controls.Add(new LiteralControl("<strong>Unable to set value of column '" + column.UniqueName + "'</strong> - " + ex.Message));
                        e.Canceled = true;
                        break;
                    }
                }
            }
        }
      //  GridEditableItem item = (GridEditableItem)e.Item;
      //  String id = item.GetDataKeyValue("FirstName").ToString();


            
           // GridEditableItem editedItem = e.Item as GridEditableItem;
           // GridEditManager editMan = editedItem.EditManager;

           
            /*objPathwayGroup.Id = Convert.ToInt16(((GridDataItem)e.Item).GetDataKeyValue("Id"));
            objPathwayGroup.GroupName = Convert.ToString(((GridTextBoxColumnEditor)(editMan.GetColumnEditor("GroupName"))).Text);
            if ((((GridNumericColumnEditor)editMan.GetColumnEditor("DisplayOrder"))).Text.Trim() != string.Empty)
            objPathwayGroup.DisplayOrder = Convert.ToInt16((((GridNumericColumnEditor)editMan.GetColumnEditor("DisplayOrder"))).Text.Trim());
             rgdSurgicalPathwayGroup.MasterTableView.ClearEditItems();
        */

            //BOL_Management_Class1 bind_radgrid3 = new BOL_Management_Class1();
            //bind_radgrid3.FLName_Grid_Binding();
           

    }
    protected void RadGrid3_ItemUpdated(object sender, GridUpdatedEventArgs e)
    {
        GridEditableItem item = (GridEditableItem)e.Item;
        String id = item.GetDataKeyValue("FName").ToString();

        /*if (e.Exception != null)
        {
            e.KeepInEditMode = true;
            e.ExceptionHandled = true;
            SetMessage("Product with ID " + id + " cannot be updated. Reason: " + e.Exception.Message);
        }
        else
        {
            SetMessage("Product with ID " + id + " is updated!");
        }*/
    }
}