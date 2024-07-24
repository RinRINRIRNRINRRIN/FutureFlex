using FutureFlex.API;
using Serilog;
using System.Data;
using System.Data.SqlClient;

namespace FutureFlex.SQL
{
    internal class tbWeightDetail
    {
        static SqlConnection con = server.con;
        static SqlDataAdapter da = new SqlDataAdapter();
        static DataTable tb = new DataTable();
        static SqlCommand cmd = new SqlCommand();
        static string sql = "";
        static string tbName = "tbWeightDetail";


        public static string ERR { get; set; }
        public static string PO { get; set; }
        public static string seq { get; set; }
        public static string country { get; set; }
        public static string type { get; set; }
        public static string side { get; set; }
        public static decimal net { get; set; }
        public static decimal tare { get; set; }
        public static decimal gross { get; set; }
        public static decimal wgh_paper_plastic { get; set; }
        public static decimal wgh_core_total { get; set; }
        public static decimal wgh_joint { get; set; }
        public static decimal wgh_meter_kg_in_roll { get; set; }
        public static int numbox { get; set; }
        public static int numroll { get; set; }
        public static int pch { get; set; }
        public static string lot { get; set; }

        /// <summary>
        /// สำหรับแสดงข้อมูล PO 
        /// </summary>
        /// <param name="po"></param>
        /// <returns></returns>
        public static DataTable SELECT_PO(string po)
        {
            try
            {
                sql = $"SELECT * FROM {tbName} WHERE wdt_po = '{po}'";
                da = new SqlDataAdapter(sql, con);
                tb = new DataTable();
                da.Fill(tb);
            }
            catch (System.Exception ex)
            {
                ERR = ex.Message;
                return tb;
            }
            return tb;
        }

        /// <summary>
        /// สำหรับแสดงข้อมูล PO 
        /// </summary>
        /// <param name="po"></param>
        /// <returns></returns>
        public static DataTable SELECT_PO_NOT_SEND_ODOO()
        {
            try
            {
                Log.Information($"== แสดงข้อมูลรายการที่ยังไม่ส่งหา odoo");
                sql = $"SELECT * FROM {tbName} WHERE wdt_po = '{PO}' and wdt_statusOdoo = 'NOT SEND'";
                da = new SqlDataAdapter(sql, con);
                tb = new DataTable();
                da.Fill(tb);
            }
            catch (System.Exception ex)
            {
                ERR = ex.Message;
                Log.Error($"== แสดงข้อมูลรายการที่ยังไม่ส่งหา odoo ไม่สำเร็จ");
                return tb;
            }
            Log.Information($"== แสดงข้อมูลรายการที่ยังไม่ส่งหา odoo สำเร็จ");
            return tb;
        }


        /// <summary>
        /// สำหรับแสดงข้อมูล po ทั้งหมดที่ยังไม่ได้ส่งไปหา odoo
        /// </summary>
        /// <returns></returns>
        public static DataTable SELECT_ODOO_DONT_SEND()
        {
            try
            {
                sql = $"SELECT * FROM {tbName} WHERE wdt_statusOdoo = 'NOT SEND'";
                da = new SqlDataAdapter(sql, con);
                tb = new DataTable();
                da.Fill(tb);
            }
            catch (System.Exception ex)
            {
                ERR = ex.Message;
                return tb;
            }
            return tb;
        }


