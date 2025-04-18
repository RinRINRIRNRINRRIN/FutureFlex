using System.Data;
using System.Data.SqlClient;

namespace FutureFlex.SQL
{
    internal class systems
    {
        static SqlConnection con = server.con;
        static SqlDataAdapter da = new SqlDataAdapter();
        static DataTable tb = new DataTable();
        static SqlCommand cmd = new SqlCommand();
        static string sql = "";

        public static string Versoin
        {
            get { return "1.3.2"; }
        }

        public static bool CheckVersion()
        {
            try
            {
                sql = "SELECT * FROM tbSystem";
                da = new SqlDataAdapter(sql, con);
                tb = new DataTable();
                da.Fill(tb);

                foreach (DataRow rw in tb.Rows)
                {
                    string ver = rw["version"].ToString();
                    // เช็คว่าตรงกันหรือไม่
                    if (Versoin != ver)
                    {
                        return false;
                    }
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

    }
}
