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
            // จัดหน้าจอ
            int x = (this.Width - gbLoadData.Width) / 2;
            int y = (this.Height - gbLoadData.Height) / 2;
            gbLoadData.Location = new System.Drawing.Point(x, y);
            gbLoadData.Visible = false;
        }

        private void dgvDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                switch (dgvDetail.Columns[e.ColumnIndex].Name)
                {
                    case "cl_rtfg":
                        frmRTFG frm = new frmRTFG();
                        frm.Rtfg_id = RTFG.Rtfg_ID;
                        frm.Rtfg_name = RTFG.Name;
                        frm.mo_file = MRP.mo_film;
                        frm.Gv_id = dgvDetail.Rows[e.RowIndex].Cells["cl_name"].Value.ToString();
                        frm.mo_date = dgvDetail.Rows[e.RowIndex].Cells["cl_mo_date"].Value.ToString();
                        frm.mo_date_delivery = dgvDetail.Rows[e.RowIndex].Cells["cl_mo_date_delivery"].Value.ToString();
                        frm.mo_work = dgvDetail.Rows[e.RowIndex].Cells["cl_mo_work"].Value.ToString();
                        frm.partner_name = dgvDetail.Rows[e.RowIndex].Cells["cl_partner"].Value.ToString();
                        frm.product_uom_name = RTFG.Product_uom_name;
                        frm.product_name = dgvDetail.Rows[e.RowIndex].Cells["cl_product"].Value.ToString();
                        frm.mo_type = dgvDetail.Rows[e.RowIndex].Cells["cl_mo_type"].Value.ToString();
                        frm.uom_id = dgvDetail.Rows[e.RowIndex].Cells["cl_uom"].Value.ToString();
                        frm.ReturnQtyPch = RTFG.Return_qty_pch.ToString();
                        frm.ReturnQtyWeight = RTFG.Return_qty_weight.ToString();
                        frm.ShowDialog();
                        break;
                }
            }
            catch (System.Exception ex)
            {


            }
        }
    }
}
