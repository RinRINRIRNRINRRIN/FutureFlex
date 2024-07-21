using FutureFlex.SQL;
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;

namespace FutureFlex
{
    public partial class frmPrint : Form
    {
        public frmPrint()
        {
            InitializeComponent();
        }


        private void frmPrint_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void guna2TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbWeightDetail.PO = txtPO.Text;
                DataTable tb = tbWeightDetail.SELECT_PO_SUCCESS_ODOO();
                DataSet1 dataSet1 = new DataSet1();


                foreach (DataRow rw in tb.Rows)
                {
                    string _gvid = rw["wdt_GVID"].ToString();
                    string _po = rw["wdt_po"].ToString();
                    string _seq = rw["wdt_seq"].ToString();
                    string _net = rw["wdt_net"].ToString();
                    string _tare = rw["wdt_tare"].ToString();
                    string _gross = rw["wdt_gross"].ToString();
                    string _lot = rw["wdt_lot"].ToString();
                    dataSet1.tbWeightDetail.Rows.Add(_gvid, _po, _seq, _net, _tare, _gross, _lot);


                }
                // ตั้งค่าตัว DataSource ของ ReportViewer
                ReportDataSource rds = new ReportDataSource("DataSet1", dataSet1.Tables["tbWeightDetail"]);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(rds);

                // รีเฟรช ReportViewer
                this.reportViewer1.RefreshReport();

            }
        }
    }
}
