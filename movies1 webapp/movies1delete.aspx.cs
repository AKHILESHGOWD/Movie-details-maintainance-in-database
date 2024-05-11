using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace movies1_webapp
{
    public partial class movies1delete : System.Web.UI.Page
    {
        string con = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(con))
            {
                string qry = $"select * from movies1 where id = {Convert.ToInt32(txtid.Text)}";
                using (SqlCommand cmd = new SqlCommand(qry, cn))
                {
                    try
                    {
                        cn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            txtmname.Text = dr["mname"].ToString();
                            txtheroname.Text = dr["heroname"].ToString();
                            txtheroinename.Text = dr["heroinname"].ToString();
                            txtbudget.Text = dr["budget"].ToString();
                        }
                        dr.Close();
                    }
                    catch (SqlException ex)
                    {
                        Response.Output.Write(ex.Message);
                    }
                    finally
                    {
                        if (cn.State == System.Data.ConnectionState.Open)
                            cn.Close();
                    }
                }
            }
        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            using(SqlConnection cn = new SqlConnection(con))
            {
                string qry = $"delete movies1 where mname='{txtmname.Text}'";
                using(SqlCommand cmd = new SqlCommand(qry,cn))
                {
                    try
                    {
                        cn.Open();
                        int res = cmd.ExecuteNonQuery();
                        if (res == 1)
                        {
                            Response.Output.Write("deleted succesfully");
                        }
                        else
                        {
                            Response.Redirect("movies1Display.aspx");
                        }
                    }
                    catch(SqlException ex)
                    {
                        Response.Output.Write(ex.Message);
                    }
                    finally
                    {
                        if(cn.State==System.Data.ConnectionState.Open)
                        {
                            cn.Close();
                        }
                    }
                }
            }

        }
    }
}