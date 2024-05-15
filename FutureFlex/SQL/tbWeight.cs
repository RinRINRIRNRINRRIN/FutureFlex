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

        public static DataTable SELECT_SEARCH(string po)
        {
            try
            {
                sql = $"SELECT wgh_id,wgh_seq,wgh_county,wgh_type,wgh_side,wgh_net,wgh_tare,wgh_gross,wgh_employee FROM {tbName} WHERE wgh_GVID = {MRP.id} and wgh_po = '{po}' ORDER BY wgh_id DESC";
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
                Console.WriteLine(ex.Message);
                return tb;
            }
            return tb;
        }

        #endregion

        #region INSERT

        public static bool INSERT_ALL_DATA(string wgh_po, string wgh_county, string wgh_type, string wgh_side, decimal wgh_weightPaper, int wgh_boxNum, decimal wgh_weightCore, int wgh_joint, decimal wgh_numMeter, decimal wgh_weightRoll, string wgh_machineOperator, decimal wgh_net, decimal wgh_tare, decimal wgh_gross, string wgh_lot, string wgh_boxSeq)
        {
            try
            {
                sql = $"INSERT INTO {tbName} (wgh_dateTime,wgh_employee,wgh_GVID,wgh_GVNAME,wgh_po,wgh_county,wgh_type,wgh_side,wgh_weightPaper,wgh_boxNum,wgh_weightCore,wgh_joint,wgh_numMeter,wgh_weightRoll,wgh_machineOperator,wgh_net,wgh_tare,wgh_gross,wgh_statusOdoo,wgh_lot,wgh_seq)" +
                    $"                 VALUES(CURRENT_TIMESTAMP,@wgh_employee,@wgh_GVID,@wgh_GVNAME,@wgh_po,@wgh_county,@wgh_type,@wgh_side,@wgh_weightPaper,@wgh_boxNum,@wgh_weightCore,@wgh_joint,@wgh_numMeter,@wgh_weightRoll,@wgh_machineOperator,@wgh_net,@wgh_tare,@wgh_gross,0,@wgh_lot,@wgh_seq)";

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
                cmd.Parameters.Add(new SqlParameter("@wgh_lot", wgh_gross));
                cmd.Parameters.Add(new SqlParameter("@wgh_seq", wgh_boxSeq));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
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
