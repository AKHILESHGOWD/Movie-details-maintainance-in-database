using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace movies1_webapp
{
    public partial class movies1insert : System.Web.UI.Page
    {
        string cn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cn))
            {
                string qry = $"insert into movies1 values('{txtmname.Text}','{txtheroname.Text}','{txtheroinname.Text}',{Convert.ToInt64(txtbudget.Text)})";
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    try
                    {
                        con.Open();
                        int res = cmd.ExecuteNonQuery();
                        if(res==1)
                        {
                            Response.Redirect("movies1Display.aspx");
                        }
                        else
                        {
                            Response.Output.Write($"not inserted");
                        }
                    }
                    catch(SqlException ex)
                    {
                        Response.Output.Write(ex.Message);
                    }
                    finally
                    {
                        if (con.State == System.Data.ConnectionState.Open)
                        {
                            con.Close();
                        }
                    }
                }
            }
        }
    }
}