        /// <summary>
        /// สำหรับแสดงข้อมูล PO ที่มีการส่งข้อมูลไปหา Odoo เรียบร้อย หน้า Repinrt พร้อมที่จะ reprint
        /// </summary>
        /// <returns></returns>
        public static DataTable SELECT_PO_SUCCESS_ODOO()
        {
            try
            {
                sql = $"SELECT b.wdt_seq," +
"a.wgh_product," +
"a.wgh_productID," +
"a.wgh_customer," +
"b.wdt_GVID," +
"b.wdt_po," +
"a.wgh_structure," +
"a.wgh_typeSuccess," +
"b.wdt_wgh_paper_plastic," +
"b.wdt_wgh_core_total," +
"b.wdt_numroll," +
"b.wdt_numbox," +
"b.wdt_pch," +
"b.wdt_net," +
"b.wdt_tare," +
"b.wdt_gross," +
"a.wgh_date," +
"a.wgh_operator," +
"b.wdt_lot," +
"b.wdt_type," +
"b.wdt_printed," +
"b.wdt_meter_kg_in_roll" +
" FROM tbWeightDetail b" +
" LEFT JOIN tbWeight a" +
" ON b.wdt_GVID = a.wgh_GV" +
$" WHERE b.wdt_po = '{PO}' and b.wdt_statusOdoo ='SEND'";
                da = new SqlDataAdapter(sql, con);
                tb = new DataTable();
                da.Fill(tb);
            }
            catch (System.Exception ex)
            {
                ERR = ex.Message;
                return tb;
            }
            return tb;
        }



        /// <summary>
        /// สำหรับบันทึกขอมูลการชั่ง
        /// </summary>
        /// <returns></returns>
        public static bool INSERT_DATA()
        {
            try
            {
                Log.Information($"== INSERTING DATA");

                sql = $"INSERT INTO {tbName} (wdt_GVID,wdt_po,wdt_seq,wdt_country,wdt_type,wdt_side,wdt_net,wdt_tare,wdt_gross,wdt_wgh_paper_plastic,wdt_wgh_core_total,wdt_wgh_joint,wdt_meter_kg_in_roll,wdt_numbox,wdt_numroll,wdt_pch,wdt_lot,wdt_employee,wdt_date,wdt_printed,wdt_statusOdoo)" +
                    $"VALUES(@wdt_GVID,@wdt_po,@wdt_seq,@wdt_country,@wdt_type,@wdt_side,@wdt_net,@wdt_tare,@wdt_gross,@wdt_wgh_paper_plastic,@wdt_wgh_core_total,@wdt_wgh_joint,@wdt_meter_kg_in_roll,@wdt_numbox,@wdt_numroll,@wdt_pch,@wdt_lot,@wdt_employee,CURRENT_TIMESTAMP,@wdt_printed,@wdt_statusOdoo)";

                Log.Information($"-- ชื่อ GV : {MRP.name}");
                Log.Information($"-- po : {PO}");
                Log.Information($"-- ลำดับที่ : {seq}");
                Log.Information($"-- ประเทศ : {country}");
                Log.Information($"-- ประเภท : {type}");
                Log.Information($"-- ด้าน : {side}");
                Log.Information($"-- น้ำหนักสุทธิ์ : {net}");
                Log.Information($"-- น้ำหนักภาชนะ : {tare}");
                Log.Information($"-- น้ำหนักรวม : {gross}");
                Log.Information($"-- น้ำหนักกระดาษ : {wgh_paper_plastic}");
                Log.Information($"-- น้ำหนักแกน : {wgh_core_total}");
                Log.Information($"-- จำนวนรอยต่อ : {wgh_joint}");
                Log.Information($"-- จำนวนเมตร : {wgh_meter_kg_in_roll}");
                Log.Information($"-- จำนวนกล่อง : {numbox}");
                Log.Information($"-- จำนวนม้วน : {numroll}");
                Log.Information($"-- จำนวนใบ : {pch}");
                Log.Information($"-- LOT : {lot}");

                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add(new SqlParameter("@wdt_GVID", MRP.name));
                cmd.Parameters.Add(new SqlParameter("@wdt_po", PO));
                cmd.Parameters.Add(new SqlParameter("@wdt_seq", seq));

                cmd.Parameters.Add(new SqlParameter("@wdt_country", country));
                cmd.Parameters.Add(new SqlParameter("@wdt_type", type));
                cmd.Parameters.Add(new SqlParameter("@wdt_side", side));

                cmd.Parameters.Add(new SqlParameter("@wdt_net", net));
                cmd.Parameters.Add(new SqlParameter("@wdt_tare", tare));
                cmd.Parameters.Add(new SqlParameter("@wdt_gross", gross));

                cmd.Parameters.Add(new SqlParameter("@wdt_wgh_paper_plastic", wgh_paper_plastic));
                cmd.Parameters.Add(new SqlParameter("@wdt_wgh_core_total", wgh_core_total));
                cmd.Parameters.Add(new SqlParameter("@wdt_wgh_joint", wgh_joint));
                cmd.Parameters.Add(new SqlParameter("@wdt_meter_kg_in_roll", wgh_meter_kg_in_roll));
                cmd.Parameters.Add(new SqlParameter("@wdt_numbox", numbox));
                cmd.Parameters.Add(new SqlParameter("@wdt_numroll", numroll));

                cmd.Parameters.Add(new SqlParameter("@wdt_pch", pch));


                cmd.Parameters.Add(new SqlParameter("@wdt_lot", lot));
                cmd.Parameters.Add(new SqlParameter("@wdt_employee", tbEmployeeSQL.emp_name));

                if (PO == "JIT")
                {
                    cmd.Parameters.Add(new SqlParameter("@wdt_printed", "NOT PRINT"));
                }
                else
                {
                    cmd.Parameters.Add(new SqlParameter("@wdt_printed", "PRINTED"));
                }
                cmd.Parameters.Add(new SqlParameter("@wdt_statusOdoo", "NOT SEND"));

                cmd.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                ERR = ex.Message;
                Log.Error($"INSERT DATA | tbWeightDetail : {ERR}");
                return false;
            }
            Log.Information($"INSERT DATA SUCCESS");
            return true;
        }


