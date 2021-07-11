using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopProjectApplication
{
    public partial class AdminDisplayShop : System.Web.UI.Page
    {
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
        }
    }
}