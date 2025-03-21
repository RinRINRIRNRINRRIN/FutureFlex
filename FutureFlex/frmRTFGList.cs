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

        void Showdata()
        {
            lblName.Text = RTFG.Name;
            lblPurchaseOrder.Text = RTFG.Po_customer;
            lblDeliveryOrder.Text = RTFG.Do_no;
            lblReturnQtyPch.Text = RTFG.Return_qty_pch.ToString();
            lblRetrunQtyWeight.Text = RTFG.Return_qty_weight.ToString() + " Kg.";
            lblDate.Text = RTFG.EffectiveDate;
            Console.WriteLine($"======================================  Import datatable to datagridview");
            for (int i = 0; i < RTFG.Mrp_list_return.Columns.Count; i++)
            {
                Console.WriteLine($"Column name : {RTFG.Mrp_list_return.Columns[i].ColumnName}");
            }
            dgvDetail.DataSource = RTFG.Mrp_list_return;
        }

        private async void txtJobNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                panel1.Visible = false;
                gbLoadData.Visible = true;
                await Task.Delay(500);
                if (await RTFG.Get_rtfg($"RTFG{txtJobNo.Text}"))
                {
                    Showdata();
                }
                else
                {
                    msg.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                    msg.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                    msg.Show($"Not found {txtJobNo.Text}", "Not found RTFG Number");
                }

                gbLoadData.Visible = false;
                panel1.Visible = true;
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
