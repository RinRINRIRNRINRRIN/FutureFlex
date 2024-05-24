using System.Data;
using System.Data.SqlClient;

namespace FutureFlex.SQL
{
    public class tbOdoo
    {

        public static string key { get; set; }
        public static string server { get; set; }
        public static string db { get; set; }

        public static void defineServerOdoo()
        {
            try
            {
                SqlConnection con = SQL.server.con;
                string sql = "SELECT * FROM tbOdoo";

                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable tb = new DataTable();
                da.Fill(tb);

                foreach (DataRow rw in tb.Rows)
                {
                    key = rw["od_key"].ToString();
                    server = rw["od_server"].ToString();
                    db = rw["od_database"].ToString();
                }
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }

    }
}
