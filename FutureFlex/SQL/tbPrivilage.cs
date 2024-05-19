using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace FutureFlex.SQL
{
    internal class tbPrivilage
    {

        public static List<string> menuPrivilage { get; set; } = new List<string>();
        public static class weight
        {
            public static string edit = "False";
            public static string del = "False";
        }

        public static class history
        {
            public static string edit = "False";
            public static string del = "False";
        }

        public static class dev
        {
            public static string edit = "False";
            public static string del = "False";
        }

        public static class account
        {
            public static string add = "False";
            public static string edit = "False";
            public static string del = "False";
            public static string privilage = "False";
        }


        static string sqlstr; //////// Query ในการกระทำ SQL
        static SqlCommand cmd;
        static SqlDataAdapter da;
        static DataTable tb;



        #region SELECT

        /// <summary>
        /// สำหรับเช็ค สิทธืทุกเมนูเมื่อ login
        /// </summary>
        /// <param name="employeeID">username</param>
        /// <returns></returns>
        public static bool CheckPrivilage(string employeeID)
        {
            try
            {
                menuPrivilage.Clear();

                if (employeeID == "sa")
                {
                    menuPrivilage.Add("weight");
                    weight.del = "True";
                    weight.edit = "True";

                    menuPrivilage.Add("reprintJIT");
                    menuPrivilage.Add("history");
                    history.del = "True";
                    history.edit = "True";

                    menuPrivilage.Add("account");
                    account.add = "True";
                    account.del = "True";
                    account.edit = "True";
                    account.privilage = "True";
                    menuPrivilage.Add("setting");
                    menuPrivilage.Add("privilage");
                    menuPrivilage.Add("dev");

                    return true;
                }

                sqlstr = $"SELECT * FROM tbPrivilage WHERE pri_employeeID = '{employeeID}'";
                da = new SqlDataAdapter(sqlstr, server.con);
                tb = new DataTable();
                da.Fill(tb);

                // ดึงข้อมูลเพื่อกำหนดสิทธิ์การใช้งาน
                foreach (DataRow rw in tb.Rows)
                {
                    string menu = rw["pri_menu"].ToString();
                    string add = rw["pri_add"].ToString();
                    string del = rw["pri_del"].ToString();
                    string edit = rw["pri_edit"].ToString();
                    switch (menu)
                    {
                        case "weight":
                            menuPrivilage.Add("weight");
                            weight.del = del;
                            weight.edit = edit;
                            break;
                        case "reprintJIT":
                            menuPrivilage.Add("reprintJIT");
                            break;
                        case "history":
                            menuPrivilage.Add("history");
                            history.del = del;
                            history.edit = edit;
                            break;
                        case "account":
                            menuPrivilage.Add("account");
                            account.add = add;
                            account.del = del;
                            account.edit = edit;
                            break;
                        case "setting":
                            menuPrivilage.Add("setting");
                            break;
                        case "privilage":
                            menuPrivilage.Add("privilage");
                            break;
                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }



        /// <summary>
        /// สำหรับเช็ค สิทธิ์เฉพาะเมนู สำหรับหน้ากำหนดสิทธื
        /// </summary>
        /// <param name="employeeID">username</param>
        /// <param name="menuName">เมนู</param>
        /// <returns></returns>
        public static DataTable CheckPrivilageMenu(string employeeID, string menuName)
        {
            try
            {
                sqlstr = $"SELECT * FROM tbPrivilage WHERE pri_employeeID  = '{employeeID}' and pri_menu = '{menuName}'";
                da = new SqlDataAdapter(sqlstr, server.con);
                tb = new DataTable();
                da.Fill(tb);
            }
            catch (System.Exception)
            {
                return tb;
            }
            return tb;
        }
        #endregion

        #region INSERT
        public static bool INSERT(string employeeID, string menuName, string pri_add, string pri_del, string pri_edit)
        {
            try
            {
                sqlstr = "INSERT INTO tbPrivilage (pri_employeeID,pri_menu,pri_add,pri_del,pri_edit)" +
                    "VALUES(@pri_employeeID,@pri_menu,@pri_add,@pri_del,@pri_edit)";

                cmd = new SqlCommand(sqlstr, server.con);
                cmd.Parameters.Add(new SqlParameter("@pri_employeeID", employeeID));
                cmd.Parameters.Add(new SqlParameter("@pri_menu", menuName));
                cmd.Parameters.Add(new SqlParameter("@pri_add", pri_add));
                cmd.Parameters.Add(new SqlParameter("@pri_del", pri_del));
                cmd.Parameters.Add(new SqlParameter("@pri_edit", pri_edit));
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }
        #endregion

        #region UPDATE

        #endregion

        #region DELETE
        public static bool DELETE(string employeeID)
        {
            try
            {
                sqlstr = $"DELETE FROM tbPrivilage WHERE pri_employeeID ='{employeeID}'";
                cmd = new SqlCommand(sqlstr, server.con);
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }
        #endregion



    }
}
