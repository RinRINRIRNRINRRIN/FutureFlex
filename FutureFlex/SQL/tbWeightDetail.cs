using FutureFlex.API;
using Serilog;
using System;
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
        public static int numrollAll { get; set; }  // จำนวนม้วนทั้งหมด
        public static decimal numroll { get; set; } // จำนวนม้วนต่อLOT
        public static int pch { get; set; }
        public static string lot { get; set; }
        public static string oparator { get; set; }

        /// <summary>
        /// สำหรับแสดงข้อมูล PO ทุกเงื่อนไข
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

        public static DataTable SELECT_DATE(string start, string end)
        {
            try
            {
                sql = $"SELECT wdt_gv_name FROM {tbName} WHERE  wdt_date BETWEEN '{start}' and '{end}'";
                da = new SqlDataAdapter(sql, con);
                tb = new DataTable();
                da.Fill(tb);
            }
            catch (Exception ex)
            {
                ERR = ex.Message;
                return tb;
            }
            return tb;
        }

        /// <summary>
        /// สำหรับแสดงข้อมูล PO  ที่ยังไม่ส่งข้อมูลไปที่ ODOO
        /// </summary>
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

        public static DataTable SELECT_JIT_AND_PO_NOT_SEND_ODOO()
        {
            try
            {
                Log.Information($"== แสดงข้อมูลรายการที่ยังไม่ส่งหา odoo");
                //sql = $"SELECT * FROM {tbName}  WHERE wdt_po = '{PO}' and wdt_GVID ='{MRP.name}' and wdt_statusOdoo = 'NOT SEND'";
                sql = $"SELECT * FROM {tbName}  WHERE wdt_po = '{PO}' and wdt_statusOdoo = 'NOT SEND' and wdt_gv_name = '{MRP.name}' and wdt_rtfg_name = ''";
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

        public static DataTable SELECT_JIT_NOT_SEND_ODOO(string gvOrRTFG)
        {
            try
            {
                Log.Information($"== แสดงข้อมูลรายการที่ยังไม่ส่งหา odoo");
                //sql = $"SELECT * FROM {tbName}  WHERE wdt_po = '{PO}' and wdt_GVID ='{MRP.name}' and wdt_statusOdoo = 'NOT SEND'";
                switch (gvOrRTFG)
                {
                    case "GV":
                        sql = $"SELECT * FROM {tbName}  WHERE wdt_po = '{PO}' and wdt_statusOdoo = 'NOT SEND' and wdt_rtfg_name = ''";
                        break;
                    case "RTFG":
                        sql = $"SELECT * FROM {tbName}  WHERE wdt_po = '{PO}' and wdt_statusOdoo = 'NOT SEND' and wdt_rtfg_name != ''";
                        break;
                }
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
        public static DataTable SELECT_ODOO_DONT_SEND(string gvOrRTFG)
        {
            try
            {
                switch (gvOrRTFG)
                {
                    case "GV":
                        sql = $"SELECT wdt_po FROM {tbName} WHERE wdt_statusOdoo = 'NOT SEND' and wdt_rtfg_name = ''";
                        break;
                    case "RTFG":
                        sql = $"SELECT wdt_po FROM {tbName} WHERE wdt_statusOdoo = 'NOT SEND' and wdt_rtfg_name != ''";
                        break;
                }
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
        /// แสดงข้อมูล PO ที่ยังไม่ปร้ิน
        /// </summary>
        /// <returns></returns>
        public static DataTable SELECT_PO_NOT_PRINT()
        {
            try
            {
                sql = $"SELECT wdt_po FROM {tbName} WHERE wdt_printed = 'NOT PRINT'";
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
        public static DataTable SELECT_PO_SUCCESS_ODOO_AND_NOT_REPRINT()
        {
            try
            {
                sql = $"SELECT b.wdt_seqNew," +
"a.wgh_product," +
"a.wgh_productID," +
"a.wgh_customer," +
"b.wdt_gv_name," +
"b.wdt_po," +
"a.wgh_structure," +
"a.wgh_typeSuccess," +
"b.wdt_wgh_paper_plastic," +
"b.wdt_wgh_core_total," +
"b.wdt_numroll," +
"b.wdt_numrollAll," +
"b.wdt_numbox," +
"b.wdt_pch," +
"b.wdt_net," +
"b.wdt_tare," +
"b.wdt_gross," +
"a.wgh_date," +
"b.wdt_oparator," +
"b.wdt_lot," +
"b.wdt_type," +
"b.wdt_printed," +
"b.wdt_meter_kg_in_roll" +
" FROM tbWeightDetail b" +
" LEFT JOIN tbWeight a" +
" ON b.wdt_gv_name = a.wgh_GV" +
$" WHERE b.wdt_po = '{PO}' and b.wdt_statusOdoo ='SEND' and b.wdt_printed = 'NOT PRINT'";
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
        /// แสดงข้อมูล GV ทั้งหมด
        /// </summary>
        /// <returns></returns>
        public static DataTable SELECT_GV(string gvid)
        {
            try
            {
                sql = $"SELECT b.wdt_seq," +
"a.wgh_product," +
"a.wgh_productID," +
"a.wgh_customer," +
"b.wdt_gv_name," +
"b.wdt_date," +
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
"b.wdt_lot," +
"b.wdt_type," +
"b.wdt_printed," +
"b.wdt_statusOdoo," +
"b.wdt_employee," +
"b.wdt_oparator," +
"b.wdt_meter_kg_in_roll" +
" FROM tbWeightDetail b" +
" LEFT JOIN tbWeight a" +
" ON b.wdt_gv_name = a.wgh_GV" +
$" WHERE a.wgh_GV = '{gvid}'";
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
        public static DataTable INSERT_DATA()
        {

            try
            {
                Log.Information($"== INSERTING DATA");

                sql = "InsertWithSeq";
                Log.Information($"-- ชื่อ GV NAME: {MRP.name}");
                Log.Information($"-- ชื่อ GV ID: {MRP.id}");
                Log.Information($"-- ชื่อ RTFG NAME : {RTFG.Name}");
                Log.Information($"-- ชื่อ RTFG ID : {RTFG.Rtfg_ID}");
                Log.Information($"-- po : {PO}");
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
                Log.Information($"-- จำนวนม้วน(ทั้งหมด) : {numrollAll}");
                Log.Information($"-- จำนวนม้วน : {numroll}");
                Log.Information($"-- จำนวนใบ : {pch}");
                Log.Information($"-- LOT : {lot}");
                Log.Information($"-- OPARATOR : {oparator}");

                cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@gv_name", MRP.name));
                cmd.Parameters.Add(new SqlParameter("@gv_id", MRP.id));
                cmd.Parameters.Add(new SqlParameter("@rtfg_name", RTFG.Name));
                cmd.Parameters.Add(new SqlParameter("@rtfg_id", RTFG.Rtfg_ID));
                cmd.Parameters.Add(new SqlParameter("@po", PO));

                cmd.Parameters.Add(new SqlParameter("@country", country));
                cmd.Parameters.Add(new SqlParameter("@type", type));
                cmd.Parameters.Add(new SqlParameter("@side", side));

                cmd.Parameters.Add(new SqlParameter("@net", net));
                cmd.Parameters.Add(new SqlParameter("@tare", tare));
                cmd.Parameters.Add(new SqlParameter("@gross", gross));

                cmd.Parameters.Add(new SqlParameter("@wgh_paper", wgh_paper_plastic));
                cmd.Parameters.Add(new SqlParameter("@wgh_core", wgh_core_total));
                cmd.Parameters.Add(new SqlParameter("@wgh_joint", wgh_joint));
                cmd.Parameters.Add(new SqlParameter("@numMeter", wgh_meter_kg_in_roll));
                cmd.Parameters.Add(new SqlParameter("@numBox", numbox));
                cmd.Parameters.Add(new SqlParameter("@numRollAll", numrollAll));
                cmd.Parameters.Add(new SqlParameter("@numRoll", numroll));

                cmd.Parameters.Add(new SqlParameter("@pch", pch));

                cmd.Parameters.Add(new SqlParameter("@lot", lot));
                cmd.Parameters.Add(new SqlParameter("@oparator", oparator));
                cmd.Parameters.Add(new SqlParameter("@employee", tbEmployeeSQL.emp_name));

                if (PO == "JIT")
                {
                    cmd.Parameters.Add(new SqlParameter("@printed", "NOT PRINT"));
                }
                else
                {
                    cmd.Parameters.Add(new SqlParameter("@printed", "PRINTED"));
                }
                cmd.Parameters.Add(new SqlParameter("@statusOdoo", "NOT SEND"));

                tb = new DataTable();
                da = new SqlDataAdapter(cmd);
                da.Fill(tb);
            }
            catch (System.Exception ex)
            {
                ERR = ex.Message;
                Log.Error($"INSERT DATA | tbWeightDetail : {ERR}");

            }
            Log.Information($"INSERT DATA SUCCESS");
            return tb;
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


        public static DataTable UPDATE(string id, decimal net, decimal tare, decimal gross)
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

                sql = $"SELECT * FROM tbWeightDetail WHERE id = {id}";
                tb = new DataTable();
                da = new SqlDataAdapter(sql, con);
                da.Fill(tb);
            }
            catch (System.Exception ex)
            {
                ERR = ex.Message;
                Log.Error($"UPDATE | tbWeightDetail : {ex.Message}");
            }
            Log.Information("== แก้ไขข้อมูลการชั่งสำเร็จ");
            return tb;
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
