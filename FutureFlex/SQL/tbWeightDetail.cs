using FutureFlex.API;
using FutureFlex.Models;
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
        public static string SO { get; set; }
        public static string seq { get; set; }
        public static string country { get; set; }
        public static string type { get; set; }
        public static string side { get; set; }
        public static double net { get; set; }
        public static double tare { get; set; }
        public static double gross { get; set; }
        public static double wgh_paper_plastic { get; set; }
        public static double wgh_core_total { get; set; }
        public static double wgh_joint { get; set; }
        public static double wgh_meter_kg_in_roll { get; set; }
        public static int numbox { get; set; }
        public static int numrollAll { get; set; }  // จำนวนม้วนทั้งหมด

        /// <summary>
        /// จำนวนม้วน / lot
        /// </summary>
        public static double numroll { get; set; } // จำนวนม้วนต่อLOT
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
                Console.WriteLine(ex.Message);
                ERR = ex.Message;
                return tb;
            }
            return tb;
        }

        /// <summary>
        /// เลือกวันที่ ที่ต้องการค้นหา
        /// </summary>
        /// <param name="start">วันที่เริ่มต้น</param>
        /// <param name="end">วันที่สิ้นสุด</param>
        /// <returns></returns>
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

        /// <summary>
        /// สำหรับแสดง JIT ที่ยังไม่ได้ส่งหา odoo
        /// </summary>
        /// <param name="gvOrRTFG">GV,RTFG,SPL</param>
        /// <returns></returns>
        public static DataTable SELECT_SPL_NOT_SEND_ODOO(string gvOrRTFG, string so, string weightType)
        {
            try
            {
                Log.Information($"== แสดงข้อมูลรายการที่ยังไม่ส่งหา odoo");
                if (weightType == "JIT")
                {
                    sql = $"SELECT * FROM {tbName}  WHERE wdt_gv_name = '{MRP.name}' and  wdt_weightType = 'SPL' and wdt_type = '{type}' and wdt_statusOdoo = 'NOT SEND' ";
                }
                else
                {
                    sql = $"SELECT * FROM {tbName}  WHERE wdt_gv_name = '{MRP.name}' and  wdt_po = '{MRP.mo_pono}' and wdt_so = '{so}' and wdt_type = '{type}' and wdt_statusOdoo = 'NOT SEND' ";

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
        /// สำหรับแสดง JIT ที่ยังไม่ได้ส่งหา odoo
        /// </summary>
        /// <param name="gvOrRTFG">GV,RTFG,SPL</param>
        /// <returns></returns>
        public static DataTable SELECT_JIT_NOT_SEND_ODOO(string gvOrRTFG)
        {
            try
            {
                Log.Information($"== แสดงข้อมูลรายการที่ยังไม่ส่งหา odoo");
                switch (gvOrRTFG)
                {
                    case "RTFG":
                        sql = $"SELECT * FROM {tbName}  WHERE  wdt_po = '' and wdt_statusOdoo = 'NOT SEND' and wdt_weightType = 'RTFG' ";
                        break;
                    case "SPL":
                        sql = $"SELECT * FROM {tbName}  WHERE  wdt_po = '' and wdt_statusOdoo = 'NOT SEND' and wdt_weightType = 'SPL' ";
                        break;
                    default:
                        sql = $"SELECT * FROM {tbName}  WHERE  wdt_po = '' and wdt_statusOdoo = 'NOT SEND' and wdt_weightType = 'JIT' ";
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
        /// แสดงรยาการ RTFG ที่มีการชั่งและยังไม่ได้ส่งไปที่ odoo
        /// </summary>
        /// <param name="rtfg_name">เลขที่</param>
        /// <returns></returns>
        public static DataTable SELECT_RTFG_NOT_SEND_ODOO(string type, string so, string weightType)
        {
            try
            {
                Log.Information($"== แสดงข้อมูลรายการที่ยังไม่ส่งหา odoo");
                if (weightType == "JIT")
                {
                    sql = $"SELECT * FROM {tbName}  WHERE wdt_gv_name = '{MRP.name}' and wdt_rtfg_name = '{RTFG.Name}'  and  wdt_weightType = 'RTFG' and wdt_type = '{type}' and wdt_statusOdoo = 'NOT SEND' ";
                }
                else
                {
                    sql = $"SELECT * FROM {tbName}  WHERE wdt_gv_name = '{MRP.name}' and  wdt_po = '{RTFG.new_po_customer}' and wdt_so = '{so}' and wdt_type = '{type}' and wdt_rtfg_name = '{RTFG.Name}' and wdt_statusOdoo = 'NOT SEND' ";

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
        /// แสดงรยาการ GV ที่มีการชั่งและยังไม่ได้ส่งไปที่ odoo
        /// </summary>
        /// <param name="gvanme">เลขที่</param>
        /// <returns></returns>
        public static DataTable SELECT_GV_NOT_SEND_ODOO(string so, string po, string type)
        {
            try
            {
                Log.Information($"== แสดงข้อมูลรายการที่ยังไม่ส่งหา odoo");
                sql = $"SELECT * FROM {tbName}  WHERE  wdt_po = '{po}' and wdt_so = '{so}' and wdt_type = '{type}' and wdt_statusOdoo = 'NOT SEND' ";
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
        /// สแกงข้อมูล JIT ที่ยัะงไม่ส่งหา odoo
        /// </summary>
        /// <param name="type">ประเภท กล่อง ม้วน</param>
        /// <returns></returns>
        public static DataTable JIT_NOT_SEND_ODOO(string type)
        {
            try
            {
                Log.Information($"== แสดงข้อมูลรายการที่ยังไม่ส่งหา odoo");
                sql = $"SELECT * FROM {tbName}  WHERE wdt_gv_name = '{MRP.name}' and wdt_type = '{type}' and  wdt_weightType = 'JIT' and wdt_statusOdoo = 'NOT SEND' ";
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
        /// แสดงข้อูลหลักจากเลือกประเภท PO จากนั้นแสดงข้อมูล Gv,RTFG,SPL แล้วต่อผู้ใช้เลือก
        /// </summary>
        /// <param name="type">GV,RTFG,SPL</param>
        /// <param name="_name">ชื่อของ GV,RTFG,SPL</param>
        /// <param name="po">เลขที่ PO หรือ JIT</param>
        /// <returns></returns>
        public static DataTable SELECT_GVorRTFGor_SPL_formHistorySuccess(string type, string _name, string po)
        {
            try
            {
                Log.Information($"== แสดงข้อมูลรายการที่ยังไม่ส่งหา odoo");
                //sql = $"SELECT * FROM {tbName}  WHERE wdt_po = '{PO}' and wdt_GVID ='{MRP.name}' and wdt_statusOdoo = 'NOT SEND'";
                switch (type)
                {
                    //case "GV":
                    //    break;
                    case "RTFG":
                        sql = $"SELECT * FROM {tbName}  WHERE  wdt_statusOdoo = 'NOT SEND' and wdt_rtfg_name = '{_name}'";
                        break;
                    case "SPL":
                        sql = $"SELECT * FROM {tbName}  WHERE wdt_spl_name = '{_name}' and wdt_statusOdoo = 'NOT SEND' ";
                        break;
                    default:
                        sql = $"SELECT * FROM {tbName}  WHERE wdt_gv_name = '{_name}' and  wdt_po = '' and wdt_statusOdoo = 'NOT SEND' and wdt_weightType = 'JIT'";
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
                        sql = $"SELECT wdt_po FROM tbWeightDetail WHERE wdt_statusOdoo = 'NOT SEND' and wdt_rtfg_name = '' and wdt_spl_name = ''  and (wdt_po = '' or wdt_po != '') and ( wdt_weightType = 'JIT' or wdt_weightType = 'PO')";
                        break;
                    case "RTFG":
                        sql = $"SELECT wdt_po FROM {tbName} WHERE wdt_statusOdoo = 'NOT SEND' and wdt_rtfg_name != '' and wdt_weightType = 'RTFG'";
                        break;
                    case "SPL":
                        sql = $"SELECT wdt_po FROM {tbName} WHERE wdt_statusOdoo = 'NOT SEND' and wdt_rtfg_name = '' and wdt_spl_name != '' and wdt_weightType = 'SPL'";
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
"a.wgh_customer_productID," +
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
$" WHERE b.wdt_po = '{PO}' and b.wdt_statusOdoo ='SEND' and b.wdt_printed = 'NOT PRINT' ORDER BY wdt_seqNew ASC";
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
                sql = $"SELECT b.wdt_seqOrigin,b.wdt_seqNew," +
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
                Console.WriteLine(ERR);
                return tb;
            }
            return tb;
        }

        /// <summary>
        /// สำหรับบันทึกขอมูลการชั่ง
        /// </summary>
        /// <returns></returns>
        public static DataTable INSERT_DATA(string GvName, int GvId, string RtfgName, int RtfgId, string slpName, int slpId, string Po, string So, string Country, string Type, string Side, double Net, double Tare, double Gross, double wgh_paper_plastic, double wgh_core_total, double wgh_joint, double wgh_meter_kg_in_roll, int numbox, int numrollAll, double numroll, int pch, string Lot, string Employee, string WeightType, string printType)
        {

            try
            {
                Log.Information($"==================================================== INSERTING DATA");

                sql = "InsertWithSeq";
                Log.Information($"-- GV NAME: {GvName}");
                Log.Information($"-- GV ID: {GvId}");
                Log.Information($"-- RTFG NAME : {RtfgName}");
                Log.Information($"-- RTFG ID : {RtfgId}");
                Log.Information($"-- SLP NAME: {slpName}");
                Log.Information($"-- SLP ID: {slpId}");
                Log.Information($"-- po : {Po}");
                Log.Information($"-- so : {So}");
                Log.Information($"-- ประเทศ : {Country}");
                Log.Information($"-- ประเภท : {Type}");
                Log.Information($"-- ด้าน : {Side}");
                Log.Information($"-- น้ำหนักสุทธิ์ : {Net}");
                Log.Information($"-- น้ำหนักภาชนะ : {Tare}");
                Log.Information($"-- น้ำหนักรวม : {Gross}");
                Log.Information($"-- น้ำหนักกระดาษ : {wgh_paper_plastic}");
                Log.Information($"-- น้ำหนักแกน : {wgh_core_total}");
                Log.Information($"-- จำนวนรอยต่อ : {wgh_joint}");
                Log.Information($"-- จำนวนเมตร : {wgh_meter_kg_in_roll}");
                Log.Information($"-- จำนวนกล่อง : {numbox}");
                Log.Information($"-- จำนวนม้วน(ทั้งหมด) : {numrollAll}");
                Log.Information($"-- จำนวนม้วน/lot : {numroll}");
                Log.Information($"-- จำนวนใบ : {pch}");
                Log.Information($" -- LOT : {Lot}");
                Log.Information($"-- OPARATOR : {Employee}");
                Log.Information($"-- ประเภทการชั่ง : {WeightType}");
                Log.Information($"-- รูปแบบปร้ิน : {printType}");

                cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@gv_name", GvName));
                cmd.Parameters.Add(new SqlParameter("@gv_id", GvId));
                cmd.Parameters.Add(new SqlParameter("@rtfg_name", RtfgName));
                cmd.Parameters.Add(new SqlParameter("@rtfg_id", RtfgId));
                cmd.Parameters.Add(new SqlParameter("@spl_name", slpName));
                cmd.Parameters.Add(new SqlParameter("@spl_id", slpId));
                if (Po == "False")
                {
                    cmd.Parameters.Add(new SqlParameter("@po", ""));
                }
                else
                {
                    cmd.Parameters.Add(new SqlParameter("@po", Po));
                }
                if (So == "False")
                {
                    cmd.Parameters.Add(new SqlParameter("@so", ""));
                }
                else
                {
                    cmd.Parameters.Add(new SqlParameter("@so", So));
                }

                cmd.Parameters.Add(new SqlParameter("@country", Country));
                cmd.Parameters.Add(new SqlParameter("@type", Type));
                cmd.Parameters.Add(new SqlParameter("@side", Side));

                cmd.Parameters.Add(new SqlParameter("@net", Net));
                cmd.Parameters.Add(new SqlParameter("@tare", Tare));
                cmd.Parameters.Add(new SqlParameter("@gross", Gross));

                cmd.Parameters.Add(new SqlParameter("@wgh_paper", wgh_paper_plastic));
                cmd.Parameters.Add(new SqlParameter("@wgh_core", wgh_core_total));
                cmd.Parameters.Add(new SqlParameter("@wgh_joint", wgh_joint));
                cmd.Parameters.Add(new SqlParameter("@numMeter", wgh_meter_kg_in_roll));
                cmd.Parameters.Add(new SqlParameter("@numBox", numbox));
                cmd.Parameters.Add(new SqlParameter("@numRollAll", numrollAll));
                cmd.Parameters.Add(new SqlParameter("@numRoll", numroll));

                cmd.Parameters.Add(new SqlParameter("@pch", pch));

                cmd.Parameters.Add(new SqlParameter("@lot", Lot));
                cmd.Parameters.Add(new SqlParameter("@oparator", Employee));
                cmd.Parameters.Add(new SqlParameter("@employee", EmployeeModel.emp_name));
                cmd.Parameters.Add(new SqlParameter("@weightType", WeightType));

                if (printType == "S")
                {
                    cmd.Parameters.Add(new SqlParameter("@printed", "NOT PRINT"));
                }
                else if (printType == "L")
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


        /// <summary>
        /// สำหรับลบข้อมูล
        /// </summary>
        /// <param name="id">เลขที่การชั่ง Id</param>
        /// <returns></returns>
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


        /// <summary>
        /// สำหรับการอัพเดทการชั่งกรณีแก้ไขการชั่ง
        /// </summary>
        /// <param name="id"></param>
        /// <param name="net"></param>
        /// <param name="tare"></param>
        /// <param name="gross"></param>
        /// <returns></returns>
        public static DataTable UPDATE(string id, double net, double tare, double gross)
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


        /// <summary>
        /// แสดงรายการที่ที่ยังไม่แสดงหา odoo ค้นหาจาก po และ ประเภทการชั่ง
        /// </summary>
        /// <param name="po">PO</param>
        /// <param name="weightType">PO,JIT,RTFG,SPL</param>
        /// <returns></returns>
        public static DataTable SearchPoAndWeightType(string po, string weightType)
        {
            try
            {
                sql = $"SELECT * FROM {tbName} WHERE wdt_po = '{po}' and wdt_weightType = '{weightType}' and wdt_statusOdoo = 'NOT SEND'";
                da = new SqlDataAdapter(sql, con);
                tb = new DataTable();
                da.Fill(tb);
            }
            catch (Exception ex)
            {
                return null;
            }
            return tb;
        }
    }
}
