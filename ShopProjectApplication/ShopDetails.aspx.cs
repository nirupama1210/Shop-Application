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
    public partial class ShopDetails : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Nirupama\\Documents\\ShopDB.mdf;Integrated Security=True;Connect Timeout=30");
                DataTable dt = new DataTable();
                dt.Columns.Add("ShopId");
                dt.Columns.Add("ShopName");
                dt.Columns.Add("Shop_phone");
                dt.Columns.Add("Shop_address");
                dt.Columns.Add("ShopEmail");

                String sname = "";
                String email = "";
                String phone = "";
                String add = "";
                String sid = "";
                try
                {
                    con.Open();
                    cmd = new SqlCommand("select ShopId,ShopName,Shop_phone,Shop_address,ShopEmail from shoptbl where Approved='True'", con);
                    SqlDataReader d = cmd.ExecuteReader();
                    SqlDataAdapter da = new SqlDataAdapter();

                    while (d.Read())
                    {

                        sid = d[0].ToString();
                        sname = d[1].ToString();
                        phone = d[2].ToString();
                        add = d[3].ToString();
                        email = d[4].ToString();

                        dt.Rows.Add(sid, sname, phone, add, email);
                    }
                    con.Close();
                }
                catch(Exception ex)
                { Response.Write(ex.ToString()); }
                

                GridView1.DataSource = dt;

                GridView1.DataBind();
            }
        }
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            if (e.CommandName == "View")
            {

                int RowIndex = Convert.ToInt32((e.CommandArgument).ToString());
                Button btn = (Button)GridView1.Rows[RowIndex].FindControl("btn");
                
                String sid = GridView1.Rows[RowIndex].Cells[0].Text;
                Response.Redirect("HomePage.aspx?sid="+sid);


            }
            
        }
    }
}