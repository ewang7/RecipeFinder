using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace RecipeFinder
{
    public partial class SignUpPage : System.Web.UI.Page
    {
        private SqlConnection conn;
        private string uname;
        private string pwd;
    
        private string email;
        protected void Page_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection();
            conn.ConnectionString = "Server=sql.cs.luc.edu;uid=aopon;pwd=p43613; Initial Catalog=RecipeFinderDB";
            conn.Open();

        }

       

        protected void Button1_Click(object sender, EventArgs e)
        {
            
                // uname = usrname;
                pwd = Request.Form["passwd"];
                email = Request.Form["email"];

                string sql = "INSERT INTO dbo.UserTable VALUES (@Uname,@Pwd,'',@Email)";


                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.Add("@Uname", System.Data.SqlDbType.VarChar, 40).Value = txtUserName.Text;
                command.Parameters.Add("@Pwd", System.Data.SqlDbType.VarChar, 40).Value = txtPassword.Text;
                command.Parameters.Add("@Email", System.Data.SqlDbType.VarChar, 40).Value = txtEmailAdd.Text;

            int result = 0;

            if (isNameTaken(txtUserName.Text))
            {
                result = command.ExecuteNonQuery();
            }
            else {
                errormessage.Text = "Username taken";
            };


                if (result == 1)
                {
                    errormessage.Text = "Insert successful";

                }
                conn.Close();
            
            
        }

        protected bool isNameTaken(String username) {
            //sql string used to get username from DB
            string sql = "SELECT * FROM UserTable WHERE Username=@Uname";
            bool result = true;

            SqlCommand comm = new SqlCommand(sql,conn);
            comm.Parameters.Add("@Uname", System.Data.SqlDbType.VarChar, 40).Value = txtUserName.Text;


            SqlDataReader dr = comm.ExecuteReader();

            //command is executed and converted to string

            if (dr.Read())
            {
                string namecheck =  dr.GetString(1);
                //if the string comes back empty, we know the username hasn't been taken
                if (!namecheck.Equals("")) 
                {
                    dr.Close();
                    result = false;
                }
             
            }
            dr.Close();
            return result;
         }
    }
}