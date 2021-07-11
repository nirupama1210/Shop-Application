using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopProjectApplication
{
    public partial class AdminSignOut : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Admin_User"] != null)
            {

                Session["Admin_User"] = null;
                Response.Redirect("Admintbl.aspx");

            }
            else if (Session["Admin_User"] == null)
            {
                Response.Redirect("Admintbl.aspx");
            }
        }
    }
    }
