using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;

namespace RecipeFinder
{
    public partial class LoginPage : System.Web.UI.Page
    {

        private SqlConnection conn;
        private string uname;
        private string pwd;
        protected void Page_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection();
            conn.ConnectionString = "Server=sql.cs.luc.edu;uid=aopon;pwd=p43613; Initial Catalog=RecipeFinderDB";
            conn.Open();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            if (!isLoginValid(txtUname.Text, Password1.Text))
            {
                logininfo.Text = "Wrong username/password";
            }
            else 
            {
                logininfo.Text = "User signed in";
            }



        }

        protected bool isLoginValid(String username,String password)
        {
            //sql string used to get username from DB
            string sql = "SELECT * FROM UserTable WHERE Username=@Uname AND Password=@Pwd";
            bool result = true;

            SqlCommand comm = new SqlCommand(sql, conn);
            comm.Parameters.Add("@Uname", System.Data.SqlDbType.VarChar, 40).Value = txtUname.Text;
            comm.Parameters.Add("@Pwd", System.Data.SqlDbType.VarChar, 40).Value = Password1.Text;


            SqlDataReader dr = comm.ExecuteReader();

            //command is executed and converted to string

            if (dr.Read())
            {
                string namecheck = dr.GetString(1);
               // string pwcheck = dr.GetString(2);
                //if the string comes back empty, we know the username isn't present
                if (namecheck.Equals(""))
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