using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace movies1_webapp
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lnklagout_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        protected void lnksmd_Click(object sender, EventArgs e)
        {
            Response.Redirect("movies1insert.aspx");
        }

        protected void lnkedit_Click(object sender, EventArgs e)
        {
            Response.Redirect("movies1update.aspx");
        }

        protected void lnkdisply_Click(object sender, EventArgs e)
        {
            Response.Redirect("movies1Display.aspx");
        }

        protected void lnkdelete_Click(object sender, EventArgs e)
        {
            Response.Redirect("movies1delete.aspx");
        }
    }
}