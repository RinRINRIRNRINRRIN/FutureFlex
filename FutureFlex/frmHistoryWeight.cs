using Bunifu.UI.WinForms;
using FutureFlex.API;
using FutureFlex.command;
using FutureFlex.SQL;
using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutureFlex
{
    public partial class frmHistoryWeight : Form
    {

        tbForSendSQL tbForSendSQL = new tbForSendSQL();
        BunifuSnackbar sc = new BunifuSnackbar();

        /// <summary>
        /// สำหรับเก็บข้อมูลว่าเลือก GV หรือ RTFG
        /// </summary>
        private string GvOrRTFG { get; set; }


        public frmHistoryWeight()
        {
            InitializeComponent();

            dgvDetail.DefaultCellStyle.Font = new Font("Athiti", 12, FontStyle.Regular);
            dgvDetail.DefaultCellStyle.ForeColor = Color.Black;
        }


        void ShowCountAndWeightTotal()
        {
            double totalWeight = 0;
            foreach (DataGridViewRow rw in dgvDetail.Rows)
            {
                double _Count = double.Parse(rw.Cells["cl_net"].Value.ToString());
                // บวกน้ำหนักรวม
                totalWeight = totalWeight + _Count;
                string rtfg = dgvDetail.Rows[rw.Index].Cells["cl_rtfg_name"].Value.ToString();
                if (rtfg != "")
                {
                    dgvDetail.Rows[rw.Index].DefaultCellStyle.BackColor = Color.Orange;
                }
                else
                {
                    dgvDetail.Rows[rw.Index].DefaultCellStyle.BackColor = Color.FromArgb(166, 205, 198);
                }
            }

            //lblTotalWeight.Text = totalWeight.ToString("F2");
            //lblTotol.Text = dgvDetail.Rows.Count.ToString();
        }

        private void frmHistoryWeight_Load(object sender, EventArgs e)
        {
            //dgvDetail.DataSource = tbWeight.SELECT_NOT_SUCCESS();
        }


        private void guna2ComboBox1_DropDown(object sender, EventArgs e)
        {
            cbbPO.Items.Clear();
            DataTable tb = tbWeightDetail.SELECT_ODOO_DONT_SEND(GvOrRTFG);

            string _opNew = "";
            string _poOld = "";

            foreach (DataRow rw in tb.Rows)
            {
                _opNew = rw["wdt_po"].ToString();
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

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // แสดงข้อมู] PO ที่มีการส่งไปหา Odoo แล้ว

            DataTable tb = new DataTable();

            if (cbbPO.Text == "JIT" || cbbPO.Text == "ไม่มีPO")
            {
                tbWeightDetail.PO = "JIT";
                tb = tbWeightDetail.SELECT_JIT_NOT_SEND_ODOO(GvOrRTFG);
                cbbJIT.Items.Clear();
                string _oldData = "";
                foreach (DataRow rw in tb.Rows)
                {
                    string value = "";
                    switch (GvOrRTFG)
                    {
                        case "GV":
                            value = rw["wdt_gv_name"].ToString();
                            break;
                        default:
                            value = rw["wdt_rtfg_name"].ToString();
                            break;
                    }

                    if (value != _oldData)
                    {
                        cbbJIT.Items.Add(value);
                        _oldData = value;
                    }
                }
                cbbJIT.Visible = true;
            }
            else
            {
                tbWeightDetail.PO = cbbPO.Text;
                tb = tbWeightDetail.SELECT_PO_NOT_SEND_ODOO();
                if (tb.Rows.Count == 0)
                {
                    sc.Show(this, "ไม่พบรายการ PO ที่เลือก", BunifuSnackbar.MessageTypes.Warning, 3000, "", BunifuSnackbar.Positions.TopCenter);
                    return;
                }
                dgvDetail.DataSource = tb;
            }
            // รวมจำนวนกล่องและน้ำหนักรวม
            ShowCountAndWeightTotal();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmHistorySuccess frmHistorySuccess = new frmHistorySuccess();
            frmHistorySuccess.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmPrint frmPrint = new frmPrint();
            frmPrint.PO = cbbPO.Text;
            frmPrint.GvOrRTFG = GvOrRTFG;
            frmPrint.ShowDialog();
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            if (dgvDetail.Rows.Count == 0)
            {
                MessageBox.Show("ไม่พบรายการที่จะส่งให้ odoo", "POST ODOO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            DialogResult dg = MessageBox.Show($"คุณต้องการส่งข้อมูลทั้งหมด {dgvDetail.Rows.Count} รายการ\nไปที่ odoo หรือไม่", "ส่งข้อมูลทั้งหมด", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dg == DialogResult.No)
            {
                return;
            }
            panel1.Enabled = false;

            foreach (DataGridViewRow rw in dgvDetail.Rows)
            {
                btnSend.Enabled = false;

                if (rw.DefaultCellStyle.BackColor != Color.Green)
                {

                    string _wgh_id = rw.Cells["cl_id"].Value.ToString();
                    string _wgh_gv_id = rw.Cells["cl_gv_id"].Value.ToString();
                    string _wgh_gv_name = rw.Cells["cl_gv_name"].Value.ToString();
                    string _wgh_rtfg_name = rw.Cells["cl_rtfg_name"].Value.ToString();
                    string _wgh_rtfg_id = rw.Cells["cl_rtfg_id"].Value.ToString();
                    string[] _wgh_dateTime = rw.Cells["cl_date"].Value.ToString().Split(' ');
                    string _wgh_po = rw.Cells["cl_po"].Value.ToString();
                    string _wgh_county = rw.Cells["cl_county"].Value.ToString();
                    string _wgh_type = rw.Cells["cl_type"].Value.ToString();
                    string _wgh_side = rw.Cells["cl_side"].Value.ToString();
                    string _wgh_weightPaper = rw.Cells["cl_wgh_paper_plastic"].Value.ToString();
                    string count_total = "";  // จำนวนกล่อง และ จำนวนม้วน
                    double _wdt_rollPerLOT = double.Parse(rw.Cells["cl_wdt_numroll"].Value.ToString());

                    if (_wgh_type == "box")
                    {
                        count_total = rw.Cells["cl_wdt_numbox"].Value.ToString();
                    }
                    else if (_wgh_type == "roll")
                    {
                        count_total = rw.Cells["cl_wdt_numrollAll"].Value.ToString();
                    }

                    string _wgh_weightCore = rw.Cells["cl_core"].Value.ToString();
                    string _wgh_joint = rw.Cells["cl_joint"].Value.ToString();
                    string _wgh_weightRoll = rw.Cells["cl_meter_kg_in_roll"].Value.ToString();
                    string _wgh_machineOperator = rw.Cells["cl_employee"].Value.ToString();
                    string _wgh_net = rw.Cells["cl_net"].Value.ToString();
                    string _wgh_tare = rw.Cells["cl_tare"].Value.ToString();
                    string _wgh_gross = rw.Cells["cl_gross"].Value.ToString();
                    string _lot = rw.Cells["cl_lot"].Value.ToString();
                    string _seq = rw.Cells["cl_seq"].Value.ToString();
                    string _pch = rw.Cells["cl_pch"].Value.ToString();


                    string[] dateA = _wgh_dateTime[0].Split('/');

                    string d = dateA[0];
                    string m = dateA[1];
                    string y = dateA[2];

                    if (d.Length == 1)
                    {
                        d = "0" + d;
                    }

                    if (m.Length == 1)
                    {
                        m = "0" + m;
                    }

                    string year = Convert.ToString(Convert.ToInt32(y) - 543);
                    string newDate = $"{year}-{m}-{d}";

                    // SEND DATA
                    // Check GV or RTFG
                    if (_wgh_rtfg_id != "0") // CREATE RTFG
                    {
                        if (await RTFG.CREATE_RTFG(_wgh_rtfg_id, _wgh_id, _wgh_machineOperator, _wgh_county, _wgh_type, _wgh_side, _wgh_po, newDate, _wgh_net, _wgh_tare, _wgh_gross, _wgh_weightPaper, _wgh_weightCore, _wgh_joint, _pch, _wgh_weightRoll, _lot, _seq, count_total, _wdt_rollPerLOT))
                        {
                            tbWeightDetail.UPDATE_STATUS_ODOO(_wgh_id);
                            rw.DefaultCellStyle.BackColor = Color.Green;
                            rw.DefaultCellStyle.ForeColor = Color.White;
                        }
                        else
                        {
                            rw.DefaultCellStyle.BackColor = Color.Red;
                            rw.DefaultCellStyle.ForeColor = Color.White;
                        }
                    }
                    else // CREATE MRP
                    {
                        if (await MRP.CREATE_MRP(_wgh_gv_id, _wgh_id, _wgh_machineOperator, _wgh_county, _wgh_type, _wgh_side, _wgh_po, newDate, _wgh_net, _wgh_tare, _wgh_gross, _wgh_weightPaper, _wgh_weightCore, _wgh_joint, _pch, _wgh_weightRoll, _lot, _seq, count_total, _wdt_rollPerLOT))
                        {
                            tbWeightDetail.UPDATE_STATUS_ODOO(_wgh_id);
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
                await Task.Delay(500);
            }
            DataTable tb = new DataTable();
            if (cbbPO.Text == "JIT" || cbbPO.Text == "ไม่มีPO")
            {
                tb = tbWeightDetail.SELECT_JIT_NOT_SEND_ODOO(GvOrRTFG);
            }
            else
            {
                tb = tbWeightDetail.SELECT_PO_NOT_SEND_ODOO();
            }

            dgvDetail.DataSource = tb;
            btnSend.Enabled = true;
            panel1.Enabled = true;
            ShowCountAndWeightTotal();
        }

        private void SelectGVorRTFG(object sender, EventArgs e)
        {
            Guna2RadioButton rdb = sender as Guna2RadioButton;
            if (rdb.Checked == true)
            {
                switch (rdb.Tag.ToString())
                {
                    case "GV":
                        dgvDetail.Columns["cl_rtfg_name"].Visible = false;
                        dgvDetail.Columns["cl_gv_name"].Visible = true;
                        cbbJIT.Items.Clear();
                        cbbJIT.Visible = false;
                        break;
                    case "RTFG":
                        dgvDetail.Columns["cl_rtfg_name"].Visible = true;
                        dgvDetail.Columns["cl_gv_name"].Visible = false;
                        cbbJIT.Items.Clear();
                        cbbJIT.Visible = false;
                        break;
                }
                DataTable dataTable = dgvDetail.DataSource as DataTable;
                if (dataTable != null)
                {
                    dataTable.Rows.Clear(); // เคลียร์ข้อมูลใน DataTable
                }
                GvOrRTFG = rdb.Tag.ToString();
                cbbPO.Enabled = true;
                cbbPO.Items.Clear();
            }
        }

        private void cbbJIT_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbWeightDetail.PO = cbbPO.Text;
            DataTable tb = tbWeightDetail.SELECT_JIT_NOT_SEND_ODOO(GvOrRTFG);
            dgvDetail.DataSource = tb;
        }
    }
}
