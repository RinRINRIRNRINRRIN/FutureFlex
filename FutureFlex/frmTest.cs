using Serilog;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using ZXing;
namespace FutureFlex
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void frmTest_Load(object sender, EventArgs e)
        {


        }

        string type = "";

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                Font fontHeader;
                Font fontHead;
                Font fontDetail;

                // Create __seq

                if (type == "JIT") // JIT
                {
                    fontHeader = new Font("Tahoma", 10, System.Drawing.FontStyle.Bold);
                    fontHead = new Font("Tahoma", 8, System.Drawing.FontStyle.Bold);
                    fontDetail = new Font("Tahoma", 7, System.Drawing.FontStyle.Regular);

                    #region Header
                    e.Graphics.DrawImage(pictureBox1.Image, 0, 5, 30, 30);
                    e.Graphics.DrawString("FUTURE FLEX CO.,LTD", fontHeader, Brushes.Black, new System.Drawing.Point(30, 15));
                    #endregion

                    #region Body
                    e.Graphics.DrawString($"[รหัสสินค้า] : ___________________________________________ ", fontHead, Brushes.Black, new System.Drawing.Point(0, 57));
                    e.Graphics.DrawString($"", fontDetail, Brushes.Black, new System.Drawing.Point(80, 57));
                    e.Graphics.DrawString($"[สินค้า] : ___________________________________________ ", fontHead, Brushes.Black, new System.Drawing.Point(0, 35));
                    e.Graphics.DrawString($"ARO 5 kg.ข้าวญี่ปุ่นสำหรับทำซูชิ", fontDetail, Brushes.Black, new System.Drawing.Point(50, 35));
                    e.Graphics.DrawString($"GV-67-07-0142250767092825", fontDetail, Brushes.Black, new System.Drawing.Point(0, 80));


                    e.Graphics.DrawString($"NO :  5", fontDetail, Brushes.Black, new System.Drawing.Point(135, 3));
                    e.Graphics.DrawString($"[จำนวน]_____ใบ.", fontHead, Brushes.Black, new System.Drawing.Point(0, 110));
                    e.Graphics.DrawString($"1", fontDetail, Brushes.Black, new System.Drawing.Point(50, 110));
                    e.Graphics.DrawString($"____________kg.", fontHead, Brushes.Black, new System.Drawing.Point(0, 130));
                    e.Graphics.DrawString($"10.00", fontDetail, Brushes.Black, new System.Drawing.Point(10, 130));

                    e.Graphics.DrawString($"[MFG] : ______________________", fontHead, Brushes.Black, new System.Drawing.Point(0, 160));
                    e.Graphics.DrawString($"{DateTime.Now.ToString("dd/MM/yyyy")}", fontDetail, Brushes.Black, new System.Drawing.Point(50, 160));

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
                    pictureBox.Image = writer.Write($"GV-67-07-0142250767092825");
                    e.Graphics.DrawImage(pictureBox.Image, 115, 100, 80, 80);

                    string barCodeStr = $"GV-67-07-0142250767092825";
                    e.Graphics.DrawString(barCodeStr, fontHead, Brushes.Black, new System.Drawing.Point(180, 270));
                    e.Graphics.DrawString("FM-DL-012 Rev.0", fontDetail, Brushes.Black, new System.Drawing.Point(0, 180));
                }
                else // แบบมี PO และ ไม่มี PO
                {
                    fontHeader = new Font("Tahoma", 14, System.Drawing.FontStyle.Bold);
                    fontHead = new Font("Tahoma", 8, System.Drawing.FontStyle.Bold);
                    fontDetail = new Font("Tahoma", 8, System.Drawing.FontStyle.Regular);

                    #region Header
                    e.Graphics.DrawImage(pictureBox1.Image, 5, -3, 50, 50);
                    e.Graphics.DrawString("FUTURE FLEX CO.,LTD", fontHeader, Brushes.Black, new System.Drawing.Point(60, 15));
                    e.Graphics.DrawString($"NO :1/10", new Font("Tahoma", 12, System.Drawing.FontStyle.Regular), Brushes.Black, new System.Drawing.Point(290, 5));
                    #endregion

                    #region Body
                    e.Graphics.DrawString($"[สินค้า] : __________________________________________________________________________________________________________", fontHead, Brushes.Black, new System.Drawing.Point(5, 55));
                    e.Graphics.DrawString($"ARO 5 kg.ข้าวญี่ปุ่นสำหรับทำซูชิ", fontDetail, Brushes.Black, new System.Drawing.Point(70, 55));
                    e.Graphics.DrawString($"[รหัสสินค้า] : ___________________________________________________________________________________________________________ ", fontHead, Brushes.Black, new System.Drawing.Point(5, 73));
                    e.Graphics.DrawString($"PDRJARS05K", fontDetail, Brushes.Black, new System.Drawing.Point(90, 73));


                    e.Graphics.DrawString($"[บริษัท] : ______________________________________________________________________________________________________", fontHead, Brushes.Black, new System.Drawing.Point(5, 91));
                    e.Graphics.DrawString($"บริษัท อุทัยโปรดิวส์ จำกัด (สาขา 00001)", fontDetail, Brushes.Black, new System.Drawing.Point(70, 91));
                    e.Graphics.DrawString($"[ใบสั่งงาน] : ________________ [ใบสั่งซื้อ] : _______________________________________________________________________", fontHead, Brushes.Black, new System.Drawing.Point(5, 109));
                    e.Graphics.DrawString($"GV-67-07-0160                                  62030", fontDetail, Brushes.Black, new System.Drawing.Point(80, 109));
                    e.Graphics.DrawString($"[โครงสร้าง] : ______________________________________________________________________________________________________", fontHead, Brushes.Black, new System.Drawing.Point(5, 127));
                    e.Graphics.DrawString($"ซิล 3 ด้าน + ซิลโค้ง 2 มุมบน VACUUM", fontDetail, Brushes.Black, new System.Drawing.Point(90, 127));
                    e.Graphics.DrawString($"[ขนาด] :________________________", fontHead, Brushes.Black, new System.Drawing.Point(5, 145));
                    e.Graphics.DrawString($"200 X 300 mm.", fontDetail, Brushes.Black, new System.Drawing.Point(60, 145));

                    e.Graphics.DrawString($"[จำนวน] :__________ใบ__________kg.", fontHead, Brushes.Black, new System.Drawing.Point(5, 163));
                    e.Graphics.DrawString($"10.00                    10.00", fontDetail, Brushes.Black, new System.Drawing.Point(75, 163));
                    e.Graphics.DrawString($"[วันเดือนปีที่ผลิต] : ________________________", fontHead, Brushes.Black, new System.Drawing.Point(5, 181));
                    e.Graphics.DrawString($"{DateTime.Now.ToString("dd/MM/yyyy")}", fontDetail, Brushes.Black, new System.Drawing.Point(110, 181));
                    e.Graphics.DrawString($"[เจ้าหน้าที่คุมเครื่อง] : ______________________", fontHead, Brushes.Black, new System.Drawing.Point(5, 199));
                    e.Graphics.DrawString($"Karin", fontDetail, Brushes.Black, new System.Drawing.Point(130, 199));

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
                    pictureBox.Image = writer.Write($"GV-67-07-0142250767092825");
                    e.Graphics.DrawImage(pictureBox.Image, 275, 150, 120, 120);

                    string barCodeStr = $"GV-67-07-0142250767092825";
                    e.Graphics.DrawString(barCodeStr, fontHead, Brushes.Black, new System.Drawing.Point(180, 270));
                    e.Graphics.DrawString("FM-DL-003 REV.1", fontDetail, Brushes.Black, new System.Drawing.Point(5, 270));
                    #endregion
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            type = "PO";
            PrintToPrinter("ZEBRA_PO");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            type = "JIT";
            PrintToPrinter("ZEBRA_JIT");
        }

        private void PrintToPrinter(string printerName)
        {
            printDocument1.PrinterSettings.PrinterName = printerName;


            if (type == "JIT")
            {
                // Convert millimeters to hundredths of an inch
                int widthInHundredthsOfInch = (int)(55 / 25.4 * 100);
                int heightInHundredthsOfInch = (int)(50 / 25.4 * 100);

                // Create a custom paper size
                PaperSize customPaperSize = new PaperSize("Custom", widthInHundredthsOfInch, heightInHundredthsOfInch);
                printDocument1.DefaultPageSettings.PaperSize = customPaperSize;

                Log.Information("- ผู้ใช้เลือกพิมพ์ข้อมูล 55*50");
            }
            else
            {
                // สำหรับเครื่อง TDP-247
                // Convert millimeters to hundredths of an inch
                //int widthInHundredthsOfInch = (int)(105 / 25.4 * 100);
                //int heightInHundredthsOfInch = (int)(75 / 25.4 * 100);
                // Convert millimeters to hundredths of an inch

                // สำหรับเครื่อง Zebra
                int widthInHundredthsOfInch = (int)(75 / 25.4 * 100);
                int heightInHundredthsOfInch = (int)(101 / 25.4 * 100);

                // Create a custom paper size
                PaperSize customPaperSize = new PaperSize("Custom", widthInHundredthsOfInch, heightInHundredthsOfInch);
                printDocument1.DefaultPageSettings.PaperSize = customPaperSize;
                Log.Information("- ผู้ใช้เลือกพิมพ์ข้อมูล 100*75");
            }


            try
            {
                // Send the document to the printer
                printDocument1.Print();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error printing to {printerName}: {ex.Message}");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
