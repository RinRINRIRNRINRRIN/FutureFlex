using FutureFlex.API;
using Serilog;
using System;
using System.Data;
using System.Data.SqlClient;

namespace FutureFlex.SQL
{
    public class tbWeight
    {

        static SqlConnection con = server.con;
        static SqlDataAdapter da = new SqlDataAdapter();
        static DataTable tb = new DataTable();
        static SqlCommand cmd = new SqlCommand();
        static string sql = "";
        static string tbName = "tbWeight";

        public static string ERR { get; set; }


        #region SELECT
        public static DataTable SELECT_ALL_DATA()
        {
            try
            {
                sql = $"SELECT * FROM {tbName} ORDER BY wgh_id DESC";
                da = new SqlDataAdapter(sql, con);
                tb = new DataTable();
                da.Fill(tb);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
                return tb;
            }
            return tb;
        }

        /// <summary>
        /// สำหรับค้นหาข้อมูล  GV  นั้น ๆ 
        /// </summary>
        /// <param name="po"></param>
        /// <returns></returns>
        public static DataTable SELECT_SEARCH()
        {
            try
            {
                sql = $"SELECT * FROM {tbName} WHERE  wgh_GV = '{MRP.name}'";
                da = new SqlDataAdapter(sql, con);
                tb = new DataTable();
                da.Fill(tb);
            }
            catch (Exception ex)
            {
                Console.WriteLine("SELECT_SEARCH " + ex.Message);
                return tb;
            }
            return tb;
        }


