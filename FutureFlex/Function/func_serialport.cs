using System.Configuration;
namespace FutureFlex.Function
{
    internal class func_serialport
    {

        public static string COM_SCALE
        {
            get { return ConfigurationManager.AppSettings["WGH_COM"]; }
        }
        public static int BAUDRATE_SCALE
        {
            get { return int.Parse(ConfigurationManager.AppSettings["WGH_BAUDRATE"]); }
        }

        public static string COM_SCANNER
        {
            get { return ConfigurationManager.AppSettings["SCN_COM"]; }
        }

        public static int BAUDRATE_SCANNER
        {
            get { return int.Parse(ConfigurationManager.AppSettings["SCN_BAUDRATE"]); }
        }
    }
}
