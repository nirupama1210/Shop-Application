using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace ShopProjectApplication
{
    public partial class Customer_register : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Nirupama\\Documents\\ShopDB.mdf;Integrated Security=True;Connect Timeout=30");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int f = 0;
                cmd = new SqlCommand("select * from customertbl where Cust_user='" + username.Text + "'", con);
                con.Open();
                SqlDataReader d = cmd.ExecuteReader();
                while (d.Read())
                {
                    f = f + 1;
                }
                int f1 = 0;
                con.Close();
                cmd = new SqlCommand("select * from customertbl where Cust_Email='" + emailid.Text + "'", con);
                con.Open();
                SqlDataReader d1 = cmd.ExecuteReader();
                while (d1.Read())
                {
                    f1 = f1 + 1;
                }
                con.Close();
                if (f == 0 && f1 == 0)
                {
                    cmd = new SqlCommand("insert into customertbl values('" + username.Text + "','" + password.Text + "','" + emailid.Text + "','" + phnno.Text + "','')", con);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Response.Write("You are registered. Please login.");
                }
                else
                {
                    if (f != 0)
                    {
                        Label1.Text = "* This Username already registered";
                       Label1.Visible = true;
                       
                        username.Text = "";
                    }
                    if (f1 != 0)
                    {
                       Label2.Text = "* This Email already registered";
                        Label2.Visible = true;
                        
                        emailid.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }

        }
    }
    }
