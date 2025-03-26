using FutureFlex.Models;
using Serilog;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
namespace FutureFlex.SQL
{
    public class tbEmployeeSQL
    {

        static string sqlstr; //////// Query ในการกระทำ SQL

        static SqlCommand cmd;
        static SqlDataAdapter da;
        static DataTable tb;

        public static string ERR { get; set; }

        #region "SELECTDATA"
        /// <summary>
        /// นำข้อมูลที่ได้ออกไปโชวร์ที่  frmUserControls
        /// </summary>
        /// <returns></returns>
        public static DataTable SELECTDATA()
        {
            try
            {
                sqlstr = "SELECT * FROM tbEmployee";
                da = new SqlDataAdapter(sqlstr, server.con);
                tb = new DataTable();
                da.Fill(tb);
            }
            catch (Exception ex)
            {

                Log.Error($"tbEmployee SELECTDATA {ex.Message}");
                return tb;
            }

            return tb;
        }


        /// <summary>
        /// สำหรับเกียวกับ ค้นหาข้อมูล
        /// </summary>
        /// <param name="column">Column ที่ต้องการจะค้นหา</param>
        /// <param name="value">Value ที่ต้องการ</param>
        /// <returns></returns>
        public static DataTable SEARCH_DATA(string column, string value)
        {
            try
            {
                sqlstr = $"SELECT * FROM tbEmployee WHERE {column} LIKE '%{value}%'";
                da = new SqlDataAdapter(sqlstr, server.con);
                tb = new DataTable();
                da.Fill(tb);
            }
            catch (Exception)
            {
                return tb;
            }
            return tb;
        }

        public static bool LOGIN(string username, string password)   /////// ใช้ในการ LOGIN frmLogin
        {
            try
            {
                sqlstr = "SELECT * FROM tbEmployee WHERE emp_username = '" + username + "' AND emp_password = '" + password + "'";
                da = new SqlDataAdapter(sqlstr, server.con);
                tb = new DataTable();
                da.Fill(tb);

                if (tb.Rows.Count == 0) { return false; }
                else
                {
                    // เอาข้อมูลมาเก็บที่ prop
                    foreach (DataRow rw in tb.Rows)
                    {
                        if (username == Convert.ToString(rw["emp_username"]) && password == Convert.ToString(rw["emp_password"]))
                        {
                            EmployeeModel.emp_username = Convert.ToString(rw["emp_username"]);
                            EmployeeModel.emp_name = Convert.ToString(rw["emp_name"]);
                            EmployeeModel.emp_password = Convert.ToString(rw["emp_password"]);
                        }
                    }

                    // เช็คสิทธิ์การใช้งานโปรแกรม
                    if (!tbPrivilage.CheckPrivilage(username))
                    {
                        return false;
                    }

                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                return false;
            }
            Log.Information($"Login success {EmployeeModel.emp_name}");
            return true;
        }
        #endregion

        #region "INSERTDATA"
        /// <summary>
        /// 
        /// </summary>
        /// <param name="emp_name"></param>
        /// <param name="emp_username"></param>
        /// <param name="emp_password"></param>
        /// <param name="position"></param>
        /// <returns></returns>
        public static bool INSERTDATA(string emp_name, string emp_username, string emp_password)
        {

            DataTable tb = SEARCH_DATA("emp_username", emp_username);

            // ตรวจสอบว่ามี username ซ้ำหรือไม่
            if (tb.Rows.Count != 0)
            {
                ERR = "พบข้อมูล username ในระบบมีอยู่แล้ว";
                return false;
            }

            sqlstr = "INSERT INTO tbEmployee" +
                " (emp_username,emp_password,emp_name,emp_status)" +
                " VALUES (@emp_username,@emp_password,@emp_name,@emp_status)";
            try
            {
                cmd = new SqlCommand(sqlstr, server.con);
                cmd.Parameters.Add(new SqlParameter("@emp_username", emp_username));
                cmd.Parameters.Add(new SqlParameter("@emp_password", emp_password));
                cmd.Parameters.Add(new SqlParameter("@emp_name", emp_name));
                cmd.Parameters.Add(new SqlParameter("@emp_status", 1));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                ERR = ex.Message;
                return false;
            }

            return true;
        }
        #endregion

        #region "UPDATEDATA"
        /// <summary>
        /// 
        /// </summary>
        /// <param name="emp_name"></param>
        /// <param name="emp_username"></param>
        /// <param name="emp_password"></param>
        /// <param name="old_userame"></param>
        /// <returns></returns>
        public static bool UPDATE(string emp_name, string emp_username, string emp_password, string old_username)
        {
            try
            {
                sqlstr = "UPDATE tbEmployee" +
                    " SET emp_username = @emp_username," +
                    " emp_password = @emp_password," +
                    " emp_name = @emp_name," +
                    " emp_status = @emp_status" +
                    " WHERE emp_username = @old_emp_username";

                cmd = new SqlCommand(sqlstr, server.con);
                cmd.Parameters.Add(new SqlParameter("@emp_username", emp_username));
                cmd.Parameters.Add(new SqlParameter("@emp_password", emp_password));
                cmd.Parameters.Add(new SqlParameter("@emp_name", emp_name));
                cmd.Parameters.Add(new SqlParameter("@emp_status", 1));
                cmd.Parameters.Add(new SqlParameter("@old_emp_username", old_username));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            return true;
        }
        #endregion

        #region "DELETEDATA"

        public static bool DELETE(string emp_username)
        {
            try
            {
                sqlstr = "DELETE FROM tbEmployee WHERE emp_username = @emp_username";
                cmd = new SqlCommand(sqlstr, server.con);
                cmd.Parameters.Add(new SqlParameter("@emp_username", emp_username));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                ERR = ex.Message;
                return false;
            }
            return true;
        }


        #endregion

    }
}
