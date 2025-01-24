using System.Diagnostics;

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
    }
}
