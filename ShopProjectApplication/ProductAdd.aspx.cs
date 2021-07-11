using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ShopProjectApplication
{
    
    public partial class ProductAdd : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd,cmd1;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ShopID"] != null)
            {

                if (Session["ShopID"].ToString() == "")
                { Response.Redirect("ShopLogin.aspx"); }
            }
            if (Session["ShopID"] == null)
            {
                Response.Redirect("ShopLogin.aspx");
            }
            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Nirupama\\Documents\\ShopDB.mdf;Integrated Security=True;Connect Timeout=30");
            Tb1.Text = Session["ShopID"].ToString();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(dd1.SelectedValue=="Clothes")
            {
                dd2.Items.Clear();
                Lb1.Visible = true;
                dd2.Items.Insert(0,"XS");
                dd2.Items.Insert(1, "S");
                dd2.Items.Insert(2, "M");
                dd2.Items.Insert(3, "L");
                dd2.Items.Insert(4, "XL");
                dd2.Items.Insert(5, "XXL");
                dd2.Visible = true;
                dd2.Enabled = true;
            }
            else if (dd1.SelectedValue == "Shoes")
            {
                dd2.Items.Clear();
                Lb1.Visible = true;
                dd2.Items.Insert(0, "1");
                dd2.Items.Insert(1, "2");
                dd2.Items.Insert(2, "3");
                dd2.Items.Insert(3, "4");
                dd2.Items.Insert(4, "5");
                dd2.Items.Insert(5, "6");
                dd2.Items.Insert(6, "7");
                dd2.Items.Insert(7, "8");
                dd2.Items.Insert(8, "9");
                dd2.Items.Insert(9, "10");
                dd2.Visible = true;
                dd2.Enabled = true;
            }
            else if (dd1.SelectedValue == "Paintings")
            {
                dd2.Items.Clear();
                Lb1.Visible = true;
                dd2.Items.Insert(0, "10 X 20");
                dd2.Items.Insert(1, "40 X 50");
                dd2.Items.Insert(2, "120 X 200");
                dd2.Visible = true;
                dd2.Enabled = true;
            }
            else
            {
                Lb1.Visible = false;
                dd2.Visible = false;
                dd2.Enabled = false;
            }
            Lb6.Visible = false;
            Lb5.Visible = false;
            Lb7.Visible = false;
            Lb7.Enabled = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            int quan_flag = 0;
            int prod = 0, name = 0;
            int price_flag = 0;
            if(Tb4.Text=="")
            {
                Lb2.Text = "Enter Price";
                Lb2.Visible = true;
                price_flag++;
            }
            else
            {
                double num;

                if (Tb4.Text != "")
                {
                    if (double.TryParse(Tb4.Text, out num))
                    {
                        if (num < 0)
                        {
                            Lb2.Visible = true;
                            Tb4.Text = "";
                            price_flag++;
                        }
                        else
                        {
                            Lb2.Visible = false;
                            price_flag = 0;
                        }
                    }
                    else
                    {
                        Lb2.Text = "Enter number";
                        Lb2.Visible = true;
                        price_flag++;
                    }
                }
            }
            if(Tb4.Text=="")
            {
                Lb3.Text = "Enter Quantity";
                Lb3.Visible = true;
                quan_flag++;
            }
            else
            {
                int num;

                if (Tb5.Text != "")
                {
                    if (int.TryParse(Tb5.Text, out num))
                    {
                        if (num < 0)
                        {
                            Lb3.Visible = true;
                            Tb5.Text = "";
                            quan_flag++;
                        }
                        else
                        {
                            Lb3.Visible = false;
                            quan_flag = 0;
                        }
                    }
                    else
                    {
                        Lb3.Text = "Enter number";
                        Lb3.Visible = true;
                        quan_flag++;
                    }
                }
            }
            if(Tb2.Text=="")
            {
                Lb5.Visible = true;
                prod++;
            }
            if(Tb3.Text=="")
            {
                Lb6.Visible = true;
                name++;
            }
            if (quan_flag == 0 && price_flag == 0 && name == 0 && prod == 0)
            {
                int x = 0;
                Lb4.Visible = false;
                int f = 0;
                int f1 = 0;
                int qnt; float price; String usrname, pid, pname, cat, size = "";
                usrname = Session["ShopID"].ToString();
                pid = Tb2.Text;
                pname = Tb3.Text;
                String prodName = "";
                cat = dd1.SelectedValue;
                String cat2 = "";
               String img="";
                System.Byte[] img1 = new Byte[1000];
                int x2 = 0;
                if (dd2.Visible && dd2.Enabled)
                {
                    size = dd2.SelectedValue;
                }
                qnt = Convert.ToInt32(Tb5.Text);
                price = float.Parse(Tb4.Text);
                byte[] bytes=null;
                string base64String = "";
                cmd1 = new SqlCommand("select Category,ProdName,ProdImage from prodtbl where ShopId='" + usrname + "' and ProdID='" + pid + "'", con);
                    try
                    {
                        con.Open();
                        SqlDataReader d = cmd1.ExecuteReader();
                        while (d.Read())
                        {
                            if (d[0].ToString() == "Others" || d[0].ToString() == "Stationary" || d[0].ToString() == "Food-Item")
                            {
                                f = f + 1;
                            prodName = d[1].ToString();
                            if (d[2] != System.DBNull.Value)
                            {
                                bytes = (byte[])d[2];

                                base64String = Convert.ToBase64String(bytes);
                            }
                            break;
                            }
                            else
                            {
                            prodName = d[1].ToString();
                            cat2 = d[0].ToString();
                            if (d[2] != System.DBNull.Value)
                            {
                                bytes = (byte[])d[2];

                                base64String = Convert.ToBase64String(bytes);
                            }
                            f1 = f1 + 1; break;
                            }
                        
                        }
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        Response.Write(ex.ToString());
                    }
                
                if(f!=0)
                {
                    Lb4.Text = "This exact product already exists. Please add some other product with different product ID";
                    Lb4.Visible = true;
                    Lb7.Visible = false;
                    Lb7.Enabled = false;
                }
                if(f1!=0)
                {
                    if (cat2 != dd1.SelectedValue)
                    {

                        Lb4.Text = "This Product must  be of Category "+cat2;
                        Lb4.Visible = true;
                        Lb7.Visible = false;
                        Lb7.Enabled = false;
                    }
                    else
                    {
                        cmd1 = new SqlCommand("select Size from prodtbl where ShopId='" + usrname + "' and ProdID='" + pid + "' and Size='"+dd2.SelectedValue+"'", con);
                        try
                        {
                            con.Open();
                            SqlDataReader d = cmd1.ExecuteReader();
                            while (d.Read())
                            {
                                x2 = x2 + 1;
                            }
                            con.Close();
                        }
                        catch (Exception ex)
                        {
                            Response.Write(ex.ToString());
                        }
                    }
                }
                
                if(Tb3.Text!=prodName && prodName!="")
                {
                    Lb4.Text = "This product already exists with Name " + prodName + ". Try changing Product ID or set Product Name as " + prodName;
                    Lb4.Visible = true;
                    Lb7.Visible = false;
                    Lb7.Enabled = false;
                }
                else if(x2!=0)
                {
                    Lb4.Text = " This exact product already exists in this size . Please try adding product in other size or other product ID";
                    Lb4.Visible = true;
                    Lb7.Visible = false;
                    Lb7.Enabled = false;
                }
                    if ((f == 0)&&(f1==0||(x2==0 && cat2==dd1.SelectedValue)) && (prodName==Tb3.Text || prodName=="")) 
                    {
                
                        if (dd2.Visible && dd2.Enabled)
                        {

                        if (FileUpload1.HasFile)
                        {
                            byte[] imgarray;
                            int imagefilelenth = FileUpload1.PostedFile.ContentLength;
                            imgarray = new byte[imagefilelenth];
                            HttpPostedFile image = FileUpload1.PostedFile;
                            image.InputStream.Read(imgarray, 0, imagefilelenth);
                            if (base64String == "")
                            {
                                cmd = new SqlCommand("insert into prodtbl values('" + usrname + "','" + pid + "','" + pname + "','" + cat + "'," + price + ",'" + size + "'," + qnt + ",@Image)", con);
                                cmd.Parameters.AddWithValue("@Image", System.Data.SqlDbType.Image).Value = imgarray;
                            }
                            else
                            {
                                cmd = new SqlCommand("insert into prodtbl values('" + usrname + "','" + pid + "','" + pname + "','" + cat + "'," + price + ",'" + size + "'," + qnt + ",@Image)", con);
                                cmd.Parameters.AddWithValue("@Image", System.Data.SqlDbType.Image).Value = bytes;
                            }
                            Lb8.Visible = true;
                            Lb8.Enabled = true;
                            Lb8.Text = "Image Is Uploaded successfully";
                            x = 1;

                        }
                        else
                        {
                            if (base64String == "")
                            {
                                cmd = new SqlCommand("insert into prodtbl values('" + usrname + "','" + pid + "','" + pname + "','" + cat + "'," + price + ",'" + size + "'," + qnt + ",NULL)", con);
                                x = 1;
                                Lb8.Visible = true;
                                Lb8.Enabled = true;
                                Lb8.Text = "Image Not uploaded";
                            }
                            else
                            {
                                cmd = new SqlCommand("insert into prodtbl values('" + usrname + "','" + pid + "','" + pname + "','" + cat + "'," + price + ",'" + size + "'," + qnt + ",@Image)", con);
                                cmd.Parameters.AddWithValue("@Image", System.Data.SqlDbType.Image).Value = bytes;
                            }

                        }
                        if (base64String != "")
                        {
                            Lb8.Visible = true;
                            Lb8.Enabled = true;
                            Lb8.Text = "This Product Already has an Image. Please go to Modify Details to change it. ";
                        }
                    }
                        else
                        {
                        if (FileUpload1.HasFile)
                        {
                            byte[] imgarray;
                                int imagefilelenth = FileUpload1.PostedFile.ContentLength;
                                imgarray = new byte[imagefilelenth];
                                HttpPostedFile image = FileUpload1.PostedFile;
                                image.InputStream.Read(imgarray, 0, imagefilelenth);

                            if (base64String == "")
                            {
                                cmd = new SqlCommand("insert into prodtbl values('" + usrname + "','" + pid + "','" + pname + "','" + cat + "'," + price + ",' '," + qnt + ",@Image)", con);
                                cmd.Parameters.AddWithValue("@Image", System.Data.SqlDbType.Image).Value = imgarray;
                            }
                            else
                            {
                                cmd = new SqlCommand("insert into prodtbl values('" + usrname + "','" + pid + "','" + pname + "','" + cat + "'," + price + ",' '," + qnt + ",@Image)", con);
                                cmd.Parameters.AddWithValue("@Image", System.Data.SqlDbType.Image).Value = bytes;
                            }
                            Lb8.Visible = true;
                            Lb8.Enabled = true;
                            Lb8.Text = "Image Is Uploaded successfully";
                        }
                        
                        else
                        {
                            if (base64String == "")
                            {
                                cmd = new SqlCommand("insert into prodtbl values('" + usrname + "','" + pid + "','" + pname + "','" + cat + "'," + price + ",' '," + qnt + ",NULL)", con);
                                Lb8.Visible = true;
                                Lb8.Enabled = true;
                                Lb8.Text = "Image Not uploaded";
                            }
                            else
                            {
                                cmd = new SqlCommand("insert into prodtbl values('" + usrname + "','" + pid + "','" + pname + "','" + cat + "'," + price + ",' '," + qnt + ",@Image)", con);
                                cmd.Parameters.AddWithValue("@Image", System.Data.SqlDbType.Image).Value = bytes;
                            }
                        }
                        if (base64String != "")
                        {
                            Lb8.Visible = true;
                            Lb8.Enabled = true;
                            Lb8.Text = "This Product Already has an Image. Please go to Modify Details to change it. ";
                        }
                        }
                        try
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            Lb7.Text=("Product Uploaded successfully! ");
                            Lb7.Visible = true;
                            Lb7.Enabled = true;
                            Button2.Visible = true;
                            Button2.Enabled = true;
                            if (x == 1)
                            {
                                Button3.Visible = true;
                                Button3.Enabled = true;
                            }

                        }
                        catch (Exception ex)
                        {
                            Response.Write(ex.ToString());
                        }
                    }
                    
                    Lb6.Visible = false;
                    Lb5.Visible = false;
                }
           
        }

        protected void Tb4_TextChanged(object sender, EventArgs e)
        {
            
            double num;
            
            if (Tb4.Text != "")
            {
                if (double.TryParse(Tb4.Text, out num))
                {
                    if (num < 0)
                    {
                        Lb2.Visible = true;
                        Tb4.Text = "";
                    }
                    else
                    {
                        Lb2.Visible = false;
                    }
                }
                else
                {
                    Lb2.Text = "Enter number";
                    Lb2.Visible = true;
                }
            }
            Lb7.Visible = false;
            Lb7.Enabled = false;

        }

        protected void Tb5_TextChanged(object sender, EventArgs e)
        {
            int num;

            if (Tb5.Text != "")
            {
                if (int.TryParse(Tb5.Text, out num))
                {
                    if (num < 0)
                    {
                        Lb3.Visible = true;
                        Tb5.Text = "";
                    }
                    else
                    {
                        Lb3.Visible = false;
                    }
                }
                else
                {
                    Lb3.Text = "Enter number";
                    Lb3.Visible = true;
                }
            }
            Lb7.Visible = false;
            Lb7.Enabled = false;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
           
            Tb4.Text="";
            Tb5.Text = "";
            Lb6.Visible = false;
            Lb5.Visible = false;
            Lb7.Visible = false;
            Lb7.Enabled = false;
            FileUpload1.Enabled = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            Tb2.Text = "";
            Tb3.Text = "";
            dd1.SelectedIndex = 0; ;
            Tb4.Text = "";
            Tb5.Text = "";
            dd2.Enabled = false;
            dd2.Visible = false;
            dd2.Visible = false;
            Lb1.Visible = false;
            Lb2.Visible = false;
            Lb3.Visible = false;
            Button3.Visible = false;
            Button3.Enabled = false;
            Lb6.Visible = false;
            Lb5.Visible = false;
            Lb7.Visible = false;
            Lb7.Enabled = false;
            Lb8.Visible = false;
            Lb8.Enabled = false;
        }

    }
}