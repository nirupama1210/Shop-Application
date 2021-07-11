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
    public partial class Shoptbl : System.Web.UI.Page
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
                cmd = new SqlCommand("select * from shoptbl where ShopId='"+shopid.Text+"'",con);
                con.Open();
                SqlDataReader d = cmd.ExecuteReader();
                while(d.Read())
                {
                    f = f + 1;
                }
                int f1 = 0;
                con.Close();
                cmd = new SqlCommand("select * from shoptbl where ShopEmail='" + emailid.Text + "'", con);
                con.Open();
                SqlDataReader d1 = cmd.ExecuteReader();
                while (d1.Read())
                {
                    f1 = f1 + 1;
                }
                con.Close();
                int f2 = 0;
                cmd = new SqlCommand("select * from shoptbl where Shop_phone='" + phnno.Text + "'", con);
                con.Open();
                SqlDataReader d2 = cmd.ExecuteReader();
                while (d2.Read())
                {
                    f2 = f2 + 1;
                }
                con.Close();
                if (f == 0 && f1==0 && f2==0)
                {
                    cmd = new SqlCommand("insert into shoptbl values('" + shopid.Text + "','" + password.Text + "','" + shopname.Text + "','" + phnno.Text + "','" + line1.Text + "," + area.Text + "," + city.Text + "," + state.Text + "," + pincode.Text + "','" + emailid.Text + "',0)", con);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Response.Write("Your shop is created. Please wait for Admin to verify your details and approve your shop.");
                }
                else
                {
                    if (f != 0)
                    {
                        Lb1.Text = "* This Shop ID already exists";
                        Lb1.Visible = true;
                        Lb1.Enabled = true;
                        shopid.Text = "";
                    }
                    if(f1!=0)
                    {
                        Lb2.Text = "* This Shop Email already exists";
                        Lb2.Visible = true;
                        Lb2.Enabled = true;
                        emailid.Text = "";
                    }
                    if (f2 != 0)
                    {
                        Lb3.Text = "* This Shop Phone number already exists";
                        Lb3.Visible = true;
                        Lb3.Enabled = true;
                        phnno.Text = "";
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