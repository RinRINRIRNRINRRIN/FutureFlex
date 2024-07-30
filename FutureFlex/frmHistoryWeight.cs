using Bunifu.UI.WinForms;
using FutureFlex.API;
using FutureFlex.command;
using FutureFlex.SQL;
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
                totalWeight = totalWeight + _Count;
            }

            lblTotalWeight.Text = totalWeight.ToString("F2");
            lblTotol.Text = dgvDetail.Rows.Count.ToString();
        }

        private void frmHistoryWeight_Load(object sender, EventArgs e)
        {
            dgvDetail.DataSource = tbWeight.SELECT_NOT_SUCCESS();
        }



        private async void bunifuButton1_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show($"คุณต้องการส่งข้อมูลทั้งหมด {dgvDetail.Rows.Count} รายการ\nไปที่ odoo หรือไม่", "ส่งข้อมูลทั้งหมด", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dg == DialogResult.No)
            {
                return;
            }

            if (dgvDetail.Rows.Count == 0)
            {
                MessageBox.Show("ไม่พบรายการที่จะส่งให้ odoo", "POST ODOO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataGridViewRow rw in dgvDetail.Rows)
            {
                bunifuButton1.Enabled = false;

                if (rw.DefaultCellStyle.BackColor != Color.Green)
                {

                    string _wgh_id = rw.Cells["cl_id"].Value.ToString();
                    string _wgh_gvname = rw.Cells["cl_gvid"].Value.ToString();
                    string[] _wgh_dateTime = rw.Cells["cl_date"].Value.ToString().Split(' ');
                    string _wgh_po = rw.Cells["cl_po"].Value.ToString();
                    string _wgh_county = rw.Cells["cl_county"].Value.ToString();
                    string _wgh_type = rw.Cells["cl_type"].Value.ToString();
                    string _wgh_side = rw.Cells["cl_side"].Value.ToString();
                    string _wgh_weightPaper = rw.Cells["cl_wgh_paper_plastic"].Value.ToString();
                    string count_total = "";  // จำนวนกล่อง และ จำนวนม้วน

                    if (_wgh_type == "box")
                    {
                        count_total = rw.Cells["cl_wdt_numbox"].Value.ToString();
                    }
                    else if (_wgh_type == "roll")
                    {
                        count_total = rw.Cells["cl_wdt_numroll"].Value.ToString();
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

                    // หา id ของ GV


                    DataTable tb = tbWeight.SELECT_SELECT_GV(_wgh_gvname);
                    string gv_id = "";
                    foreach (DataRow rws in tb.Rows)
                    {
                        gv_id = rws["wgh_gvid"].ToString();
                    }

                    // SEND DATA
                    if (await MRP.CREATE_MRP(gv_id, _wgh_id, _wgh_machineOperator, _wgh_county, _wgh_type, _wgh_side, _wgh_po, newDate, _wgh_net, _wgh_tare, _wgh_gross, _wgh_weightPaper, _wgh_weightCore, _wgh_joint, _pch, _wgh_weightRoll, _lot, _seq, count_total))
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
                await Task.Delay(500);
            }
            ShowCountAndWeightTotal();
            DataTable tb1 = tbWeightDetail.SELECT_PO_NOT_SEND_ODOO();
            dgvDetail.DataSource = tb1;
            bunifuButton1.Enabled = true;
        }


        private void guna2ComboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // แสดงข้อมู] PO ที่มีการส่งไปหา Odoo แล้ว
                tbWeightDetail.PO = cbbPO.Text;
                DataTable tb = tbWeightDetail.SELECT_PO_NOT_SEND_ODOO();
                if (tb.Rows.Count == 0)
                {
                    sc.Show(this, "ไม่พบรายการ PO ที่เลือก", BunifuSnackbar.MessageTypes.Warning, 3000, "", BunifuSnackbar.Positions.TopCenter);
                    return;
                }
                dgvDetail.DataSource = tb;
            }
        }

        private void guna2ComboBox1_DropDown(object sender, EventArgs e)
        {
            cbbPO.Items.Clear();
            DataTable tb = tbWeightDetail.SELECT_ODOO_DONT_SEND();

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
            tbWeightDetail.PO = cbbPO.Text;
            DataTable tb = tbWeightDetail.SELECT_PO_NOT_SEND_ODOO();
            if (tb.Rows.Count == 0)
            {
                sc.Show(this, "ไม่พบรายการ PO ที่เลือก", BunifuSnackbar.MessageTypes.Warning, 3000, "", BunifuSnackbar.Positions.TopCenter);
                return;
            }
            dgvDetail.DataSource = tb;


            // รวมจำนวนกล่องและน้ำหนักรวม
            ShowCountAndWeightTotal();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            frmPrint frmPrint = new frmPrint();
            frmPrint.ShowDialog();
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            frmHistorySuccess frmHistorySuccess = new frmHistorySuccess();
            frmHistorySuccess.ShowDialog();
        }
    }
}
