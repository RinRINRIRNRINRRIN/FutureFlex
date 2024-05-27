using Bunifu.UI.WinForms;
using FutureFlex.API;
using FutureFlex.Function;
using FutureFlex.SQL;
using Newtonsoft.Json.Linq;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;
using ZXing;

namespace FutureFlex
{
    public partial class frmWeightNew : Form
    {
        public frmWeightNew()
        {
            InitializeComponent();

            foreach (var txt in panel2.Controls.OfType<Guna.UI2.WinForms.Guna2TextBox>())
            {
                txt.Text = "0";
                txt.Enabled = false;
            }

            this.FormBorderStyle = FormBorderStyle.None;
            dgvDetail.ColumnHeadersDefaultCellStyle.Font = new Font("Athiti", 12, System.Drawing.FontStyle.Regular);
            dgvDetail.DefaultCellStyle.Font = new Font("Athiti", 12, System.Drawing.FontStyle.Regular);
            dgvDetail.DefaultCellStyle.ForeColor = Color.Black;

            cbbPO.Items.Clear();
            cbbPO.Items.Add("--เลือกเลขที่ PO--");
            cbbPO.SelectedIndex = 0;

            gbData.Enabled = false;
        }

        #region "LOCAL VARIABLE"
        string statusType = "";     ///// ใช่้สำหรับเก็บค่า การเลือกประเภท จาก Groupbox 
        string statusCounty = "";   ///// ใช่้สำหรับเก็บค่า การเลือกประเทศ จาก Groupbox 
        string statusSide = "";     ///// ใช่้สำหรับเก็บค่า การเลือกด้าน จาก Groupbox 
        bool statusPrint = false;    // ใช้สำหรับเก็บค่า การพิมพ์แบบ Auto หรือไม่ | true = AutoPrint ,False = ShowDialog before print
        bool statusRePrintSeq = false; // ใช้สำหรับเก็บค่า การลบหากลบแล้วต้องการ reprint ลำดับการชั่งใหม่หรือไม่ | true = Reprint , False = Not RePrint

        int wgh_id = 0;

        BunifuSnackbar sb = new BunifuSnackbar();
        #endregion


        #region Function Local

        void ClearForm()
        {
            statusCounty = "";
            statusSide = "";
            statusType = "";

            txtJobNo.Clear();

            cbbPO.Items.Clear();
            cbbPO.Items.Add("--เลือกเลขที่ PO--");
            cbbPO.SelectedIndex = 0;

            gbData.CustomBorderColor = Color.Navy;
            gbData.BorderColor = Color.Navy;

            foreach (var lbl in panel1.Controls.OfType<Label>())
            {
                lbl.Text = "......";
            }

            foreach (var gbChilden in gbData.Controls.OfType<Guna.UI2.WinForms.Guna2GroupBox>())
            {

                foreach (var rdb in gbChilden.Controls.OfType<RadioButton>())
                {
                    rdb.Checked = false;
                }

            }

            foreach (var txt in gbData.Controls.OfType<Guna.UI2.WinForms.Guna2TextBox>())
            {
                txt.Text = "0";
                txt.Enabled = false;
            }

            dgvDetail.Rows.Clear();
            label33.Text = "0";
            lbTotalWgh.Text = "0.0";

        }

