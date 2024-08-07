using Bunifu.UI.WinForms;
using ClosedXML.Excel;
using FutureFlex.SQL;
using Serilog;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FutureFlex
{
    public partial class frmHistorySuccess : Form
    {
        public frmHistorySuccess()
        {
            InitializeComponent();
        }


        BunifuSnackbar sc = new BunifuSnackbar();



        private void frmHistorySuccess_Load(object sender, EventArgs e)
        {
            dgvDetail.DefaultCellStyle.ForeColor = Color.Black;
        }

        private async void dgvDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gbMain_Click(object sender, EventArgs e)
        {

        }

        private void cbbPO_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvDetail.Rows.Clear();
            DataTable tb = tbWeightDetail.SELECT_GV(cbbPO.Text);

            foreach (DataRow rw in tb.Rows)
            {
                lblCustomer.Text = rw["wgh_customer"].ToString();
                lblProduct.Text = rw["wgh_product"].ToString();
                lblPO.Text = rw["wdt_po"].ToString();
                lblStructure.Text = rw["wgh_structure"].ToString();
                lblJobType.Text = rw["wgh_typeSuccess"].ToString();

                string _status = rw["wdt_statusOdoo"].ToString();
                string _seq = rw["wdt_seq"].ToString();
                string _numBox = rw["wdt_numBox"].ToString();
                string _numRoll = rw["wdt_numRoll"].ToString();
                string _numPch = rw["wdt_pch"].ToString();
                string _net = rw["wdt_net"].ToString();
                string _oparator = rw["wdt_oparator"].ToString();
                string _employee = rw["wdt_employee"].ToString();
                string[] _date = rw["wdt_date"].ToString().Split(' ');
                string _lot = rw["wdt_lot"].ToString();

                string num = "";
                if (_numBox == "0")
                {
                    num = _numRoll;
                }
                else if (_numRoll == "0")
                {
                    num = _numBox;
                }

                string _state = "";
                if (_status == "NOT SEND")
                {
                    _state = "ยังไม่ส่ง";
                }
                else if (_status == "SEND")
                {
                    _state = "ส่งแล้ว";
                }

                dgvDetail.Rows.Add(_state, _seq, num, _numPch, _net, _date[0], _oparator, _employee, _lot);
            }

            foreach (DataGridViewRow rw in dgvDetail.Rows)
            {
                string _status = rw.Cells["cl_status"].Value.ToString();
                switch (_status)
                {
                    case "ยังไม่ส่ง":
                        rw.Cells["cl_status"].Style.ForeColor = Color.Red;
                        break;
                    case "ส่งแล้ว":
                        rw.Cells["cl_status"].Style.ForeColor = Color.Green;
                        break;
                }
                rw.Cells["cl_status"].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                rw.Cells["cl_status"].Style.Font = new Font("Athiti", 10, FontStyle.Bold);
            }
        }

        private void cbbPO_DropDown(object sender, EventArgs e)
        {
            cbbPO.Items.Clear();
            DataTable tb = tbWeight.SELECT_ALL_DATA();

            foreach (DataRow rw in tb.Rows)
            {
                cbbPO.Items.Add(rw["wgh_GV"].ToString());
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sa = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sa.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook el = new XLWorkbook())
                        {
                            DataTable tb = new DataTable();
                            // เพิ่มคอลัมน์ใน DataTable จาก DataGridView
                            foreach (DataGridViewColumn column in dgvDetail.Columns)
                            {
                                tb.Columns.Add(column.HeaderText);
                            }

                            // เพิ่มแถวใน DataTable จาก DataGridView
                            foreach (DataGridViewRow row in dgvDetail.Rows)
                            {
                                if (row.IsNewRow) continue; // ข้ามแถวใหม่ (ที่ยังไม่ได้เพิ่มข้อมูล)

                                DataRow dataRow = tb.NewRow();
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    dataRow[cell.ColumnIndex] = cell.Value;
                                }
                                tb.Rows.Add(dataRow);
                            }
                            el.Worksheets.Add(tb, "Data export");
                            el.SaveAs(sa.FileName);
                        }
                        sc.Show(this, "Export รายการสำเร็จ", BunifuSnackbar.MessageTypes.Success, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                    }
                    catch (Exception ex)
                    {
                        sc.Show(this, "เกิดข้อผิดผลาก " + ex.Message, BunifuSnackbar.MessageTypes.Error, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                        Log.Error("EXPORT EXCEL : " + ex.Message);
                    }
                }
            }
        }
    }
}
