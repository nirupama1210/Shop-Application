using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace ShopProjectApplication
{
    public partial class AddCart : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if(Session["Cname"]!=null)
            {
               // Response.Write(Session["Cname"].ToString());
                if (!IsPostBack)
                {
                    con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Nirupama\\Documents\\ShopDB.mdf;Integrated Security=True;Connect Timeout=30");

                    if (Session["addproduct"] != null)
                    {
                        if (Session["addproduct"].ToString() == "true")
                        {
                            Session["addproduct"] = "false";

                            if (Request.QueryString["shopid"] != null && Request.QueryString["prodid"] != null && Request.QueryString["size"] != null)
                            {



                                try
                                {
                                    String sid = Request.QueryString["shopid".ToString()];
                                    String pid = Request.QueryString["prodid".ToString()];
                                    String size = Request.QueryString["size".ToString()];
                                    if (size == "")
                                    {
                                        size = " ";
                                    }
                                    String quan = "1";
                                    if (Request.QueryString["quan"] != null)
                                    { quan = Request.QueryString["quan".ToString()]; }
                                    int f = 0;
                                    cmd = new SqlCommand("select * from Cart where Cust_user='" + Session["Cname"].ToString() + "' and ProdID='" + pid + "' and ShopID='" + sid + "' and Size='" + size + "'", con);
                                    int q = 0;
                                    con.Open();
                                    SqlDataReader d1 = cmd.ExecuteReader();
                                    while (d1.Read())
                                    {
                                        q = Convert.ToInt32(d1[4].ToString());
                                        f = f + 1;
                                    }

                                    con.Close();
                                    if (f == 0)
                                    {

                                        cmd = new SqlCommand("insert into Cart values('" + Session["Cname"].ToString() + "','" + pid + "','" + sid + "','" + size + "'," + quan + ")", con);
                                        con.Open();
                                        cmd.ExecuteNonQuery();
                                        con.Close();
                                    }
                                    if (f > 0)
                                    {
                                        q = q + Convert.ToInt32(quan);
                                        cmd = new SqlCommand("update Cart set Quantity=" + q.ToString() + " where Cust_user='" + Session["Cname"].ToString() + "' and ProdID='" + pid + "' and ShopID='" + sid + "'and Size='" + size + "'", con);
                                        con.Open();
                                        cmd.ExecuteNonQuery();
                                        con.Close();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Response.Write(ex.ToString());

                                }
                            }
                        }
                    }
                    cart();
                }

            }
            else
            {
                Session["site"] = "Cart";
                if (Request.QueryString["shopid"] != null && Request.QueryString["prodid"] != null && Request.QueryString["size"] != null)
                {
                    Response.Redirect("Customerlogin.aspx?shopid=" + Request.QueryString["shopid".ToString()] + "&prodid=" + Request.QueryString["prodid".ToString()] + "&size=" + Request.QueryString["size".ToString()]); 
                }
                else
                {
                    Response.Redirect("Customerlogin.aspx");
                }
            }
        }
        void cart()
        {
            try {

                DataTable dt = new DataTable();
                dt.Columns.Add("ProdID");
                dt.Columns.Add("ShopID");
                dt.Columns.Add("ProdName");
                dt.Columns.Add("ShopName");
                dt.Columns.Add("size");
                dt.Columns.Add("Price");
                dt.Columns.Add("ProdImage");
                dt.Columns.Add("Quantity");
                dt.Columns.Add("TPrice");
                String pname = "";
                        String sname = "";
                        String sizes = "";
                        String price = "";
                        String img = "";
                        String quan = "";
                        String tprice = "";
                String pid = "";
                String sid = "";
                        string base64String = "";
                        con.Open();
                        cmd = new SqlCommand("select ProdQuantity,Shop_address,ProdName,Category,Price,ProdImage,ShopName,c.size,c.Quantity,c.ShopID,c.ProdID from prodtbl p,shoptbl s,Cart c where p.ShopID=s.ShopId and s.ShopId=c.ShopId and c.ShopID=p.ShopID and p.ProdId=c.ProdID and p.Size=c.Size and Cust_user='" + Session["Cname"].ToString() + "'", con);
                        SqlDataReader d = cmd.ExecuteReader();
                        SqlDataAdapter da = new SqlDataAdapter();
                       
                        while (d.Read())
                        {
             
                            pname = d[2].ToString();
                            sname = d[6].ToString();
                            price = d[4].ToString();
                            sizes = d[7].ToString();
                            quan = d[8].ToString();
                    sid = d[9].ToString();
                    pid = d[10].ToString();
                            // Response.Write(d[4].ToString());
                            if (d[5] != System.DBNull.Value)
                            {
                                byte[] bytes = (byte[])d[5];

                                base64String = Convert.ToBase64String(bytes);
                            }
                            if (base64String != "")
                            {
                                img = "data:image/jpg;base64," + base64String;
                                base64String = "";

                            }
                            else
                            {
                                img = "no-image.jpg";

                            }
                            tprice = (Convert.ToInt32(price) * Convert.ToInt32(quan)).ToString();
                            dt.Rows.Add(pid,sid,pname, sname, sizes, price, img,quan,tprice);
                        }
              

                        con.Close();
                        
                        GridView1.DataSource = dt;
               
                        GridView1.DataBind();
                if (dt.Rows.Count == 0)
                {
                    Button1.Visible = false;
                }
                else { Button1.Visible = true; }
                    }
                    catch (Exception ex)
                    { Response.Write(ex.ToString()); }
                }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("PlaceOrder.aspx");
        }
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            
            if (e.CommandName == "Remove")
            {

                int RowIndex = Convert.ToInt32((e.CommandArgument).ToString());
                Button btn = (Button)GridView1.Rows[RowIndex].FindControl("btnRem");
                String pid = GridView1.Rows[RowIndex].Cells[0].Text;
                String sid = GridView1.Rows[RowIndex].Cells[1].Text;
                String size = GridView1.Rows[RowIndex].Cells[4].Text;
                if (size == "")
                {
                    size = " ";
                }
                //Response.Write("delete from Cart where Cust_user='" + Session["Cname"].ToString() + "' and ShopID='" + sid + "' and ProdID='" + pid + "' and size='" + size + "'");
                try
                {
                    con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Nirupama\\Documents\\ShopDB.mdf;Integrated Security=True;Connect Timeout=30");
                    con.Open();
                    cmd = new SqlCommand("delete from Cart where Cust_user='" + Session["Cname"].ToString() + "' and ShopID='" + sid + "' and ProdID='" + pid + "' and size='" + size + "'", con);
                    int x=cmd.ExecuteNonQuery();
                    con.Close();
                   // Response.Write(x);
                    cart();
                }
                catch(Exception ex)
                {
                    Response.Write(ex.ToString());
                }


            }
            if(e.CommandName=="Modify")
            {
                int RowIndex = Convert.ToInt32((e.CommandArgument).ToString());
                String pid = GridView1.Rows[RowIndex].Cells[0].Text;
                String sid = GridView1.Rows[RowIndex].Cells[1].Text;
                String size = GridView1.Rows[RowIndex].Cells[4].Text;
                Response.Redirect("ModifyCart.aspx?pid="+pid+"&sid="+sid+"&size="+size);

            }
        }
    }
}