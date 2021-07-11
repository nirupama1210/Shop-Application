using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ShopProjectApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Admin_User"] != null)
            {

                if (Session["Admin_User"].ToString() == "")
                { Response.Redirect("Admintbl.aspx"); }
            }
            if (Session["Admin_User"] == null)
            {
                Response.Redirect("Admintbl.aspx");
            }
           
            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Nirupama\\Documents\\ShopDB.mdf;Integrated Security=True;Connect Timeout=30");
        }

        protected void B3_Click(object sender, EventArgs e)
        {
            int f = 0;
            try
            {
                cmd = new SqlCommand("select ShopId,ShopName,Shop_phone,Shop_address,ShopEmail from shoptbl where Approved='False'", con);
                con.Open();
                Lb2.Text = "";
                SqlDataReader d = cmd.ExecuteReader();
                while (d.Read())
                {
                    f = f + 1;
                    Lb2.Text = Lb2.Text + "<br><b>Shop ID </b>" + d[0].ToString() + "<br>";
                    Lb2.Text = Lb2.Text + "<b>Shop Name </b>" + d[1].ToString() + "<br>";
                    Lb2.Text = Lb2.Text + "<b>Contact Number </b>" + d[2].ToString() + "<br>";
                    Lb2.Text = Lb2.Text + "<b>Address </b>" + d[3].ToString() + "<br>";
                    Lb2.Text = Lb2.Text + "<b>Email </b>" + d[4].ToString() + "<br>";
                    Lb2.Text = Lb2.Text + "<br>";
                    Lb2.Visible = true;

                }
                if (f == 0)
                {

                    Lb2.Text = Lb2.Text + "No UnApproved Shops ";
                    Lb2.Visible = true;

                }
            }
            catch(Exception ex)
            {
                Response.Write(ex.ToString());
            }
         
        }

        protected void B1_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < CheckBoxList1.Items.Count; i++)
                {
                    if (CheckBoxList1.Items[i].Selected)
                    {
                        cmd = new SqlCommand("update shoptbl set Approved='True' where ShopId='" + CheckBoxList1.Items[i].Text + "'", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                   
                
                }
                
                Response.Redirect("AdminApproveShop.aspx",true);
                
            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }
        }

        protected void B2_Click(object sender, EventArgs e)
        {

            try
            {
                for (int i = 0; i < CheckBoxList1.Items.Count; i++)
                {
                    if (CheckBoxList1.Items[i].Selected)
                    {
                        cmd = new SqlCommand("delete from shoptbl where ShopId='" + CheckBoxList1.Items[i].Text + "'", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }


                }

                Response.Redirect("AdminApproveShop.aspx", true);

            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }
        }
    }
}