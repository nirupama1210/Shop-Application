using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ShopProjectApplication
{
    public partial class Customerlogin : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Nirupama\\Documents\\ShopDB.mdf;Integrated Security=True;Connect Timeout=30");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["Cname"] == null)
            {
                try
                {
                    int f = 0;
                    cmd = new SqlCommand("select Cust_user from customertbl where (Cust_user='" + username.Text + "' or Cust_Email='" + username.Text + "') and Cust_Pass='" + password.Text+"'", con);
                    con.Open();
                    String cust = "";
                    SqlDataReader d = cmd.ExecuteReader();
                    while (d.Read())
                    {
                        cust = d[0].ToString();
                        f = f + 1;
                    }
                    if (f == 0)
                    {
                        Response.Write("Incorrect Username or Password.");
                    }
                    else
                    {
                        Session["Cname"] = cust;
                        if (Session["site"] != null)
                        {
                            if (Session["site"].ToString() == "Cart" || Session["site"].ToString() == "ModCart")
                            {
                                Session["site"] = null;
                                if (Request.QueryString["shopid"] != null && Request.QueryString["prodid"] != null && Request.QueryString["size"] != null)
                                {
                                    Response.Redirect("AddCart.aspx?shopid=" + Request.QueryString["shopid".ToString()] + "&prodid=" + Request.QueryString["prodid".ToString()] + "&size=" + Request.QueryString["size".ToString()]);
                                }
                                else
                                {
                                    Response.Redirect("AddCart.aspx");
                                }
                                
                            }
                            else if (Session["site"].ToString() == "Order" || Session["site"].ToString() == "Place")
                            {
                                Session["site"] = null;
                                Response.Redirect("MyOrders.aspx");
                            }


                        }
                        else
                        {
                            Response.Redirect("AddCart.aspx");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Response.Write(ex.ToString());
                }
            }
            else {
                Session["Cname"] = null;
                Response.Redirect("HomePage.aspx");

            }

        }

        protected void Home_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
    }
}