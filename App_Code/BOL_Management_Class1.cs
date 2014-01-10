using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Net;
//using System.Web.HttpRequest;

namespace BOL_Management_Namespace
{
    /// <summary>
    /// Summary description for BOL_Management_Class1
    /// </summary>
    public class BOL_Management_Class1
    {
        public SqlConnection con;
        public SqlCommand cmd = new SqlCommand();
        public SqlDataAdapter da = new SqlDataAdapter();
        public DataSet ds = new DataSet();
        //public string constr = "Data Source=V2INMUMPC668\\MADAN;Initial Catalog=viwwe_Manegement;Integrated Security=True";
        //public string constr= "Data Source=V2INMUMPC668;Initial Catalog=viwwe_Manegement;Integrated Security=True";
        //public string constr = "Data Source=V2VAPC0079;Initial Catalog=viwwe_Manegement;Integrated Security=True";
        public string constr = "Data Source=V2VAPC0079;Initial Catalog=viwwe_Manegement;Integrated Security=True";
        public DataTable dt;
        public SqlDataReader dr;
        public DataRow mydatarow;
        public String name, Passwordss;
        public int curr=0;
        //public DataRow dr;
        public BOL_Management_Class1()
        {
             //
            // TODO: Add constructor logic here
            //
        }
         public void bindDB()
        {
            try
            {
                con = new SqlConnection();
                con.ConnectionString = constr;
                con.Open();
                //string select_query = "proc_aselect_country";
                //string select_query = "proc_distinct_country";
                cmd = new SqlCommand("proc_distinct_country", con);
                //cmd.CommandType = CommandType.StoredProcedure; 
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                /*da.Fill(ds, "[COUNTRY]");
                dt = ds.Tables["[COUNTRY]"];*/
                da.Fill(ds, "[STATE_COUNTRY]");
                dt = ds.Tables["[STATE_COUNTRY]"];
                con.Close();
            }
            catch (Exception e)
            {
                System.Web.HttpContext.Current.Response.Write(e.StackTrace);
            }

        }
         public void bindState(int state_index)
         {
             try
             {
                 con = new SqlConnection();
                 con.ConnectionString = constr;
                 con.Open();
                 //string select_query = "proc_state_country";
                 cmd = new SqlCommand("proc_state_country ", con);
                 //string s2 = "SELECT STATES FROM STATE_COUNTRY WHERE index_value=@index_selected";
                 //cmd = new SqlCommand(s2, con);
                 cmd.Parameters.AddWithValue("@index_selected", state_index);
                 cmd.CommandType = CommandType.StoredProcedure; 
                 da = new SqlDataAdapter(cmd);
                 ds = new DataSet();
                 da.Fill(ds, "[STATE_COUNTRY]");
                 dt = ds.Tables["[STATE_COUNTRY]"];
                 //con.Close();
                 /*string select_query = "SELECT STATES FROM [STATE_COUNTRY] WHERE index_value=@index_selected";
                 cmd = new SqlCommand(select_query, con);*/
                 //dr = cmd.ExecuteReader;
             }
             catch(Exception e)
             { System.Web.HttpContext.Current.Response.Write(e.StackTrace); }
         
        }

         public void bindState_by_country(string state_name)
         {
             try
             {
                 con = new SqlConnection();
                 con.ConnectionString = constr;
                 con.Open();
                 cmd = new SqlCommand("proc_State_select_by_country", con);
                 cmd.Parameters.AddWithValue("@country", state_name);
                 cmd.CommandType = CommandType.StoredProcedure;
                 da = new SqlDataAdapter(cmd);
                 ds = new DataSet();
                 da.Fill(ds, "[STATE_COUNTRY]");
                 dt = ds.Tables["[STATE_COUNTRY]"];
            }
             catch (Exception e)
             { System.Web.HttpContext.Current.Response.Write(e.StackTrace); }
        }
        
