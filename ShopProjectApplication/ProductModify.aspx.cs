using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace ShopProjectApplication
{
    public partial class ProductModify : System.Web.UI.Page
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
            else if (Session["ShopID"] == null)
            {
                Response.Redirect("ShopLogin.aspx");
            }
            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Nirupama\\Documents\\ShopDB.mdf;Integrated Security=True;Connect Timeout=30");
            Tb1.Text = Session["ShopID"].ToString();
        }

        protected void Ddl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ddl4.Enabled = false;
            Ddl4.Visible = false;
            Lb3.Enabled = false;
            Lb3.Visible = false;
            if (Ddl1.SelectedValue == "Product Name")
            {
                Ddl2.Enabled = true;
                Ddl2.Visible = true;
                Lb1.Enabled = true;
                Lb1.Visible = true;
                Lb2.Enabled = false;
                Lb2.Visible = false;
                Ddl3.Enabled = false;
                Ddl3.Visible = false;
            }
            else if (Ddl1.SelectedValue == "Product ID")
            {
                try
                {

                    cmd = new SqlCommand("select ProdID,Size from prodtbl where ShopId='" + Session["ShopID"].ToString() + "'", con);
                    con.Open();
                    int i = 0;
                    SqlDataReader d = cmd.ExecuteReader();
                    Ddl3.Items.Clear();
                    Ddl3.Items.Insert(i, " ");
                    i = i + 1;
                    while (d.Read())
                    {
                        if (d[1].ToString() != " ")
                        { Ddl3.Items.Insert(i, d[0].ToString() + " Size: " + d[1].ToString()); }
                        else { Ddl3.Items.Insert(i, d[0].ToString()); }
                        i = i + 1;
                    }
                    Ddl3.Visible = true;
                    Ddl3.Enabled = true;
                    Lb2.Visible = true;
                    Lb2.Enabled = true;
                    Ddl2.Visible = false;
                    Ddl2.Enabled = false;
                    Lb1.Enabled = false;
                    Lb1.Visible = false;
                    con.Close();
                }
                catch (Exception ex)
                {
                    Response.Write(ex.ToString());
                }
            }
            Ddl6.Enabled = false;
            Ddl6.Visible = false;
            Lb5.Enabled = false;
            Lb5.Visible = false;
            Ddl5.Visible = false;
            Ddl5.Enabled = false;
            Lb4.Visible = false;
            Lb4.Enabled = false;
            Tb2.Visible = false;
            Tb2.Enabled = false;
            Bt1.Enabled = false;
            Bt1.Visible = false;
            Lb7.Enabled = false;
            Lb7.Visible = false;
            Lb8.Visible = false;
            Lb8.Enabled = false;
            FileUpload1.Visible = false;
            FileUpload1.Enabled = false;
        }

        protected void Ddl3_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Ddl3.Visible && Ddl3.Enabled)
            {
                Ddl4.Visible = true;
                Ddl4.Enabled = true;
                Lb3.Visible = true;
                Lb4.Enabled = true;
            }
            Ddl6.Enabled = false;
            Ddl6.Visible = false;
            Lb5.Enabled = false;
            Lb5.Visible = false;
            Ddl5.Visible = false;
            Ddl5.Enabled = false;
            Lb4.Visible = false;
            Lb4.Enabled = false;
            Tb2.Visible = false;
            Tb2.Enabled = false;
            Bt1.Enabled = false;
            Bt1.Visible = false;
            Lb7.Enabled = false;
            Lb7.Visible = false;
            Lb8.Visible = false;
            Lb8.Enabled = false;
            FileUpload1.Visible = false;
            FileUpload1.Enabled = false;

        }

        protected void Ddl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Ddl1.SelectedValue == "Product Name")
            {
                try
                {

                    cmd = new SqlCommand("select ProdID,Size from prodtbl where ProdName='" + Ddl2.SelectedValue + "' and ShopId='" + Session["ShopID"].ToString() + "'", con);
                    con.Open();
                    int i = 0;
                    SqlDataReader d = cmd.ExecuteReader();
                    Ddl3.Items.Clear();
                    Ddl3.Items.Insert(i, " ");
                    i = i + 1;
                    while (d.Read())
                    {
                        if (d[1].ToString() != " ")
                        { Ddl3.Items.Insert(i, d[0].ToString() + " Size: " + d[1].ToString()); }
                        else { Ddl3.Items.Insert(i, d[0].ToString()); }
                        i = i + 1;
                    }
                    Ddl3.Visible = true;
                    Ddl3.Enabled = true;
                    Lb2.Visible = true;
                    Lb2.Enabled = true;
                    con.Close();
                    Ddl4.Visible = false;
                    Ddl4.Enabled = false;
                    Lb3.Visible = false;
                    Lb3.Enabled = false;
                }
                catch (Exception ex)
                {
                    Response.Write(ex.ToString());
                }
            }
            Ddl6.Enabled = false;
            Ddl6.Visible = false;
            Lb5.Enabled = false;
            Lb5.Visible = false;
            Ddl5.Visible = false;
            Ddl5.Enabled = false;
            Lb4.Visible = false;
            Lb4.Enabled = false;
            Tb2.Visible = false;
            Tb2.Enabled = false;
            Ddl4.Visible = false;
            Ddl4.Enabled = false;
            Lb3.Visible = false;
            Lb3.Enabled = false;
            Bt1.Enabled = false;
            Bt1.Visible = false;
            Lb7.Enabled = false;
            Lb7.Visible = false;
            Lb6.Visible = false;
            Lb6.Enabled = false;
            Lb8.Visible = false;
            Lb8.Enabled = false;
            FileUpload1.Visible = false;
            FileUpload1.Enabled = false;
        }

        protected void Ddl4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Ddl4.SelectedValue == "Category")
            {
                Ddl5.Items.Clear();
                Lb4.Text = "Category: ";
                Lb4.Visible = true;
                Ddl5.Items.Insert(0, "Food-Item");
                Ddl5.Items.Insert(0, "Clothes");
                Ddl5.Items.Insert(0, "Shoes");
                Ddl5.Items.Insert(0, "Bags");
                Ddl5.Items.Insert(0, "Stationary");
                Ddl5.Items.Insert(0, "Paintings");
                Ddl5.Items.Insert(0, "Others");
                Ddl5.Visible = true;
                Ddl5.Enabled = true;
                Tb2.Enabled = false;
                Tb2.Visible = false;
                Bt1.Enabled = false;
                Bt1.Visible = false;
                Lb8.Visible = false;
                Lb8.Enabled = false;
                FileUpload1.Visible = false;
                FileUpload1.Enabled = false;

            }
            else if (Ddl4.SelectedValue == "Price")
            {
                Lb4.Text = "Price";
                Lb4.Visible = true;
                Lb4.Enabled = true;
                Tb2.Visible = true;
                Tb2.Enabled = true;
                Ddl5.Visible = false;
                Ddl5.Enabled = false;
                Bt1.Enabled = true;
                Bt1.Visible = true;
                Lb8.Visible = false;
                Lb8.Enabled = false;
                FileUpload1.Visible = false;
                FileUpload1.Enabled = false;
            }
            else if (Ddl4.SelectedValue == "Product Name")
            {
                Lb4.Text = "Product Name";
                Lb4.Visible = true;
                Lb4.Enabled = true;
                Tb2.Visible = true;
                Tb2.Enabled = true;
                Ddl5.Visible = false;
                Ddl5.Enabled = false;
                Bt1.Enabled = true;
                Bt1.Visible = true;
                Lb8.Visible = false;
                Lb8.Enabled = false;
                FileUpload1.Visible = false;
                FileUpload1.Enabled = false;
            }
            else if (Ddl4.SelectedValue == "Quantity")
            {
                Lb4.Text = "Quantity";
                Lb4.Visible = true;
                Lb4.Enabled = true;
                Tb2.Visible = true;
                Tb2.Enabled = true;
                Bt1.Enabled = true;
                Ddl5.Visible = false;
                Ddl5.Enabled = false;
                Bt1.Visible = true;
                Lb8.Visible = false;
                Lb8.Enabled = false;
                FileUpload1.Visible = false;
                FileUpload1.Enabled = false;
            }
            else if(Ddl4.SelectedValue=="Product Image")
            {
                FileUpload1.Visible = true;
                FileUpload1.Enabled = true;
                Bt1.Enabled = true;
                Bt1.Visible = true;
                Ddl5.Visible = false;
                Ddl5.Enabled = false;
                Tb2.Visible = false;
                Tb2.Enabled = false;
                Lb4.Enabled = false;
                Lb4.Visible = false;

            }
            Ddl6.Enabled = false;
            Ddl6.Visible = false;
            Lb5.Enabled = false;
            Lb5.Visible = false;
            Lb7.Enabled = false;
            Lb7.Visible = false;
            Lb6.Visible = false;
            Lb6.Enabled = false;
        }

        protected void Ddl5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Ddl5.SelectedValue == "Clothes")
            {
                Ddl6.Items.Clear();
                Lb5.Visible = true;
                Ddl6.Items.Insert(0, "XS");
                Ddl6.Items.Insert(1, "S");
                Ddl6.Items.Insert(2, "M");
                Ddl6.Items.Insert(3, "L");
                Ddl6.Items.Insert(4, "XL");
                Ddl6.Items.Insert(5, "XXL");
                Ddl6.Visible = true;
                Ddl6.Enabled = true;
                Bt1.Enabled = false;
                Bt1.Visible = false;
            }
            else if (Ddl5.SelectedValue == "Shoes")
            {
                Ddl6.Items.Clear();
                Lb5.Visible = true;
                Ddl6.Items.Insert(0, "1");
                Ddl6.Items.Insert(1, "2");
                Ddl6.Items.Insert(2, "3");
                Ddl6.Items.Insert(3, "4");
                Ddl6.Items.Insert(4, "5");
                Ddl6.Items.Insert(5, "6");
                Ddl6.Items.Insert(6, "7");
                Ddl6.Items.Insert(7, "8");
                Ddl6.Items.Insert(8, "9");
                Ddl6.Items.Insert(9, "10");
                Ddl6.Visible = true;
                Ddl6.Enabled = true;
                Bt1.Enabled = false;
                Bt1.Visible = false;
            }
            else if (Ddl5.SelectedValue == "Paintings")
            {
                Ddl6.Items.Clear();
                Lb5.Visible = true;
                Ddl6.Items.Insert(0, "10 X 20");
                Ddl6.Items.Insert(1, "40 X 50");
                Ddl6.Items.Insert(2, "120 X 200");
                Ddl6.Visible = true;
                Ddl6.Enabled = true;
                Bt1.Enabled = false;
                Bt1.Visible = false;
            }
            else
            {
                Ddl6.Enabled = false;
                Ddl6.Visible = false;
                Lb5.Enabled = false;
                Lb5.Visible = false;
                Bt1.Enabled = true;
                Bt1.Visible = true;
            }
            Lb7.Enabled = false;
            Lb7.Visible = false;
            Lb6.Visible = false;
            Lb6.Enabled = false;
        }

        protected void Bt1_Click(object sender, EventArgs e)
        {
            int f = 0;
            if (Ddl4.SelectedValue == "Product Image")
            {
                if (!FileUpload1.HasFile)
                {
                    f++;
                    Lb8.Visible = true;
                    Lb8.Enabled = true;
                }
            }
            if (Tb2.Enabled && Tb2.Visible)
            {

                if(Tb2.Text!="")
                {
                    if(Ddl4.SelectedValue=="Price")
                    {
                        double num;

                        if (double.TryParse(Tb2.Text, out num))
                            {
                                if (num < 0)
                                {
                                    Lb7.Visible = true;
                                    Lb7.Enabled = true;
                                Lb7.Text = "Enter Price>0";
                                    Tb2.Text = "";
                                f++;
                                }
                                else
                                {
                                    Lb7.Visible = false;
                                Lb7.Enabled = false;
                                f = 0;
                                }
                            }
                            else
                            {
                                Lb7.Text = "Enter number";
                                Lb7.Visible = true;
                            Lb7.Enabled = true;
                            f++;
                            }
                     
                    }
                    else if(Ddl4.SelectedValue=="Quantity")
                    {
                        int num;
                        if (int.TryParse(Tb2.Text, out num))
                        {
                            if (num < 0)
                            {
                                Lb7.Visible = true;
                                Lb7.Enabled = true;
                                Lb7.Text = "Enter Quantity>0";
                                Tb2.Text = "";
                                f++;
                            }
                            else
                            {
                                Lb7.Visible = false;
                                Lb7.Enabled = false;
                                f = 0;
                            }
                        }
                        else
                        {
                            Lb7.Text = "Enter number";
                            Lb7.Visible = true;
                            Lb7.Enabled = true;
                            f++;
                        }
                    }
                    
                String st1 = "";
                String newval = "";
                String pid = Ddl3.SelectedValue.Split(' ')[0];
                    String oldsize = " ";
                    if ((Ddl3.SelectedValue.Split(' ').Length) > 1)
                    { oldsize = Ddl3.SelectedValue.Split(' ')[2]; }

                if (Ddl4.SelectedValue == "Product Name")
                {
                    st1 = "ProdName";
                    newval = Tb2.Text;
                }
                else if (Ddl4.SelectedValue == "Price")
                {
                    st1 = "Price";
                    newval = Tb2.Text;
                }
                else if (Ddl4.SelectedValue == "Quantity")
                {
                    st1 = "ProdQuantity";
                    newval = Tb2.Text;

                }
                    if (f == 0)
                    {
                        try
                        {
                            if (Ddl4.SelectedValue == "Price" || Ddl4.SelectedValue == "Quantity")
                            {
                                cmd = new SqlCommand("update prodtbl set " + st1 + "=" + newval + " where ShopID='" + Session["ShopID"].ToString() + "' and ProdID='" + pid + "' and Size='" + oldsize + "'", con);
                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();
                                Lb6.Text=("Updated details");
                                Lb6.Visible = true;
                                Lb6.Enabled = true;
                            }

                            else if (Ddl4.SelectedValue == "Product Name")
                            {
                                cmd = new SqlCommand("update prodtbl set " + st1 + "='" + newval + "' where ShopID='" + Session["ShopID"].ToString() + "' and ProdID='" + pid + "' and Size='" + oldsize + "'", con);
                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();
                               Lb6.Text=("Updated details");
                                Lb6.Visible = true;
                                Lb6.Enabled = true;
                            }
                            
                        }
                        catch (Exception ex)
                        {
                            Response.Write(ex);
                        }
                    }
            }
                else
                {
                    Lb7.Text = "Enter " + Ddl4.SelectedValue;
                    Lb7.Enabled = true;
                    Lb7.Visible = true;
                    
                }
        }
            else
            {
                String size = " ";
                String st1 = "";
                String newval = "";
                String pid = Ddl3.SelectedValue.Split(' ')[0];
                String oldsize = " ";
                if ((Ddl3.SelectedValue.Split(' ').Length) > 1)
                { oldsize = Ddl3.SelectedValue.Split(' ')[2]; }
                Lb7.Enabled = false;
                Lb7.Visible = false;
                if (Ddl4.SelectedValue == "Category")
                {
                    st1 = "Category";
                    newval = Ddl5.SelectedValue;
                    if (Ddl6.Enabled)
                    {
                        size = Ddl6.SelectedValue;
                    }
                }
                try
                {
                    if (Ddl4.SelectedValue == "Category")
                    {


                        cmd = new SqlCommand("update prodtbl set " + st1 + "='" + newval + "', size='" + size + "' where ShopID='" + Session["ShopID"].ToString() + "' and ProdID='" + pid + "' and Size='" + oldsize + "'", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        Lb6.Text=("Updated details");
                        Lb6.Visible = true;
                        Lb6.Enabled = true;


                    }
                    else if (Ddl4.SelectedValue == "Product Image")
                    {
                        if (FileUpload1.HasFile)
                        {
                            byte[] imgarray;
                            int imagefilelenth = FileUpload1.PostedFile.ContentLength;
                            imgarray = new byte[imagefilelenth];
                            HttpPostedFile image = FileUpload1.PostedFile;
                            image.InputStream.Read(imgarray, 0, imagefilelenth);

                            cmd = new SqlCommand("update prodtbl set ProdImage=@Image where ShopID='" + Session["ShopID"].ToString() + "' and ProdID='" + pid + "'", con);
                            cmd.Parameters.AddWithValue("@Image", System.Data.SqlDbType.Image).Value = imgarray;
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            Lb8.Visible = true;
                            Lb8.Enabled = true;
                            if (oldsize == " ")
                            { Lb8.Text = "Image Is Modified successfully "; }
                            else
                            {
                                Lb8.Text = "Image Is Modified Successfully for all sizes. ";
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    Response.Write(ex.ToString());
                }
                
            }
        }

        protected void Ddl6_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bt1.Enabled = true;
            Bt1.Visible = true;
            Lb7.Enabled = false;
            Lb7.Visible = false;
            Lb6.Visible = false;
            Lb6.Enabled = false;

        }
    }
}