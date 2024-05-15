using System.Configuration;
using System.Diagnostics;
using System.IO.Ports;

namespace FutureFlex.Function
{
    public class Function
    {

        /// <summary>
        /// สำหรับเช็คว่าโปรแกมมีเปิดซ้ำไหม
        /// </summary>
        /// <returns></returns>
        public static bool CHECK_PROGRAM()
        {
            try
            {
                Process[] a = Process.GetProcessesByName("FutureFlex");

                if (a.Length > 1)
                {
                    return false;
                }
            }
            catch (System.Exception ex)
            {

                return false;
            }
            return true;
        }


        public static string RS232(SerialPort sa)
        {
            string d = "";
            string device = ConfigurationManager.AppSettings["DEVICE"];

            switch (device)
            {
                case "DI81":
                    string data = sa.ReadLine();        //// นำค่าที่ได้จาก RS232 มาเก็บไว้ในตัวแปร

                    string[] value = data.Split('\r');
                    //Console.WriteLine("GROSS WEIGHT " + value[4].Substring(12).Trim());
                    //Console.WriteLine("NET WEIGHT " + value[5].Substring(10).Trim());
                    //Console.WriteLine("TARE " + value[6].Substring(4).Trim());

                    string net = value[5].Substring(10).Trim();
                    string tare = value[6].Substring(4).Trim();
                    string gross = value[4].Substring(12).Trim();

                    d = $"{net}|{tare}|{gross}";
                    break;
                case "DFWLB-SN405":

                    break;
                case "DFWL-SN405":

                    break;
            }
            return d;
        }

    }
}
