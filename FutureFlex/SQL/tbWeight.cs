using FutureFlex.API;
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
        /// <param name="po">เลขที่ PO</param>
        /// <param name="county">ประเทศ</param>
        /// <param name="type">ประเภท</param>
        /// <param name="side">ด้าน</param>
        /// <param name="weight_paper_plstic">น้ำหนักกระดาษ/น้ำหนักพลาสติก</param>
        /// <param name="core_total">น้ำหนักแกนรวม</param>
        /// <param name="joint">น้ำหนักรอยต่้อ</param>
        /// <param name="qty_bag_in_box">จำนวนซองต่อกล่อง</param>
        /// <param name="qty_meter_kg_in_roll">จำนวนเมตรต่อกล่อง</param>
        /// <param name="totalBox">จำนวนกล่อง</param>
        /// <param name="_operator">ผู้คุมเครื่อง</param>
        /// <returns></returns>
        public static bool INSERT_ALL_DATA(string _operator)
        {
            try
            {
                sql = $"INSERT INTO {tbName} (wgh_GV,wgh_gvid,wgh_customer,wgh_productID,wgh_product,wgh_jobType,wgh_typeSuccess,wgh_structure,wgh_daliveryStation,wgh_date,wgh_dateDalivery,wgh_operator)" +
                    $"VALUES(@wgh_GV,@wgh_gvid,@wgh_customer,@wgh_productID,@wgh_product,@wgh_jobType,@wgh_typeSuccess,@wgh_structure,@wgh_daliveryStation,@wgh_date,@wgh_dateDalivery,@wgh_operator)";

                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add(new SqlParameter("@wgh_GV", MRP.name));
                cmd.Parameters.Add(new SqlParameter("@wgh_gvid", MRP.id));
                cmd.Parameters.Add(new SqlParameter("@wgh_productID", MRP.default_code));
                cmd.Parameters.Add(new SqlParameter("@wgh_customer", MRP.partner_name));
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
                Console.WriteLine("insert" + ex.Message);
                return false;
            }
            return true;
        }

        #endregion
        #region UPDATE
        public static bool UPDATE_ALL_DATA(int id, string wgh_po, string wgh_county, string wgh_type, string wgh_side, decimal wgh_weightPaper, int wgh_boxNum, decimal wgh_weightCore, int wgh_joint, decimal wgh_numMeter, decimal wgh_weightRoll, string wgh_machineOperator, decimal wgh_net, decimal wgh_tare, decimal wgh_gross)
        {
            try
            {
                sql = $"UPDATE {tbName}" +
                    $" SET wgh_employee = @wgh_employee," +
                    $"wgh_GVID = @wgh_GVID," +
                    $"wgh_GVNAME = @wgh_GVNAME," +
                    $"wgh_po = @wgh_po," +
                    $"wgh_county =@wgh_county," +
                    $"wgh_type = @wgh_type," +
                    $"wgh_side = @wgh_side," +
                    $"wgh_weightPaper = @wgh_weightPaper," +
                    $"wgh_boxNum = @wgh_boxNum," +
                    $"wgh_weightCore = @wgh_weightCore," +
                    $"wgh_joint = @wgh_joint," +
                    $"wgh_numMeter = @wgh_numMeter," +
                    $"wgh_weightRoll = @wgh_weightRoll," +
                    $"wgh_machineOperator = @wgh_machineOperator," +
                    $"wgh_net = @wgh_net," +
                    $"wgh_tare = @wgh_tare," +
                    $"wgh_gross = @wgh_gross" +
                    $" WHERE wgh_id = @wgh_id";

                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add(new SqlParameter("@wgh_employee", tbEmployeeSQL.emp_username));
                cmd.Parameters.Add(new SqlParameter("@wgh_GVID", MRP.id));
                cmd.Parameters.Add(new SqlParameter("@wgh_GVNAME", MRP.name));
                cmd.Parameters.Add(new SqlParameter("@wgh_po", wgh_po));
                cmd.Parameters.Add(new SqlParameter("@wgh_county", wgh_county));
                cmd.Parameters.Add(new SqlParameter("@wgh_type", wgh_type));
                cmd.Parameters.Add(new SqlParameter("@wgh_side", wgh_side));
                cmd.Parameters.Add(new SqlParameter("@wgh_weightPaper", wgh_weightPaper));
                cmd.Parameters.Add(new SqlParameter("@wgh_boxNum", wgh_boxNum));
                cmd.Parameters.Add(new SqlParameter("@wgh_weightCore", wgh_weightCore));
                cmd.Parameters.Add(new SqlParameter("@wgh_joint", wgh_joint));
                cmd.Parameters.Add(new SqlParameter("@wgh_numMeter", wgh_numMeter));
                cmd.Parameters.Add(new SqlParameter("@wgh_weightRoll", wgh_weightRoll));
                cmd.Parameters.Add(new SqlParameter("@wgh_machineOperator", wgh_machineOperator));
                cmd.Parameters.Add(new SqlParameter("@wgh_net", wgh_net));
                cmd.Parameters.Add(new SqlParameter("@wgh_tare", wgh_tare));
                cmd.Parameters.Add(new SqlParameter("@wgh_gross", wgh_gross));
                cmd.Parameters.Add(new SqlParameter("@wgh_id", id));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

        public static bool UPDATE_STATUS(int id)
        {
            try
            {
                sql = $"UPDATE {tbName} SET wgh_statusOdoo = 1 WHERE wgh_id = {id}";
                cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

        public static bool UPDATE_SEQ(int id, string wgh_seq)
        {
            try
            {
                sql = $"UPDATE {tbName}" +
                    $" SET wgh_seq = @wgh_seq " +
                    " WHERE wgh_id = @wgh_id";


                cmd = new SqlCommand(sql, con);

                cmd.Parameters.Add(new SqlParameter("@wgh_seq", wgh_seq));
                cmd.Parameters.Add(new SqlParameter("@wgh_id", id));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

        #endregion

        #region DELETE
        public static bool DELETE_DATA(int wgh_id)
        {
            try
            {
                sql = $"DELETE FROM {tbName} WHERE wgh_id = @wgh_id";

                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add(new SqlParameter("@wgh_id", wgh_id));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }
        #endregion









    }
}
