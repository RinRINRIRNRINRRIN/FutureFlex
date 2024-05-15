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
        public static string emp_username { get; set; }
        public static string emp_name { get; set; }

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

        public static bool LOGIN(string username, string password)   /////// ใช้ในการ LOGIN frmLogin
        {
            try
            {
                sqlstr = "SELECT * FROM tbEmployee WHERE emp_username = '" + username + "' AND emp_username = '" + password + "'";
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
                            emp_username = Convert.ToString(rw["emp_username"]);
                            emp_name = Convert.ToString(rw["emp_name"]);
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
                MainFun.LogsSend(2, ex.ToString());
                return false;
            }
            MainFun.LogsSend(3, "Not found user");
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
        public bool INSERTDATA(string emp_name, string emp_username, string emp_password)
        {
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
        public bool UPDATE_ALL_DATA(string emp_name, string emp_username, string emp_password, string old_username)
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
        #endregion

        #region "GETDATA"


        #endregion

    }
}