        public static DataTable SELECT_SUCCESS()
        {
            try
            {
                sql = $"SELECT * FROM {tbName} WHERE wgh_statusOdoo = 1";
                da = new SqlDataAdapter(sql, con);
                tb = new DataTable();
                da.Fill(tb);

                if (tb.Rows.Count == 0)
                {
                    return tb;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return tb;
            }
            return tb;
        }

        /// <summary>
        /// สำหรับแสดงข้อมูลการชั่งที่ยังไม่ส่งไปหา Odoo
        /// </summary>
        /// <returns></returns>
        public static DataTable SELECT_NOT_SUCCESS()
        {
            try
            {
                sql = $"SELECT * FROM {tbName} WHERE wgh_statusOdoo = 0";
                da = new SqlDataAdapter(sql, con);
                tb = new DataTable();
                da.Fill(tb);

                if (tb.Rows.Count == 0)
                {
                    return tb;
                }
            }
            catch (Exception ex)
            {
                ERR = ex.Message;
                return tb;
            }
            return tb;
        }

        public static DataTable SELECT_SELECT_GV(string gvname)
        {
            try
            {
                sql = $"SELECT * FROM {tbName} WHERE  wgh_GV = '{gvname}'";
                da = new SqlDataAdapter(sql, con);
                tb = new DataTable();
                da.Fill(tb);
            }
            catch (Exception ex)
            {
                Console.WriteLine("SELECT_SEARCH " + ex.Message);
                return tb;
            }
            return tb;
        }

        #endregion

        #region INSERT

        /// <summary>
        /// สำหรับเพิ่มข้อมูลหลัก
        /// </summary>
        /// <param name="_operator">ผู้คุมเครื่อง</param>
        /// <returns></returns>
        public static bool INSERT_ALL_DATA(string _operator)
        {
            try
            {
                Log.Information($"== TBWEIGHT INSERTING");
                sql = $"INSERT INTO {tbName} (wgh_GV,wgh_gvid,wgh_customer,wgh_customer_productID,wgh_productID,wgh_product,wgh_jobType,wgh_typeSuccess,wgh_structure,wgh_daliveryStation,wgh_date,wgh_dateDalivery,wgh_operator)" +
                    $"VALUES(@wgh_GV,@wgh_gvid,@wgh_customer,@wgh_customer_productID,@wgh_productID,@wgh_product,@wgh_jobType,@wgh_typeSuccess,@wgh_structure,@wgh_daliveryStation,@wgh_date,@wgh_dateDalivery,@wgh_operator)";

                Log.Information($"- ชื่อ GV : {MRP.name} ");
                Log.Information($"- เลขที่ GV :  {MRP.id}");
                Log.Information($"- รหัสสินค้าของลูกค้า : {MRP.customer_product_code}");
                Log.Information($"- รหัสสินค้า :  {MRP.default_code}");
                Log.Information($"- ชื่อสินค้า :  {MRP.product_name}");
                Log.Information($"- ชื่อลูกค้า :  {MRP.partner_name}");
                Log.Information($"- ขนาดงาน : {MRP.mo_type}");
                Log.Information($"- โครงสร้าง : {MRP.mo_work}");
                Log.Information($"- สถานที่จัดส่ง : {MRP.mo_station_name}");
                Log.Information($"- วันที่จัดส่ง : {MRP.mo_date_delivery}");
                Log.Information($"- วันที่ผลิต : {MRP.mo_date}");
                Log.Information($"- ผู้คุมเครื่อง : {_operator}");

                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add(new SqlParameter("@wgh_GV", MRP.name));
                cmd.Parameters.Add(new SqlParameter("@wgh_gvid", MRP.id));
                cmd.Parameters.Add(new SqlParameter("@wgh_productID", MRP.default_code));
                cmd.Parameters.Add(new SqlParameter("@wgh_customer", MRP.partner_name));
                cmd.Parameters.Add(new SqlParameter("@wgh_customer_productID", MRP.customer_product_code));
                cmd.Parameters.Add(new SqlParameter("@wgh_product", MRP.product_name));
                cmd.Parameters.Add(new SqlParameter("@wgh_jobType", MRP.mo_type));
                cmd.Parameters.Add(new SqlParameter("@wgh_typeSuccess", MRP.mo_work));
                cmd.Parameters.Add(new SqlParameter("@wgh_structure", MRP.mo_film));
                cmd.Parameters.Add(new SqlParameter("@wgh_daliveryStation", MRP.mo_station_name));
                cmd.Parameters.Add(new SqlParameter("@wgh_dateDalivery", MRP.mo_date_delivery));
                cmd.Parameters.Add(new SqlParameter("@wgh_date", MRP.mo_date));
                cmd.Parameters.Add(new SqlParameter("@wgh_operator", _operator));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                ERR = ex.Message;
                Log.Error($"== tbWeight | INSERT_ALL_DATA : {ex.Message}");
                Console.WriteLine("insert" + ex.Message);
                return false;
            }
            Log.Information($"== INSERT TBWEIGHT SUCCESS");
            return true;
        }

        #endregion
        #region UPDATE
        /// <summary>
        /// สำหรับเพิ่มข้อมูลหลัก
        /// </summary>
        /// <param name="_operator">ผู้คุมเครื่อง</param>
        /// <returns></returns>
        public static bool UPDATE_ALL_DATA(string _operator)
        {
            try
            {
                Log.Information($"== TBWEIGHT UPDATING");
                sql = $"UPDATE {tbName}" +
                    $" SET wgh_productID = @wgh_productID," +
                    $" wgh_customer = @wgh_customer," +
                    $" wgh_customer_productID = @wgh_customer_productID," +
                    $" wgh_product = @wgh_product," +
                    $" wgh_jobType = @wgh_jobType," +
                    $" wgh_typeSuccess = @wgh_typeSuccess," +
                    $" wgh_structure = @wgh_structure," +
                    $" wgh_daliveryStation = @wgh_daliveryStation," +
                    $" wgh_date = @wgh_date," +
                    $" wgh_dateDalivery = @wgh_dateDalivery," +
                    $" wgh_operator = @wgh_operator" +
                    $" WHERE wgh_GV = @wgh_GV";

                Log.Information($"- ชื่อ GV : {MRP.name} ");
                Log.Information($"- เลขที่ GV :  {MRP.id}");
                Log.Information($"- รหัสสินค้าของลูกค้า : {MRP.customer_product_code}");
                Log.Information($"- รหัสสินค้า :  {MRP.default_code}");
                Log.Information($"- ชื่อสินค้า :  {MRP.product_name}");
                Log.Information($"- ชื่อลูกค้า :  {MRP.partner_name}");
                Log.Information($"- ขนาดงาน : {MRP.mo_type}");
                Log.Information($"- โครงสร้าง : {MRP.mo_film}");
                Log.Information($"- สถานที่จัดส่ง : {MRP.mo_station_name}");
                Log.Information($"- วันที่จัดส่ง : {MRP.mo_date_delivery}");
                Log.Information($"- วันที่ผลิต : {MRP.mo_date}");
                Log.Information($"- ผู้คุมเครื่อง : {_operator}");

                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add(new SqlParameter("@wgh_productID", MRP.default_code));
                cmd.Parameters.Add(new SqlParameter("@wgh_customer", MRP.partner_name));
                cmd.Parameters.Add(new SqlParameter("@wgh_customer_productID", MRP.customer_product_code));
                cmd.Parameters.Add(new SqlParameter("@wgh_product", MRP.product_name));
                cmd.Parameters.Add(new SqlParameter("@wgh_jobType", MRP.mo_type));
                cmd.Parameters.Add(new SqlParameter("@wgh_typeSuccess", MRP.mo_work));
                cmd.Parameters.Add(new SqlParameter("@wgh_structure", MRP.mo_film));
                cmd.Parameters.Add(new SqlParameter("@wgh_daliveryStation", MRP.mo_station_name));
                cmd.Parameters.Add(new SqlParameter("@wgh_date", MRP.mo_date));
                cmd.Parameters.Add(new SqlParameter("@wgh_dateDalivery", MRP.mo_date_delivery));
                cmd.Parameters.Add(new SqlParameter("@wgh_operator", _operator));
                cmd.Parameters.Add(new SqlParameter("@wgh_GV", MRP.name));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                ERR = ex.Message;
                Log.Error($"== tbWeight | UPDATE_ALL_DATA : {ERR}");
                return false;
            }
            Log.Information($"== UPDATE TBWEIGHT SUCCESS");
            return true;
        }
        #endregion
    }
}
