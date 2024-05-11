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
    public partial class movies1Display : System.Web.UI.Page
    {
        string con = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(con))
            {
                string qry = $"select * from movies1";
                using (SqlCommand cmd = new SqlCommand(qry, cn))
                {
                    try
                    {
                        cn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        List<movies1> lst = new List<movies1>();
                        while (dr.Read())
                        {
                            movies1 m1 = new movies1();
                            m1._Id = Convert.ToInt32(dr["id"]);
                            m1._MovieName = dr["mname"].ToString();
                            m1._HeroName = dr["heroname"].ToString();
                            m1._HeroineName = dr["heroinname"].ToString();
                            m1._Budget = (long)dr["budget"];
                            lst.Add(m1);
                        }
                        dr.Close();
                        gridview.DataSource = lst;
                        gridview.DataBind();

                    }
                    catch (Exception ex)
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
    }
           
    

    public class movies1
    {
        public int _Id { get; set; }
        public string _MovieName { get; set; }
        public string _HeroName { get; set; }
        public string _HeroineName { get; set; }
        public long _Budget { get; set; }

    }
}