using FutureFlex.API;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutureFlex
{
    public partial class frmRTFGList : Form
    {
        public frmRTFGList()
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

            if (await RTFG.PO.Return_list(txtPO.Text))
            {
            dgvDetail.DataSource = RTFG.Mrp_list_return;
        }
            else
            {
                msg.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                msg.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                msg.Show($"Not found {txtPO.Text}", "Not found RTFG Number");
                return false;
            }
            return true;
        }


        /// <summary>
        /// ชั่งเพื่อเก็บ
        /// </summary>
        async Task<bool> GetJit(string rtfg)
        {
            await Task.Delay(1000);

            if (await RTFG.JIT.Return_num(rtfg))
            {

                dgvDetail.DataSource = RTFG.Mrp_list_return;
                }
                else
                {
                    msg.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                    msg.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                msg.Show($"Not found {txtRTFG.Text}", "Not found RTFG Number");
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
                    if (!await GetJit($"RTFG{txtRTFG.Text}"))
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

        private void frmRTFGList_Load(object sender, System.EventArgs e)
        {
            gbWeightPoOrJit.Visible = true;
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
                            if (!await MRP.GET_MRP($"{value}"))
                            {
                                msg.Buttons = MessageDialogButtons.OK;
                                msg.Icon = MessageDialogIcon.Warning;
                                msg.Show($"Not found : {value}", "Not found");
                                return;
                            }
                        }
                        if (value.Contains("RTFG"))
                        {

                            panel1.Visible = false;
                            gbLoadData.Visible = true;
                            // ลองดึงข้อมูลเพื่อไปกำหนดหน้าชั่งหากพบข้อมูล
                            if (!await RTFG.JIT.Return_num(value))
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
                        frmRTFG frmRTFG = new frmRTFG();
                        frmRTFG.weightType = weightTyep;
                        frmRTFG.ShowDialog();

                        break;


                }
            }
            catch
            {

            }
        }

        private void btnWeight_Click(object sender, System.EventArgs e)
        {
            if (txtPO.Text == "" && txtRTFG.Text == "")
            {
                msg.Icon = MessageDialogIcon.Warning;
                msg.Buttons = MessageDialogButtons.OK;
                msg.Show("Please fill the data", "Empty data");
                return;
            }

            Check(weightTyep);
            }

        private void guna2RadioButton2_CheckedChanged(object sender, System.EventArgs e)
        {
            Guna2RadioButton rdb = sender as Guna2RadioButton;
            if (rdb.Checked)
            {
                switch (rdb.Tag.ToString())
                {
                    case "JIT":

                        txtRTFG.Enabled = true;
                        txtPO.Enabled = false;
                        gbData.Text = "รายการ RTFG";
                        dgvDetail.Columns["cl_name"].HeaderText = "GV NAME";
                        break;
                    case "PO":
                        txtRTFG.Enabled = false;
                        txtPO.Enabled = true;
                        gbData.Text = "รายการ GV";
                        dgvDetail.Columns["cl_name"].HeaderText = "RTFG NAME";
                        break;
                }
                weightTyep = rdb.Tag.ToString();
            }
        }

        private void guna2GradientButton1_Click(object sender, System.EventArgs e)
        {
            panel1.Visible = false;
            gbWeightPoOrJit.Visible = true;
        }
    }
}