        /// <summary>
        /// สำหรับเรียกดูข้อมูลใหม่
        /// </summary>
        /// <param name="status">เพิ่มหรือลบ ADD,DEL</param>
        void ShowData()
        {
            DataTable tb = tbWeight.SELECT_SEARCH(cbbPO.Text);
            dgvDetail.DataSource = tb;

            label33.Text = "0";
            lbTotalWgh.Text = "00.00";

            if (dgvDetail.Rows.Count != 0)
            {

                label33.Text = Convert.ToString(tb.Rows.Count);
                foreach (DataRow rw in tb.Rows)
                {
                    double c = Convert.ToDouble(rw["wgh_net"].ToString());

                    double g = 0;
                    string n = "0";

                    g = c + Convert.ToDouble(lbTotalWgh.Text);
                    n = g.ToString("#0.00");
                    lbTotalWgh.Text = n;
                }
                foreach (DataGridViewRow rw in dgvDetail.Rows)
                {
                    rw.Cells["cl_wgh_seq"].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                for (int i = 0; i < dgvDetail.Rows.Count; i++)
                {
                    dgvDetail.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }

                dgvDetail.Enabled = true;
            }

        }

        void ShowLoadData()
        {
            pnMain.Visible = false;
            int x = (gbMain.Width - gbLoadData.Width) / 2;
            int y = (gbMain.Height - gbLoadData.Height) / 2;

            gbLoadData.Location = new System.Drawing.Point(x, y);
            gbLoadData.Visible = true;
        }

        #endregion

        private void frmWeightNew_Load(object sender, EventArgs e)
        {
            // กำหนดค่าให้กับ serialport
            serialPort1.PortName = func_serialport.COM_SCALE;
            serialPort1.BaudRate = func_serialport.BAUDRATE_SCALE;

            // เช็คสิทธื ว่าลบหรือแก้ไขได้หรือไม่
            if (tbPrivilage.weight.del == "True") { dgvDetail.Columns["cl_del"].Visible = true; gbDel.Visible = true; }
            if (tbPrivilage.weight.edit == "True") { dgvDetail.Columns["cl_edit"].Visible = true; }
        }
        #region "INPUT"

        //=============================================================================================================================================================   Start input data fomr Groupbox
        private void rdTypeBox_CheckedChanged(object sender, EventArgs e)
        {
            if (rdTypeBox.Checked == true)
            {
                foreach (var txt in panel2.Controls.OfType<Guna.UI2.WinForms.Guna2TextBox>())
                {
                    txt.Text = "0";
                    txt.Enabled = false;
                }
                btnReprint.Text = "NET WEIGHT";
                txtNumBox.Enabled = true;
                statusType = "box";
                rdNot.Checked = true;
                gbSide.Enabled = false;
            }
        }

        private void rdTypeRoll_CheckedChanged(object sender, EventArgs e)
        {
            if (rdTypeRoll.Checked == true)
            {
                foreach (var txt in panel2.Controls.OfType<Guna.UI2.WinForms.Guna2TextBox>())
                {
                    txt.Text = "0";
                    txt.Enabled = true;
                }
                btnReprint.Text = "น้ำหนักสุทธิ - น้ำหักแกน";
                gbSide.Enabled = true;
                txtNumBox.Enabled = false;
                statusType = "roll";

            }
        }

        private void rdInCounty_CheckedChanged(object sender, EventArgs e)
        {

            if (rdInCounty.Checked == true)
            {
                statusCounty = "dom";
            }
        }
        private void rdOutCounty_CheckedChanged(object sender, EventArgs e)
        {

            if (rdOutCounty.Checked == true)
            {
                statusCounty = "ovs";
            }
        }
        private void rdNot_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNot.Checked == true)
            {
                statusSide = "none";
            }
        }

        private void rdFrontSide_CheckedChanged(object sender, EventArgs e)
        {
            if (rdFrontSide.Checked == true)
            {
                statusSide = "front";
            }
        }

