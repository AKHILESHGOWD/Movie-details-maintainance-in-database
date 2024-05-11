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
    public partial class login : System.Web.UI.Page
    {
        string con = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            Admin a1 = new Admin();
            a1._UserName = txtusername.Text;
            a1._Password = txtpassword.Text;

            AdminOperations operations = new AdminOperations();
            bool res = operations.Adminlogin(con, a1);
            if (res)
            {
                Response.Redirect("home.aspx");
            }
            else
            {
                Response.Output.Write("username and password is incorrect");
            }
        }

        protected void lnkreg_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}