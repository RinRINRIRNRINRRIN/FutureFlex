using Bunifu.UI.WinForms;
using FutureFlex.API;
using FutureFlex.SQL;
using System;
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
            dgvDetail.DataSource = tbWeight.SELECT_SUCCESS();
        }

        private async void dgvDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvDetail.Columns[e.ColumnIndex].Name == "cl_btnDel")
                {
                    int wgh_id = Convert.ToInt16(dgvDetail.Rows[e.RowIndex].Cells["cl_wgh_id"].Value.ToString());
                    Console.WriteLine(wgh_id);
                    // ถามผู้ใช้
                    DialogResult dialogResult = MessageBox.Show("คุณต้องการลบข้อมูลหรือไม่", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        // ลบข้อมูลที่ odoo ก่อน 
                        if (await MRP.DELETE(wgh_id))
                        {
                            // ถ้าลบ odoo สำเร็จให้ลบข้อมูลใน db
                            tbWeight.DELETE_DATA(wgh_id);
                            dgvDetail.DataSource = tbWeight.SELECT_SUCCESS();
                        }
                        else
                        {
                            sc.Show(this, "เกิดข้อผิดผลาด " + MRP.err, BunifuSnackbar.MessageTypes.Error, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " dgvDetail");
                throw;
            }
        }

        private void gbMain_Click(object sender, EventArgs e)
        {

        }
    }
}
