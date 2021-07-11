using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ShopProjectApplication
{
    public partial class ModifyCart : System.Web.UI.Page
    {

        SqlConnection con;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Cname"] != null)
            {
                if (!IsPostBack)
                {
                    try
                    {
                        String pid = Request.QueryString["pid".ToString()];
                        String sid = Request.QueryString["sid".ToString()];
                        String size = Request.QueryString["size".ToString()];
                        int q = 0;
                        String Pname = "";
                        String sname = "";
                        String price = "";
                        con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Nirupama\\Documents\\ShopDB.mdf;Integrated Security=True;Connect Timeout=30");
                        cmd = new SqlCommand("select ProdQuantity,ProdName,Price,ShopName from prodtbl p,shoptbl s where p.ShopID=s.ShopId and ProdID='" + pid + "' and p.ShopID='" + sid + "' and p.size='" + size + "'", con);

                        con.Open();
                        SqlDataReader d1 = cmd.ExecuteReader();
                        DropDownList1.Items.Clear();
                        while (d1.Read())
                        {
                            Pname = d1[1].ToString();
                            sname = d1[3].ToString();
                            price = d1[2].ToString();
                            q = Convert.ToInt32(d1[0].ToString());
                        }
                        con.Close();
                        Label1.Text = Pname;
                        Label2.Text = sname;
                        Label3.Text = price;
                        if (q > 5)
                        {
                            DropDownList1.Items.Clear();
                            for (int i = 0; i < 5; i++)
                            { DropDownList1.Items.Insert(i, (i + 1).ToString()); }
                        }
                        else
                        {
                            DropDownList1.Items.Clear();
                            for (int i = 0; i < q; i++)
                            { DropDownList1.Items.Insert(i, (i + 1).ToString()); }
                        }

                    }
                    catch (Exception ex)
                    {
                        ex.ToString();
                    }
                }
            }
            else {
                Session["site"] = "ModCart";
                Response.Redirect("Customerlogin.aspx");
            }
            }
        

        protected void Button1_Click(object sender, EventArgs e)
        {
        String pid = Request.QueryString["pid".ToString()];
        String sid = Request.QueryString["sid".ToString()];
        String size = Request.QueryString["size".ToString()];
           // Response.Write(DropDownList1.SelectedValue);
        con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Nirupama\\Documents\\ShopDB.mdf;Integrated Security=True;Connect Timeout=30");

            cmd = new SqlCommand("update Cart set Quantity="+DropDownList1.SelectedValue+" where ProdID='" + pid + "' and ShopID='" + sid + "' and size='" + size + "' and Cust_user='"+Session["Cname"].ToString()+"'", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("AddCart.aspx");
           
        }
    }
}