        public void suggetion_box_con()
         { 
             con=new SqlConnection();
             con.ConnectionString=constr;
             con.Open();
             //cmd = new SqlCommand("SELECT * FROM[Suggetion_Box]",con);
             //cmd = new SqlCommand("proc_Suggetion_box", con);
             cmd = new SqlCommand("proc_Suggetion_box", con);
             cmd.CommandType = CommandType.StoredProcedure;
             da = new SqlDataAdapter(cmd);
             SqlCommandBuilder cmdbl = new SqlCommandBuilder(da);
             ds = new DataSet();
             
             // mydatarow = new DataRow();               
             //DataRow mydatarow=dt.NewRow() ;
             da.Fill(ds, "[Suggetion_Box]");
             dt = ds.Tables["[Suggetion_Box]"];
            /* string ip;

             ip = System.Web.re Request.ServerVariables("HTTP_X_FORWARDED_FOR");
             if (ip == string.Empty)
             {
                 ip = Request.ServerVariables("REMOTE_ADDR");
             }*/
            //con.Close();   
         }
        
        public void SignUp_con() {
             con = new SqlConnection();
             con.ConnectionString = constr;
             con.Open();
             cmd = new SqlCommand("proc_signup_page", con);
             cmd.CommandType = CommandType.StoredProcedure;
             da = new SqlDataAdapter(cmd);
             SqlCommandBuilder cmdbldr = new SqlCommandBuilder(da);
             ds = new DataSet();
             da.FillSchema(ds, SchemaType.Source, "[Sign_up_page]"); 
             da.Fill(ds, "[Sign_up_page]");
             dt = ds.Tables["[Sign_up_page]"];
         }
       /// <summary>
       /// not using
       /// </summary>
       /* public void Helthinfo_con() {
            con = new SqlConnection();
            con.ConnectionString = constr;
            con.Open();
            cmd = new SqlCommand("proc_B_D_H_P_S", con);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            SqlCommandBuilder cmdbldr = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "Blood_Drugs_Hereditary_Profession_SociActiv");
            dt = ds.Tables["Blood_Drugs_Hereditary_Profession_SociActiv"];
        }*/

        public void Blood_Group_Con()
        {
            con = new SqlConnection();
            con.ConnectionString = constr;
            con.Open();
            cmd = new SqlCommand("proc_NOTNULL_Blood_Group", con);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            SqlCommandBuilder cmdbldr = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "Blood_Drugs_Hereditary_Profession_SociActiv");
            dt = ds.Tables["Blood_Drugs_Hereditary_Profession_SociActiv"];
        }

