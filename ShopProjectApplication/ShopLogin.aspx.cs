using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ShopProjectApplication
{
    public partial class ShopLogin : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Nirupama\\Documents\\ShopDB.mdf;Integrated Security=True;Connect Timeout=30");
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            try
            {
                int f = 0;
                cmd = new SqlCommand("select ShopId from shoptbl where (ShopId='"+shopid.Text+"' or ShopEmail='"+shopid.Text+"') and Shop_password='"+pass.Text+"' and Approved='True'", con);
                con.Open();
                String shop = "";
                SqlDataReader d = cmd.ExecuteReader();
                while (d.Read())
                {
                    shop = d[0].ToString();
                     f = f + 1;
                }
                if (f == 0)
                {
                    Response.Write("Incorrect ShopID or Password. Or your shop has not been approved by Admin Yet.");
                }
                else
                {
                    Session["ShopID"] = shop;
                    Response.Redirect("ShopProduct.aspx");
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