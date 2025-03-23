using Serilog;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace FutureFlex.SQL
{
    public class server
    {

        public static string serverLocal = ConfigurationManager.AppSettings["SERVER_LOCAL"];
        static string port = ConfigurationManager.AppSettings["PORT_LOCAL"];
        static string user = ConfigurationManager.AppSettings["USER_LOCAL"];
        static string pass = ConfigurationManager.AppSettings["PASS_LOCAL"];
        static string db = ConfigurationManager.AppSettings["DB_LOCAL"];
        public static string ERR { get; set; }
        public static SqlConnection con = new SqlConnection();


        public static async Task<bool> ConnectDatabase()
        {
            try
            {
                con = new SqlConnection($"Server={serverLocal},{port};Database={db};User Id={user};Password={pass};");
                await con.OpenAsync();
            }
            catch (System.Exception ex)
            {
                Log.Error($"ConnectDatabase {ex.Message}");
                Console.WriteLine($"ConnectDatabase {ex.Message}");
                return false;
            }
            return true;
        }

    }
}
