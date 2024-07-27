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

        private void cbbPO_DropDown(object sender, EventArgs e)
        {
            cbbPO.Items.Clear();
            DataTable tb = tbWeightDetail.SELECT_ODOO_DONT_SEND();

            string _opNew = "";
            string _poOld = "";

            foreach (DataRow rw in tb.Rows)
            {
                _opNew = rw["wdt_po"].ToString();
                if (_opNew != _poOld)
                {
                    cbbPO.Items.Add(_opNew);
                    _poOld = _opNew;
                }
            }
        }

        private void cbbPO_SelectedIndexChanged(object sender, EventArgs e)
        {
            // กำหนด PO
            tbWeightDetail.PO = cbbPO.Text;
            DataTable tb = new DataTable();

            string productName = "";
            string customerName = "";
            string date = DateTime.Now.ToString("dd/MM/yyyy");
            string jobScale = "";
            double totalPch = 0;
            int totalList = 0;
            double totalNet = 0;

            tb = tbWeightDetail.SELECT_PO_NOT_SEND_ODOO();
            // Get data tbweight
            foreach (DataRow rw in tb.Rows)
            {
                string _gvname = rw["wdt_GVID"].ToString();
                DataTable tb1 = tbWeight.SELECT_SELECT_GV(_gvname);
                foreach (DataRow rw1 in tb1.Rows)
                {
                    productName = $"({rw1["wgh_productID"]} {rw1["wgh_product"]})";
                    customerName = rw1["wgh_customer"].ToString();
                    jobScale = rw1["wgh_typeSuccess"].ToString();
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
                string _employee = rw["wdt_employee"].ToString();

                totalPch = totalPch + double.Parse(rw["wdt_pch"].ToString());
                totalNet = totalNet + double.Parse(rw["wdt_net"].ToString());
                dataSet1.tbWeightDetail.Rows.Add(_gvid, _po, _seq, _net, _tare, _gross, _lot, _employee);
            }
            totalList = tb.Rows.Count;


            // Set parameter
            ReportParameter _productName = new ReportParameter("productName", productName);  // กำหนดค่า parameter 
            ReportParameter _customerName = new ReportParameter("customerName", customerName);  // กำหนดค่า parameter 
            ReportParameter _date = new ReportParameter("date", date);  // กำหนดค่า parameter 
            ReportParameter _jobScale = new ReportParameter("jobscale", jobScale);  // กำหนดค่า parameter 
            ReportParameter _totalList = new ReportParameter("totalList", totalList.ToString());  // กำหนดค่า parameter 
            ReportParameter _totalPch = new ReportParameter("totalPch", totalPch.ToString());  // กำหนดค่า parameter 
            ReportParameter _totalNet = new ReportParameter("totalNet", totalNet.ToString());  // กำหนดค่า parameter 

            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { _productName });
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { _customerName });
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { _date });
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { _jobScale });
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { _totalList });
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { _totalPch });
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { _totalNet });

            // ตั้งค่าตัว DataSource ของ ReportViewer
            ReportDataSource rds = new ReportDataSource("DataSet1", dataSet1.Tables["tbWeightDetail"]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);

            // รีเฟรช ReportViewer
            this.reportViewer1.RefreshReport();
        }
    }
}
