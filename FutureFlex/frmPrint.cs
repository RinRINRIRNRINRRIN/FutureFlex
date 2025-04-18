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

        public string PO { get; set; }
        /// <summary>
        /// สำหรับบอกว่าการพิมพ์รายงานก่อนส่งหา odoo นั้นเป็นรายงานแบไหน SPL,GV,RTFG เพื่อไปกำหนดค่าที่ RDLC
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// สำหรับกำหนดค่าให้กับ GV หากการพิมพ์ข้อมูลก่อนส่งหา odoo นั้นเป้นการพิมพ์แบบ Gv
        /// </summary>
        public string GV_name { get; set; }

        DataTable tbBox { get; set; } = new DataTable();
        DataTable tbRoll { get; set; } = new DataTable();

        void CreateColumne(DataTable tb)
        {
            tb.Columns.Add("gv_name");
            tb.Columns.Add("po");
            tb.Columns.Add("seq");
            tb.Columns.Add("net");
            tb.Columns.Add("numPch");
            tb.Columns.Add("lot");
            tb.Columns.Add("employee");
        }


        private void frmPrint_Load(object sender, EventArgs e)
        {
            // กำหนด PO
            tbWeightDetail.PO = PO;
            DataTable tb = new DataTable();

            string GvOrRTFGNumber = "";
            string productName = "";
            string customerName = "";
            string date = DateTime.Now.ToString("dd/MM/yyyy");
            string jobScale = "";
            double totalPch = 0;
            int totalList = 0;
            double totalNet = 0;

            if (PO == "JIT" || PO == "ไม่มีPO")
            {
                tb = tbWeightDetail.SELECT_JIT_NOT_SEND_ODOO(GvOrRTFG);
            }
            else
            {
                tb = tbWeightDetail.SELECT_PO_NOT_SEND_ODOO();
            }

            // Get data tbweight
            foreach (DataRow rw in tb.Rows)
            {
                string _gvname = rw["wdt_gv_name"].ToString();
                string _rtfg = rw["wdt_rtfg_name"].ToString();
                if (_rtfg == "")
                {
                    GvOrRTFGNumber = _gvname;
                }
                else
                {
                    GvOrRTFGNumber = _rtfg;
                }
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
                string _gvid = rw["wdt_gv_name"].ToString();
                string _po = rw["wdt_po"].ToString();
                string _seq = rw["wdt_seqOrigin"].ToString();
                string _net = rw["wdt_net"].ToString();

                string numPch = "";
                switch (rw["wdt_type"].ToString())
                {
                    case "box":
                        numPch = $"{double.Parse(rw["wdt_pch"].ToString()).ToString("#,###")} ใบ";
                        break;
                    case "roll":

                        numPch = $"{double.Parse(rw["wdt_meter_kg_in_roll"].ToString()).ToString("#,###.00")}ม./{double.Parse(rw["wdt_pch"].ToString()).ToString("#,###")}ใบ";
                        break;
                }

                string _lot = rw["wdt_lot"].ToString();
                string _employee = rw["wdt_employee"].ToString();

                totalPch = totalPch + double.Parse(rw["wdt_pch"].ToString());
                totalNet = totalNet + double.Parse(rw["wdt_net"].ToString());
                dataSet1.tbWeightDetail.Rows.Add(_gvid, _po, _seq, _net, numPch, _lot, _employee);
            }
            totalList = tb.Rows.Count;


            // Set parameter
            ReportParameter _productName = new ReportParameter("productName", productName);  // กำหนดค่า parameter 
            ReportParameter _customerName = new ReportParameter("customerName", customerName);  // กำหนดค่า parameter 
            ReportParameter _date = new ReportParameter("date", date);  // กำหนดค่า parameter 
            ReportParameter _jobScale = new ReportParameter("jobscale", jobScale);  // กำหนดค่า parameter 
            ReportParameter _totalList = new ReportParameter("totalList", totalList.ToString("#,###"));
            ReportParameter _totalPch = new ReportParameter("totalPch", totalPch.ToString("#,###"));  // กำหนดค่า parameter 
            ReportParameter _totalNet = new ReportParameter("totalNet", totalNet.ToString("#,###.00"));  // กำหนดค่า parameter 
            ReportParameter _GvOrRTFGNumber = new ReportParameter("rtpGvOrRTFGNumber", GvOrRTFGNumber);
            bool _gvRtft = false;
            switch (GvOrRTFG)
            {
                case "GV":
                    _gvRtft = true;
                    break;
                case "RTFG":
                    _gvRtft = false;
                    break;
            }
            ReportParameter _GvOrRtfg = new ReportParameter("GvOrRTFG", _gvRtft.ToString());

            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { _productName });
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { _customerName });
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { _date });
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { _jobScale });
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { _totalList });
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { _totalPch });
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { _totalNet });
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { _GvOrRtfg });
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { _GvOrRTFGNumber });

            // ตั้งค่าตัว DataSource ของ ReportViewer
            ReportDataSource rds = new ReportDataSource("DataSet1", dataSet1.Tables["tbWeightDetail"]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            // รีเฟรช ReportViewer
            this.reportViewer1.RefreshReport();

        }

        private void reportViewer1_PrintingBegin(object sender, ReportPrintEventArgs e)
        {

            Console.WriteLine("PrintBegin");
            this.Close();
        }

        private void reportViewer1_Print(object sender, ReportPrintEventArgs e)
        {

        }
    }
}
