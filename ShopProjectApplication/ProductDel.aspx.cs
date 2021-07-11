using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ShopProjectApplication
{
    public partial class ProductDel : System.Web.UI.Page
    {

        SqlConnection con;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ShopID"] != null)
            {

                if (Session["ShopID"].ToString() == "")
                { Response.Redirect("ShopLogin.aspx"); }
            }
            if (Session["ShopID"] == null)
            {
                Response.Redirect("ShopLogin.aspx");
            }
            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Nirupama\\Documents\\ShopDB.mdf;Integrated Security=True;Connect Timeout=30");
            Tb1.Text = Session["ShopID"].ToString();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue == "By Category")
            {
                Ddl2.Visible = true;
                Ddl2.Enabled = true;
                Ddl3.Visible = false;
                Ddl3.Enabled = false;
                Ddl4.Visible = false;
                Ddl4.Enabled = false;
                Ddl5.Visible = false;
                Ddl5.Enabled = false;
                Lb3.Visible = false;
                Lb3.Enabled = false;
                Lb2.Visible = false;
                Lb2.Enabled = false;
                Lb1.Visible = false;
                Lb1.Enabled = false;
            }
            else if (DropDownList1.SelectedValue == "By Product ID")
            {
                try
                {

                    cmd = new SqlCommand("select distinct(ProdID) from prodtbl where ShopID='" + Session["ShopID"].ToString() + "'", con);
                    con.Open();
                    int i = 0;
                    SqlDataReader d = cmd.ExecuteReader();
                    Ddl3.Items.Clear();
                    Ddl2.Visible = false;
                    Ddl2.Enabled = false;
                    while (d.Read())
                    {
                        Ddl3.Items.Insert(i, d[0].ToString());
                        i = i + 1;
                    }
                    Lb1.Visible = true;
                    Lb1.Enabled = true;
                    Lb1.Text = "Product ID";
                    Ddl3.Visible = true;
                    Ddl3.Enabled = true;
                    con.Close();
                    Ddl4.Visible = false;
                    Ddl4.Enabled = false;
                    Lb2.Visible = false;
                    Lb2.Enabled = false;
                    Ddl5.Visible = false;
                    Ddl5.Enabled = false;
                    Lb3.Visible = false;
                    Lb3.Visible = false;
                }
                catch (Exception ex)
                {
                    Response.Write(ex.ToString());
                }
            }
            else if (DropDownList1.SelectedValue == "By Product Name")
            {
                try
                {

                    cmd = new SqlCommand("select distinct(ProdName) from prodtbl where ShopID='" + Session["ShopID"].ToString() + "'", con);
                    con.Open();
                    int i = 0;
                    SqlDataReader d = cmd.ExecuteReader();
                    Ddl3.Items.Clear();
                    Ddl2.Visible = false;
                    Ddl2.Enabled = false;
                    while (d.Read())
                    {
                        Ddl3.Items.Insert(i, d[0].ToString());
                        i = i + 1;
                    }
                    Lb1.Visible = true;
                    Lb1.Enabled = true;
                    Lb1.Text = "Product Names";
                    Ddl3.Visible = true;
                    Ddl3.Enabled = true;
                    con.Close();
                    Ddl4.Visible = false;
                    Ddl4.Enabled = false;
                    Lb2.Visible = false;
                    Lb2.Enabled = false;
                    Ddl5.Visible = false;
                    Ddl5.Enabled = false;
                    Lb3.Visible = false;
                    Lb3.Visible = false;
                }
                catch (Exception ex)
                {
                    Response.Write(ex.ToString());
                }
            }
            Lb4.Visible = false;
            Lb4.Enabled = false;
        }

        protected void Ddl3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue == "By Product Name" )
            {
                try
                {

                    cmd = new SqlCommand("select distinct(ProdID) from prodtbl where ShopID='" + Session["ShopID"].ToString() + "' and ProdName='" + Ddl3.SelectedValue + "'", con);
                    con.Open();
                    int i = 0;
                    SqlDataReader d = cmd.ExecuteReader();
                    Ddl4.Items.Clear();
                    Ddl2.Visible = false;
                    Ddl2.Enabled = false;
                    while (d.Read())
                    {
                        Ddl4.Items.Insert(i, d[0].ToString());
                        i = i + 1;
                    }
                    Lb2.Visible = true;
                    Lb2.Enabled = true;
                    Lb2.Text = "Product ID";
                    Ddl4.Visible = true;
                    Ddl4.Enabled = true;
                    Ddl5.Visible = false;
                    Ddl5.Enabled = false;
                    Lb3.Visible = false;
                    Lb3.Visible = false;
                    con.Close();
                }
                catch (Exception ex)
                {
                    Response.Write(ex.ToString());
                }
            }
            else if (DropDownList1.SelectedValue == "By Category")
            {
                try
                {

                    cmd = new SqlCommand("select distinct(ProdID) from prodtbl where ShopID='" + Session["ShopID"].ToString() + "' and ProdName='" + Ddl3.SelectedValue + "' and Category='"+Ddl2.SelectedValue+"'", con);
                    con.Open();
                    int i = 0;
                    SqlDataReader d = cmd.ExecuteReader();
                    Ddl4.Items.Clear();
                    Ddl2.Visible = true;
                    Ddl2.Enabled = true;
                    while (d.Read())
                    {
                        Ddl4.Items.Insert(i, d[0].ToString());
                        i = i + 1;
                    }
                    Lb2.Visible = true;
                    Lb2.Enabled = true;
                    Lb2.Text = "Product ID";
                    Ddl4.Visible = true;
                    Ddl4.Enabled = true;
                    con.Close();
                }
                catch (Exception ex)
                {
                    Response.Write(ex.ToString());
                }
            }
            else if (DropDownList1.SelectedValue=="By Product ID")
            {
                try
                {
                    cmd = new SqlCommand("select Size from prodtbl where ShopID='" + Session["ShopID"].ToString() + "' and ProdID='" + Ddl3.SelectedValue + "' and Size!=' '", con);
                    con.Open();
                    int i = 0;
                    SqlDataReader d = cmd.ExecuteReader();
                    Ddl4.Items.Clear();
                    Ddl4.Visible = true;
                    Ddl4.Enabled = true;
                    Ddl4.Items.Insert(i, " ");
                    i = i + 1;
                    while (d.Read())
                    {
                        Ddl4.Items.Insert(i, d[0].ToString());
                        i = i + 1;
                    }
                    Lb2.Visible = true;
                    Lb2.Text = "Size";
                    Lb2.Enabled = true;
                    if (i == 1)
                    {
                        Ddl4.Visible = false;
                        Lb2.Visible = false;
                    }
                    con.Close();

                }
                catch(Exception ex)
                {
                    Response.Write(ex.ToString());
                }
            }
            Lb4.Visible = false;
            Lb4.Enabled = false;
        }

        protected void Ddl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue == "By Category")
            {
                try
                {

                    cmd = new SqlCommand("select distinct(ProdName) from prodtbl where Category='" + Ddl2.SelectedValue + "' and ShopID='"+ Session["ShopID"].ToString() + "'", con);
                    con.Open();
                    int i = 0;
                    SqlDataReader d = cmd.ExecuteReader();
                    Ddl3.Items.Clear();
                    
                    while (d.Read())
                    {
                        Ddl3.Items.Insert(i, d[0].ToString());
                        i = i + 1;
                    }
                    Lb1.Visible = true;
                    Lb1.Enabled = true;
                    Lb1.Text = "Product Names";
                    Ddl3.Visible = true;
                    Ddl3.Enabled = true;
                    con.Close();
                }
                catch (Exception ex)
                {
                    Response.Write(ex.ToString());
                }
            }
            Lb4.Visible = false;
            Lb4.Enabled = false;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue == "By Category")
            {
                if (Ddl4.Enabled && Ddl5.Enabled)
                {
                    try
                    {
                        cmd = new SqlCommand("delete from prodtbl where ShopId='" + Session["ShopID"].ToString() + "' and ProdID='" + Ddl4.SelectedValue + "' and Size='" + Ddl5.SelectedValue + "'", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        Lb4.Text=("Product Deleted");
                        Lb4.Visible = true;
                        Lb4.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        Response.Write(ex.ToString());
                    }
                }
                else if (Ddl4.Enabled && !Ddl5.Enabled)
                {
                    try
                    {
                        cmd = new SqlCommand("delete from prodtbl where ShopId='" + Session["ShopID"].ToString() + "' and ProdID='" + Ddl4.SelectedValue + "' and Size=' '", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        Lb4.Text = ("Product Deleted");
                        Lb4.Visible = true;
                        Lb4.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        Response.Write(ex.ToString());
                    }
                }
            }
            else if (DropDownList1.SelectedValue == "By Product Name")
            {
                if (Ddl4.Enabled && Ddl5.Enabled)
                {
                    try
                    {
                        cmd = new SqlCommand("delete from prodtbl where ShopId='" + Session["ShopID"].ToString() + "' and ProdID='" + Ddl4.SelectedValue + "' and Size='" + Ddl5.SelectedValue + "'", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        Lb4.Text = ("Product Deleted");
                        Lb4.Visible = true;
                        Lb4.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        Response.Write(ex.ToString());
                    }
                }
                else if (Ddl4.Enabled && !Ddl5.Enabled)
                {

                    try
                    {
                        cmd = new SqlCommand("delete from prodtbl where ShopId='" + Session["ShopID"].ToString() + "' and ProdID='" + Ddl4.SelectedValue + "' and Size=' '", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        Lb4.Text = ("Product Deleted");
                        Lb4.Visible = true;
                        Lb4.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        Response.Write(ex.ToString());
                    }
                }
                else
                {
                    Lb4.Text="Please Select all values";
                    Lb4.Visible = true;
                    Lb4.Enabled = true;
                }
            }
            else if (DropDownList1.SelectedValue == "By Product ID")
            {
                if (Ddl3.Enabled && Ddl4.Enabled)
                {
                    try
                    {
                        cmd = new SqlCommand("delete from prodtbl where ShopId='" + Session["ShopID"].ToString() + "' and ProdID='" + Ddl3.SelectedValue + "' and Size='" + Ddl4.SelectedValue + "'", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        Lb4.Text = ("Product Deleted");
                        Lb4.Visible = true;
                        Lb4.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        Response.Write(ex.ToString());
                    }
                }
                else if (Ddl3.Enabled && !Ddl4.Enabled)
                {

                    try
                    {
                        cmd = new SqlCommand("delete from prodtbl where ShopId='" + Session["ShopID"].ToString() + "' and ProdID='" + Ddl3.SelectedValue + "' and Size=' '", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        Lb4.Text = ("Product Deleted");
                        Lb4.Visible = true;
                        Lb4.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        Response.Write(ex.ToString());
                    }
                }
                else
                {
                   Lb4.Text=("Please Select all values");
                    Lb4.Visible = true;
                    Lb4.Enabled = true;
                }
            }
            else
            {
                Lb4.Text=("Please Select all values");
                Lb4.Visible = true;
                Lb4.Enabled = true;
            }

             }

        protected void Ddl4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue == "By Category")
            {
                try
                {

                    cmd = new SqlCommand("select distinct(Size) from prodtbl where Category='" + Ddl2.SelectedValue + "' and ShopId='"+ Session["ShopID"].ToString() + "' and ProdId='"+Ddl4.Text+"'", con);
                    con.Open();
                    int i = 0;
                    SqlDataReader d = cmd.ExecuteReader();
                    Ddl5.Items.Clear();

                    while (d.Read())
                    {
                        Ddl5.Items.Insert(i, d[0].ToString());
                        i = i + 1;
                    }
                    Lb3.Visible = true;
                    Lb3.Enabled = true;
                    Ddl5.Visible = true;
                    Ddl5.Enabled = true;
                    con.Close();
                }
                catch (Exception ex)
                {
                    Response.Write(ex.ToString());
                }
            }
            else if (DropDownList1.SelectedValue == "By Product Name")
            {
                try
                {

                    cmd = new SqlCommand("select distinct(Size) from prodtbl where ProdName='"+Ddl3.SelectedValue+"' and ShopId='" + Session["ShopID"].ToString() + "' and ProdId='" + Ddl4.SelectedValue + "' and Size!=' '", con);
                    con.Open();
                    int i = 0;
                    SqlDataReader d = cmd.ExecuteReader();
                    Ddl5.Items.Clear();
                    Ddl5.Items.Insert(i, " ");
                    i = i + 1;
                    while (d.Read())
                    {
                        Ddl5.Items.Insert(i, d[0].ToString());
                        i = i + 1;
                    }
                    Lb3.Visible = true;
                    Lb3.Enabled = true;
                    Ddl5.Visible = true;
                    Ddl5.Enabled = true;
                    con.Close();
                }
                catch (Exception ex)
                {
                    Response.Write(ex.ToString());
                }
            }
        }
    }
}