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
            public static string edit = "false";
            public static string del = "false";
        }

        public static class history
        {
            public static string edit = "false";
            public static string del = "false";
        }

        public static class dev
        {
            public static string edit = "false";
            public static string del = "false";
        }


        static string sqlstr; //////// Query ในการกระทำ SQL
        static SqlCommand cmd;
        static SqlDataAdapter da;
        static DataTable tb;



        #region SELECT
        public static bool CheckPrivilage(string employeeID)
        {
            try
            {
                menuPrivilage.Clear();

                if (employeeID == "sa")
                {
                    menuPrivilage.Add("weight");
                    weight.del = "true";
                    weight.edit = "true";

                    menuPrivilage.Add("reprintJIT");
                    menuPrivilage.Add("history");
                    history.del = "true";
                    history.edit = "true";

                    menuPrivilage.Add("privilage");
                    menuPrivilage.Add("setting");
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
                            break;
                        case "setting":
                            menuPrivilage.Add("setting");
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

        #endregion

        #region INSERT
        public static bool INSERT(string employeeID, string menuName, string pri_del, string pri_edit)
        {
            try
            {
                sqlstr = "INSERT INTO tbPrivilage (pri_employeeID,pri_menu,pri_del,pri_edit)" +
                    "VALUES(@pri_employeeID,@pri_menu,@pri_del,@pri_edit)";

                cmd = new SqlCommand(sqlstr, server.con);
                cmd.Parameters.Add(new SqlParameter("@pri_employeeID", employeeID));
                cmd.Parameters.Add(new SqlParameter("@pri_menu", menuName));
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
