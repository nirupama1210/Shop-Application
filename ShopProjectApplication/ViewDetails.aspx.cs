using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ShopProjectApplication
{
    public partial class ViewDetails : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    String size = "";
                    String sid = Request.QueryString["shopid".ToString()];
                    String pid = Request.QueryString["prodid".ToString()];
                    int q = 0;
                    string base64String = "";
                    con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Nirupama\\Documents\\ShopDB.mdf;Integrated Security=True;Connect Timeout=30");
                    cmd = new SqlCommand("select ProdQuantity,Shop_address,ProdName,Category,Price,ProdImage,ShopName,size from prodtbl p,shoptbl s where p.ShopID=s.ShopId and ProdID='" + pid + "' and p.ShopID='" + sid + "'", con);
                    con.Open();
                    SqlDataReader d1 = cmd.ExecuteReader();
                    int f = 0;

                    while (d1.Read())
                    {
                        f = f + 1;
                    }
                    con.Close();
                    if (f == 1)
                    {

                        cmd = new SqlCommand("select ProdQuantity,Shop_address,ProdName,Category,Price,ProdImage,ShopName,size from prodtbl p,shoptbl s where p.ShopID=s.ShopId and ProdID='" + pid + "' and p.ShopID='" + sid + "'", con);
                        con.Open();
                        SqlDataReader d = cmd.ExecuteReader();
                        while (d.Read())
                        {

                            Label2.Text = d[6].ToString();
                            Label3.Text = d[2].ToString();
                            Label4.Text = d[3].ToString();
                            q = Convert.ToInt32(d[0].ToString());
                            if (Convert.ToInt32(d[0].ToString()) > 0 && Convert.ToInt32(d[0].ToString()) < 5)
                            { Label1.Text = " LESS THAN 5 LEFT "; }
                            else if (Convert.ToInt32(d[0].ToString()) >= 5)
                            {
                                Label1.Text = " IN STOCK ";
                            }
                            else if (Convert.ToInt32(d[0].ToString()) <= 0)
                            {
                                Label1.Text = " OUT OF STOCK";
                            }
                            Label5.Text = d[4].ToString();
                            Label6.Text = d[1].ToString();
                            if (d[7].ToString() != " ")
                            {
                                Label7.Text = "Size " + d[7].ToString();
                                
                     
                            }
                            size = d[7].ToString();
                            if (d[5] != System.DBNull.Value)
                            {
                                byte[] bytes = (byte[])d[5];

                                base64String = Convert.ToBase64String(bytes);
                            }
                        }
                        if (base64String != "")
                        {
                            Image1.ImageUrl = "data:image/jpg;base64," + base64String;
                            Image1.Visible = true;
                        }
                        else
                        {
                            Image1.ImageUrl = "no-image.jpg";
                            Image1.Visible = true;
                        }
                    
                        DropDownList1.Visible = false;
                        Label1.Visible = true;
                        con.Close();
                        if (q > 0)
                        {
                            DropDownList2.Enabled = true;
                            if (q > 5)
                            {
                                DropDownList2.Items.Clear();
                                for (int i = 0; i < 5; i++)
                                { DropDownList2.Items.Insert(i,(i+1).ToString()); }
                            }
                            else
                            {
                                DropDownList2.Items.Clear();
                                for (int i = 0; i < q; i++)
                                { DropDownList2.Items.Insert(i, (i + 1).ToString()); }
                            }
                        }
                    }
                    else if (f > 1)
                    {

                        String Shop = "";
                        String prod = "";
                        String cat = "";
                        String add = "";

                        cmd = new SqlCommand("select ProdQuantity,Shop_address,ProdName,Category,Price,ProdImage,ShopName,size from prodtbl p,shoptbl s where p.ShopID=s.ShopId and ProdID='" + pid + "' and p.ShopID='" + sid + "'", con);
                        con.Open();
                        SqlDataReader d2 = cmd.ExecuteReader();
                        DropDownList1.Items.Clear();
                        int i = 1;
                        DropDownList1.Items.Insert(0, "Sizes");
                        while (d2.Read())
                        {
                            DropDownList1.Items.Insert(i, d2[7].ToString());
                            i = i + 1;
                            Shop = d2[6].ToString();
                            prod = d2[2].ToString();
                            cat = d2[3].ToString();
                            add = d2[1].ToString();
                            if (d2[5] != System.DBNull.Value)
                            {
                                byte[] bytes = (byte[])d2[5];

                                base64String = Convert.ToBase64String(bytes);
                            }
                        }
                        if (base64String != "")
                        {
                            Image1.ImageUrl = "data:image/jpg;base64," + base64String;
                            Image1.Visible = true;
                        }
                        else
                        {
                            Image1.ImageUrl = "no-image.jpg";
                            Image1.Visible = true;
                        }
                        con.Close();
                        Label1.Text = "Select size";
                        Label5.Text = "Select size";
                        Label2.Text = Shop;
                        Label3.Text = prod;
                        Label4.Text = cat;
                        Label6.Text = add;
                        Label7.Visible = false;
                        Label1.Visible = false;
                        DropDownList1.Visible = true;
                        DropDownList2.Enabled = false;
                    }
                    
                    
                }
                catch (Exception ex) { Response.Write(ex.ToString()); }

            }
            Label8.Visible = false;
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(DropDownList1.SelectedValue!="Sizes" && DropDownList1.Visible)
            {
                try
                {

                    String sid = Request.QueryString["shopid".ToString()];
                    String pid = Request.QueryString["prodid".ToString()];
                    String size = DropDownList1.SelectedValue;
                    String price = "";
                    String quan = "";
                    con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Nirupama\\Documents\\ShopDB.mdf;Integrated Security=True;Connect Timeout=30");
                    cmd = new SqlCommand("select ProdQuantity,Price from prodtbl p,shoptbl s where p.ShopID=s.ShopId and ProdID='" + pid + "' and p.ShopID='" + sid + "' and size='"+size+"'", con);
                    con.Open();
                    SqlDataReader d2 = cmd.ExecuteReader();
                    while (d2.Read())
                    {
                        price = d2[1].ToString();
                        quan = d2[0].ToString();
                    }
                     if (Convert.ToInt32(quan) > 0 && Convert.ToInt32(quan) < 5)
                     { Label1.Text = " LESS THAN 5 LEFT "; }
                     else if (Convert.ToInt32(quan) >= 5)
                     {
                         Label1.Text = " IN STOCK ";
                     }
                     else if (Convert.ToInt32(quan) <= 0)
                     {
                         Label1.Text = " OUT OF STOCK";
                     }
                   
                    Label5.Text = price;
                    Label1.Visible = true;

                    if (Convert.ToInt32(quan) > 0)
                    {
                        
                        DropDownList2.Enabled = true;
                        if (Convert.ToInt32(quan) > 5)
                        {
                            DropDownList2.Items.Clear();
                            for (int i = 0; i < 5; i++)
                            { DropDownList2.Items.Insert(i, (i + 1).ToString()); }
                        }
                        else
                        {
                            DropDownList2.Items.Clear();
                            for (int i = 0; i < Convert.ToInt32(quan); i++)
                            { DropDownList2.Items.Insert(i, (i + 1).ToString()); }
                        }
                    }
                }
                catch(Exception ex)
                {
                    Response.Write(ex.ToString());
                }

            }
            Label8.Visible = false;
            if(DropDownList1.SelectedValue=="Sizes" && DropDownList1.Visible)
            {
                Label1.Text = "Select size";
                Label5.Text = "Select size";
                DropDownList2.Enabled = false;
                Label7.Visible = false;
                Label1.Visible = false;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList2.Enabled)
            {
                if (DropDownList1.SelectedValue != "Sizes" && DropDownList1.Visible)
                {
                    Session["addproduct"] = "true";
                    String sid = Request.QueryString["shopid".ToString()];
                    String pid = Request.QueryString["prodid".ToString()];
                    Response.Redirect("AddCart.aspx?shopid=" + sid + "&prodid=" + pid + "&size=" + DropDownList1.SelectedValue.ToString()+"&quan="+DropDownList2.SelectedValue.ToString());
                }
                else if (DropDownList1.Visible == false)
                {
                    Session["addproduct"] = "true";
                    String sid = Request.QueryString["shopid".ToString()];
                    String pid = Request.QueryString["prodid".ToString()];
                    Response.Redirect("AddCart.aspx?shopid=" + sid + "&prodid=" + pid + "&size=" + Label7.Text.Split(' ')[1]+"&quan=" + DropDownList2.SelectedValue.ToString());
                }
                if (DropDownList1.SelectedValue == "Sizes" && DropDownList1.Visible)
                {
                    Label8.Text = "Please Select a size";
                    Label8.Visible = true;
                    DropDownList2.Enabled = false;
                }
            }
            else
            {
                Label8.Text = "Please Select a size and then choose quantity";
                Label8.Visible = true;
            }
        }
    }
}