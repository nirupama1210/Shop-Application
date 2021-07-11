using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using System.IO;
using iTextSharp.text;

namespace ShopProjectApplication
{
    public partial class MyOrders : System.Web.UI.Page
    {

        SqlConnection con;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (Session["Cname"] != null)
            {
               
                if (!IsPostBack)
                {
                    

                    DataTable dt = new DataTable();
                    dt.Columns.Add("OrderID");

                    dt.Columns.Add("OrderDate");
                    dt.Columns.Add("Total");
                    con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Nirupama\\Documents\\ShopDB.mdf;Integrated Security=True;Connect Timeout=30");
                    String OrderDate = "";
                    String OrderID = "";
                    String tot = "";
                    con.Open();
                    cmd = new SqlCommand("select distinct OrderDate,OrderID,Total from [Order] where Cust_user='" + Session["Cname"].ToString() + "'", con);
                    SqlDataReader d = cmd.ExecuteReader();


                    while (d.Read())
                    {

                        OrderDate = d[0].ToString();
                        OrderID = d[1].ToString();
                        tot = d[2].ToString();
                        dt.Rows.Add(OrderID, OrderDate, tot);
                    }
                    con.Close();
                    GridView1.DataSource = dt;
                    GridView1.DataBind();


                }
            }
            else {
                Session["site"] = "Order";
                Response.Redirect("Customerlogin.aspx");
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Show")
            {
                
                int RowIndex = Convert.ToInt32((e.CommandArgument).ToString());
                Button btn = (Button)GridView1.Rows[RowIndex].FindControl("btnShow");
                
                if (btn.Text == "Show More")
                {
                    
                    GridView gv =(GridView)GridView1.Rows[RowIndex].FindControl("GridView2");

                   String oid = GridView1.Rows[RowIndex].Cells[0].Text;

                    DataSet ds1 = new DataSet();

                    String ShopID = "";
                    String ProdID = "";
                    String size = "";
                    DataTable dt2 = new DataTable();
                    dt2.Columns.Add("ProdID");
                    dt2.Columns.Add("ShopID");
                    dt2.Columns.Add("Size");
                    con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Nirupama\\Documents\\ShopDB.mdf;Integrated Security=True;Connect Timeout=30");
                    con.Open();
                        cmd = new SqlCommand("select distinct ProdID,ShopID,Size from [Order] where Cust_user='" + Session["Cname"].ToString() + "' and OrderID='" + oid + "'", con);
                        SqlDataReader d2 = cmd.ExecuteReader();


                        while (d2.Read())
                        {

                            ProdID = d2[0].ToString();
                            ShopID = d2[1].ToString();
                            size = d2[2].ToString();
                            dt2.Rows.Add(ProdID, ShopID, size);
                        }
                        con.Close();
                    gv.DataSource = dt2;
                    gv.DataBind();
                    btn.Text = "Collapse";
                }
                else if (btn.Text == "Collapse")
                {
                    GridView gv = (GridView)GridView1.Rows[RowIndex].FindControl("GridView2");
                    gv.DataSource = null;
                    gv.DataBind();
                    btn.Text = "Show More";
                }
            
            }
        }
    }
}