using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace ShopProjectApplication
{
    public partial class ShopProduct : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Nirupama\\Documents\\ShopDB.mdf;Integrated Security=True;Connect Timeout=30");
            if (Session["ShopID"]!=null)
            {
            
                if(Session["ShopID"].ToString() == "")
               { Response.Redirect("ShopLogin.aspx"); }
           }
           if(Session["ShopID"]==null)
            {
                Response.Redirect("ShopLogin.aspx");
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string pid = GridView1.SelectedRow.Cells[1].Text;
            string sid = Session["ShopID"].ToString();
            string size = GridView1.SelectedRow.Cells[4].Text; 
            string pname = "";
            string category = "";
            string quantity = "";
            string price = "";
            //string img = "";
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[6] { new DataColumn("Product Id", typeof(string)),
                    new DataColumn("Product Name", typeof(string)),
                    new DataColumn("Category",typeof(string)),
            new DataColumn("Price",typeof(string)),
            new DataColumn("Quantity",typeof(string)),
              new DataColumn("Size",typeof(string)),
            });
            string base64String="";

            try
            {
                cmd = new SqlCommand("select ProdName,Category,Price,ProdQuantity,ProdImage from prodtbl where ShopID='" + sid + "' and ProdID='" + pid + "' and Size='" + size + "'", con);
                con.Open();
                SqlDataReader d=cmd.ExecuteReader();
                while(d.Read())
                {
                    pname = d[0].ToString();
                    category = d[1].ToString();
                    price = d[2].ToString();
                    quantity = d[3].ToString();
                    // Response.Write(d[4].ToString());
                    if (d[4] !=System.DBNull.Value)
                    {
                        byte[] bytes = (byte[])d[4];

                        base64String = Convert.ToBase64String(bytes);
                    }
                    //img.Src = 
                    //img = "data:image/jpg;base64," + Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(d[4].ToString()));
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
                dt.Rows.Add(pid, pname, category,price,quantity,size);
                con.Close();
               DetailsView1.DataSource = dt;
                DetailsView1.DataBind();
               
            }
            catch(Exception ex)
            {
                Response.Write(ex.ToString());
            }
            


        }
    }
}