using FutureFlex.API;
using FutureFlex.SQL;
using Serilog;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Printing;
using System.Windows.Forms;
using ZXing;

namespace FutureFlex.Function
{
    internal class func_print
    {
        /// <summary>
        /// ประเภท
        /// </summary>
        public static string _statusType { get; set; }
        /// <summary>
        /// ลำดัล
        /// </summary>
        public static string _seq { get; set; }
        /// <summary>
        /// น้ำหนักสุทธิ
        /// </summary>
        public static string _net { get; set; }
        /// <summary>
        /// จำนวนกล่องทั้งหมด
        /// </summary>
        public static string _numBox { get; set; }
        /// <summary>
        /// จำนวนม้วนทั้งหมด
        /// </summary>
        public static string _numRoll { get; set; }
        /// <summary>
        /// จำนวนม
        /// </summary>
        public static string _numMeter { get; set; }
        /// <summary>
        /// จำนวนใบของกล่อง
        /// </summary>
        public static string _pchBox { get; set; }
        /// <summary>
        /// จำนวนใบของกล่อง
        /// </summary>
        public static string _pchRoll { get; set; }
        /// <summary>
        /// น้ำหนักกระดาษ
        /// </summary>
        public static string _wghPaper { get; set; }
        /// <summary>
        /// น้ำหนักแกน
        /// </summary>
        public static string _wghCore { get; set; }
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

        public static string ERR { get; set; }

