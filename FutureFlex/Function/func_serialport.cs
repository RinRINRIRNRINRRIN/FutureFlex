using System.Configuration;
namespace FutureFlex.Function
{
    internal class func_serialport
    {

        public static string COM_SCALE
        {
            get { return COM_SCALE; }
            set { value = ConfigurationManager.AppSettings["WGH_COM"]; }
        }
        public static int BAUDRATE_SCALE
        {
            get { return BAUDRATE_SCALE; }
            set { value = int.Parse(ConfigurationManager.AppSettings["WGH_BAUDRATE"]); }
        }

        public static string COM_SCANNER
        {
            get { return COM_SCANNER; }
            set { value = ConfigurationManager.AppSettings["SCN_COM"]; }
        }

        public static int BAUDRATE_SCANNER
        {
            get { return BAUDRATE_SCANNER; }
            set { value = int.Parse(ConfigurationManager.AppSettings["SCN_BAUDRATE"]); }
        }

    }

}
}
