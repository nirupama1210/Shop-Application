using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
namespace ShopProjectApplication
{

    public partial class Admintbl : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Nirupama\\Documents\\ShopDB.mdf;Integrated Security=True;Connect Timeout=30");

        }


        protected void login_Click(object sender, EventArgs e)
        {
            try
            {
                int f = 0;
                String admin = "";
                cmd = new SqlCommand("select Admin_user from Admintbl where Admin_user='" + Username.Text + "' and Admin_pass='" + password.Text + "'", con);
                con.Open();

                SqlDataReader d = cmd.ExecuteReader();
                while (d.Read())
                {
                    f = f + 1;
                    admin = d[0].ToString();
                }
                if (f == 0)
                {
                    Response.Write("Incorrect Username or Password");
                }
                else
                {
                    Session["Admin_User"] = admin;
                    Response.Redirect("AdminApproveShop.aspx");
                    
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }


        }

        protected void Home_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
    }
}