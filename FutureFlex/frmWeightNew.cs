using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using FutureFlex.API;
using FutureFlex.Function;
using FutureFlex.SQL;
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

            ClearForm();

            this.FormBorderStyle = FormBorderStyle.None;
            dgvDetail.ColumnHeadersDefaultCellStyle.Font = new Font("Athiti", 12, System.Drawing.FontStyle.Regular);
            dgvDetail.DefaultCellStyle.Font = new Font("Athiti", 12, System.Drawing.FontStyle.Regular);
            dgvDetail.DefaultCellStyle.ForeColor = Color.Black;

            cbbPO.Items.Clear();
            cbbPO.Items.Add("--เลือกเลขที่ PO--");
            cbbPO.SelectedIndex = 0;


        }


        string statusType = "";     ///// ใช่้สำหรับเก็บค่า การเลือกประเภท จาก Groupbox 
        string statusCounty = "";   ///// ใช่้สำหรับเก็บค่า การเลือกประเทศ จาก Groupbox 
        string statusSide = "";     ///// ใช่้สำหรับเก็บค่า การเลือกด้าน จาก Groupbox 
        bool statusPrint = false;    // ใช้สำหรับเก็บค่า การพิมพ์แบบ Auto หรือไม่ | true = AutoPrint ,False = ShowDialog before print

        bool isStart = false; // สำหรับเก็บค่าว่า เริ่มหรือยัง

        int _id = 0; // สำหรับเช็คว่ามีค่าที่จะต้อง UPDATE หรือไม่
        bool isEdit = false; // สำหรับเช็คว่ามีการ แก้ไข หรือไม่


        BunifuSnackbar sb = new BunifuSnackbar();



        #region Function Local

        /// <summary>
        /// สำหรับเครียความพร้อมของโปรแกรม
        /// </summary>
        void ClearForm()
        {
            statusCounty = "";
            statusSide = "";
            statusType = "";

            //txtJobNo.Clear();

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

            foreach (var txt in panel2.Controls.OfType<Guna.UI2.WinForms.Guna2TextBox>())
            {
                txt.Text = "0";
                txt.Enabled = false;
            }
            DataTable dataTable = tbWeightDetail.SELECT_PO("---");

            dgvDetail.DataSource = dataTable;
            label33.Text = "0";
            lbTotalWgh.Text = "0.0";

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
            try
            {
                // กำหนดค่าให้กับ serialport
                spScale.PortName = func_serialport.COM_SCALE;
                spScale.BaudRate = func_serialport.BAUDRATE_SCALE;

                spScale.Open();
                //spScanner.Open();
                // เช็คสิทธื ว่าลบหรือแก้ไขได้หรือไม่
                if (tbPrivilage.weight.del == "True") { dgvDetail.Columns["cl_del"].Visible = true; }
                if (tbPrivilage.weight.edit == "True") { dgvDetail.Columns["cl_edit"].Visible = true; }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        #region "INPUT"

        //=============================================================================================================================================================   Start input data fomr Groupbox
        private void rdTypeBox_CheckedChanged(object sender, EventArgs e)
        {
            if (rdTypeBox.Checked == true)
            {
                if (cbbPO.Text != "JIT")
                {
                    foreach (var txt in panel2.Controls.OfType<Guna.UI2.WinForms.Guna2TextBox>())
                    {
                        if (txt.Tag == "roll")
                        {
                            txt.Text = "0";
                            txt.Enabled = false;
                        }
                    }

                    foreach (var txt in panel2.Controls.OfType<Guna.UI2.WinForms.Guna2TextBox>())
                    {
                        if (txt.Tag == "box")
                        {
                            txt.Text = "0";
                            txt.Enabled = true;
                        }
                    }
                }
                else
                {
                    foreach (var txt in panel2.Controls.OfType<Guna.UI2.WinForms.Guna2TextBox>())
                    {
                        txt.Text = "0";
                        txt.Enabled = false;
                    }
                }

                btnReprint.Text = "NET WEIGHT";
                statusType = "box";
                rdNot.Checked = true;
                gbSide.Enabled = false;
            }
        }

        private void rdTypeRoll_CheckedChanged(object sender, EventArgs e)
        {
            if (rdTypeRoll.Checked == true)
            {
                if (cbbPO.Text != "JIT")
                {
                    foreach (var txt in panel2.Controls.OfType<Guna.UI2.WinForms.Guna2TextBox>())
                    {
                        if (txt.Tag == "box")
                        {
                            txt.Text = "0";
                            txt.Enabled = false;
                        }
                    }

                    foreach (var txt in panel2.Controls.OfType<Guna.UI2.WinForms.Guna2TextBox>())
                    {
                        if (txt.Tag == "roll")
                        {
                            txt.Text = "0";
                            txt.Enabled = true;
                        }
                    }
                }
                else
                {
                    foreach (var txt in panel2.Controls.OfType<Guna.UI2.WinForms.Guna2TextBox>())
                    {
                        txt.Text = "0";
                        txt.Enabled = false;
                    }
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
            if (txtNumRoll.Text != "")
            {
                if (txtNunMeter.Text != "0")
                {
                    string[] a = label15.Text.Split(' ');
                    string b = a[2];
                    double c = double.Parse(b) / 1000;
                    double d = double.Parse(txtNunMeter.Text) / c;

                    txtNumRoll.Text = d.ToString("F0");
                }
            }
        }

        #endregion

        #region "PROCESS"

        private void dgvDetail_CellContentClick(object sender, DataGridViewCellEventArgs e) //// เมื่อกด ลบ ที่ dgv จะเข้า Event นี้
        {
            try
            {
                switch (dgvDetail.Columns[e.ColumnIndex].Name)
                {
                    case "cl_del":
                        _id = Convert.ToInt16(dgvDetail.Rows[e.RowIndex].Cells["cl_id"].Value.ToString());

                        DialogResult dialogResult = System.Windows.Forms.MessageBox.Show("คุณต้องการลบข้อมูลหรือไม่", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            if (tbWeightDetail.DELETE(_id.ToString()))
                            {
                                dgvDetail.Rows.RemoveAt(e.RowIndex);
                                sb.Show(this, "ลบรายการสำเสร็จ", BunifuSnackbar.MessageTypes.Success, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                            }
                            else
                            {
                                sb.Show(this, $"DELETE {tbWeightDetail.ERR}", BunifuSnackbar.MessageTypes.Success, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                            }
                            return;
                        }
                        break;
                    case "cl_edit":
                        string _employee = dgvDetail.Rows[e.RowIndex].Cells["cl_employee"].Value.ToString();
                        // เช็คว่าคนที่จะแก้ไขต้องเป็นเดียวกัน
                        if (_employee != tbEmployeeSQL.emp_name)
                        {
                            sb.Show(this, "ไม่สามารถแก้ไขการชั่งของคนอื่นได้", BunifuSnackbar.MessageTypes.Warning, 3000, "", BunifuSnackbar.Positions.TopCenter);
                            return;
                        }
                        _id = Convert.ToInt16(dgvDetail.Rows[e.RowIndex].Cells["cl_id"].Value.ToString());
                        isEdit = true;
                        dgvDetail.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Olive;
                        dgvDetail.Enabled = false;
                        break;
                    case "cl_print":
                        if (cbPrint.Checked)
                        {
                            if (cbbPO.Text == "JIT")
                            {
                                // Convert millimeters to hundredths of an inch
                                int widthInHundredthsOfInch = (int)(50 / 25.4 * 100);
                                int heightInHundredthsOfInch = (int)(55 / 25.4 * 100);

                                // Create a custom paper size
                                PaperSize customPaperSize = new PaperSize("Custom", widthInHundredthsOfInch, heightInHundredthsOfInch);
                                printDocument1.DefaultPageSettings.PaperSize = customPaperSize;
                            }
                            else
                            {
                                // สำหรับเครื่อง TDP-247
                                // Convert millimeters to hundredths of an inch
                                //int widthInHundredthsOfInch = (int)(105 / 25.4 * 100);
                                //int heightInHundredthsOfInch = (int)(75 / 25.4 * 100);
                                // Convert millimeters to hundredths of an inch

                                // สำหรับเครื่อง Zebra
                                int widthInHundredthsOfInch = (int)(75 / 25.4 * 100);
                                int heightInHundredthsOfInch = (int)(101 / 25.4 * 100);

                                // Create a custom paper size
                                PaperSize customPaperSize = new PaperSize("Custom", widthInHundredthsOfInch, heightInHundredthsOfInch);
                                printDocument1.DefaultPageSettings.PaperSize = customPaperSize;
                            }

                            if (statusPrint) // AutoPrint
                            {
                                printDocument1.Print();
                            }
                            else
                            {
                                try
                                {
                                    printPreviewDialog1.ShowDialog();
                                }
                                catch (Exception)
                                {
                                }
                            }
                        }
                        break;

                }
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
            if (!isStart)
            {
                return;
            }

            #region RECEIVE DATA
            //string data = Function.Function.RS232(spScale);

            string a = spScale.ReadLine();
            Console.WriteLine($"SERIAL {a}");
            string[] b = a.Split(',');

            Console.WriteLine($"NET {b[2].Trim()}");
            Console.WriteLine($"TARE {b[3].Trim()}");
            Console.WriteLine($"GROSS {b[4].Trim()}");

            string net = b[2];
            string tare = b[3];
            string gross = b[4];

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
            #endregion
            DataTable tb = tbWeightDetail.SELECT_PO_NOT_SEND_ODOO();

            // เช็คว่าเป็น UPDATE or INSERT
            if (isEdit) // UDPATE
            {
                #region UPDATE
                if (tbWeightDetail.UPDATE(_id.ToString(), decimal.Parse(net), decimal.Parse(tare), decimal.Parse(gross)))
                {
                    isEdit = false;
                    _id = 0;
                    tb = tbWeightDetail.SELECT_PO_NOT_SEND_ODOO();
                    BeginInvoke(new MethodInvoker(delegate ()
                    {
                        dgvDetail.Enabled = true;
                        dgvDetail.DataSource = tb;
                    }));
                }
                else
                {
                    BeginInvoke(new MethodInvoker(delegate ()
                    {
                        sb.Show(this, $"UPDATE {tbWeightDetail.ERR}", BunifuSnackbar.MessageTypes.Error, 3000, "", BunifuSnackbar.Positions.TopCenter);
                    }));
                    return;
                }
                #endregion
            }
            else // INSERT
            {
                // เช็คว่าครบจำนวนที่จะต้องชั่งหรือยัง
                if (tbWeightDetail.PO != "JIT" && tbWeightDetail.PO != "ไม่มีPO")
                {
                    // เช็คว่าเป็นเป็นงานม้วนหรือกล่อง
                    switch (statusType)
                    {
                        case "box":
                            if (tb.Rows.Count >= int.Parse(txtNumBox.Text))
                            {
                                BeginInvoke(new MethodInvoker(delegate ()
                                {
                                    sb.Show(this, "จำนวนกล่องสินค้าครบแล้ว", BunifuSnackbar.MessageTypes.Warning, 3000, "", BunifuSnackbar.Positions.TopCenter);
                                }));
                                return;
                            }
                            break;
                        case "roll":
                            if (tb.Rows.Count >= int.Parse(txtNumRoll.Text))
                            {
                                BeginInvoke(new MethodInvoker(delegate ()
                                {
                                    sb.Show(this, "จำนวนกล่องสินค้าครบแล้ว", BunifuSnackbar.MessageTypes.Warning, 3000, "", BunifuSnackbar.Positions.TopCenter);
                                }));
                                return;
                            }
                            break;
                    }

                }


                #region SAVE DATA
                string _seq = Convert.ToString(tb.Rows.Count + 1);
                switch (_seq.Length)
                {
                    case 1:
                        _seq = $"00{_seq}";
                        break;
                    case 2:
                        _seq = $"0{_seq}";
                        break;
                }


                string _date = DateTime.Now.ToString("dd/MM/yy", System.Globalization.CultureInfo.CreateSpecificCulture("EN-en"));
                string _Time = DateTime.Now.ToString("HH:mm:ss", System.Globalization.CultureInfo.CreateSpecificCulture("EN-en"));
                string _lot = $"{MRP.name}{_date.Replace("/", "").Trim()}{_Time.Replace(":", "").Trim()}{_seq}";


                // insert new data
                tbWeightDetail.seq = _seq;
                tbWeightDetail.net = decimal.Parse(lbNetWgh.Text);
                tbWeightDetail.tare = decimal.Parse(lbTareWgh.Text);
                tbWeightDetail.gross = decimal.Parse(lbGrossWgh.Text);
                tbWeightDetail.wgh_paper_plastic = decimal.Parse(txtWghPaper.Text);
                tbWeightDetail.wgh_core_total = decimal.Parse(txtWghCors.Text);
                tbWeightDetail.wgh_joint = decimal.Parse(txtJoint.Text);
                tbWeightDetail.numbox = int.Parse(txtNumBox.Text);
                tbWeightDetail.numroll = int.Parse(txtNumRoll.Text);

                switch (statusType)
                {
                    case "box":
                        tbWeightDetail.wgh_meter_kg_in_roll = 0;
                        tbWeightDetail.pch = int.Parse(txtPchBox.Text);
                        break;
                    case "roll":
                        tbWeightDetail.wgh_meter_kg_in_roll = decimal.Parse(txtNunMeter.Text);
                        tbWeightDetail.pch = int.Parse(txtPchRoll.Text);
                        break;
                }

                tbWeightDetail.lot = $"{MRP.name}{_date.Replace("/", "").Trim()}{_Time.Replace(":", "").Trim()}{_seq}";


                // บันทึกข้อมูล
                if (!tbWeightDetail.INSERT_DATA())
                {
                    BeginInvoke(new MethodInvoker(delegate ()
                    {
                        sb.Show(this, $"INSERT DATA {tbWeightDetail.ERR}", BunifuSnackbar.MessageTypes.Error, 3000, "", BunifuSnackbar.Positions.TopCenter);
                    }));
                    return;
                }

                tb = tbWeightDetail.SELECT_PO_NOT_SEND_ODOO();
                BeginInvoke(new MethodInvoker(delegate ()
                {
                    dgvDetail.DataSource = tb;
                }));
                // เพิ่มข้อมูลไปที่ dgv

                #endregion


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
                        int widthInHundredthsOfInch = (int)(50 / 25.4 * 100);
                        int heightInHundredthsOfInch = (int)(55 / 25.4 * 100);

                        // Create a custom paper size
                        PaperSize customPaperSize = new PaperSize("Custom", widthInHundredthsOfInch, heightInHundredthsOfInch);
                        printDocument1.DefaultPageSettings.PaperSize = customPaperSize;
                    }
                    else
                    {
                        // สำหรับเครื่อง TDP-247
                        // Convert millimeters to hundredths of an inch
                        //int widthInHundredthsOfInch = (int)(105 / 25.4 * 100);
                        //int heightInHundredthsOfInch = (int)(75 / 25.4 * 100);
                        // Convert millimeters to hundredths of an inch

                        // สำหรับเครื่อง Zebra
                        int widthInHundredthsOfInch = (int)(75 / 25.4 * 100);
                        int heightInHundredthsOfInch = (int)(101 / 25.4 * 100);

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
                        try
                        {
                            printPreviewDialog1.ShowDialog();
                        }
                        catch (Exception)
                        {
                        }

                    }));
                }
            }
            #endregion

        }
        //============================================================================================================================================================= End  input data form RS232
        #endregion

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

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                Font fontHeader;
                Font fontHead;
                Font fontDetail;

                // Create Seq
                string seq = Convert.ToString(dgvDetail.Rows.Count);
                if (cbbPO.Text != "JIT" && cbbPO.Text != "ไม่มี PO")
                {
                    if (statusType == "box")
                    {
                        seq = $"{seq}/{txtNumBox.Text}";
                    }

                    if (statusType == "roll")
                    {
                        seq = $"{seq}/{txtNumRoll.Text}";
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
                    e.Graphics.DrawString($"[รหัสสินค้า] : ___________________________________________ ", fontHead, Brushes.Black, new System.Drawing.Point(0, 57));
                    e.Graphics.DrawString($"{MRP.product_id}", fontDetail, Brushes.Black, new System.Drawing.Point(80, 57));
                    e.Graphics.DrawString($"[สินค้า] : ___________________________________________ ", fontHead, Brushes.Black, new System.Drawing.Point(0, 35));
                    e.Graphics.DrawString($"{MRP.product_name.Substring(0, 25)}", fontDetail, Brushes.Black, new System.Drawing.Point(50, 35));
                    e.Graphics.DrawString($"[ใบสั่งงาน] : ___________________________________________ ", fontHead, Brushes.Black, new System.Drawing.Point(0, 80));
                    e.Graphics.DrawString($"{MRP.name}                  ", fontDetail, Brushes.Black, new System.Drawing.Point(70, 80));


                    switch (statusType) // เช็คว่าผู้ใช้เลือกการชั่งแบบ กล่องหรือม้วน
                    {
                        case "box":
                            e.Graphics.DrawString($"NO :  {seq}", fontDetail, Brushes.Black, new System.Drawing.Point(135, 3));
                            e.Graphics.DrawString($"[จำนวน]_____กล่อง.", fontHead, Brushes.Black, new System.Drawing.Point(0, 110));
                            e.Graphics.DrawString($"{txtNumBox.Text}", fontDetail, Brushes.Black, new System.Drawing.Point(50, 110));
                            e.Graphics.DrawString($"____________kg.", fontHead, Brushes.Black, new System.Drawing.Point(0, 130));
                            e.Graphics.DrawString($"{lbNetWgh.Text}", fontDetail, Brushes.Black, new System.Drawing.Point(10, 130));
                            e.Graphics.DrawString($"[MFG] : ______________________", fontHead, Brushes.Black, new System.Drawing.Point(0, 160));
                            e.Graphics.DrawString($"{DateTime.Now.ToString("dd/MM/yyyy")}", fontDetail, Brushes.Black, new System.Drawing.Point(50, 160));
                            break;   //กรณีเลือกกล่อง
                        case "roll":
                            e.Graphics.DrawString($"NO :  {seq}", fontDetail, Brushes.Black, new System.Drawing.Point(135, 3));

                            e.Graphics.DrawString($"[จำนวน]________ม.", fontHead, Brushes.Black, new System.Drawing.Point(0, 110));
                            e.Graphics.DrawString($"{txtNunMeter.Text}", fontDetail, Brushes.Black, new System.Drawing.Point(65, 110));
                            e.Graphics.DrawString($"_____________ใบ", fontHead, Brushes.Black, new System.Drawing.Point(0, 125));
                            e.Graphics.DrawString($"{txtNumRoll.Text}", fontDetail, Brushes.Black, new System.Drawing.Point(30, 125));
                            e.Graphics.DrawString($"_____________kg.", fontHead, Brushes.Black, new System.Drawing.Point(0, 140));
                            e.Graphics.DrawString($"{lbNetWgh.Text} ", fontDetail, Brushes.Black, new System.Drawing.Point(30, 140));
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
                    e.Graphics.DrawString("FM-DL-012 Rev.0", fontDetail, Brushes.Black, new System.Drawing.Point(0, 180));
                }
                else // แบบมี PO และ ไม่มี PO
                {
                    fontHeader = new Font("Tahoma", 14, System.Drawing.FontStyle.Bold);
                    fontHead = new Font("Tahoma", 8, System.Drawing.FontStyle.Bold);
                    fontDetail = new Font("Tahoma", 8, System.Drawing.FontStyle.Regular);

                    #region Header
                    e.Graphics.DrawImage(pictureBox1.Image, 5, -3, 50, 50);
                    e.Graphics.DrawString("FUTURE FLEX CO.,LTD", fontHeader, Brushes.Black, new System.Drawing.Point(60, 15));
                    e.Graphics.DrawString($"NO : {seq}", new Font("Tahoma", 12, System.Drawing.FontStyle.Regular), Brushes.Black, new System.Drawing.Point(290, 5));
                    #endregion

                    #region Body
                    e.Graphics.DrawString($"[สินค้า] : __________________________________________________________________________________________________________", fontHead, Brushes.Black, new System.Drawing.Point(5, 55));
                    e.Graphics.DrawString($"{MRP.product_name}", fontDetail, Brushes.Black, new System.Drawing.Point(70, 55));

                    e.Graphics.DrawString($"[รหัสสินค้า] : ___________________________________________________________________________________________________________ ", fontHead, Brushes.Black, new System.Drawing.Point(5, 73));
                    e.Graphics.DrawString($"{MRP.default_code}", fontDetail, Brushes.Black, new System.Drawing.Point(90, 73));


                    e.Graphics.DrawString($"[บริษัท] : ______________________________________________________________________________________________________", fontHead, Brushes.Black, new System.Drawing.Point(5, 91));
                    e.Graphics.DrawString($"{MRP.partner_name}", fontDetail, Brushes.Black, new System.Drawing.Point(70, 91));
                    e.Graphics.DrawString($"[ใบสั่งงาน] : ________________ [ใบสั่งซื้อ] : _______________________________________________________________________", fontHead, Brushes.Black, new System.Drawing.Point(5, 109));
                    e.Graphics.DrawString($"{MRP.name}                                  {cbbPO.Text}", fontDetail, Brushes.Black, new System.Drawing.Point(80, 109));
                    e.Graphics.DrawString($"[โครงสร้าง] : ______________________________________________________________________________________________________", fontHead, Brushes.Black, new System.Drawing.Point(5, 127));
                    e.Graphics.DrawString($"{MRP.mo_film}", fontDetail, Brushes.Black, new System.Drawing.Point(90, 127));
                    e.Graphics.DrawString($"[ขนาด] :________________________", fontHead, Brushes.Black, new System.Drawing.Point(5, 145));
                    e.Graphics.DrawString($"{MRP.mo_work}", fontDetail, Brushes.Black, new System.Drawing.Point(60, 145));

                    switch (statusType) // เช็คว่าผู้ใช้เลือกการชั่งแบบ กล่องหรือม้วน
                    {
                        case "box":
                            e.Graphics.DrawString($"[จำนวน] :__________ใบ__________kg.", fontHead, Brushes.Black, new System.Drawing.Point(5, 163));
                            e.Graphics.DrawString($"{txtNumBox.Text}                    {lbNetWgh.Text}", fontDetail, Brushes.Black, new System.Drawing.Point(75, 163));
                            e.Graphics.DrawString($"[วันเดือนปีที่ผลิต] : ________________________", fontHead, Brushes.Black, new System.Drawing.Point(5, 181));
                            e.Graphics.DrawString($"{DateTime.Now.ToString("dd/MM/yyyy")}", fontDetail, Brushes.Black, new System.Drawing.Point(110, 181));
                            e.Graphics.DrawString($"[เจ้าหน้าที่คุมเครื่อง] : ______________________", fontHead, Brushes.Black, new System.Drawing.Point(5, 199));
                            e.Graphics.DrawString($"{txtOperator.Text}", fontDetail, Brushes.Black, new System.Drawing.Point(130, 199));
                            break;   //กรณีเลือกกล่อง
                        case "roll":
                            e.Graphics.DrawString($"[นน.กระดาษ/นน.พลาสติก] :________________", fontHead, Brushes.Black, new System.Drawing.Point(5, 163));
                            e.Graphics.DrawString($"{txtWghPaper.Text}", fontDetail, Brushes.Black, new System.Drawing.Point(170, 163));
                            e.Graphics.DrawString($"[นน.แกน/นน.รวม] :______________________", fontHead, Brushes.Black, new System.Drawing.Point(5, 181));
                            e.Graphics.DrawString($"{txtWghCors.Text}", fontDetail, Brushes.Black, new System.Drawing.Point(120, 181));
                            e.Graphics.DrawString($"[จำนวนสุทธิ]________ม.______ใบ_______kg.", fontHead, Brushes.Black, new System.Drawing.Point(5, 199));
                            e.Graphics.DrawString($"{txtNunMeter.Text}           {txtNumRoll.Text}            {lbNetWgh.Text} ", fontDetail, Brushes.Black, new System.Drawing.Point(90, 199));
                            e.Graphics.DrawString($"[วันเดือนปีที่ผลิต] : ______________________", fontHead, Brushes.Black, new System.Drawing.Point(5, 217));
                            e.Graphics.DrawString($"{DateTime.Now.ToString("dd/MM/yyyy")}", fontDetail, Brushes.Black, new System.Drawing.Point(130, 217));
                            e.Graphics.DrawString($"[เจ้าหน้าที่คุมเครื่อง] : ____________________", fontHead, Brushes.Black, new System.Drawing.Point(5, 235));
                            e.Graphics.DrawString($"{txtOperator.Text}", fontDetail, Brushes.Black, new System.Drawing.Point(130, 235));
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
            catch (Exception ex)
            {
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


        private void btnStart_Click(object sender, EventArgs e)
        {
            BunifuButton btn = sender as BunifuButton;
            switch (btn.Text)
            {
                case "เริ่มชั่งสินค้า":
                    // เช็คว่าเลือกข้อมูลครบหรือไม่
                    if (statusCounty == "" || statusSide == "" || statusType == "" || cbbPO.Text == "")
                    {
                        sb.Show(this, "กรุณาตรวจสอบ ประเทศ ประเภท ด้าน po ก่อนกันบันทึก", BunifuSnackbar.MessageTypes.Warning, 3000, "", BunifuSnackbar.Positions.TopCenter);
                        return;
                    }

                    //หากไม่ได้เลือก JIT จะต้องเช็คว่ากรอกข้อมูลครบหรือไม่
                    if (cbbPO.Text != "JIT" && cbbPO.Text != "ไม่มีPO")
                    {
                        // หลังจากเลือกงาน กล่อง ม้วนให้เช็คว่า ได้คีย์ข้อมูลหรือไม่
                        switch (statusType)
                        {
                            case "box":
                                foreach (var item in panel2.Controls.OfType<Guna.UI2.WinForms.Guna2TextBox>())
                                {
                                    if (item.Tag == "box")
                                    {
                                        if (item.Text == "" || item.Text == "0")
                                        {
                                            sb.Show(this, "กรุณาเลอกกรอกข้อมูลให้ครบกอนการบันทึก", BunifuSnackbar.MessageTypes.Warning, 3000, "", BunifuSnackbar.Positions.TopCenter);
                                            return;
                                        }
                                    }
                                }
                                break;
                            case "roll":
                                foreach (var item in panel2.Controls.OfType<Guna.UI2.WinForms.Guna2TextBox>())
                                {
                                    if (item.Tag == "roll")
                                    {
                                        if (item.Text == "" || item.Text == "0")
                                        {
                                            sb.Show(this, "กรุณาเลอกกรอกข้อมูลให้ครบกอนการบันทึก", BunifuSnackbar.MessageTypes.Warning, 3000, "", BunifuSnackbar.Positions.TopCenter);
                                            return;
                                        }
                                    }
                                }
                                break;
                        }
                    }

                    tbWeightDetail.PO = cbbPO.Text;
                    tbWeightDetail.country = statusCounty;
                    tbWeightDetail.type = statusType;
                    tbWeightDetail.side = statusSide;
                    // นำ GV ไปหาในระบบก่อน
                    DataTable tb = tbWeight.SELECT_SEARCH();
                    if (tb.Rows.Count == 0)
                    {
                        //บันทึกข้อมูลไปที่ tbWeight
                        if (!tbWeight.INSERT_ALL_DATA(txtOperator.Text))
                        {
                            sb.Show(this, $"เกิดข้อผิดผลาด {tbWeight.ERR}", BunifuSnackbar.MessageTypes.Error, 3000, "", BunifuSnackbar.Positions.TopCenter);
                            return;
                        }
                    }



                    // ปิดปุ่ต่่าง ๆ 
                    gbData.Enabled = false;
                    isStart = true;

                    btn.Text = "หยุดชั่งสินค้า";

                    btn.onHoverState.BorderColor = Color.White;
                    btn.onHoverState.FillColor = Color.Red;
                    btn.onHoverState.ForeColor = Color.White;

                    btn.OnIdleState.BorderColor = Color.Red;
                    btn.OnIdleState.FillColor = Color.White;
                    btn.OnIdleState.ForeColor = Color.Red;

                    btn.OnIdleState.BorderColor = Color.Red;
                    btn.OnIdleState.FillColor = Color.White;
                    btn.OnIdleState.ForeColor = Color.Red;
                    break;
                case "หยุดชั่งสินค้า":

                    gbData.Enabled = true;
                    isStart = false;

                    btn.Text = "เริ่มชั่งสินค้า";

                    btn.onHoverState.BorderColor = Color.White;
                    btn.onHoverState.FillColor = Color.Green;
                    btn.onHoverState.ForeColor = Color.White;

                    btn.OnIdleState.BorderColor = Color.Green;
                    btn.OnIdleState.FillColor = Color.White;
                    btn.OnIdleState.ForeColor = Color.Green;

                    btn.OnIdleState.BorderColor = Color.Green;
                    btn.OnIdleState.FillColor = Color.White;
                    btn.OnIdleState.ForeColor = Color.Green;

                    break;
            }
        }

        private void cbbPO_SelectedIndexChanged(object sender, EventArgs e)
        {

            // เครียข้อมูล
            tbWeightDetail.PO = cbbPO.Text;
            DataTable tb1 = tbWeightDetail.SELECT_PO_NOT_SEND_ODOO();
            dgvDetail.DataSource = tb1;

            //// ดึงข้อมูลจาก Odoo
            //if (!await MRP.GET_MRP(txtJobNo.Text))
            //{
            //    pnMain.Visible = true;
            //    sb.Show(this, MRP.err, BunifuSnackbar.MessageTypes.Error, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
            //    return;
            //}

            //// แสดงข้อมูล gvของเก่า หากมี
            //tb1 = tbWeight.SELECT_SEARCH();

            //foreach (DataRow rw in tb1.Rows)
            //{
            //    txtOperator.Text = rw["wgh_operator"].ToString();
            //}
        }

        private async void txtJobNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtJobNo.Text == "")
                {
                    sb.Show(this, "กรุณากรอกข้อมูล", BunifuSnackbar.MessageTypes.Warning, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                    return;
                }
                // เครีย์ propของ MRP
                MRP.ClearProp();

                // เครียฟอร์ม
                ClearForm();

                pnMain.Visible = false;
                //แสดง Loader
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

                DataTable tb = tbWeight.SELECT_SEARCH();
                foreach (DataRow rw in tb.Rows)
                {
                    txtOperator.Text = rw["wgh_operator"].ToString();
                }


                // define combobox
                string[] a = MRP.mo_pono.Split(',');
                cbbPO.Items.Clear();

                foreach (var b in a)
                {
                    cbbPO.Items.Add(b.Trim());
                }
                cbbPO.Items.Add("JIT");
                cbbPO.Items.Add("ไม่มี PO");
            }
        }

        private void frmWeightNew_FormClosing(object sender, FormClosingEventArgs e)
        {
            spScale.Close();
        }
    }
}
