using BO;
using DAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace movies1_webapp
{
    public partial class Register : System.Web.UI.Page
    {
        string con = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnreg_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            a._UserName = txtusername.Text;
            a._Password = txtpassword.Text;
            a._Email = txtemail.Text;

            AdminOperations operations = new AdminOperations();
            bool res = operations.AdminInsert(con, a);
            if (res)
            {
                Response.Redirect("login.aspx");
            }
            else
            {
                Response.Output.Write("<script>alert('Not Registered ,Please give proper username,password and email')</script>");
            }
        }
    }
}