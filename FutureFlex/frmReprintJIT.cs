using Bunifu.UI.WinForms;
using FutureFlex.API;
using FutureFlex.Function;
using FutureFlex.SQL;
using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        string gv_old = "";
        string gv_new = "";
        private void frmReprintJIT_Load(object sender, EventArgs e)
        {
            // กำหนดค่าให้คอมพิวเตอร์เป็นภาษาอังกฤษ
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-US"));
        }

        async void PrintData(string _lot, string _mode)
        {
            if (cbPrint.Checked)
            {
                // Set printer
                if (!func_print.SetPrinter(printDocument1, _mode))
                {
                    sb.Show(this, "ไม่สามารถเชื่อมต่อ printer ได้", BunifuSnackbar.MessageTypes.Warning, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                    return;
                }

                foreach (DataGridViewRow rw in dgvDetail.Rows)
                {
                    string lot = rw.Cells["cl_wdt_lot"].Value.ToString();
                    if (_lot == lot)
                    {
                        func_print._seq = rw.Cells["cl_wdt_seq"].Value.ToString();
                        func_print._statusType = rw.Cells["cl_wdt_type"].Value.ToString();
                        func_print._net = rw.Cells["cl_wdt_net"].Value.ToString();
                        func_print._numBox = rw.Cells["cl_wdt_numbox"].Value.ToString();
                        func_print._numRoll = rw.Cells["cl_wdt_numrollAll"].Value.ToString();
                        func_print._numMeter = rw.Cells["cl_wdt_meter_kg_in_roll"].Value.ToString();
                        func_print._pchBox = rw.Cells["cl_wdt_pch"].Value.ToString();
                        func_print._pchRoll = rw.Cells["cl_wdt_pch"].Value.ToString();
                        func_print._wghPaper = rw.Cells["cl_wdt_wgh_paper_plastic"].Value.ToString();
                        func_print._wghCore = rw.Cells["cl_wdt_wgh_core_total"].Value.ToString();
                        func_print.pictureBox1 = pictureBox1;
                        func_print._operator = rw.Cells["cl_wgh_operator"].Value.ToString();
                        func_print._lot = lot;

                        string gv_name = rw.Cells["cl_wdt_gv_name"].Value.ToString();

                        if (gv_name != gv_old)
                        {
                            await MRP.GET_MRP(gv_name);
                            gv_old = gv_name;
                        }

                        if (radioButton3.Checked)
                        {
                            printDocument1.Print();
                        }
                        else if (radioButton4.Checked)
                        {
                            printPreviewDialog1.ShowDialog();
                        }
                        break;
                    }
                }
            }
        }

        void ShowData()
        {
            tbWeightDetail.PO = cbbPO.Text.Trim();
            DataTable tb = tbWeightDetail.SELECT_PO_SUCCESS_ODOO_AND_NOT_REPRINT();
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
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            if (!func_print.FormatPrint(e))
            {
                msg.Icon = MessageDialogIcon.Error;
                msg.Buttons = MessageDialogButtons.OK;
                msg.Show($"Can't print \n {func_print.ERR}", "Error print printDocument1_PrintPage");
                return;
            }

            tbWeightDetail.UPDATE_STATUS_PRINT(lot);
            foreach (DataGridViewRow rw in dgvDetail.Rows)
            {
                string _lot = rw.Cells["cl_wdt_lot"].Value.ToString();
                if (_lot == lot)
                {
                    rw.DefaultCellStyle.BackColor = Color.Green;
                    return;
                }
            }
        }


        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            //if (txtLot.Text.Length == 28)
            //{
            //    foreach (DataGridViewRow rw in dgvDetail.Rows)
            //    {
            //        string _lot = rw.Cells["cl_wdt_lot"].Value.ToString();
            //        if (txtLot.Text == _lot)
            //        {
            //            lot = txtLot.Text;
            //            await Task.Delay(500);
            //            PrintData(lot);
            //            break;
            //        }
            //    }
            //}
        }

        private void dgvDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvDetail.Columns[e.ColumnIndex].Name == "cl_print")
                {
                    lot = dgvDetail.Rows[e.RowIndex].Cells["cl_wdt_lot"].Value.ToString();

                    PrintData(lot, "PO");
                }
            }
            catch (Exception ex)
            {
                sb.Show(this, $"DATAGRIDVIEW {ex.Message}", BunifuSnackbar.MessageTypes.Error, 3000, "", BunifuSnackbar.Positions.TopCenter);
                return;
            }
        }


        private void txtLot_IconRightClick(object sender, EventArgs e)
        {
            txtLot.Clear();
        }

        private async void txtLot_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                label1.Text = $"DATA : {txtLot.Text}";
                lot = txtLot.Text;
                txtLot.Clear();
                foreach (DataGridViewRow rw in dgvDetail.Rows)
                {
                    string _lot = rw.Cells["cl_wdt_lot"].Value.ToString();
                    if (lot == _lot)
                    {
                        await Task.Delay(500);
                        PrintData(lot, "PO");
                        break;
                    }
                }
            }
        }

        private void cbbPO_DropDown(object sender, EventArgs e)
        {
            cbbPO.Items.Clear();
            DataTable tb = tbWeightDetail.SELECT_PO_NOT_PRINT();

            string _opNew = "";
            string _poOld = "";

            foreach (DataRow rw in tb.Rows)
            {
                string po = rw["wdt_po"].ToString();
                _opNew = rw["wdt_po"].ToString();

                if (po != "JIT")
                {
                    bool isSame = false;
                    for (int i = 0; i < cbbPO.Items.Count; i++)
                    {
                        if (_opNew == cbbPO.Items[i].ToString())
                        {
                            isSame = true;
                        }
                    }
                    if (!isSame)
                    {
                        cbbPO.Items.Add(_opNew);
                    }
                }
            }
        }

        private void cbbPO_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbPO.Text == "JIT")
            {
                sb.Show(this, "ไม่สามารถ reprint jit", BunifuSnackbar.MessageTypes.Warning, 3000, "", BunifuSnackbar.Positions.TopCenter);
                return;
            }
            // แสดงข้อมูล PO ที่ส่งไปหา Odoo เรียบร้ิยแล้ว
            ShowData();
        }

        private void printDocument1_EndPrint(object sender, PrintEventArgs e)
        {
            //Console.WriteLine("EndPrint");
            //printPreviewDialog1.Close();
        }
    }
}
