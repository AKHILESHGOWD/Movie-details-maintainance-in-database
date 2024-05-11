using BO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AdminOperations
    {
        public bool AdminInsert(string cn, Admin a1)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(cn))
            {
                string qry1 = $"select * from Admin where UserName='{a1._UserName}' or Password='{a1._Password}' or Email='{a1._Email}'";
                string qry2 = $"insert into Admin values('{a1._UserName}','{a1._Password}','{a1._Email}')";
                using (SqlCommand cmd1 = new SqlCommand(qry1, conn))
                {
                    try
                    {
                        conn.Open();
                        SqlDataReader dr = cmd1.ExecuteReader();
                        if (dr.HasRows)
                        {
                            result = false;
                        }
                        else
                        {
                            dr.Close();
                            using (SqlCommand cmd2 = new SqlCommand(qry2, conn))
                            {

                                int res = cmd2.ExecuteNonQuery();
                                if (res == 1)
                                {
                                    result = true;
                                }
                                else
                                {
                                    result = false;
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        if (conn.State == System.Data.ConnectionState.Open)
                        {
                            conn.Close();
                        }
                    }
                }
            }
            return result;
        }
        public bool Adminlogin(string cn, Admin a2)
        {
            bool res = false;
            using (SqlConnection conn = new SqlConnection(cn))
            {
                string qry = $"select * from Admin where UserName='{a2._UserName}'and Password='{a2._Password}'";
                using (SqlCommand cmd1 = new SqlCommand(qry, conn))
                {
                    try
                    {
                        conn.Open();
                        SqlDataReader dr = cmd1.ExecuteReader();
                        if (dr.HasRows)
                        {
                            res = true;
                        }
                        else
                        {
                            res = false;
                        }
                        dr.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        if (conn.State == System.Data.ConnectionState.Open)
                        {
                            conn.Close();
                        }
                    }
                }
            }
            return res;
        }
    }
}