        private void rdBackSide_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBackSide.Checked == true)
            {
                statusSide = "behind";
            }
        }

        private void txtNunRoll_TextChanged(object sender, EventArgs e)
        {
            if (txtNunMeter.Text != "")
            {
                double a = Convert.ToDouble(txtWghCors.Text);
                double b = Convert.ToDouble(txtNunMeter.Text) / a;

                int c = (int)Math.Floor(b);
                txtBlade.Text = Convert.ToString(c);
            }

        }

        #endregion

        #region "PROCESS"

        private void dgvDetail_CellContentClick(object sender, DataGridViewCellEventArgs e) //// เมื่อกด ลบ ที่ dgv จะเข้า Event นี้
        {
            try
            {
                wgh_id = Convert.ToInt32(dgvDetail.Rows[e.RowIndex].Cells["cl_wgh_id"].Value);  // กำหนดค่า fs_id ไปไว้ที่ตัวแปร MainVal.fs_id

                if (dgvDetail.Columns[e.ColumnIndex].Name == "cl_del")
                {
                    if (wgh_id != 0)
                    {
                        DialogResult dialogResult = MessageBox.Show("คุณต้องการลบข้อมูลหรือไม่", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {

                            if (!tbWeight.DELETE_DATA(wgh_id))
                            {
                                sb.Show(this, "เกิดข้อผิดผลาด", BunifuSnackbar.MessageTypes.Error, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                                return;
                            }

                            //if (statusRePrintSeq)
                            //{
                            //    for (int i = 0; i < dgvDetail.Rows.Count; i++)
                            //    {
                            //        string wgh_id = dgvDetail.Rows[i].Cells["cl_wgh_id"].Value.ToString();
                            //        tbWeight.up
                            //    }
                            //}


                            sb.Show(this, "ลบรายการสำเสร็จ", BunifuSnackbar.MessageTypes.Success, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                            ShowData();
                            wgh_id = 0;
                            return;
                        }

                    }
                }
                else if (dgvDetail.Columns[e.ColumnIndex].Name == "cl_edit")
                {
                    string _btnText = dgvDetail.Rows[e.RowIndex].Cells["cl_edit"].EditedFormattedValue.ToString();

                    dgvDetail.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Olive;
                    dgvDetail.Enabled = false;
                    return;
                }
                // เครียค่าเป็น 0
                wgh_id = 0;
            }
            catch (Exception ex)
            {
                sb.Show(this, ex.Message, BunifuSnackbar.MessageTypes.Error, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                return;
            }
        }
        //============================================================================================================================================================= Start  input data form RS232
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (gbData.BorderColor == Color.Green)
            {
                string data = Function.Function.RS232(serialPort1);
                string[] a = data.Split('|');

                string net = a[0];
                string tare = a[1];
                string gross = a[2];

                double old = Convert.ToDouble(lbTotalWgh.Text);
                double total = old + Convert.ToDouble(net);


                BeginInvoke(new MethodInvoker(delegate ()
                {
                    lbTareWgh.Text = tare;
                    lbGrossWgh.Text = gross;
                }));

                if (statusType == "box")
                {
                    BeginInvoke(new MethodInvoker(delegate ()
                    {
                        lbNetWgh.Text = net;
                    }));
                }
                else if (statusType == "roll")
                {
                    //double cors = Convert.ToDouble(txtWghCors.Text);
                    //double tt = Convert.ToDouble(net) - cors;
                    BeginInvoke(new MethodInvoker(delegate ()
                    {
                        lbNetWgh.Text = Convert.ToString(net);
                    }));
                }
                // เช็๕ว่าเป็นการ เพิ่ม หรือว่า แก้ไขรายการ

                if (wgh_id == 0)  // INSERT
                {
                    #region INSERT DATA
                    BeginInvoke(new MethodInvoker(delegate ()
                    {
                        // INSERT NEW DATA
                        string po = cbbPO.Text;
                        decimal wghPaper = Convert.ToDecimal(txtWghPaper.Text);
                        int numBox = Convert.ToInt32(txtNumBox.Text);
                        decimal wghCore = Convert.ToDecimal(txtWghCors.Text);
                        int joing = Convert.ToInt32(txtJoint.Text);
                        decimal numMeter = Convert.ToDecimal(txtNunMeter.Text);
                        decimal bland = Convert.ToDecimal(txtBlade.Text);
                        decimal wghNet = Convert.ToDecimal(net);
                        decimal wghTare = Convert.ToDecimal(tare);
                        decimal wghGross = Convert.ToDecimal(gross);
                        string date = DateTime.Now.ToString("dd/MM/yy", System.Globalization.CultureInfo.CreateSpecificCulture("TH-th"));
                        string[] _dateArry = date.Split('/');
                        string time = DateTime.Now.ToString("HH:mm:ss");
                        string[] _timeArry = time.Split(':');

                        int seq = 0;
                        if (dgvDetail.Rows.Count == 0)
                        {
                            seq = 1;
                        }
                        else
                        {
                            string ac = dgvDetail.Rows[0].Cells["cl_wgh_seq"].Value.ToString();
                            seq = 1 + int.Parse(ac);
                        }

                        string Lot = $"{MRP.name}{_dateArry[0]}{_dateArry[1]}{_dateArry[2]}{_timeArry[0]}{_timeArry[1]}{_timeArry[2]}{seq}";

                        if (!tbWeight.INSERT_ALL_DATA(cbbPO.Text, statusCounty, statusType, statusSide, wghPaper, numBox, wghCore, joing, numMeter, bland, txtOperator.Text, wghNet, wghTare, wghGross, Lot, seq.ToString()))
                        {
                            sb.Show(this, "เกิดข้อผิดผลาด", BunifuSnackbar.MessageTypes.Error, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                            return;
                        }
                        sb.Show(this, "เพิ่มรายการ", BunifuSnackbar.MessageTypes.Success, 1000, "OK", BunifuSnackbar.Positions.TopCenter);
                        ShowData();
                    }));
                    #endregion
                }
                else  // UPDATE
                {
                    #region UPDATE DATA
                    BeginInvoke(new MethodInvoker(delegate ()
                    {
                        // UPDATE NEW DATA
                        string po = cbbPO.Text;
                        decimal wghPaper = Convert.ToDecimal(txtWghPaper.Text);
                        int numBox = Convert.ToInt32(txtNumBox.Text);
                        decimal wghCore = Convert.ToDecimal(txtWghCors.Text);
                        int joing = Convert.ToInt32(txtJoint.Text);
                        decimal numMeter = Convert.ToDecimal(txtNunMeter.Text);
                        decimal bland = Convert.ToDecimal(txtBlade.Text);
                        decimal wghNet = Convert.ToDecimal(net);
                        decimal wghTare = Convert.ToDecimal(tare);
                        decimal wghGross = Convert.ToDecimal(gross);

                        if (!tbWeight.UPDATE_ALL_DATA(wgh_id, cbbPO.Text, statusCounty, statusType, statusSide, wghPaper, numBox, wghCore, joing, numMeter, bland, txtOperator.Text, wghNet, wghTare, wghGross))
                        {
                            sb.Show(this, "เกิดข้อผิดผลาด", BunifuSnackbar.MessageTypes.Error, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                            return;
                        }
                        sb.Show(this, "แก้ไขรายการสำเร็จ", BunifuSnackbar.MessageTypes.Success, 1000, "OK", BunifuSnackbar.Positions.TopCenter);
                        ShowData();
                    }));
                    #endregion
                    wgh_id = 0;
                }



                #region Print Data
                // Print Sticker
                // เช็คว่าผู้ใช้ต้องการปริ้นแบบไหน
                if (cbPrint.Checked)
                {

                    // ตั้งฝค่ากระดาษ
                    BeginInvoke(new MethodInvoker(delegate ()
                    {
                        if (cbbPO.Text == "JIT")
                        {
                            // Convert millimeters to hundredths of an inch
                            int widthInHundredthsOfInch = (int)(55 / 25.4 * 100);
                            int heightInHundredthsOfInch = (int)(50 / 25.4 * 100);

                            // Create a custom paper size
                            PaperSize customPaperSize = new PaperSize("Custom", widthInHundredthsOfInch, heightInHundredthsOfInch);
                            printDocument1.DefaultPageSettings.PaperSize = customPaperSize;
                        }
                        else
                        {
                            // Convert millimeters to hundredths of an inch
                            int widthInHundredthsOfInch = (int)(105 / 25.4 * 100);
                            int heightInHundredthsOfInch = (int)(75 / 25.4 * 100);

                            // Create a custom paper size
                            PaperSize customPaperSize = new PaperSize("Custom", widthInHundredthsOfInch, heightInHundredthsOfInch);
                            printDocument1.DefaultPageSettings.PaperSize = customPaperSize;
                        }
                    }));


                    if (statusPrint) // AutoPrint
                    {
                        BeginInvoke(new MethodInvoker(delegate ()
                        {
                            printDocument1.Print();
                        }));
                    }
                    else
                    {
                        BeginInvoke(new MethodInvoker(delegate ()
                        {
                            printPreviewDialog1.ShowDialog();
                        }));
                    }
                }
                #endregion
            }
            else
            {
                sb.Show(this, "กรุณากรอกข้อมูลให้ครบแล้วกด เริ่ม", BunifuSnackbar.MessageTypes.Warning, 2000, "OK", BunifuSnackbar.Positions.TopCenter);
            }
        }
        //============================================================================================================================================================= End  input data form RS232
        #endregion

        private async void txtJobNo_IconRightClick(object sender, EventArgs e)
        {
            if (txtJobNo.Text == "")
            {
                sb.Show(this, "กรุณากรอกข้อมูล", BunifuSnackbar.MessageTypes.Warning, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                return;
            }


            pnMain.Visible = false;
            ShowLoadData();

            if (!await MRP.GET_MRP(txtJobNo.Text))
            {
                pnMain.Visible = true;
                sb.Show(this, MRP.err, BunifuSnackbar.MessageTypes.Error, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                return;
            }

            pnMain.Visible = true;
            gbLoadData.Visible = false;

            // define label
            label7.Text = $"{MRP.name}";
            label8.Text = $"{MRP.partner_name}";
            label11.Text = $"{MRP.product_name}";
            label13.Text = $"{MRP.mo_type}";
            label15.Text = $"{MRP.mo_work}";
            label17.Text = $"{MRP.mo_film}";
            label21.Text = $"{MRP.mo_station_name}";
            label23.Text = $"{MRP.mo_date_delivery}";
            // define combobox
            string[] a = MRP.mo_pono.Split(',');
            cbbPO.Items.Clear();
            foreach (var b in a)
            {
                cbbPO.Items.Add(b);
            }
            //  cbbPO.DroppedDown = true;
        }

        private void cbbPO_DropDownClosed(object sender, EventArgs e)
        {
            if (cbbPO.Text == "")
            {
                cbbPO.Items.Clear();
                cbbPO.Items.Add("--เลือกเลขที่ PO--");
                cbbPO.SelectedIndex = 0;
            }
        }

        private async void cbbPO_DropDown(object sender, EventArgs e)
        {
            if (txtJobNo.Text == "")
            {
                sb.Show(this, "กรุณากรอกข้อมูลเลขที่ใบสั่งผลิตก่อน", BunifuSnackbar.MessageTypes.Warning, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                return;
            }
            ShowLoadData();
            JArray a = await MRP.GET_PO(txtJobNo.Text);

            if (a.Count == 0)
            {
                pnMain.Visible = true;
                sb.Show(this, "ไม่พบรายการ", BunifuSnackbar.MessageTypes.Warning, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                return;
            }

            cbbPO.Items.Clear();
            for (int i = 0; i < a.Count; i++)
            {
                cbbPO.Items.Add(a[i].ToString());
            }
            cbbPO.Items.Add("JIT");
            cbbPO.Items.Add("ไม่มี PO");

            pnMain.Visible = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // ตรวจสอบค่าว่า 
            if (statusCounty == "" || statusSide == "" || statusType == "")
            {
                sb.Show(this, "กรุณากรอกข้อมูลให้ครบก่อนทำการชั่ง", BunifuSnackbar.MessageTypes.Warning, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                return;
            }

            foreach (var txt in panel2.Controls.OfType<Guna.UI2.WinForms.Guna2TextBox>())
            {
                if (txt.Text == "")
                {
                    sb.Show(this, "กรุณากรอกข้อมูลให้ครบก่อนทำการชั่ง", BunifuSnackbar.MessageTypes.Warning, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                    return;
                }
            }

            // ปิดการคีย์
            serialPort1.Open();
            gbData.CustomBorderColor = Color.Green;
            gbData.BorderColor = Color.Green;
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            btnReset.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("คุณต้องการที่จะหยุดการชั่งหรือไม่", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                serialPort1.Close();
                gbData.CustomBorderColor = Color.Red;
                gbData.BorderColor = Color.Red;
                btnStart.Enabled = true;
                btnStop.Enabled = false;
                btnReset.Enabled = true;

            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("คุณต้องการจะยกเลิกรายการทั้งหมดหรือไม่", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                }
                btnStart.Enabled = true;
                btnStop.Enabled = false;
                btnReset.Enabled = false;
                // คืนค่าเหมือนเดิม
                ClearForm();
            }
        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void KeyIn(object sender, KeyPressEventArgs e)
        {
            // ตรวจสอบว่าตัวอักษรที่ผู้ใช้ป้อนเป็นตัวเลขหรือจุดทศนิยมหรือไม่
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                sb.Show(this, "กรุณากรอกเฉพาะตัวเลข", BunifuSnackbar.MessageTypes.Warning, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                e.Handled = true; // ไม่อนุญาตให้ป้อนตัวอักษรนี้
            }

            // ถ้ามีจุดทศนิยมอยู่แล้ว และผู้ใช้ป้อนจุดทศนิยมอีก หรือ ถ้าจุดทศนิยมอยู่ที่ตำแหน่งแรก
            if ((e.KeyChar == '.') && ((sender as Guna.UI2.WinForms.Guna2TextBox).Text.IndexOf('.') > -1 || (sender as Guna.UI2.WinForms.Guna2TextBox).Text.Length == 0))
            {
                sb.Show(this, "กรุณากรอกเฉพาะตัวเลข", BunifuSnackbar.MessageTypes.Warning, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                e.Handled = true;
            }
        }

        private void cbbPO_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbPO.Text.Contains('-'))
            {
                return;
            }
            gbData.Enabled = true;
            ShowData();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font fontHeader;
            Font fontHead;
            Font fontDetail;

            // Create Seq
            string seq = dgvDetail.Rows[0].Cells["cl_wgh_seq"].Value.ToString();
            if (cbbPO.Text != "JIT" && cbbPO.Text != "ไม่มี PO")
            {
                if (statusType == "box")
                {
                    seq = $"{seq}/{txtNumBox.Text}";
                }

                if (statusType == "roll")
                {
                    seq = $"{seq}/{txtBlade.Text}";
                }
            }


            if (cbbPO.Text == "JIT") // JIT
            {
                fontHeader = new Font("Tahoma", 10, System.Drawing.FontStyle.Bold);
                fontHead = new Font("Tahoma", 8, System.Drawing.FontStyle.Bold);
                fontDetail = new Font("Tahoma", 7, System.Drawing.FontStyle.Regular);


                #region Header
                e.Graphics.DrawImage(pictureBox1.Image, 0, 5, 30, 30);
                e.Graphics.DrawString("FUTURE FLEX CO.,LTD", fontHeader, Brushes.Black, new System.Drawing.Point(30, 15));

                #endregion

                #region Body
                e.Graphics.DrawString($"[รหัสสินค้า] : ___________________________________________ ", fontHead, Brushes.Black, new System.Drawing.Point(0, 35));
                e.Graphics.DrawString($"{MRP.product_id}", fontDetail, Brushes.Black, new System.Drawing.Point(80, 35));
                e.Graphics.DrawString($"[สินค้า] : ___________________________________________ ", fontHead, Brushes.Black, new System.Drawing.Point(0, 57));
                e.Graphics.DrawString($"{MRP.product_name}", fontDetail, Brushes.Black, new System.Drawing.Point(50, 55));
                e.Graphics.DrawString($"[ใบสั่งงาน] : ___________________________________________ ", fontHead, Brushes.Black, new System.Drawing.Point(0, 80));
                e.Graphics.DrawString($"{MRP.name}                  ", fontDetail, Brushes.Black, new System.Drawing.Point(70, 80));


                switch (statusType) // เช็คว่าผู้ใช้เลือกการชั่งแบบ กล่องหรือม้วน
                {
                    case "box":
                        e.Graphics.DrawString($"NO :  {seq}/{txtNumBox.Text}", fontDetail, Brushes.Black, new System.Drawing.Point(135, 3));
                        e.Graphics.DrawString($"[จำนวน]_____กล่อง.", fontHead, Brushes.Black, new System.Drawing.Point(0, 110));
                        e.Graphics.DrawString($"{txtNumBox.Text}", fontDetail, Brushes.Black, new System.Drawing.Point(50, 110));
                        e.Graphics.DrawString($"____________kg.", fontHead, Brushes.Black, new System.Drawing.Point(0, 130));
                        e.Graphics.DrawString($"{lbNetWgh.Text}", fontDetail, Brushes.Black, new System.Drawing.Point(10, 130));
                        e.Graphics.DrawString($"[MFG] : ______________________", fontHead, Brushes.Black, new System.Drawing.Point(0, 160));
                        e.Graphics.DrawString($"{DateTime.Now.ToString("dd/MM/yyyy")}", fontDetail, Brushes.Black, new System.Drawing.Point(50, 160));
                        break;   //กรณีเลือกกล่อง
                    case "roll":
                        e.Graphics.DrawString($"NO :  {seq}/{txtNunMeter.Text}", fontDetail, Brushes.Black, new System.Drawing.Point(135, 3));

                        e.Graphics.DrawString($"[จำนวน]________ม.", fontHead, Brushes.Black, new System.Drawing.Point(0, 110));
                        e.Graphics.DrawString($"{txtNunMeter.Text}", fontDetail, Brushes.Black, new System.Drawing.Point(55, 110));
                        e.Graphics.DrawString($"_____________ใบ", fontHead, Brushes.Black, new System.Drawing.Point(0, 125));
                        e.Graphics.DrawString($"{txtBlade.Text}", fontDetail, Brushes.Black, new System.Drawing.Point(10, 125));
                        e.Graphics.DrawString($"_____________kg.", fontHead, Brushes.Black, new System.Drawing.Point(0, 140));
                        e.Graphics.DrawString($"{lbNetWgh.Text} ", fontDetail, Brushes.Black, new System.Drawing.Point(10, 140));
                        e.Graphics.DrawString($"[MFG] : ______________________", fontHead, Brushes.Black, new System.Drawing.Point(0, 160));
                        e.Graphics.DrawString($"{DateTime.Now.ToString("dd/MM/yyyy")}", fontDetail, Brushes.Black, new System.Drawing.Point(50, 160));
                        break;  //กรณีเลือกม้วน  
                }
                #endregion

                // ตั้งค่า Format Barcode
                BarcodeWriter writer = new BarcodeWriter()
                {
                    Format = BarcodeFormat.QR_CODE
                };

                PictureBox pictureBox = new PictureBox()
                {
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                // Generage QR Code
                pictureBox.Image = writer.Write($"{MRP.name}{DateTime.Now.ToString("dd")}{DateTime.Now.ToString("MM")}{DateTime.Now.ToString("yy")}{DateTime.Now.ToString("HH")}{DateTime.Now.ToString("mm")}{DateTime.Now.ToString("ss")}001");
                e.Graphics.DrawImage(pictureBox.Image, 115, 100, 100, 100);

                string barCodeStr = $"{MRP.name}{DateTime.Now.ToString("dd")}{DateTime.Now.ToString("MM")}{DateTime.Now.ToString("yy")}{DateTime.Now.ToString("HH")}{DateTime.Now.ToString("mm")}{DateTime.Now.ToString("ss")}001";
                e.Graphics.DrawString(barCodeStr, fontHead, Brushes.Black, new System.Drawing.Point(180, 270));
                e.Graphics.DrawString("FM-DL-003 REV.1", fontDetail, Brushes.Black, new System.Drawing.Point(0, 180));
            }
            else // แบบมี PO และ ไม่มี PO
            {
                fontHeader = new Font("Tahoma", 14, System.Drawing.FontStyle.Bold);
                fontHead = new Font("Tahoma", 8, System.Drawing.FontStyle.Bold);
                fontDetail = new Font("Tahoma", 8, System.Drawing.FontStyle.Regular);

                #region Header
                e.Graphics.DrawImage(pictureBox1.Image, 5, -3, 50, 50);
                e.Graphics.DrawString("FUTURE FLEX CO.,LTD", fontHeader, Brushes.Black, new System.Drawing.Point(60, 15));
                e.Graphics.DrawString($"NO :  {seq}", fontDetail, Brushes.Black, new System.Drawing.Point(320, 0));
                #endregion

                #region Body
                e.Graphics.DrawString($"[สินค้า] : ____________________________  [รหัสสินค้า] : _______________ ", fontHead, Brushes.Black, new System.Drawing.Point(5, 55));
                e.Graphics.DrawString($"{MRP.product_name}                               {MRP.default_code}", fontDetail, Brushes.Black, new System.Drawing.Point(60, 55));
                e.Graphics.DrawString($"[บริษัท] : ______________________________________________________________________________________________________", fontHead, Brushes.Black, new System.Drawing.Point(5, 73));
                e.Graphics.DrawString($"{MRP.partner_name}", fontDetail, Brushes.Black, new System.Drawing.Point(60, 73));
                e.Graphics.DrawString($"[ใบสั่งงาน] : ________________ [ใบสั่งซื้อ] : _______________________________________________________________________", fontHead, Brushes.Black, new System.Drawing.Point(5, 91));
                e.Graphics.DrawString($"{MRP.name}                                  {cbbPO.Text}", fontDetail, Brushes.Black, new System.Drawing.Point(80, 91));
                e.Graphics.DrawString($"[โครงสร้าง] : ______________________________________________________________________________________________________", fontHead, Brushes.Black, new System.Drawing.Point(5, 109));
                e.Graphics.DrawString($"{MRP.mo_film}", fontDetail, Brushes.Black, new System.Drawing.Point(80, 109));
                e.Graphics.DrawString($"[ขนาด] :______________________________________________________________________________________________________", fontHead, Brushes.Black, new System.Drawing.Point(5, 127));
                e.Graphics.DrawString($"{MRP.mo_work}", fontDetail, Brushes.Black, new System.Drawing.Point(60, 127));

                switch (statusType) // เช็คว่าผู้ใช้เลือกการชั่งแบบ กล่องหรือม้วน
                {
                    case "box":
                        e.Graphics.DrawString($"[จำนวน] :__________ใบ__________kg.", fontHead, Brushes.Black, new System.Drawing.Point(5, 145));
                        e.Graphics.DrawString($"{txtNumBox.Text}                 {lbNetWgh.Text}     ", fontDetail, Brushes.Black, new System.Drawing.Point(75, 145));
                        e.Graphics.DrawString($"[วันเดือนปีที่ผลิต] : ________________________", fontHead, Brushes.Black, new System.Drawing.Point(5, 163));
                        e.Graphics.DrawString($"{DateTime.Now.ToString("dd/MM/yyyy")}", fontDetail, Brushes.Black, new System.Drawing.Point(110, 163));
                        e.Graphics.DrawString($"[เจ้าหน้าที่คุมเครื่อง] : ______________________", fontHead, Brushes.Black, new System.Drawing.Point(5, 181));
                        e.Graphics.DrawString($"{txtOperator.Text}", fontDetail, Brushes.Black, new System.Drawing.Point(130, 181));
                        break;   //กรณีเลือกกล่อง
                    case "roll":
                        e.Graphics.DrawString($"[นน.กระดาษ/นน.พลาสติก] :______________________________________________________________________________________________________", fontHead, Brushes.Black, new System.Drawing.Point(5, 145));
                        e.Graphics.DrawString($"{txtWghPaper.Text}", fontDetail, Brushes.Black, new System.Drawing.Point(170, 145));
                        e.Graphics.DrawString($"[นน.แกน/นน.รวม] :______________________", fontHead, Brushes.Black, new System.Drawing.Point(5, 163));
                        e.Graphics.DrawString($"{txtWghCors.Text}", fontDetail, Brushes.Black, new System.Drawing.Point(120, 163));
                        e.Graphics.DrawString($"[จำนวนสุทธิ]________ม.______ใบ_______kg.", fontHead, Brushes.Black, new System.Drawing.Point(5, 181));
                        e.Graphics.DrawString($"{txtNunMeter.Text}           {txtBlade.Text}            {lbNetWgh.Text} ", fontDetail, Brushes.Black, new System.Drawing.Point(90, 181));
                        e.Graphics.DrawString($"[วันเดือนปีที่ผลิต] : ______________________", fontHead, Brushes.Black, new System.Drawing.Point(5, 199));
                        e.Graphics.DrawString($"{DateTime.Now.ToString("dd/MM/yyyy")}", fontDetail, Brushes.Black, new System.Drawing.Point(130, 199));
                        e.Graphics.DrawString($"[เจ้าหน้าที่คุมเครื่อง] : ____________________", fontHead, Brushes.Black, new System.Drawing.Point(5, 217));
                        e.Graphics.DrawString($"{txtOperator.Text}", fontDetail, Brushes.Black, new System.Drawing.Point(130, 217));
                        break;  //กรณีเลือกม้วน  
                }
                #endregion

                #region Footer
                // ตั้งค่า Format Barcode
                BarcodeWriter writer = new BarcodeWriter()
                {
                    Format = BarcodeFormat.QR_CODE
                };

                PictureBox pictureBox = new PictureBox()
                {
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                // Generage QR Code
                pictureBox.Image = writer.Write($"{MRP.name}{DateTime.Now.ToString("dd")}{DateTime.Now.ToString("MM")}{DateTime.Now.ToString("yy")}{DateTime.Now.ToString("HH")}{DateTime.Now.ToString("mm")}{DateTime.Now.ToString("ss")}001");
                e.Graphics.DrawImage(pictureBox.Image, 275, 150, 120, 120);

                string barCodeStr = $"{MRP.name}{DateTime.Now.ToString("dd")}{DateTime.Now.ToString("MM")}{DateTime.Now.ToString("yy")}{DateTime.Now.ToString("HH")}{DateTime.Now.ToString("mm")}{DateTime.Now.ToString("ss")}001";
                e.Graphics.DrawString(barCodeStr, fontHead, Brushes.Black, new System.Drawing.Point(180, 270));
                e.Graphics.DrawString("FM-DL-003 REV.1", fontDetail, Brushes.Black, new System.Drawing.Point(5, 270));
                #endregion
            }
        }

        private void cbPrint_CheckedChanged(object sender, BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (cbPrint.CheckState == BunifuCheckBox.CheckStates.Checked)
            {
                groupBox2.Enabled = true;
            }
            else
            {
                groupBox2.Enabled = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                statusPrint = true;
            }
            if (radioButton4.Checked)
            {
                statusPrint = false;
            }

            Console.WriteLine(statusPrint);
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked)
            {
                statusRePrintSeq = false;
            }
            else { statusRePrintSeq = true; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int seq = 1;
            for (int i = dgvDetail.Rows.Count - 1; i <= dgvDetail.Rows.Count - 1; i--)
            {
                if (i >= 0)
                {
                    string _wgh_id = dgvDetail.Rows[i].Cells["cl_wgh_id"].Value.ToString();
                    tbWeight.UPDATE_SEQ(int.Parse(_wgh_id), seq.ToString());
                    seq++;
                }
                else
                {
                    break;
                }
            }
            ShowData();
            MessageBox.Show("แก้ไขลำดับเสร็จสิ้น", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