        /// <summary>
        /// สำหรับการพิมพ์
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool FormatPrint(PrintPageEventArgs e)
        {
            Log.Information($"==================================================== Print data : {tbWeightDetail.PO}");
            try
            {
                Font fontHeader;
                Font fontHead;
                Font fontDetail;
                // Create __seq
                if (printType != "JIT")
                {
                    if (_statusType == "box")
                    {
                        _seq = $"{_seq}/{_numBox}";
                    }

                    if (_statusType == "roll")
                    {
                        _seq = $"{_seq}/{_numRoll}";
                    }
                }

                string[] sep_p = _seq.Split('/');
                if (sep_p.Length == 3)
                {
                    _seq = $"{sep_p[0]}/{sep_p[1]}";
                }

                Log.Information($"SEQ : {_seq}");
                Log.Information($"customer_product_code : {MRP.customer_product_code}");
                Log.Information($"default_code : {MRP.default_code}");
                Log.Information($"product_name : {MRP.product_name}");
                Log.Information($"lot : {_lot}");
                Log.Information($"Stauts Type : {_statusType}");


                if (printType == "JIT") // JIT
                {
                    fontHeader = new Font("Tahoma", 10, System.Drawing.FontStyle.Bold);
                    fontHead = new Font("Tahoma", 8, System.Drawing.FontStyle.Bold);
                    fontDetail = new Font("Tahoma", 7, System.Drawing.FontStyle.Regular);

                    #region Header
                    e.Graphics.DrawImage(pictureBox1.Image, 0, 5, 30, 30);
                    e.Graphics.DrawString("FUTURE FLEX CO.,LTD", fontHeader, Brushes.Black, new System.Drawing.Point(30, 15));
                    #endregion

                    #region Body
                    e.Graphics.DrawString($"[รหัสสินค้า] : ___________________________________________ ", fontHead, Brushes.Black, new System.Drawing.Point(0, 70));
                    e.Graphics.DrawString($"{MRP.customer_product_code}", fontDetail, Brushes.Black, new System.Drawing.Point(80, 70));
                    e.Graphics.DrawString($"[สินค้า] : ___________________________________________ ", fontHead, Brushes.Black, new System.Drawing.Point(0, 35));
                    string defualtCodeWithProductname = $"{MRP.default_code} {MRP.product_name}";
                    int defualtCodeWithProductnameLength = defualtCodeWithProductname.Length;

                    if (defualtCodeWithProductname.Length >= 28)
                    {
                        e.Graphics.DrawString($"{defualtCodeWithProductname.Substring(0, 28)}", fontDetail, Brushes.Black, new System.Drawing.Point(50, 35));
                        int total = defualtCodeWithProductname.Length - 28;
                        e.Graphics.DrawString($"{defualtCodeWithProductname.Substring(28, total)}", fontDetail, Brushes.Black, new System.Drawing.Point(0, 50));
                        e.Graphics.DrawString($"___________________________________________ ", fontHead, Brushes.Black, new System.Drawing.Point(0, 50));

                    }
                    else
                    {
                        e.Graphics.DrawString($"{defualtCodeWithProductname}", fontDetail, Brushes.Black, new System.Drawing.Point(50, 35));

                    }
                    e.Graphics.DrawString($"{_lot}                  ", fontDetail, Brushes.Black, new System.Drawing.Point(0, 90));


                    switch (_statusType) // เช็คว่าผู้ใช้เลือกการชั่งแบบ กล่องหรือม้วน
                    {
                        case "box":
                            Log.Information($"จำนวนใบ : {_pchBox} (double)");
                            Log.Information($"Net : {_net} (double)");
                            Log.Information($"MFG : {DateTime.Now.ToString("dd/MM/yyyy")}");
                            e.Graphics.DrawString($"NO :  {_seq}", fontDetail, Brushes.Black, new System.Drawing.Point(135, 3));
                            e.Graphics.DrawString($"[จำนวน]________ใบ.", fontHead, Brushes.Black, new System.Drawing.Point(0, 110));
                            e.Graphics.DrawString($"{int.Parse(_pchBox).ToString("#,###")}", fontDetail, Brushes.Black, new System.Drawing.Point(50, 110));
                            e.Graphics.DrawString($"____________kg.", fontHead, Brushes.Black, new System.Drawing.Point(0, 130));
                            e.Graphics.DrawString($"{double.Parse(_net).ToString("#,###.00")}", fontDetail, Brushes.Black, new System.Drawing.Point(10, 130));
                            e.Graphics.DrawString($"[MFG] : ______________________", fontHead, Brushes.Black, new System.Drawing.Point(0, 160));
                            e.Graphics.DrawString($"{DateTime.Now.ToString("dd/MM/yyyy")}", fontDetail, Brushes.Black, new System.Drawing.Point(50, 160));
                            break;   //กรณีเลือกกล่อง
                        case "roll":
                            Log.Information($"จำนวนม : {_numMeter} (double)");
                            Log.Information($"ใบ : {_pchRoll} (int)");
                            Log.Information($"Net : {_net} (double)");
                            Log.Information($"MFG : {DateTime.Now.ToString("dd/MM/yyyy")}");
                            e.Graphics.DrawString($"NO :  {_seq}", fontDetail, Brushes.Black, new System.Drawing.Point(135, 3));
                            e.Graphics.DrawString($"[จำนวน]________ม.", fontHead, Brushes.Black, new System.Drawing.Point(0, 110));
                            e.Graphics.DrawString($"{double.Parse(_numMeter).ToString("#,###.00")}", fontDetail, Brushes.Black, new System.Drawing.Point(50, 110));
                            e.Graphics.DrawString($"_____________ใบ", fontHead, Brushes.Black, new System.Drawing.Point(0, 125));
                            e.Graphics.DrawString($"{int.Parse(_pchRoll).ToString("#,###")}", fontDetail, Brushes.Black, new System.Drawing.Point(30, 125));
                            e.Graphics.DrawString($"_____________kg.", fontHead, Brushes.Black, new System.Drawing.Point(0, 140));
                            e.Graphics.DrawString($"{double.Parse(_net).ToString("#,###.00")} ", fontDetail, Brushes.Black, new System.Drawing.Point(30, 140));
                            e.Graphics.DrawString($"[MFG] : ______________________", fontHead, Brushes.Black, new System.Drawing.Point(0, 160));
                            e.Graphics.DrawString($"{DateTime.Now.ToString("dd/MM/yyyy")}", fontDetail, Brushes.Black, new System.Drawing.Point(50, 160));
                            break;  //กรณีเลือกม้วน  
                    }
                    #endregion

                    // ตั้งค่า Format Barcode
                    BarcodeWriter writer = new BarcodeWriter()
                    {
                        Format = BarcodeFormat.QR_CODE
                    };

                    PictureBox pictureBox = new PictureBox()
                    {
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };
                    // Generage QR Code
                    pictureBox.Image = writer.Write($"{_lot}");
                    e.Graphics.DrawImage(pictureBox.Image, 115, 100, 80, 80);

                    string barCodeStr = $"{_lot}";
                    e.Graphics.DrawString(barCodeStr, fontHead, Brushes.Black, new System.Drawing.Point(180, 270));
                    e.Graphics.DrawString("FM-DL-012 Rev.0", fontDetail, Brushes.Black, new System.Drawing.Point(0, 180));
                }
                else // แบบมี PO
                {
                    fontHeader = new Font("Tahoma", 14, System.Drawing.FontStyle.Bold);
                    fontHead = new Font("Tahoma", 8, System.Drawing.FontStyle.Bold);
                    fontDetail = new Font("Tahoma", 8, System.Drawing.FontStyle.Regular);

                    #region Header
                    e.Graphics.DrawImage(pictureBox1.Image, 5, -3, 30, 30);
                    e.Graphics.DrawString("FUTURE FLEX CO.,LTD", fontHeader, Brushes.Black, new System.Drawing.Point(60, 3));
                    e.Graphics.DrawString($"NO : {_seq}", new Font("Tahoma", 12, System.Drawing.FontStyle.Regular), Brushes.Black, new System.Drawing.Point(290, 5));
                    #endregion

                    #region Body
                    string defaultPlusProductName = $"{MRP.default_code} {MRP.product_name}";
                    if (defaultPlusProductName.Length > 53)
                    {
                        e.Graphics.DrawString($"[สินค้า] : __________________________________________________________________________________________________________", fontHead, Brushes.Black, new System.Drawing.Point(5, 40));
                        e.Graphics.DrawString($"{defaultPlusProductName.Substring(0, 53)} ", fontDetail, Brushes.Black, new System.Drawing.Point(70, 40));
                        e.Graphics.DrawString($"__________________________________________________________________________________________________________________", fontHead, Brushes.Black, new System.Drawing.Point(5, 55));
                        e.Graphics.DrawString($"{defaultPlusProductName.Substring(53, defaultPlusProductName.Length - 53)} ", fontDetail, Brushes.Black, new System.Drawing.Point(5, 55));
                    }
                    else
                    {
                        e.Graphics.DrawString($"[สินค้า] : __________________________________________________________________________________________________________", fontHead, Brushes.Black, new System.Drawing.Point(5, 55));
                        e.Graphics.DrawString($"{defaultPlusProductName} ", fontDetail, Brushes.Black, new System.Drawing.Point(70, 55));
                    }
                    e.Graphics.DrawString($"[รหัสสินค้า] : ___________________________________________________________________________________________________________ ", fontHead, Brushes.Black, new System.Drawing.Point(5, 73));
                    e.Graphics.DrawString($"{MRP.customer_product_code}", fontDetail, Brushes.Black, new System.Drawing.Point(90, 73));

                    Log.Information($"บริษัท : {MRP.partner_name}");
                    Log.Information($"ใบสั่งงาน : {MRP.name}");
                    Log.Information($"ใบสั่งซ์้อ : {tbWeightDetail.PO}");
                    Log.Information($"โครงสร้าง : {MRP.mo_film}");
                    Log.Information($"ขนาด : {MRP.mo_work}");
                    e.Graphics.DrawString($"[บริษัท] : ______________________________________________________________________________________________________", fontHead, Brushes.Black, new System.Drawing.Point(5, 91));
                    e.Graphics.DrawString($"{MRP.partner_name}", fontDetail, Brushes.Black, new System.Drawing.Point(70, 91));
                    e.Graphics.DrawString($"[ใบสั่งงาน] : ________________ [ใบสั่งซื้อ] : _______________________________________________________________________", fontHead, Brushes.Black, new System.Drawing.Point(5, 109));
                    e.Graphics.DrawString($"{MRP.name}                                  {MRP.mo_pono}", fontDetail, Brushes.Black, new System.Drawing.Point(80, 109));
                    e.Graphics.DrawString($"[โครงสร้าง] : ______________________________________________________________________________________________________", fontHead, Brushes.Black, new System.Drawing.Point(5, 127));
                    e.Graphics.DrawString($"{MRP.mo_film}", fontDetail, Brushes.Black, new System.Drawing.Point(90, 127));
                    e.Graphics.DrawString($"[ขนาด] :__________________________________", fontHead, Brushes.Black, new System.Drawing.Point(5, 145));
                    e.Graphics.DrawString($"{MRP.mo_work}", fontDetail, Brushes.Black, new System.Drawing.Point(60, 145));

                    switch (_statusType) // เช็คว่าผู้ใช้เลือกการชั่งแบบ กล่องหรือม้วน
                    {
                        case "box":
                            Log.Information($"จำนวนใบ : {_pchBox} (int)");
                            Log.Information($"Net : {_net} ");
                            Log.Information($"วันเดือนปีที่ผลิต: {DateTime.Now.ToString("dd/MM/yyyy")} ");
                            Log.Information($"เจ้าหน้าที่คุมเครื่อง: {_operator} ");
                            e.Graphics.DrawString($"[จำนวน] :__________ใบ__________kg.", fontHead, Brushes.Black, new System.Drawing.Point(5, 163));
                            e.Graphics.DrawString($"{int.Parse(_pchBox).ToString("#,###.00")}               {_net}", fontDetail, Brushes.Black, new System.Drawing.Point(75, 163));
                            e.Graphics.DrawString($"[วันเดือนปีที่ผลิต] : ________________________", fontHead, Brushes.Black, new System.Drawing.Point(5, 181));
                            e.Graphics.DrawString($"{DateTime.Now.ToString("dd/MM/yyyy")}", fontDetail, Brushes.Black, new System.Drawing.Point(110, 181));
                            e.Graphics.DrawString($"[เจ้าหน้าที่คุมเครื่อง] : ______________________", fontHead, Brushes.Black, new System.Drawing.Point(5, 199));
                            e.Graphics.DrawString($"{_operator}", fontDetail, Brushes.Black, new System.Drawing.Point(130, 199));

                            break;   //กรณีเลือกกล่อง
                        case "roll":
                            Log.Information($"นน.กระดาษ/นน.พลาสติก : {_wghPaper} ");
                            Log.Information($"นน.แกน/นน.รวม : {_wghCore} ");
                            Log.Information($"จำนวนสุทธิ ม : {_numMeter} (double)");
                            Log.Information($"ใบ : {_pchRoll} (int)");
                            Log.Information($"วันเดือนปีที่ผลิต: {DateTime.Now.ToString("dd/MM/yyyy")} ");
                            Log.Information($"เจ้าหน้าที่คุมเครื่อง: {_operator} ");
                            e.Graphics.DrawString($"[นน.กระดาษ/นน.พลาสติก] :________________", fontHead, Brushes.Black, new System.Drawing.Point(5, 163));
                            e.Graphics.DrawString($"{_wghPaper}", fontDetail, Brushes.Black, new System.Drawing.Point(170, 163));
                            e.Graphics.DrawString($"[นน.แกน/นน.รวม] :______________________", fontHead, Brushes.Black, new System.Drawing.Point(5, 181));
                            e.Graphics.DrawString($"{_wghCore}", fontDetail, Brushes.Black, new System.Drawing.Point(120, 181));
                            e.Graphics.DrawString($"[จำนวนสุทธิ]", fontHead, Brushes.Black, new System.Drawing.Point(5, 199));
                            e.Graphics.DrawString($"{double.Parse(_numMeter).ToString("#,###.00")}", fontDetail, Brushes.Black, new System.Drawing.Point(75, 199));
                            e.Graphics.DrawString($"ม.", fontHead, Brushes.Black, new System.Drawing.Point(125, 199));
                            e.Graphics.DrawString($"{int.Parse(_pchRoll).ToString("#,###.00")}", fontDetail, Brushes.Black, new System.Drawing.Point(140, 199));
                            e.Graphics.DrawString($"ใบ", fontHead, Brushes.Black, new System.Drawing.Point(190, 199));
                            e.Graphics.DrawString($"{double.Parse(_net).ToString("#,###.00")}", fontDetail, Brushes.Black, new System.Drawing.Point(210, 199));
                            e.Graphics.DrawString($"kg.", fontHead, Brushes.Black, new System.Drawing.Point(250, 199));
                            e.Graphics.DrawString($"______    ________    ___________", fontHead, Brushes.Black, new System.Drawing.Point(75, 199));
                            e.Graphics.DrawString($"[วันเดือนปีที่ผลิต] : ______________________", fontHead, Brushes.Black, new System.Drawing.Point(5, 217));
                            e.Graphics.DrawString($"{DateTime.Now.ToString("dd/MM/yyyy")}", fontDetail, Brushes.Black, new System.Drawing.Point(130, 217));
                            e.Graphics.DrawString($"[เจ้าหน้าที่คุมเครื่อง] : ____________________", fontHead, Brushes.Black, new System.Drawing.Point(5, 235));
                            e.Graphics.DrawString($"{_operator}", fontDetail, Brushes.Black, new System.Drawing.Point(130, 235));

                            break;  //กรณีเลือกม้วน  
                    }
                    #endregion

                    #region Footer
                    // ตั้งค่า Format Barcode
                    BarcodeWriter writer = new BarcodeWriter()
                    {
                        Format = BarcodeFormat.QR_CODE
                    };

                    PictureBox pictureBox = new PictureBox()
                    {
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };
                    // Generage QR Code
                    pictureBox.Image = writer.Write($"{_lot}");
                    e.Graphics.DrawImage(pictureBox.Image, 275, 150, 120, 120);

                    string barCodeStr = $"{_lot}";
                    e.Graphics.DrawString(barCodeStr, fontHead, Brushes.Black, new System.Drawing.Point(180, 270));
                    e.Graphics.DrawString("FM-DL-003 REV.1", fontDetail, Brushes.Black, new System.Drawing.Point(5, 270));
                    #endregion
                }
            }
            catch (Exception ex)
            {
                Log.Error("FormatPrint : " + ex.Message);
                ERR = ex.Message;
                return false;
            }
            return true;
        }


        public static bool SetPrinter(PrintDocument printDocument, string mode)
        {
            try
            {
                Log.Information("==================================================== ตั้งค่ากระดาษ");
                int widthInHundredthsOfInch = 0;
                int heightInHundredthsOfInch = 0;
                PaperSize customPaperSize;

                if (mode == "JIT")
                {
                    // ปร้ินตามชื่อของปร้ินเตอร์
                    //printDocument.PrinterSettings.PrinterName = "ZEBRA_JIT";
                    //if (!CheckPrinterStatus("ZEBRA_JIT"))
                    //{
                    //    return false;
                    //}

                    // Convert millimeters to hundredths of an inch
                    widthInHundredthsOfInch = (int)(55 / 25.4 * 100);
                    heightInHundredthsOfInch = (int)(50 / 25.4 * 100);

                    // Create a custom paper size
                    customPaperSize = new PaperSize("Custom", widthInHundredthsOfInch, heightInHundredthsOfInch);
                    printDocument.DefaultPageSettings.PaperSize = customPaperSize;

                    Log.Information("- ผู้ใช้เลือกพิมพ์ข้อมูล 55*50");
                }
                else
                {
                    //printDocument.PrinterSettings.PrinterName = "ZEBRA_PO";
                    //if (!CheckPrinterStatus("ZEBRA_PO"))
                    //{
                    //    return false;
                    //}
                    // สำหรับเครื่อง TDP-247
                    // Convert millimeters to hundredths of an inch
                    //int widthInHundredthsOfInch = (int)(105 / 25.4 * 100);
                    //int heightInHundredthsOfInch = (int)(75 / 25.4 * 100);
                    // Convert millimeters to hundredths of an inch

                    // สำหรับเครื่อง Zebra
                    widthInHundredthsOfInch = (int)(75 / 25.4 * 100);
                    heightInHundredthsOfInch = (int)(101 / 25.4 * 100);

                    // Create a custom paper size
                    customPaperSize = new PaperSize("Custom", widthInHundredthsOfInch, heightInHundredthsOfInch);
                    printDocument.DefaultPageSettings.PaperSize = customPaperSize;
                    Log.Information("- ผู้ใช้เลือกพิมพ์ข้อมูล 100*75");
                }
            }
            catch (Exception ex)
            {
                Log.Error($"SetPrinter : {ex.Message}");
                return false;
            }

            return true;
        }




        static bool CheckPrinterStatus(string printerName)
        {
            bool isConnected = false;

            try
            {
                PrintServer printServer = new PrintServer();
                PrintQueue printQueue = printServer.GetPrintQueue(printerName);

                if (printQueue != null)
                {
                    isConnected = true;
                }
            }
            catch (PrintQueueException ex)
            {
                isConnected = false;
            }

            return isConnected;
        }
    }
}
