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

                int result = command.ExecuteNonQuery();


                if (result == 1)
                {
                    errormessage.Text = "Insert successful";

                }
                conn.Close();
            
            
        }

        protected bool isValidEmail(  ) {


            return false;
         }
    }
}