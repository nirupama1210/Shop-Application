using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopProjectApplication
{
    public partial class ShopSignOut : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ShopID"] != null)
            {

                Session["ShopID"] = null;
                Response.Redirect("ShopLogin.aspx");

            }
           else if (Session["ShopID"] == null)
            {
                Response.Redirect("ShopLogin.aspx");
            }
        }
    }
}