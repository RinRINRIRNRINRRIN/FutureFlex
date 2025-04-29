using FutureFlex.Models;
using Serilog;
using System.Data;
using System.Data.SqlClient;

namespace FutureFlex.SQL
{
    public class tbOdoo
    {

        /// <summary>
        /// ดึงข้อมูลจากฐาน เพื่อเรียกใช้ odoo
        /// </summary>
        public static void defineServerOdoo()
        {
            try
            {
                Log.Information($"==== GET CONFIG ODOO API");
                SqlConnection con = SQL.server.con;
                string sql = $"SELECT * FROM tbOdoo WHERE od_status = '{OdooModel.Status}'";

                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable tb = new DataTable();
                da.Fill(tb);

                foreach (DataRow rw in tb.Rows)
                {
                    OdooModel.Key = rw["od_key"].ToString();
                    OdooModel.Server = rw["od_server"].ToString();
                    OdooModel.Database = rw["od_database"].ToString();
                    Log.Information($"-- key : {OdooModel.Key}");
                    Log.Information($"-- server : {OdooModel.Server}");
                    Log.Information($"-- db : {OdooModel.Database}");
                    break;
                }
            }
            catch (System.Exception ex)
            {
                Log.Error($"tbOdoo | defineServerOdoo {ex.Message}");
            }
        }

    }
}
