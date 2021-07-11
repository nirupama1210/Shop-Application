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
    public partial class PlaceOrder : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        int finalprice = 0;
        int f = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Cname"] != null)
                {

                    DataTable dt = new DataTable();
                    dt.Columns.Add("ProdID");
                    dt.Columns.Add("ProdName");
                    dt.Columns.Add("Price");
                    dt.Columns.Add("ShopID");
                    dt.Columns.Add("Quantity");
                    dt.Columns.Add("Size");
                    dt.Columns.Add("TPrice");
                    con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Nirupama\\Documents\\ShopDB.mdf;Integrated Security=True;Connect Timeout=30");
                    try
                    {
                        String pname = "";
                        String pid = "";
                        String sid = "";
                        String price = "";
                        String size = "";
                        String quan = "";
                        String tprice = "";

                        con.Open();
                        cmd = new SqlCommand("select ProdName,c.ProdID,c.ShopID,c.size,c.Quantity,Price from prodtbl p,Cart c where c.ShopID=p.ShopID and p.ProdId=c.ProdID and p.Size=c.Size and Cust_user='" + Session["Cname"].ToString() + "'", con);
                        SqlDataReader d = cmd.ExecuteReader();
                        SqlDataAdapter da = new SqlDataAdapter();

                        while (d.Read())
                        {

                            pname = d[0].ToString();
                            pid = d[1].ToString();
                            sid = d[2].ToString();
                            size = d[3].ToString();
                            quan = d[4].ToString();
                            price = d[5].ToString();

                            finalprice = finalprice + (Convert.ToInt32(price) * Convert.ToInt32(quan));


                            tprice = (Convert.ToInt32(price) * Convert.ToInt32(quan)).ToString();
                            dt.Rows.Add(pid, pname, price, sid, quan, size, tprice);
                        }


                        con.Close();

                        GridView1.DataSource = dt;
                        Session["items"] = dt;
                        GridView1.DataBind();
                        if (GridView1.Rows.Count > 0)
                        {
                            GridView1.FooterRow.Cells[4].Text = "Grand Total";
                            GridView1.FooterRow.Cells[5].Text = finalprice.ToString();
                        }
                        Session["finalprice"]=finalprice;

                    }
                    catch (Exception ex)
                    { Response.Write(ex.ToString()); }
                    String oid = "O" + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + Session["Cname"].ToString();
                    Label1.Text = oid;
                    Label2.Text = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
                }
            }   
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            if(TextBox1.Text!="")
            {
                if (Session["items"] != null)
                {
                    if (DropDownList1.SelectedValue.ToString() == "Cash On Delivery")
                    {
                        
                       

                        Label3.Visible = false;
                        DataTable dt = (DataTable)Session["items"];
                        finalprice=Convert.ToInt32(Session["finalprice"].ToString());
                        
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {

                            try
                            {
                                
                                con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Nirupama\\Documents\\ShopDB.mdf;Integrated Security=True;Connect Timeout=30");
                                con.Open();
                                cmd = new SqlCommand("insert into [Order] values ( '" + Session["Cname"].ToString() + "','" + Label1.Text + "','" + dt.Rows[i]["ProdID"] + "','" + dt.Rows[i]["ShopID"] + "','" + dt.Rows[i]["Size"] + "','" + dt.Rows[i]["Quantity"] + "','" + Label2.Text + "','" + TextBox1.Text + "'," + finalprice + ")", con);
                                cmd.ExecuteNonQuery();
                                con.Close();
                                //Response.Write("Inserted");
                                Session["items"] = null;

                                con.Open();
                                cmd = new SqlCommand("delete from Cart where Cust_user='" + Session["Cname"].ToString() + "' and ProdID='" + dt.Rows[i]["ProdID"] + "' and Size='" + dt.Rows[i]["Size"] + "' and ShopID='" + dt.Rows[i]["ShopID"] + "'", con);

                                cmd.ExecuteNonQuery();
                                con.Close();
                                
                                con.Open();
                                cmd = new SqlCommand("update prodtbl set ProdQuantity=ProdQuantity-" + dt.Rows[i]["Quantity"] + " where ProdID='" + dt.Rows[i]["ProdID"] + "' and Size='" + dt.Rows[i]["Size"] + "' and ShopID='" + dt.Rows[i]["ShopID"] + "'", con);
                                cmd.ExecuteNonQuery();
                                con.Close();
                                f = f + 1;
                                Button2.Visible = true;
                                Button3.Visible = true;
                                Session["fval"] = f;
                                TextBox1.Enabled = false;
                                DropDownList1.Enabled = false;
                                Button1.Visible = false;
                            }
                            catch (Exception ex)
                            {
                                Response.Write(ex.ToString());
                            }
                        }
                        
                        
                    }
                }
                else if (DropDownList1.SelectedValue.ToString()== "Credit/Debit card")
                {
                    Label3.Text = "*Sorry Credit/Debit card not enabled yet for this site.<br /> Please try Cash On Delivery Mode.";
                    Label3.Visible = true;
                }

            }
            else
            {
                Label3.Text = "Please enter your order address.";
                Label3.Visible = true;
            }
        }

        public void redirect_page() {
            Response.Redirect("MyOrders.aspx");
        }
        public override void VerifyRenderingInServerForm(Control control)
        {
            //base.VerifyRenderingInServerForm(control);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("MyOrders.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            
            if (Session["fval"] != null)
            {
                if (Convert.ToInt32(Session["fval"].ToString()) != 0)
                {

                    Button3.Visible = false;
                    add.Text = "Customer Address: " + TextBox1.Text + " <br />";
                    mode.Text = "Mode of Payment: " + DropDownList1.SelectedValue.ToString() + "<br />";
                    disc.Text = "<br />*Declaration: This invoice is inclusive of all taxes as well as all delivery charges. <br /> THIS IS A COMPUTER GENERATED INVOICE.";
                    add.Visible = true;
                    mode.Visible = true;
                    disc.Visible = true;
                    Response.ContentType = "application/pdf";
                    Response.AddHeader("content-disposition", "attachment;filename=OrderInvoice.pdf");
                    Response.Cache.SetCacheability(HttpCacheability.NoCache);
                    StringWriter sw = new StringWriter();
                    HtmlTextWriter hw = new HtmlTextWriter(sw);
                    Panel1.RenderControl(hw);
                    StringReader sr = new StringReader(sw.ToString());
                    Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 100f, 0f);
                    HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
                    PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
                    pdfDoc.Open();
                    htmlparser.Parse(sr);
                    pdfDoc.Close();
                    Response.Write(pdfDoc);

                   // f = 0;
                    //Session["fval"] = f;
                }
               
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue.ToString() == "Cash On Delivery")
            {
                Label3.Visible = false;
            }
            else if (DropDownList1.SelectedValue.ToString() == "Credit/Debit card")
            {
                Label3.Text = "*Sorry Credit/Debit card not enabled yet for this site.<br /> Please try Cash On Delivery Mode.";
                Label3.Visible = true;
            }
        }
    }
}