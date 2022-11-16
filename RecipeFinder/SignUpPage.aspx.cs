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
        private string cpwd;
        private string email;
        protected void Page_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection();
            conn.ConnectionString = "Server=sql.cs.luc.edu;uid=aopon;pwd=p43613; Initial Catalog=aopon";
            conn.Open();

        }

        public int ExecuteAction(string sql)
        {
            SqlCommand command = new SqlCommand(sql, conn);
            int result = command.ExecuteNonQuery();
            return result;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            uname = Request.Form["uname"];
            pwd   = Request.Form["pwd"];
            cpwd  = Request.Form["cpwd"];
            email = Request.Form["email"];

            string sqlstatement = "INSERT INTO dbo.UserTable VALUES (1,'uname','pwd','email')";

            int result = ExecuteAction(sqlstatement);
            if (result!=1) 
            {
                string err = Request.Form["errormessage"];
              
            }
            conn.Close();
        }
    }
}