        public static bool DELETE(string id)
        {
            try
            {
                Log.Information($"-- ลบข้อมูลที่ {id}");
                sql = $"DELETE FROM {tbName} WHERE id = '{id}'";
                cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                ERR = ex.Message;
                Log.Error($"DELETE | tbWeightDetail : {ERR}");
                return false;
            }
            Log.Information($"== ลบข้อมูลสำเร็จ");
            return true;
        }


        public static bool UPDATE(string id, decimal net, decimal tare, decimal gross)
        {
            try
            {
                Log.Information("== แก้ไขข้อมูลการชั่ง");
                sql = $"UPDATE {tbName} " +
                    $" SET wdt_net = @wdt_net," +
                    $" wdt_tare = @wdt_tare," +
                    $" wdt_gross = @wdt_gross" +
                    $" WHERE id = @id";

                Log.Information($"- น้ำหนักสุทธิ์ : {net}");
                Log.Information($"- น้ำหนักภาชนะ : {tare}");
                Log.Information($"- น้ำหนักรวม : {gross}");
                Log.Information($"- แก้ไขข้อมูลที่ : {id}");

                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add(new SqlParameter("@wdt_net", net));
                cmd.Parameters.Add(new SqlParameter("@wdt_tare", tare));
                cmd.Parameters.Add(new SqlParameter("@wdt_gross", gross));
                cmd.Parameters.Add(new SqlParameter("@id", id));
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                ERR = ex.Message;
                Log.Error($"UPDATE | tbWeightDetail : {ex.Message}");
                return false;
            }
            Log.Information("== แก้ไขข้อมูลการชั่งสำเร็จ");
            return true;
        }

        /// <summary>
        /// สำหรับอัพเดทว่ามีการส่งไปหา Odoo เรียบร้อยแล้ว
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool UPDATE_STATUS_ODOO(string id)
        {
            try
            {
                sql = $"UPDATE {tbName} " +
                    $" SET wdt_statusOdoo = 'SEND'" +
                    $" WHERE id = {id}";
                cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                return false;
            }
            return true;
        }


        /// <summary>
        /// สำหรับอัพเดทว่ามีการปริ้นเรียบร้อยแล้ว
        /// </summary>
        /// <returns></returns>
        public static bool UPDATE_STATUS_PRINT(string lot)
        {
            try
            {
                sql = $"UPDATE {tbName} " +
                    $" SET wdt_printed = 'PRINTED'" +
                    $" WHERE wdt_lot = '{lot}'";
                cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                ERR = ex.Message;
                return false;
            }
            return true;
        }



    }
}
