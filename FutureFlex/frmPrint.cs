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
            CreateColumne(tbBox);
            CreateColumne(tbRoll);

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


            if (PO == "JIT")
            {
                tb = tbWeightDetail.SELECT_GVorRTFGor_SPL_formHistorySuccess(type, GV_name, "JIT");
            }
            else
            {
                tb = tbWeightDetail.SearchPoAndWeightType(PO, type);
            }

            // Get data tbweight
            foreach (DataRow rw in tb.Rows)
            {
                string _gvname = rw["wdt_gv_name"].ToString();
                string _rtfg = rw["wdt_rtfg_name"].ToString();
                string _spl_name = rw["wdt_spl_name"].ToString();
                if (_rtfg != "")
                {
                    GvOrRTFGNumber = _rtfg;
                }
                else if (_spl_name != "")
                {
                    GvOrRTFGNumber = _spl_name;
                }
                else
                {
                    GvOrRTFGNumber = _gvname;
                }
                // Get ดึงข้อมูลหลักของ tbweight
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

            string _gvid = "";
            string _po = "";
            string _seq = "";
            string _net = "";
            string numPch = "";
            string _lot = "";
            string _employee = "";
            // เช็คว่ามีกล่องไหม
            foreach (DataRow rw in tb.Rows)
            {
                if (rw["wdt_type"].ToString() == "box")
                {
                    tbBox.Rows.Add("", "", "กล่อง", "", "", "", "");
                    // loop get box
                    foreach (DataRow rw2 in tb.Rows)
                    {
                        if (rw2["wdt_type"].ToString() == "box")
                        {
                            _gvid = rw2["wdt_gv_name"].ToString();
                            _po = rw2["wdt_po"].ToString();
                            _seq = rw2["wdt_seqOrigin"].ToString();
                            _net = rw2["wdt_net"].ToString();

                            numPch = $"{double.Parse(rw2["wdt_pch"].ToString()).ToString("#,###")} ใบ";
                            _lot = rw2["wdt_lot"].ToString();
                            _employee = rw2["wdt_employee"].ToString();

                            totalPch = totalPch + double.Parse(rw2["wdt_pch"].ToString());
                            totalNet = totalNet + double.Parse(rw2["wdt_net"].ToString());
                            tbBox.Rows.Add(_gvid, _po, _seq, _net, numPch, _lot, _employee);
                        }
                    }
                    break;
                }
            }

            // เช็คว่ามีม้วนไหม
            foreach (DataRow rw in tb.Rows)
                {
                if (rw["wdt_type"].ToString() == "roll")
                {
                    tbBox.Rows.Add("", "", "ม้วน", "", "", "", "");
                    // loop get box
                    foreach (DataRow rw2 in tb.Rows)
                    {
                        if (rw2["wdt_type"].ToString() == "roll")
                        {
                            _gvid = rw2["wdt_gv_name"].ToString();
                            _po = rw2["wdt_po"].ToString();
                            _seq = rw2["wdt_seqOrigin"].ToString();
                            _net = rw2["wdt_net"].ToString();
                            Console.WriteLine(double.Parse(rw2["wdt_meter_kg_in_roll"].ToString()).ToString("#,###"));
                            Console.WriteLine(double.Parse(rw2["wdt_pch"].ToString()).ToString("#,###"));
                            numPch = $"{double.Parse(rw2["wdt_meter_kg_in_roll"].ToString()).ToString("#,###")}ม./{double.Parse(rw2["wdt_pch"].ToString()).ToString("#,###")}ใบ";
                            _lot = rw2["wdt_lot"].ToString();
                            _employee = rw2["wdt_employee"].ToString();


                            totalPch = totalPch + double.Parse(rw2["wdt_pch"].ToString());
                            totalNet = totalNet + double.Parse(rw2["wdt_net"].ToString());
                            tbRoll.Rows.Add(_gvid, _po, _seq, _net, numPch, _lot, _employee);
                        }
                    }
                        break;
                }
            }


            // รวม tbBox and tbRoll to tbWeight
            foreach (DataRow rw in tbBox.Rows)
            {
                _gvid = rw["gv_name"].ToString();
                _po = rw["po"].ToString();
                _seq = rw["seq"].ToString();
                _net = rw["net"].ToString();

                numPch = rw["numPch"].ToString();
                _lot = rw["lot"].ToString();
                _employee = rw["employee"].ToString();

                dataSet1.tbWeightDetail.Rows.Add(_gvid, _po, _seq, _net, numPch, _lot, _employee);
                }


            // รวม tbBox and tbRoll to tbWeight
            foreach (DataRow rw in tbRoll.Rows)
            {
                _gvid = rw["gv_name"].ToString();
                _po = rw["po"].ToString();
                _seq = rw["seq"].ToString();
                _net = rw["net"].ToString();

                numPch = rw["numPch"].ToString();
                _lot = rw["lot"].ToString();
                _employee = rw["employee"].ToString();

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
            ReportParameter _GvOrRtfg = new ReportParameter("GvOrRTFG", type);

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
