using Bunifu.UI.WinForms;
using FutureFlex.API;
using FutureFlex.command;
using FutureFlex.SQL;
using System;
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



        private void frmHistoryWeight_Load(object sender, EventArgs e)
        {
            dgvDetail.DataSource = tbWeight.SELECT_NOT_SUCCESS();
        }

        private async void dgvDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = dgvDetail.Rows[e.RowIndex].Index;
            int wgh_id = Convert.ToInt16(dgvDetail.Rows[e.RowIndex].Cells["cl_wgh_id"].Value.ToString());
            if (dgvDetail.Columns[e.ColumnIndex].Name == "cl_btnSend")
            {
                dgvDetail.Columns["cl_btnDel"].Visible = false;
                await SelectData(d);
                MessageBox.Show("ส่งข้อมูลสำเร็จ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvDetail.DataSource = tbWeight.SELECT_NOT_SUCCESS();
            }
            else if (dgvDetail.Columns[e.ColumnIndex].Name == "cl_btnDel")
            {
                DialogResult dialog = MessageBox.Show("คุณต้องการจะลบข้อมูลหรือไม่ ข้อมูลที่ลบจะไม่ส่งผลกับ ODOO", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    if (tbWeight.DELETE_DATA(wgh_id))
                    {
                        dgvDetail.DataSource = tbWeight.SELECT_NOT_SUCCESS();
                    }
                    else
                    {
                        sc.Show(this, "เกิดข้อผิดผลาด", BunifuSnackbar.MessageTypes.Error, 2000, "OK", BunifuSnackbar.Positions.TopCenter);
                    }
                }
            }
        }

        async Task SelectData(int index)
        {
            // SELECT DATA
            string wgh_id = dgvDetail.Rows[index].Cells["cl_wgh_id"].Value.ToString();
            string[] wgh_dateTime = dgvDetail.Rows[index].Cells["cl_wgh_dateTime"].Value.ToString().Split(' ');
            string wgh_GVID = dgvDetail.Rows[index].Cells["cl_wgh_GVID"].Value.ToString();
            string wgh_po = dgvDetail.Rows[index].Cells["cl_wgh_po"].Value.ToString();
            string wgh_county = dgvDetail.Rows[index].Cells["cl_wgh_county"].Value.ToString();
            string wgh_type = dgvDetail.Rows[index].Cells["cl_wgh_type"].Value.ToString();
            string wgh_side = dgvDetail.Rows[index].Cells["cl_wgh_side"].Value.ToString();
            string wgh_weightPaper = dgvDetail.Rows[index].Cells["cl_wgh_weightPaper"].Value.ToString();
            string wgh_boxNum = dgvDetail.Rows[index].Cells["cl_wgh_boxNum"].Value.ToString();
            string wgh_weightCore = dgvDetail.Rows[index].Cells["cl_wgh_weightCore"].Value.ToString();
            string wgh_joint = dgvDetail.Rows[index].Cells["cl_wgh_joint"].Value.ToString();
            string wgh_numMeter = dgvDetail.Rows[index].Cells["cl_wgh_numMeter"].Value.ToString();
            string wgh_weightRoll = dgvDetail.Rows[index].Cells["cl_wgh_weightRoll"].Value.ToString();
            string wgh_machineOperator = dgvDetail.Rows[index].Cells["cl_wgh_machineOperator"].Value.ToString();
            string wgh_net = dgvDetail.Rows[index].Cells["cl_wgh_net"].Value.ToString();
            string wgh_tare = dgvDetail.Rows[index].Cells["cl_wgh_tare"].Value.ToString();
            string wgh_gross = dgvDetail.Rows[index].Cells["cl_wgh_gross"].Value.ToString();

            DateTime dateTime = DateTime.Parse(wgh_dateTime[0]);
            Console.WriteLine(dateTime);

            string[] dateA = wgh_dateTime[0].Split('/');

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
            if (await MRP.CREATE_MRP(wgh_GVID, wgh_id, wgh_machineOperator, wgh_county, wgh_type, wgh_side, wgh_po, newDate, wgh_net, wgh_tare, wgh_gross, wgh_weightPaper, wgh_weightCore, wgh_joint, wgh_weightRoll, wgh_boxNum, wgh_numMeter))
            {
                Console.WriteLine(wgh_id + "  Success");
                Console.WriteLine("=============================================================================");
                tbWeight.UPDATE_STATUS(Convert.ToInt16(wgh_id));
                BeginInvoke(new MethodInvoker(delegate ()
                {
                    dgvDetail.Rows[index].DefaultCellStyle.BackColor = Color.Green;
                    dgvDetail.Rows[index].DefaultCellStyle.ForeColor = Color.White;
                }));
            }
            else
            {
                BeginInvoke(new MethodInvoker(delegate ()
                {
                    dgvDetail.Rows[index].DefaultCellStyle.BackColor = Color.Red;
                    dgvDetail.Rows[index].DefaultCellStyle.ForeColor = Color.White;
                    sc.Show(this, MRP.err, BunifuSnackbar.MessageTypes.Error, 5000, "OK", BunifuSnackbar.Positions.TopCenter);
                }));
            }

            tbWeight.UPDATE_STATUS(int.Parse(wgh_id));
        }

        async Task SendData()
        {
            try
            {
                for (int i = 0; i < dgvDetail.Rows.Count; i++)
                {
                    await SelectData(i);
                    await Task.Delay(500);
                }



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        private async void bunifuButton1_Click(object sender, EventArgs e)
        {
            await Task.Run(SendData);
            dgvDetail.DataSource = tbWeight.SELECT_NOT_SUCCESS();
        }

    }
}
