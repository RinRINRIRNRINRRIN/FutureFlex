using Bunifu.UI.WinForms;
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

        string statusOdoo = ""; // keep data search

        private void guna2TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPO.Text == "")
                {
                    sb.Show(this, "กรุณากรอกข้อมูล PO ที่ต้องการค้นหา", BunifuSnackbar.MessageTypes.Warning, 3000, "", BunifuSnackbar.Positions.TopCenter);
                    return;
                }

                // กำหนด PO
                tbWeightDetail.PO = txtPO.Text;
                DataTable tb = new DataTable();

                string productName = "";
                string customerName = "";
                string date = "";
                string jobScale = "";
                double totalPch = 0;
                int totalList = 0;

                tb = tbWeightDetail.SELECT_PO_NOT_SEND_ODOO();
                // Get data tbweight
                foreach (DataRow rw in tb.Rows)
                {
                    string _gvname = rw["wdt_GVID"].ToString();
                    DataTable tb1 = tbWeight.SELECT_SELECT_GV(_gvname);
                    foreach (DataRow rw1 in tb1.Rows)
                    {
                        productName = rw1["wgh_product"].ToString();
                        customerName = rw1["wgh_customer"].ToString();
                        jobScale = rw1["wgh_typeSuccess"].ToString();
                        string[] _datea = rw1["wgh_date"].ToString().Split(' ');
                        date = _datea[0];
                        break;
                    }
                    break;
                }



                DataSet1 dataSet1 = new DataSet1();
                // Get data tbweightDetail
                foreach (DataRow rw in tb.Rows)
                {
                    string _gvid = rw["wdt_GVID"].ToString();
                    string _po = rw["wdt_po"].ToString();
                    string _seq = rw["wdt_seq"].ToString();
                    string _net = rw["wdt_net"].ToString();
                    string _tare = rw["wdt_tare"].ToString();
                    string _gross = rw["wdt_gross"].ToString();
                    string _lot = rw["wdt_lot"].ToString();
                    totalPch = totalPch + double.Parse(rw["wdt_pch"].ToString());
                    dataSet1.tbWeightDetail.Rows.Add(_gvid, _po, _seq, _net, _tare, _gross, _lot);
                }
                totalList = tb.Rows.Count;


                // Set parameter
                ReportParameter _productName = new ReportParameter("productName", productName);  // กำหนดค่า parameter 
                ReportParameter _customerName = new ReportParameter("customerName", customerName);  // กำหนดค่า parameter 
                ReportParameter _date = new ReportParameter("date", date);  // กำหนดค่า parameter 
                ReportParameter _jobScale = new ReportParameter("jobscale", jobScale);  // กำหนดค่า parameter 
                ReportParameter _totalList = new ReportParameter("totalList", totalList.ToString());  // กำหนดค่า parameter 
                ReportParameter _totalPch = new ReportParameter("totalPch", totalPch.ToString());  // กำหนดค่า parameter 

                reportViewer1.LocalReport.SetParameters(new ReportParameter[] { _productName });
                reportViewer1.LocalReport.SetParameters(new ReportParameter[] { _customerName });
                reportViewer1.LocalReport.SetParameters(new ReportParameter[] { _date });
                reportViewer1.LocalReport.SetParameters(new ReportParameter[] { _jobScale });
                reportViewer1.LocalReport.SetParameters(new ReportParameter[] { _totalList });
                reportViewer1.LocalReport.SetParameters(new ReportParameter[] { _totalPch });

                // ตั้งค่าตัว DataSource ของ ReportViewer
                ReportDataSource rds = new ReportDataSource("DataSet1", dataSet1.Tables["tbWeightDetail"]);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(rds);

                // รีเฟรช ReportViewer
                this.reportViewer1.RefreshReport();

            }
        }

        private void RAIDO_BUTTON_CHECK(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            BunifuRadioButton rdb = sender as BunifuRadioButton;
            switch (rdb.Tag)
            {
                case "NOTSEND":
                    statusOdoo = "NOTSEND";
                    break;
                case "SEND":
                    statusOdoo = "SEND";
                    break;
            }
        }

        private void txtPO_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
