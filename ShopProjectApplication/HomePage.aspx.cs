using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ShopProjectApplication
{
    public partial class HomePage : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["addproduct"] = "false";
            if (!IsPostBack)
            {
                try
                {
                    con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Nirupama\\Documents\\ShopDB.mdf;Integrated Security=True;Connect Timeout=30");
                    cmd = new SqlCommand("select ProdID,p.ShopID,ProdName,Category,Price,ProdImage,ShopName,size from prodtbl p,shoptbl s where p.ShopID=s.ShopId", con);
                    if (Request.QueryString["sid".ToString()] != null)
                    { cmd = new SqlCommand("select ProdID,p.ShopID,ProdName,Category,Price,ProdImage,ShopName,size from prodtbl p,shoptbl s where p.ShopID=s.ShopId and s.ShopId='" + Request.QueryString["sid".ToString()] + "'", con); }

                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    System.Data.DataTable dt = new System.Data.DataTable();
                    sda.Fill(dt);
                    DataList1.DataSource = dt;
                    DataList1.DataBind();
                    if (dt.Rows.Count == 0)
                    {
                        Response.Write("No products found");
                    }
                    con.Close();


                }
                catch (Exception ex) { Response.Write(ex.ToString()); }
            }
        }


        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if(e.CommandName=="viewdetails")
            {
                String[] cmdargs = e.CommandArgument.ToString().Split(new char[] { ','});
                Response.Redirect("ViewDetails.aspx?shopid="+cmdargs[1]+"&prodid="+cmdargs[0]);
            }
            else if (e.CommandName == "addtocart")
            {
                Session["addproduct"] = "true";
                int q = 0;
                String[] cmdargs = e.CommandArgument.ToString().Split(new char[] { ',' });
                con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Nirupama\\Documents\\ShopDB.mdf;Integrated Security=True;Connect Timeout=30");
                cmd = new SqlCommand("select ProdQuantity from prodtbl where ProdID='"+cmdargs[0]+"' and ShopID='"+cmdargs[1]+"' and size='"+cmdargs[2]+"'", con);
                con.Open();
                SqlDataReader d = cmd.ExecuteReader();
                while(d.Read())
                {
                    q = Convert.ToInt32(d[0].ToString());
                }
                if (q > 0)
                { Response.Redirect("AddCart.aspx?shopid=" + cmdargs[1] + "&prodid=" + cmdargs[0] + "&size=" + cmdargs[2]); }
                else { Response.Write("<script>alert('Product OUT OF STOCK');</script>"); }
            }
        }

        protected void Image1(object sender, DataListItemEventArgs e)
        {

        }
        protected string ToBase64(object data)
        {
            if (data != System.DBNull.Value)
            {
                byte[] bytes = (byte[])data;
                string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);
                return "data:image/jpg;base64," + base64String;
            }
            return "no-image.jpg";


        }

        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
        void checkBoxFind()
        {
            String food = "", bag = "", shoe = "", cloth = "", paint = "", other = "";
            if (CheckBox1.Checked)
            {
                food = CheckBox1.Text;
            }
            if (CheckBox2.Checked)
            {
                bag = CheckBox2.Text;
            }
            if (CheckBox3.Checked)
            {
                shoe = CheckBox3.Text;
            }
            if (CheckBox4.Checked)
            {
                cloth = CheckBox4.Text;
            }
            if (CheckBox5.Checked)
            {
                paint = CheckBox5.Text;
            }
            if (CheckBox6.Checked)
            {
                other = CheckBox6.Text;
            }
            try
            {
                con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Nirupama\\Documents\\ShopDB.mdf;Integrated Security=True;Connect Timeout=30");
                cmd = new SqlCommand("select ProdID,p.ShopID,ProdName,Category,Price,ProdImage,ShopName,size from prodtbl p,shoptbl s where p.ShopID=s.ShopId and p.Category IN ('"+food+"','"+bag+"','"+shoe+"','"+cloth+"','"+paint+"','"+other+"')", con);
                if (Request.QueryString["sid".ToString()] != null)
                { cmd = new SqlCommand("select ProdID,p.ShopID,ProdName,Category,Price,ProdImage,ShopName,size from prodtbl p,shoptbl s where p.ShopID=s.ShopId and s.ShopId='" + Request.QueryString["sid".ToString()] + "' and p.Category IN ('" + food + "','" + bag + "','" + shoe + "','" + cloth + "','" + paint + "','" + other + "')", con); }

                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                System.Data.DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);
                DataList1.DataSource = dt;
                DataList1.DataBind();
                if (dt.Rows.Count == 0)
                {
                    Response.Write("No products found");
                }
                con.Close();


            }
            catch (Exception ex) { Response.Write(ex.ToString()); }
        }
        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxFind();
        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxFind();
        }

        protected void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxFind();
        }

        protected void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxFind();
        }

        protected void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxFind();
        }

        protected void CheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxFind();
        }
    }
}