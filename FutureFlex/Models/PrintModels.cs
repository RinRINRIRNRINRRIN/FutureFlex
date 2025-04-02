using System.Windows.Forms;

namespace FutureFlex.Models
{
    internal class PrintModels
    {


        /// <summary>
        /// ประเภท กล่อง,ม้วน
        /// </summary>
        public static string Types { get; set; }
        /// <summary>
        /// ลำดัล
        /// </summary>
        public static int _seq { get; set; }
        /// <summary>
        /// น้ำหนักสุทธิ
        /// </summary>
        public static double _net { get; set; }
        /// <summary>
        /// จำนวนกล่องทั้งหมด
        /// </summary>
        public static int _numBox { get; set; }
        /// <summary>
        /// จำนวนม้วนทั้งหมด
        /// </summary>
        public static int _numRoll { get; set; }
        /// <summary>
        /// จำนวนเมตร
        /// </summary>
        public static double _numMeter { get; set; }
        /// <summary>
        /// จำนวนใบของกล่อง
        /// </summary>
        public static int _pchBox { get; set; }
        /// <summary>
        /// จำนวนใบม้วน
        /// </summary>
        public static int _pchRoll { get; set; }
        /// <summary>
        /// น้ำหนักกระดาษ
        /// </summary>
        public static double _wghPaper { get; set; }
        /// <summary>
        /// น้ำหนักแกน
        /// </summary>
        public static double _wghCore { get; set; }
        /// <summary>
        /// รูปภาพ
        /// </summary>
        public static PictureBox pictureBox1 { get; set; }
        /// <summary>
        /// คนคุมเครื่อง
        /// </summary>
        public static string _operator { get; set; }

        /// <summary>
        /// สำหรับกำหนดค่าว่าจะปร้ินแบบใบใหญ่หรือใบเล็ก (po = ใบใหญ่ , JIT = ใบเล็ก)
        /// </summary>
        public static string printType { get; set; }

        /// <summary>
        /// เลขที่ lot
        /// </summary>
        public static string _lot { get; set; }


        public static void ClearProp()
        {
            Types = null;
            _seq = 0;
            _net = 0;
            _numBox = 0;
            _numRoll = 0;
            _numMeter = 0;
            _pchBox = 0;
            _wghPaper = 0;
            _wghCore = 0;
            _operator = null;
            _lot = null;

        }
    }
}
