using FutureFlex.Models;
﻿using Serilog;
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
                string sql = "SELECT * FROM tbOdoo";

                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable tb = new DataTable();
                da.Fill(tb);

                foreach (DataRow rw in tb.Rows)
                {
                    key = rw["od_key"].ToString();
                    server = rw["od_server"].ToString();
                    db = rw["od_database"].ToString();
                    Log.Information($"-- key : {key}");
                    Log.Information($"-- server : {server}");
                    Log.Information($"-- db : {db}");
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
