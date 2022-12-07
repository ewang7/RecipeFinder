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
        private PasswordHelper pwh;
    
        private string email;
        protected void Page_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection();
            //ewang8
            conn.ConnectionString = "Server=sql.cs.luc.edu;uid=ewang8;pwd=p00277; Initial Catalog=RecipeFinderDB";
            conn.Open();

        }

       

        protected void Button1_Click(object sender, EventArgs e)
        {
            
                // uname = usrname;
                pwd = Request.Form["passwd"];
                email = Request.Form["email"];
                pwh = new PasswordHelper();

                string sql = "INSERT INTO dbo.UserTable VALUES (@Uname,@Pwd,'',@Email)";


                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.Add("@Uname", System.Data.SqlDbType.VarChar, 40).Value = txtUserName.Text;

            //set up erncryption for password
            String enPass= pwh.Encrypt(txtPassword.Text);
            command.Parameters.Add("@Pwd", System.Data.SqlDbType.VarChar, 40).Value = enPass;
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