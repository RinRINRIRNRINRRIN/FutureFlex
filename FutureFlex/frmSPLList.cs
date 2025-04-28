using FutureFlex.API;
using Guna.UI2.WinForms;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutureFlex
{
    public partial class frmSPLList : Form
    {
        public frmSPLList()
        {
            InitializeComponent();

            int x = (this.Width - gbWeightPoOrJit.Width) / 2;
            int y = (this.Height - gbWeightPoOrJit.Height) / 2;
            gbWeightPoOrJit.Location = new System.Drawing.Point(x, y);

            x = (this.Width - gbLoadData.Width) / 2;
            y = (this.Height - gbLoadData.Height) / 2;

            gbLoadData.Location = new System.Drawing.Point(x, y);
        }

        /// <summary>
        /// เก็บว่าต้องการชั่ง PO หรือ JIT
        /// </summary>
        public string weightTyep { get; set; }
        async Task<bool> GetPO()
        {
            await Task.Delay(1000);

            if (await SLP.Split_list(txtPO.Text))
            {
                dgvDetail.DataSource = SLP.Mrp_list_return;
            }
            else
            {
                msg.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                msg.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                msg.Show($"Not found {txtPO.Text}", "Not found SPLIT Number");
                return false;
            }
            return true;
        }


        /// <summary>
        /// ชั่งเพื่อเก็บ
        /// </summary>
        async Task<bool> GetJit(string split)
        {
            await Task.Delay(1000);

            if (await SLP.Split_num(split))
            {

                dgvDetail.DataSource = SLP.Mrp_list_return;
            }
            else
            {
                msg.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                msg.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                msg.Show($"Not found {txtSPL.Text}", "Not found SPLIT Number");
                return false;
            }
            return true;

        }

        async void Check(string value)
        {
            gbWeightPoOrJit.Visible = false;
            gbLoadData.Visible = true;
            switch (value)
            {
                case "JIT":
                    if (!await GetJit($"SPL{txtSPL.Text}"))
                    {
                        gbLoadData.Visible = false;
                        gbWeightPoOrJit.Visible = true;
                        return;
                    }
                    break;
                case "PO":
                    if (!await GetPO())
                    {
                        gbLoadData.Visible = false;
                        gbWeightPoOrJit.Visible = true;
                        return;
                    }
                    break;
            }
            gbLoadData.Visible = false;
            gbWeightPoOrJit.Visible = false;
            panel1.Visible = true;
        }

        private void txtJobNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Guna2TextBox btn = sender as Guna2TextBox;
                Check(btn.Tag.ToString());
            }
        }

        private void frmSPLList_Load(object sender, EventArgs e)
        {
            gbWeightPoOrJit.Visible = true;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtPO.Text == "" && txtSPL.Text == "")
            {
                msg.Icon = MessageDialogIcon.Warning;
                msg.Buttons = MessageDialogButtons.OK;
                msg.Show("Please fill the data", "Empty data");
                return;
            }

            Check(weightTyep);
        }

        private async void dgvDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                switch (dgvDetail.Columns[e.ColumnIndex].Name)
                {
                    case "cl_rtfg":
                        string value = dgvDetail.Rows[e.RowIndex].Cells["cl_name"].Value.ToString();
                        if (value.Contains("GV"))
                        {
                            // ลองดึงข้อมูลเพื่อไปกำหนดหน้าชั่งหากพบข้อมูล
                            if (!await MRP.GET_MRP($"{value}", ""))
                            {
                                msg.Buttons = MessageDialogButtons.OK;
                                msg.Icon = MessageDialogIcon.Warning;
                                msg.Show($"Not found : {value}", "Not found");
                                return;
                            }
                        }
                        if (value.Contains("SPL"))
                        {

                            panel1.Visible = false;
                            gbLoadData.Visible = true;
                            // ลองดึงข้อมูลเพื่อไปกำหนดหน้าชั่งหากพบข้อมูล
                            if (!await SLP.Split_num(value))
                            {
                                msg.Buttons = MessageDialogButtons.OK;
                                msg.Icon = MessageDialogIcon.Warning;
                                msg.Show($"Not found : {value}", "Not found");
                                return;
                            }

                            await GetJit(value);

                            panel1.Visible = true;
                            gbLoadData.Visible = false;


                            return;
                        }


                        // แสดงหน้าชั่ง
                        frmSplit frmRTFG = new frmSplit();
                        frmRTFG.weightType = weightTyep;
                        frmRTFG.ShowDialog();

                        break;


                }
            }
            catch
            {

            }
        }

        private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Guna2RadioButton rdb = sender as Guna2RadioButton;
            if (rdb.Checked)
            {
                switch (rdb.Tag.ToString())
                {
                    case "JIT":

                        txtSPL.Enabled = true;
                        txtPO.Enabled = false;
                        gbData.Text = "รายการ SPLIT";
                        dgvDetail.Columns["cl_name"].HeaderText = "GV NAME";
                        break;
                    case "PO":
                        txtSPL.Enabled = false;
                        txtPO.Enabled = true;
                        gbData.Text = "รายการ GV";
                        dgvDetail.Columns["cl_name"].HeaderText = "SPLIT NAME";
                        break;
                }
                weightTyep = rdb.Tag.ToString();
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            gbWeightPoOrJit.Visible = true;
        }
    }
}
