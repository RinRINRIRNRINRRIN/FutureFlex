using Bunifu.UI.WinForms;
using FutureFlex.SQL;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace FutureFlex
{
    public partial class frmReprintJIT : Form
    {
        public frmReprintJIT()
        {
            InitializeComponent();
            dgvDetail.DefaultCellStyle.ForeColor = Color.White;
        }

        string lot = ""; // สำหรับบอกว่าจะปริ้นที่ lot ไหน
        BunifuSnackbar sb = new BunifuSnackbar();
        private void frmReprintJIT_Load(object sender, EventArgs e)
        {
            // กำหนดค่าให้กับ serialport
        }

        void PrintData(string _lot)
        {
            // Format Zebra
            int widthInHundredthsOfInch = (int)(75 / 25.4 * 100);
            int heightInHundredthsOfInch = (int)(101 / 25.4 * 100);

            // Create a custom paper size
            PaperSize customPaperSize = new PaperSize("Custom", widthInHundredthsOfInch, heightInHundredthsOfInch);
            printDocument1.DefaultPageSettings.PaperSize = customPaperSize;

            if (cbPrint.Checked)
            {
                foreach (DataGridViewRow rw in dgvDetail.Rows)
                {
                    string lot = rw.Cells["cl_wdt_lot"].Value.ToString();
                    if (_lot == lot)
                    {
                        if (tbWeightDetail.UPDATE_STATUS_PRINT(_lot))
                        {
                            if (radioButton3.Checked)
                            {
                                printDocument1.Print();
                            }
                            else if (radioButton4.Checked)
                            {
                                printPreviewDialog1.ShowDialog();
                            }
                            rw.DefaultCellStyle.BackColor = Color.Green;
                            sb.Show(this, $"สำเร็จ", BunifuSnackbar.MessageTypes.Success, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                        }
                        else
                        {
                            sb.Show(this, $"พบข้อผิดผลาด {tbWeightDetail.PO}", BunifuSnackbar.MessageTypes.Error, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                            rw.DefaultCellStyle.BackColor = Color.Red;
                        }

                        break;
                    }
                }
            }
        }

        void ShowData()
        {
            tbWeightDetail.PO = txtPO.Text;
            DataTable tb = tbWeightDetail.SELECT_PO_SUCCESS_ODOO();
            // เช็คว่ามีข้อมูลหรือไม่
            if (tb.Rows.Count == 0)
            {
                sb.Show(this, "ไม่พบรายการ PO ที่ต้องการจะ reprint ใหม่", BunifuSnackbar.MessageTypes.Warning, 3000, "", BunifuSnackbar.Positions.TopCenter);
                return;
            }

            dgvDetail.DataSource = tb;
            foreach (DataGridViewRow rw in dgvDetail.Rows)
            {
                string isPrint = rw.Cells["cl_wdt_print"].Value.ToString();
                if (isPrint == "PRINTED")
                {
                    rw.DefaultCellStyle.BackColor = Color.Green;
                    rw.DefaultCellStyle.ForeColor = Color.White;
                }
                else
                {
                    rw.DefaultCellStyle.BackColor = Color.Red;
                    rw.DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }

        private void txtPO_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPO.Text == "JIT")
                {
                    sb.Show(this, "ไม่สามารถ reprint jit", BunifuSnackbar.MessageTypes.Warning, 3000, "", BunifuSnackbar.Positions.TopCenter);
                    return;
                }
                // แสดงข้อมูล PO ที่ส่งไปหา Odoo เรียบร้ิยแล้ว
                ShowData();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                Font fontHeader = new Font("Tahoma", 14, System.Drawing.FontStyle.Bold);
                Font fontHead = new Font("Tahoma", 8, System.Drawing.FontStyle.Bold);
                Font fontDetail = new Font("Tahoma", 8, System.Drawing.FontStyle.Regular);

                foreach (DataGridViewRow rw in dgvDetail.Rows)
                {
                    string customer = rw.Cells["cl_wgh_customer"].Value.ToString();
                    string _po = rw.Cells["cl_wdt_po"].Value.ToString();
                    string _gvname = rw.Cells["cl_wdt_gvid"].Value.ToString();
                    string _seq = rw.Cells["cl_wdt_seq"].Value.ToString();
                    string _type = rw.Cells["cl_wdt_type"].Value.ToString();
                    string _totalBox = rw.Cells["cl_wdt_numbox"].Value.ToString();
                    string _totalRoll = rw.Cells["cl_wdt_numroll"].Value.ToString();
                    string _net = rw.Cells["cl_wdt_net"].Value.ToString();
                    string _tare = rw.Cells["cl_wdt_tare"].Value.ToString();
                    string _gross = rw.Cells["cl_wdt_gross"].Value.ToString();
                    string _employee = rw.Cells["cl_wgh_operator"].Value.ToString();
                    string _date = rw.Cells["cl_wgh_date"].Value.ToString();
                    string _productName = rw.Cells["cl_wgh_product"].Value.ToString();
                    string _productID = rw.Cells["cl_wgh_productID"].Value.ToString();
                    string _typeSuccess = rw.Cells["cl_wgh_typeSuccess"].Value.ToString();
                    string _structure = rw.Cells["cl_wgh_structure"].Value.ToString();
                    string _numMeter = rw.Cells["cl_wdt_meter_kg_in_roll"].Value.ToString();
                    string _pch = rw.Cells["cl_wdt_pch"].Value.ToString();
                    string _operator = rw.Cells["cl_wgh_operator"].Value.ToString();
                    string _wghPaper = rw.Cells["cl_wdt_wgh_paper_plastic"].Value.ToString();
                    string _wghCore = rw.Cells["cl_wdt_wgh_core_total"].Value.ToString();
                    string _lot = rw.Cells["cl_wdt_lot"].Value.ToString();

                    if (_lot == lot)
                    {

                        switch (_type)
                        {
                            case "box":
                                _seq = $"{_seq}/{_totalBox}";
                                break;
                            case "roll":
                                _seq = $"{_seq}/{_totalRoll}";
                                break;
                        }

                        #region Header
                        e.Graphics.DrawImage(pictureBox1.Image, 5, -3, 50, 50);
                        e.Graphics.DrawString("FUTURE FLEX CO.,LTD", fontHeader, Brushes.Black, new System.Drawing.Point(60, 15));
                        e.Graphics.DrawString($"NO : {_seq}", new Font("Tahoma", 12, System.Drawing.FontStyle.Regular), Brushes.Black, new System.Drawing.Point(290, 5));
                        #endregion

                        #region Body
                        e.Graphics.DrawString($"[สินค้า] : __________________________________________________________________________________________________________", fontHead, Brushes.Black, new System.Drawing.Point(5, 55));
                        e.Graphics.DrawString($"{_productName}", fontDetail, Brushes.Black, new System.Drawing.Point(70, 55));

                        e.Graphics.DrawString($"[รหัสสินค้า] : ___________________________________________________________________________________________________________ ", fontHead, Brushes.Black, new System.Drawing.Point(5, 73));
                        e.Graphics.DrawString($"{_productID}", fontDetail, Brushes.Black, new System.Drawing.Point(90, 73));


                        e.Graphics.DrawString($"[บริษัท] : ______________________________________________________________________________________________________", fontHead, Brushes.Black, new System.Drawing.Point(5, 91));
                        e.Graphics.DrawString($"{customer}", fontDetail, Brushes.Black, new System.Drawing.Point(70, 91));
                        e.Graphics.DrawString($"[ใบสั่งงาน] : ________________ [ใบสั่งซื้อ] : _______________________________________________________________________", fontHead, Brushes.Black, new System.Drawing.Point(5, 109));
                        e.Graphics.DrawString($"{_gvname}                                  {_po}", fontDetail, Brushes.Black, new System.Drawing.Point(80, 109));
                        e.Graphics.DrawString($"[โครงสร้าง] : ______________________________________________________________________________________________________", fontHead, Brushes.Black, new System.Drawing.Point(5, 127));
                        e.Graphics.DrawString($"{_structure}", fontDetail, Brushes.Black, new System.Drawing.Point(90, 127));
                        e.Graphics.DrawString($"[ขนาด] :________________________", fontHead, Brushes.Black, new System.Drawing.Point(5, 145));
                        e.Graphics.DrawString($"{_typeSuccess}", fontDetail, Brushes.Black, new System.Drawing.Point(60, 145));

                        switch (_type) // เช็คว่าผู้ใช้เลือกการชั่งแบบ กล่องหรือม้วน
                        {
                            case "box":
                                e.Graphics.DrawString($"[จำนวน] :__________ใบ__________kg.", fontHead, Brushes.Black, new System.Drawing.Point(5, 163));
                                e.Graphics.DrawString($"{_pch}                    {_net}", fontDetail, Brushes.Black, new System.Drawing.Point(75, 163));
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
                                e.Graphics.DrawString($"{_numMeter}           {_pch}            {_net} ", fontDetail, Brushes.Black, new System.Drawing.Point(90, 199));
                                e.Graphics.DrawString($"[วันเดือนปีที่ผลิต] : ______________________", fontHead, Brushes.Black, new System.Drawing.Point(5, 217));
                                e.Graphics.DrawString($"{DateTime.Now.ToString("dd/MM/yyyy")}", fontDetail, Brushes.Black, new System.Drawing.Point(130, 217));
                                e.Graphics.DrawString($"[เจ้าหน้าที่คุมเครื่อง] : ____________________", fontHead, Brushes.Black, new System.Drawing.Point(5, 235));
                                e.Graphics.DrawString($"{_operator}", fontDetail, Brushes.Black, new System.Drawing.Point(130, 235));
                                break;  //กรณีเลือกม้วน  
                        }

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
                #endregion
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        private async void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (txtLot.Text.Length == 28)
            {
                foreach (DataGridViewRow rw in dgvDetail.Rows)
                {
                    string _lot = rw.Cells["cl_wdt_lot"].Value.ToString();
                    if (txtLot.Text == _lot)
                    {
                        lot = txtLot.Text;
                        await Task.Delay(500);
                        PrintData(lot);
                        break;
                    }
                }
            }
        }

        private void dgvDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvDetail.Columns[e.ColumnIndex].Name == "cl_print")
                {
                    lot = dgvDetail.Rows[e.RowIndex].Cells["cl_wdt_lot"].Value.ToString();

                    PrintData(lot);
                }
            }
            catch (Exception ex)
            {
                sb.Show(this, $"DATAGRIDVIEW {ex.Message}", BunifuSnackbar.MessageTypes.Error, 3000, "", BunifuSnackbar.Positions.TopCenter);
                return;
            }
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtLot_IconRightClick(object sender, EventArgs e)
        {
            txtLot.Clear();
        }
    }
}
