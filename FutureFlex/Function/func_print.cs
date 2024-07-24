using FutureFlex.API;
using FutureFlex.SQL;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using ZXing;

namespace FutureFlex.Function
{
    internal class func_print
    {

        public string _statusType { get; set; }   // ประเภท
        public string _statusSide { get; set; }   // ด้าน
        public string _statusCounty { get; set; } // ประเทศ
        public string _seq { get; set; }  // ลำดับ
        public string _net { get; set; }  // น้ำหนักสุทธิ์
        public string _numBox { get; set; }  // จำนวนกล่อง
        public string _numRoll { get; set; }  // จำนวนม้วน
        public string _numMeter { get; set; } // จำนวนเมตร
        public string _pchBox { get; set; }  // จำนวนใบของกล่อง
        public string _pchRoll { get; set; }  // จำนวนใบของม้วน
        public string _wghPaper { get; set; }  // น้ำหนักกระดาษ
        public string _wghCore { get; set; }  // น้ำหนักแกน
        public PictureBox pictureBox1 { get; set; }  // เก็บรูปภาพ 
        public string _operator { get; set; } // ชื่อผู้คุมเครื่อง


        public void FormatPrint(PrintPageEventArgs e)
        {
            try
            {
                Font fontHeader;
                Font fontHead;
                Font fontDetail;

                // Create __seq
                if (tbWeightDetail.PO != "JIT" && tbWeightDetail.PO != "ไม่มี PO")
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


                if (tbWeightDetail.PO == "JIT") // JIT
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
                    e.Graphics.DrawString($"{MRP.product_id}", fontDetail, Brushes.Black, new System.Drawing.Point(80, 57));
                    e.Graphics.DrawString($"[สินค้า] : ___________________________________________ ", fontHead, Brushes.Black, new System.Drawing.Point(0, 35));
                    e.Graphics.DrawString($"{MRP.product_name.Substring(0, 25)}", fontDetail, Brushes.Black, new System.Drawing.Point(50, 35));
                    e.Graphics.DrawString($"[ใบสั่งงาน] : ___________________________________________ ", fontHead, Brushes.Black, new System.Drawing.Point(0, 80));
                    e.Graphics.DrawString($"{MRP.name}                  ", fontDetail, Brushes.Black, new System.Drawing.Point(70, 80));


                    switch (_statusType) // เช็คว่าผู้ใช้เลือกการชั่งแบบ กล่องหรือม้วน
                    {
                        case "box":
                            e.Graphics.DrawString($"NO :  {_seq}", fontDetail, Brushes.Black, new System.Drawing.Point(135, 3));
                            e.Graphics.DrawString($"[จำนวน]_____ใบ.", fontHead, Brushes.Black, new System.Drawing.Point(0, 110));
                            e.Graphics.DrawString($"{_pchBox}", fontDetail, Brushes.Black, new System.Drawing.Point(50, 110));
                            e.Graphics.DrawString($"____________kg.", fontHead, Brushes.Black, new System.Drawing.Point(0, 130));
                            e.Graphics.DrawString($"{_net}", fontDetail, Brushes.Black, new System.Drawing.Point(10, 130));
                            e.Graphics.DrawString($"[MFG] : ______________________", fontHead, Brushes.Black, new System.Drawing.Point(0, 160));
                            e.Graphics.DrawString($"{DateTime.Now.ToString("dd/MM/yyyy")}", fontDetail, Brushes.Black, new System.Drawing.Point(50, 160));
                            break;   //กรณีเลือกกล่อง
                        case "roll":
                            e.Graphics.DrawString($"NO :  {_seq}", fontDetail, Brushes.Black, new System.Drawing.Point(135, 3));

                            e.Graphics.DrawString($"[จำนวน]________ม.", fontHead, Brushes.Black, new System.Drawing.Point(0, 110));
                            e.Graphics.DrawString($"{_numMeter}", fontDetail, Brushes.Black, new System.Drawing.Point(65, 110));
                            e.Graphics.DrawString($"_____________ใบ", fontHead, Brushes.Black, new System.Drawing.Point(0, 125));
                            e.Graphics.DrawString($"{_pchRoll}", fontDetail, Brushes.Black, new System.Drawing.Point(30, 125));
                            e.Graphics.DrawString($"_____________kg.", fontHead, Brushes.Black, new System.Drawing.Point(0, 140));
                            e.Graphics.DrawString($"{_net} ", fontDetail, Brushes.Black, new System.Drawing.Point(30, 140));
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
                    pictureBox.Image = writer.Write($"{MRP.name}{DateTime.Now.ToString("dd")}{DateTime.Now.ToString("MM")}{DateTime.Now.ToString("yy")}{DateTime.Now.ToString("HH")}{DateTime.Now.ToString("mm")}{DateTime.Now.ToString("ss")}001");
                    e.Graphics.DrawImage(pictureBox.Image, 115, 100, 80, 80);

                    string barCodeStr = $"{MRP.name}{DateTime.Now.ToString("dd")}{DateTime.Now.ToString("MM")}{DateTime.Now.ToString("yy")}{DateTime.Now.ToString("HH")}{DateTime.Now.ToString("mm")}{DateTime.Now.ToString("ss")}001";
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
                    e.Graphics.DrawString($"NO : {_seq}", new Font("Tahoma", 12, System.Drawing.FontStyle.Regular), Brushes.Black, new System.Drawing.Point(290, 5));
                    #endregion

                    #region Body
                    e.Graphics.DrawString($"[สินค้า] : __________________________________________________________________________________________________________", fontHead, Brushes.Black, new System.Drawing.Point(5, 55));
                    e.Graphics.DrawString($"{MRP.product_name}", fontDetail, Brushes.Black, new System.Drawing.Point(70, 55));

                    e.Graphics.DrawString($"[รหัสสินค้า] : ___________________________________________________________________________________________________________ ", fontHead, Brushes.Black, new System.Drawing.Point(5, 73));
                    e.Graphics.DrawString($"{MRP.default_code}", fontDetail, Brushes.Black, new System.Drawing.Point(90, 73));


                    e.Graphics.DrawString($"[บริษัท] : ______________________________________________________________________________________________________", fontHead, Brushes.Black, new System.Drawing.Point(5, 91));
                    e.Graphics.DrawString($"{MRP.partner_name}", fontDetail, Brushes.Black, new System.Drawing.Point(70, 91));
                    e.Graphics.DrawString($"[ใบสั่งงาน] : ________________ [ใบสั่งซื้อ] : _______________________________________________________________________", fontHead, Brushes.Black, new System.Drawing.Point(5, 109));
                    e.Graphics.DrawString($"{MRP.name}                                  {tbWeightDetail.PO}", fontDetail, Brushes.Black, new System.Drawing.Point(80, 109));
                    e.Graphics.DrawString($"[โครงสร้าง] : ______________________________________________________________________________________________________", fontHead, Brushes.Black, new System.Drawing.Point(5, 127));
                    e.Graphics.DrawString($"{MRP.mo_film}", fontDetail, Brushes.Black, new System.Drawing.Point(90, 127));
                    e.Graphics.DrawString($"[ขนาด] :________________________", fontHead, Brushes.Black, new System.Drawing.Point(5, 145));
                    e.Graphics.DrawString($"{MRP.mo_work}", fontDetail, Brushes.Black, new System.Drawing.Point(60, 145));

                    switch (_statusType) // เช็คว่าผู้ใช้เลือกการชั่งแบบ กล่องหรือม้วน
                    {
                        case "box":
                            e.Graphics.DrawString($"[จำนวน] :__________ใบ__________kg.", fontHead, Brushes.Black, new System.Drawing.Point(5, 163));
                            e.Graphics.DrawString($"{_pchBox}                    {_net}", fontDetail, Brushes.Black, new System.Drawing.Point(75, 163));
                            e.Graphics.DrawString($"[วันเดือนปีที่ผลิต] : ________________________", fontHead, Brushes.Black, new System.Drawing.Point(5, 181));
                            e.Graphics.DrawString($"{DateTime.Now.ToString("dd/MM/yyyy")}", fontDetail, Brushes.Black, new System.Drawing.Point(110, 181));
                            e.Graphics.DrawString($"[เจ้าหน้าที่คุมเครื่อง] : ______________________", fontHead, Brushes.Black, new System.Drawing.Point(5, 199));
                            e.Graphics.DrawString($"{_operator}", fontDetail, Brushes.Black, new System.Drawing.Point(130, 199));
                            break;   //กรณีเลือกกล่อง
                        case "roll":
                            e.Graphics.DrawString($"[นน.กระดาษ/นน.พลาสติก] :________________", fontHead, Brushes.Black, new System.Drawing.Point(5, 163));
                            e.Graphics.DrawString($"{_wghPaper}", fontDetail, Brushes.Black, new System.Drawing.Point(170, 163));
                            e.Graphics.DrawString($"[นน.แกน/นน.รวม] :______________________", fontHead, Brushes.Black, new System.Drawing.Point(5, 181));
                            e.Graphics.DrawString($"{_wghCore}", fontDetail, Brushes.Black, new System.Drawing.Point(120, 181));
                            e.Graphics.DrawString($"[จำนวนสุทธิ]________ม.______ใบ_______kg.", fontHead, Brushes.Black, new System.Drawing.Point(5, 199));
                            e.Graphics.DrawString($"{_numMeter}           {_pchRoll}            {_net} ", fontDetail, Brushes.Black, new System.Drawing.Point(90, 199));
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
                    pictureBox.Image = writer.Write($"{MRP.name}{DateTime.Now.ToString("dd")}{DateTime.Now.ToString("MM")}{DateTime.Now.ToString("yy")}{DateTime.Now.ToString("HH")}{DateTime.Now.ToString("mm")}{DateTime.Now.ToString("ss")}001");
                    e.Graphics.DrawImage(pictureBox.Image, 275, 150, 120, 120);

                    string barCodeStr = $"{MRP.name}{DateTime.Now.ToString("dd")}{DateTime.Now.ToString("MM")}{DateTime.Now.ToString("yy")}{DateTime.Now.ToString("HH")}{DateTime.Now.ToString("mm")}{DateTime.Now.ToString("ss")}001";
                    e.Graphics.DrawString(barCodeStr, fontHead, Brushes.Black, new System.Drawing.Point(180, 270));
                    e.Graphics.DrawString("FM-DL-003 REV.1", fontDetail, Brushes.Black, new System.Drawing.Point(5, 270));
                    #endregion
                }
            }
            catch (Exception ex)
            {
            }
        }


    }
}