        public void Drugs_Names_con()
        {
            con = new SqlConnection();
            con.ConnectionString = constr;
            con.Open();
            cmd = new SqlCommand("proc_NOTNULL_Drugs_Name", con);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            SqlCommandBuilder cmdbldr = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "Blood_Drugs_Hereditary_Profession_SociActiv");
            dt = ds.Tables["Blood_Drugs_Hereditary_Profession_SociActiv"];
        }

        public void Hereditory_Disease_con()
        {
            con = new SqlConnection();
            con.ConnectionString = constr;
            con.Open();
            cmd = new SqlCommand("proc_NOTNULL_Hereditory_Disease", con);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            SqlCommandBuilder cmdbldr = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "Blood_Drugs_Hereditary_Profession_SociActiv");
            dt = ds.Tables["Blood_Drugs_Hereditary_Profession_SociActiv"];
        }

        public void profesion_con()
        {
            con = new SqlConnection();
            con.ConnectionString = constr;
            con.Open();
            cmd = new SqlCommand("proc_NotNull_B_D_H_P_S", con);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            SqlCommandBuilder cmdbldr = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "Blood_Drugs_Hereditary_Profession_SociActiv");
            dt = ds.Tables["Blood_Drugs_Hereditary_Profession_SociActiv"];
        }
        public void socio_act_con()
        {
            con = new SqlConnection();
            con.ConnectionString = constr;
            con.Open();
            cmd = new SqlCommand("proc_NotNull_socio__B_D_H_P_S", con);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            SqlCommandBuilder cmdbldr = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "Blood_Drugs_Hereditary_Profession_SociActiv");
            dt = ds.Tables["Blood_Drugs_Hereditary_Profession_SociActiv"];
        }
        public void Helth_Checkup_Combo_con()
        {
            con = new SqlConnection();
            con.ConnectionString = constr;
            con.Open();
            //cmd = new SqlCommand("SELECT FName FROM [sign_up_page]", con);
            cmd = new SqlCommand("proc_Fname", con);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            SqlCommandBuilder cmdbldr = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "[Sign_up_page]");
            dt = ds.Tables["[Sign_up_page]"];
        }
        public BOL_Management_Class1 Sign_in_con(string name, string Password)
        {
            //bool valid_user=true;
            con = new SqlConnection();
            con.ConnectionString = constr;
            con.Open();
            cmd = new SqlCommand("p3", con);

            cmd.CommandType = CommandType.StoredProcedure;
            
            SqlParameter Fname = new SqlParameter("@name1", SqlDbType.VarChar, 50);
            Fname.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(Fname);

            SqlParameter pass = new SqlParameter("@password1", SqlDbType.VarChar, 50);
            pass.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(pass);

            cmd.Parameters.AddWithValue("@name",name);
            cmd.Parameters.AddWithValue("@password",Password);
            
            cmd.CommandType = CommandType.StoredProcedure; 
            da = new SqlDataAdapter(cmd);
            SqlCommandBuilder cmdbldr = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "[Sign_up_page]");
            dt = ds.Tables["[Sign_up_page]"];
            //string fname,passwordss;
            BOL_Management_Class1 sample = new BOL_Management_Class1();
            sample.name=Convert.ToString(Fname.Value);
            sample.Passwordss = Convert.ToString(pass.Value);
            return sample;
         }

        public void Thank_wellcomeuser()
        {
            //DataRow rw;
            //int curr = 0;
            con = new SqlConnection();
            con.ConnectionString = constr;
            con.Open();
            cmd = new SqlCommand("proc_wellcome", con);
            //cmd = new SqlCommand("SELECT FName,LName FROM sign_up_page", con);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            SqlCommandBuilder cmdbldr = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "[Sign_up_page]");
            dt = ds.Tables["[Sign_up_page]"];
            //con.Close();
        }
        public void Medical_Drugs_connection()
        {
            con = new SqlConnection();
            con.ConnectionString = constr;
            con.Open();
            cmd = new SqlCommand("proc_Type_Of_Disease", con);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            SqlCommandBuilder cmdbldr = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "Diesese_Prescription");
            dt = ds.Tables["Diesese_Prescription"];
        }
        public void Medical_Duration_Of_Desease()
        {
            con = new SqlConnection();
            con.ConnectionString = constr;
            con.Open();
            cmd = new SqlCommand("proc_Duration_Of_Desease", con);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            SqlCommandBuilder cmdbldr = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "Diesese_Prescription");
            dt = ds.Tables["Diesese_Prescription"];
        }
        public void Prescription(int disease_index)
        {
            con = new SqlConnection();
            con.ConnectionString = constr;
            con.Open();
            //string select_query = "proc_state_country";
            cmd = new SqlCommand("proc_Prescribed_Medicine", con);
            //string s2 = "SELECT STATES FROM STATE_COUNTRY WHERE index_value=@index_selected";
            //cmd = new SqlCommand(s2, con);
            cmd.Parameters.AddWithValue("@Disease_Index", disease_index);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "Diesese_Prescription");
            dt = ds.Tables["Diesese_Prescription"];
         }
        public void Head_Sub_Body_Parts_con()
        {
            con = new SqlConnection();
            con.ConnectionString = constr;
            con.Open();
            //string select_query = "proc_state_country";
            cmd = new SqlCommand("proc_Head_Sub_Body_Parts", con);
            //string s2 = "SELECT STATES FROM STATE_COUNTRY WHERE index_value=@index_selected";
            //cmd = new SqlCommand(s2, con);
            //cmd.Parameters.AddWithValue("@Disease_Index", disease_index);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "Head_Sub_Body_Parts");
            dt = ds.Tables["Head_Sub_Body_Parts"];
        }

        public void Arm_Sub_Body_Parts_con()
        {
            con = new SqlConnection();
            con.ConnectionString = constr;
            con.Open();
            //string select_query = "proc_state_country";
            cmd = new SqlCommand("proc_Arm_Sub_Body_Parts", con);
            //string s2 = "SELECT STATES FROM STATE_COUNTRY WHERE index_value=@index_selected";
            //cmd = new SqlCommand(s2, con);
            //cmd.Parameters.AddWithValue("@Disease_Index", disease_index);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "Arm_Sub_Body_Parts");
            dt = ds.Tables["Arm_Sub_Body_Parts"];
        }

        public void Abdomen_Sub_Body_Parts_con()
        {
            con = new SqlConnection();
            con.ConnectionString = constr;
            con.Open();
            //string select_query = "proc_state_country";
            cmd = new SqlCommand("proc_Abdomen_Sub_Body_parts", con);
            //string s2 = "SELECT STATES FROM STATE_COUNTRY WHERE index_value=@index_selected";
            //cmd = new SqlCommand(s2, con);
            //cmd.Parameters.AddWithValue("@Disease_Index", disease_index);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "Abdomen_Sub_Body_parts");
            dt = ds.Tables["Abdomen_Sub_Body_parts"];
        }

        public void Leg_Sub_Body_Parts_con()
        {
            con = new SqlConnection();
            con.ConnectionString = constr;
            con.Open();
            //string select_query = "proc_state_country";
            cmd = new SqlCommand("proc_Leg_Sub_Body_parts", con);
            //string s2 = "SELECT STATES FROM STATE_COUNTRY WHERE index_value=@index_selected";
            //cmd = new SqlCommand(s2, con);
            //cmd.Parameters.AddWithValue("@Disease_Index", disease_index);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "Leg_Sub_Body_parts");
            dt = ds.Tables["Leg_Sub_Body_parts"];
        }

        public void Leg_subpart_Dr_Con(int Prescription_indx)
        {
            con = new SqlConnection();
            con.ConnectionString = constr;
            con.Open();
            cmd = new SqlCommand("proc_select_Leg_dr",con);
            cmd.Parameters.AddWithValue("@body_part", Prescription_indx);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "Leg_Sub_Body_parts");
            dt = ds.Tables["Leg_Sub_Body_parts"];
        }

        public void Abdomen_subpart_Dr_Con(int Abdomen_index)
        {
            con = new SqlConnection();
            con.ConnectionString = constr;
            con.Open();
            cmd = new SqlCommand("proc_select_Abdomen_dr", con);
            cmd.Parameters.AddWithValue("@abdomen_body_part", Abdomen_index);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "Abdomen_Sub_Body_Parts");
            dt = ds.Tables["Abdomen_Sub_Body_Parts"];
        
        }

        public void Arm_Dr_Con(int Arm_index)
        {
            con = new SqlConnection();
            con.ConnectionString = constr;
            con.Open();
            cmd = new SqlCommand("proc_select_Arm_dr", con);
            cmd.Parameters.AddWithValue("@arm_body_part", Arm_index);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "Arm_Sub_Body_Parts");
            dt = ds.Tables["Arm_Sub_Body_Parts"];

        }
        public void Head_Dr_Con(int Head_index)
        {    
            con = new SqlConnection();
            con.ConnectionString = constr;
            con.Open();
            cmd = new SqlCommand("proc_select_Head_dr", con);
            cmd.Parameters.AddWithValue("@Sub_BODY_PARTS", Head_index);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "Head_Sub_Body_Parts");
            dt = ds.Tables["Head_Sub_Body_Parts"];
       
        }


        public void Health_Info_Details()
        {
            con = new SqlConnection();
            con.ConnectionString = constr;
            con.Open();
            cmd = new SqlCommand("proc_Health_Info", con);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            SqlCommandBuilder cmdbldr = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "Health_Info");
            dt = ds.Tables["Health_Info"];
        }

        public void send_user_ID(string username1, string password1)
        {
            con = new SqlConnection();
            con.ConnectionString = constr;
            con.Open();
            cmd = new SqlCommand("proc_send_user_id", con);
            cmd.Parameters.AddWithValue("@fname", username1);
            cmd.Parameters.AddWithValue("@password", password1);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "Sign_Up_Page");
            dt = ds.Tables["Sign_Up_Page"];
        }

        /*public void send_user_sign_up_data(string username2,string password2)
        {
            con = new SqlConnection();
            con.ConnectionString = constr;
            con.Open();
            cmd = new SqlCommand("proc_send_user_sign_up_info", con);
            cmd.Parameters.AddWithValue("@fname", username2);
            cmd.Parameters.AddWithValue("@password", password2);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "Sign_Up_Page");
            dt = ds.Tables["Sign_Up_Page"];
        }*/

        
        public void send_user_sign_up_data_by_id(string users_id)
        {
            con = new SqlConnection();
            con.ConnectionString = constr;
            con.Open();
            cmd = new SqlCommand("proc_send_info_by_id", con);
            cmd.Parameters.AddWithValue("@id", users_id);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "Sign_Up_Page");
            dt = ds.Tables["Sign_Up_Page"];
        }

        public void Bind_Data_Grid()
        {
            con = new SqlConnection();
            con.ConnectionString = constr;
            con.Open();
            cmd = new SqlCommand("proc_Total_user_Data", con);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            SqlCommandBuilder cmdbldr = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "Sign_up_page");
            dt = ds.Tables["Sign_up_page"];
        }

        public void Medicine_Bank_Con(String Medicine_Name)
        {
            con = new SqlConnection();
            con.ConnectionString = constr;
            con.Open();
            cmd = new SqlCommand("proc_Medicine_Bank_search", con);
            cmd.Parameters.AddWithValue("@alphabet", Medicine_Name);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "Medicine_Bank");
            dt = ds.Tables["Medicine_Bank"];

        }
        public void Admin_con(string auser_name, string user_password)
        {
            con = new SqlConnection();
            con.ConnectionString = constr;
            con.Open();
            cmd = new SqlCommand("proc_admin_login", con);
            cmd.Parameters.AddWithValue("@user_name", auser_name);
            cmd.Parameters.AddWithValue("@password", user_password);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            //SqlCommandBuilder cmdbldr = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.FillSchema(ds, SchemaType.Source, "Admin_Login");
            da.Fill(ds, "Admin_Login");
            dt = ds.Tables["Admin_Login"];
            con.Close();
        }

        public void Change_password(int id, string password_up)
        {
            con = new SqlConnection();
            con.ConnectionString = constr;
            con.Open();
            cmd = new SqlCommand("proc_changepassword1", con);
            cmd.Parameters.AddWithValue("@user_id", id);
            cmd.Parameters.AddWithValue("@change_pass", password_up);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            //SqlCommandBuilder cmdbldr = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.FillSchema(ds, SchemaType.Source, "Sign_up_page");
            da.Fill(ds, "Sign_up_page");
            dt = ds.Tables["Sign_up_page"];
            con.Close();
        }
        public void FLName_Grid_Binding()
        {
            con = new SqlConnection();
            con.ConnectionString = constr;
            con.Open();
            cmd = new SqlCommand("proc_Sign_UP_binding", con);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            
            SqlCommandBuilder cmdbldr = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.FillSchema(ds, SchemaType.Source, "Sign_up_page");
            da.Fill(ds, "[Sign_up_page]");
            dt = ds.Tables["[Sign_up_page]"];
               
        }
        public void password_compare_case(string username, string password_case_sens)
        {
            con = new SqlConnection();
            con.ConnectionString = constr;
            con.Open();
            cmd = new SqlCommand("proc_sign_in_window", con);
            cmd.Parameters.AddWithValue("@user_name", username);
            cmd.Parameters.AddWithValue("@password_matching", password_case_sens);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            //SqlCommandBuilder cmdbldr = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.FillSchema(ds, SchemaType.Source, "Sign_up_page");
            da.Fill(ds, "Sign_up_page");
            dt = ds.Tables["Sign_up_page"];
            con.Close();
        
        }
        public void delete_profile(string delete_userid)
        {
            con = new SqlConnection();
            con.ConnectionString = constr;
            con.Open();
            cmd = new SqlCommand("proc_delete_user_profile", con);
            cmd.Parameters.AddWithValue("@userID", delete_userid);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            //SqlCommandBuilder cmdbldr = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.FillSchema(ds, SchemaType.Source, "Sign_up_page");
            da.Fill(ds, "Sign_up_page");
            dt = ds.Tables["Sign_up_page"];
            con.Close();
       }

        public void user_age(string userage_id)
        {
            con = new SqlConnection();
            con.ConnectionString = constr;
            con.Open();
            cmd = new SqlCommand("uers_age", con);
            cmd.Parameters.AddWithValue("@userid", userage_id);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.FillSchema(ds, SchemaType.Source, "Sign_up_page");
            da.Fill(ds, "Sign_up_page");
            dt = ds.Tables["Sign_up_page"];
            con.Close();
            
        }
    }
}

