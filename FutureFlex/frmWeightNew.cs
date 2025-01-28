using Bunifu.UI.WinForms;
using FutureFlex.API;
using FutureFlex.Function;
using FutureFlex.SQL;
using Guna.UI2.WinForms;
using Serilog;
using System;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutureFlex
{
    public partial class frmWeightNew : Form
    {
        public frmWeightNew()
        {
            InitializeComponent();

            ClearForm();

            ShowLoadData();

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
        bool statusPrint = false;   // ใช้สำหรับเก็บค่า การพิมพ์แบบ Auto หรือไม่ | true = AutoPrint ,False = ShowDialog before print

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
            Log.Information("== เครีย์ Form");
            statusCounty = "";
            statusSide = "";
            statusType = "";

            //txtJobNo.Clear();

            cbbPO.Items.Clear();
            cbbPO.Items.Add("--เลือกเลขที่ PO--");
            cbbPO.SelectedIndex = 0;

            gbData.CustomBorderColor = Color.Navy;
            gbData.BorderColor = Color.Navy;

            foreach (var lbl in gbData.Controls.OfType<Label>())
            {
                if (lbl.Tag == "value")
                {
                    lbl.Text = "......";
                }
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
            Log.Information("== เครีย์ Form สำเร็จ");
        }

        void SetPaperAndPrint()
        {
            // Set paper 
            if (cbPrint.Checked)
            {
                Log.Information("- ผู้ใช้เลือกพิมพ์ข้อมูล");

                // Check print is online?
                if (!func_print.SetPrinter(printDocument1, tbWeightDetail.PO))
                {
                    BeginInvoke(new MethodInvoker(delegate ()
                    {
                        sb.Show(this, "ไม่สามารถเชื่อมต่อ printer ได้", BunifuSnackbar.MessageTypes.Warning, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                    }));
                    return;
                }

                if (statusPrint) // AutoPrint
                {
                    try
                    {

                        printDocument1.Print();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);

                    }
                }
                else
                {
                    try
                    {
                        printPreviewDialog1.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        BeginInvoke(new MethodInvoker(delegate ()
                        {

                            sb.Show(this, "กรุณาปิด หน้าต่างการพิมพ์ " + ex.Message, BunifuSnackbar.MessageTypes.Error, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                        }));
                        return;
                    }
                }
            }
        }

        /// <summary>
        /// กำหนดค่าตัวแปลก่อนทำการปริ้น
        /// </summary>
        /// <param name="seq"></param>
        void DefinePrintParameter()
        {

            // Print paper
            func_print._seq = tbWeightDetail.seq;
            func_print._statusType = statusType;
            func_print._net = lbNetWgh.Text;
            func_print._numBox = txtNumBox.Text;
            func_print._numRoll = txtNumRollAll.Text;
            func_print._numMeter = txtNunMeter.Text;
            func_print._pchBox = txtPchBox.Text;
            func_print._pchRoll = txtPchRoll.Text;
            func_print._wghPaper = txtWghPaper.Text;
            func_print._wghCore = txtWghCors.Text;
            func_print.pictureBox1 = pictureBox1;
            func_print._operator = txtOperator.Text;
            func_print._lot = tbWeightDetail.lot;
        }


        void ShowLoadData()
        {
            int x = (this.Width - gbLoadData.Width) / 2;
            int y = (this.Height - gbLoadData.Height) / 2;

            gbLoadData.Location = new System.Drawing.Point(x, y);
        }

        /// <summary>
        /// สำหรับนับจำนวนน้ำหนักหลังจากชั่งแต่ละครั้งขึ้นอยู่กับว่า หน่วยซื้อ เป็น ใบหรือเป็นน้ำหนัก
        /// </summary>
        void ShowDataGridAndCountPchOrWeight()
        {
            // แสดงข้อมูล
            BeginInvoke(new MethodInvoker(delegate ()
            {
                tbWeightDetail.PO = cbbPO.Text;
                DataTable tb1 = tbWeightDetail.SELECT_JIT_NOT_SEND_ODOO("GV");
                dgvDetail.DataSource = tb1;
            }));
        }
        async void GetMessage()
        {
            string old_data = "";
            while (true)
            {
                if (func_tcpClient.ConnectState)
                {
                    string message = func_tcpClient.ReceiveData;
                    if (message != null)
                    {
                        if (message == "GET_DATA\n")
                        {
                            ShowDataGridAndCountPchOrWeight();
                        }
                        func_tcpClient.ReceiveData = null;
                    }
                }

                if (func_tcpClient.ErrState)
                {

                    BeginInvoke(new MethodInvoker(delegate ()
                    {
                        msg.Icon = MessageDialogIcon.Error;
                        msg.Buttons = MessageDialogButtons.OK;
                        msg.Show("Server futureflex is offline", "Server offline");
                    }));

                    break;
                }


                await Task.Delay(500);
            }
            BeginInvoke(new MethodInvoker(delegate ()
            {
                this.Close();
            }));
        }
        #endregion

        private async void frmWeightNew_Load(object sender, EventArgs e)
        {
            try
            {
                Log.Information($"==================================================   frmWeightNew is open");
                pnMain.Visible = false;
                gbLoadData.Visible = true;
                label1.Text = "กำลังเชื่อมต่อ server futureflex ..";
                // เชื่อมต่อ TcpServer ก่อน
                if (!await func_tcpClient.Connect())
                {
                    msg.Icon = MessageDialogIcon.Error;
                    msg.Buttons = MessageDialogButtons.OK;
                    msg.Show("Can't connect to server futureflex", "Fails to connect server");
                    gbLoadData.Visible = false;
                    this.Close();
                    return;
                }

                await Task.Delay(1000);
                gbLoadData.Visible = false;
                pnMain.Visible = true;
                // เปิดการอ่านค่าจาก Server
                _ = Task.Run(() =>
                {
                    GetMessage();
                });

                // กำหนดค่าให้กับ serialport
                spScale.PortName = func_serialport.COM_SCALE;
                spScale.BaudRate = func_serialport.BAUDRATE_SCALE;
                spScale.Open();

                Log.Information($"== Serial port open");
                Log.Information($"-- COM SCALE : {spScale.PortName}");
                Log.Information($"-- COM BAUDRATE : {spScale.BaudRate}");
                Log.Information($"Scale is connected");

                //spScanner.Open();
                // เช็คสิทธื ว่าลบหรือแก้ไขได้หรือไม่
                if (tbPrivilage.weight.del == "True") { dgvDetail.Columns["cl_del"].Visible = true; }
                if (tbPrivilage.weight.edit == "True") { dgvDetail.Columns["cl_edit"].Visible = true; }

                Log.Information($"== Get privilage");
                Log.Information($"-- DEL : {tbPrivilage.weight.del} ");
                Log.Information($"-- EDIT : {tbPrivilage.weight.edit} ");
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                Log.Error($"frmWeightNew | frmWeightNew_Load {ex.Message}");
            }

        }
        #region "INPUT"

        //=============================================================================================================================================================   Start input data fomr Groupbox
        private void rdTypeBox_CheckedChanged(object sender, EventArgs e)
        {
            if (rdTypeBox.Checked == true)
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
                foreach (var txt in panel2.Controls.OfType<Guna.UI2.WinForms.Guna2TextBox>())
                {
                    if (txt.Tag.ToString() == "box")
                    {
                        txt.Text = "0";
                        txt.Enabled = false;
                    }
                }

                foreach (var txt in panel2.Controls.OfType<Guna.UI2.WinForms.Guna2TextBox>())
                {
                    if (txt.Tag.ToString() == "roll")
                    {
                        txt.Text = "0";
                        txt.Enabled = true;
                    }
                }

                btnReprint.Text = "น้ำหนักสุทธิ - น้ำหนักแกน";
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
            try
            {
                if (txtNunMeter.Text != "")
                {

                    if (txtNunMeter.Text != "0")
                    {
                        string[] a = label15.Text.Split('X');
                        string[] b = a[0].Split(' ');
                        double c = double.Parse(b[0].Trim()) / 1000;
                        double d = double.Parse(txtNunMeter.Text) / c;
                        string[] f = d.ToString().Split('.');
                        txtPchRoll.Text = f[0];
                    }

                    if (MRP.product_roll_length != 0)
                    {
                        double numMetPerRoll = MRP.product_roll_length;
                        double numMet = double.Parse(txtNunMeter.Text);
                        double total = numMet / numMetPerRoll;
                        txtNumRoll.Text = total.ToString("F2");
                    }

                }
            }
            catch (Exception ex)
            {
                Log.Error($"ERROR txtNunRoll_TextChanged : {ex.Message}");
                return;
            }

        }
        #endregion

        #region "PROCESS"
        private async void dgvDetail_CellContentClick(object sender, DataGridViewCellEventArgs e) //// เมื่อกด ลบ ที่ dgv จะเข้า Event นี้
        {
            try
            {
                switch (dgvDetail.Columns[e.ColumnIndex].Name)
                {
                    case "cl_del":
                        Log.Information($"== ผู้ใช้เลือกลบข้อมูล");
                        _id = Convert.ToInt32(dgvDetail.Rows[e.RowIndex].Cells["cl_id"].Value.ToString());
                        DialogResult dialogResult = System.Windows.Forms.MessageBox.Show("คุณต้องการลบข้อมูลหรือไม่", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            if (tbWeightDetail.DELETE(_id.ToString()))
                            {
                                await func_tcpClient.SendDataAsync("GET_DATA");
                                dgvDetail.Rows.RemoveAt(e.RowIndex);
                                sb.Show(this, "ลบรายการสำเสร็จ", BunifuSnackbar.MessageTypes.Success, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                            }
                            else
                            {
                                sb.Show(this, $"DELETE {tbWeightDetail.ERR}", BunifuSnackbar.MessageTypes.Success, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                            }
                            return;
                        }
                        else
                        {
                            Log.Information($"== ผู้ใช้ยกเลิกลบข้อมูล");
                        }
                        break;
                    case "cl_edit":
                        Log.Information($"== ผู้ใช้เลือกแก้ไขข้อมูล");
                        string _employee = dgvDetail.Rows[e.RowIndex].Cells["cl_employee"].Value.ToString();
                        // เช็คว่าคนที่จะแก้ไขต้องเป็นเดียวกัน
                        if (tbEmployeeSQL.emp_username != "sa")
                        {
                            if (_employee != tbEmployeeSQL.emp_name)
                            {
                                sb.Show(this, "ไม่สามารถแก้ไขการชั่งของคนอื่นได้", BunifuSnackbar.MessageTypes.Warning, 3000, "", BunifuSnackbar.Positions.TopCenter);
                                return;
                            }
                        }

                        _id = Convert.ToInt16(dgvDetail.Rows[e.RowIndex].Cells["cl_id"].Value.ToString());
                        tbWeightDetail.seq = dgvDetail.Rows[e.RowIndex].Cells["cl_seq"].Value.ToString();
                        tbWeightDetail.lot = dgvDetail.Rows[e.RowIndex].Cells["cl_lot"].Value.ToString();
                        isEdit = true;
                        dgvDetail.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Olive;
                        dgvDetail.Enabled = false;
                        break;
                    case "cl_print":
                        Log.Information($"== ผู้ใช้เลือกพิมพ์ข้อมูลใหม่");
                        tbWeightDetail.seq = dgvDetail.Rows[e.RowIndex].Cells["cl_seq"].Value.ToString();
                        tbWeightDetail.lot = dgvDetail.Rows[e.RowIndex].Cells["cl_lot"].Value.ToString();
                        DefinePrintParameter();
                        SetPaperAndPrint();
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
        private async void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (!isStart)
            {
                return;
            }

            #region RECEIVE DATA
            //string data = Function.Function.RS232(spScale);

            string a = spScale.ReadLine();
            Console.WriteLine($"SERIAL {a}");
            Log.Information($"== SERIAL {a}");
            string[] b = a.Split(',');

            Log.Information($"- NET {b[2]}");
            Log.Information($"- TARE {b[3]}");
            Log.Information($"- GROSS {b[4]}");

            string net = b[2].Trim();
            string tare = b[3].Trim();
            string gross = b[4].Trim();

            // สดงข้อมูลน้ำหนักที่อ่านมาได้
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
                double cors = Convert.ToDouble(txtWghCors.Text);
                double tt = Convert.ToDouble(net) - cors;
                BeginInvoke(new MethodInvoker(delegate ()
                {
                    lbNetWgh.Text = Convert.ToString(tt);
                }));
                Log.Information($"- น้ำหนักแกน - น้ำหนักสุทธิ์ {tt}");
            }
            #endregion
            DataTable tb = new DataTable();

            // เช็คว่าเป็น UPDATE or INSERT
            if (isEdit) // UDPATE
            {
                #region UPDATE
                tb = tbWeightDetail.UPDATE(_id.ToString(), decimal.Parse(net), decimal.Parse(tare), decimal.Parse(gross));
                if (tb.Rows.Count != 0)
                {
                    isEdit = false;
                    _id = 0;
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
                if (tbWeightDetail.PO != "JIT")
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
                            if (tb.Rows.Count >= int.Parse(txtNumRollAll.Text))
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

                string _date = DateTime.Now.ToString("dd/MM/yy", System.Globalization.CultureInfo.CreateSpecificCulture("EN-en"));
                string _Time = DateTime.Now.ToString("HH:mm:ss", System.Globalization.CultureInfo.CreateSpecificCulture("EN-en"));
                string _lot = $"{MRP.name}{_date.Replace("/", "").Trim()}{_Time.Replace(":", "").Trim()}";


                // insert new data
                //tbWeightDetail.seq = _seq;
                tbWeightDetail.net = decimal.Parse(lbNetWgh.Text);
                tbWeightDetail.tare = decimal.Parse(lbTareWgh.Text);
                tbWeightDetail.gross = decimal.Parse(lbGrossWgh.Text);
                tbWeightDetail.wgh_paper_plastic = decimal.Parse(txtWghPaper.Text);
                tbWeightDetail.wgh_core_total = decimal.Parse(txtWghCors.Text);
                tbWeightDetail.wgh_joint = decimal.Parse(txtJoint.Text);
                tbWeightDetail.numbox = int.Parse(txtNumBox.Text);
                tbWeightDetail.numrollAll = int.Parse(txtNumRollAll.Text);
                tbWeightDetail.numroll = decimal.Parse(txtNumRoll.Text);

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

                tbWeightDetail.lot = _lot;
                tbWeightDetail.oparator = txtOperator.Text;
                RTFG.Name = "";
                RTFG.Rtfg_ID = 0;

                tb = tbWeightDetail.INSERT_DATA();
                // บันทึกข้อมูล
                if (tb.Rows.Count == 0)
                {
                    BeginInvoke(new MethodInvoker(delegate ()
                    {
                        sb.Show(this, $"บันทึกข้อมูลผิดผลาด {tbWeightDetail.ERR}", BunifuSnackbar.MessageTypes.Error, 3000, "", BunifuSnackbar.Positions.TopCenter);
                    }));
                    return;
                }
                #endregion
            }

            foreach (DataRow rw in tb.Rows)
            {
                func_print._seq = rw["wdt_seqOrigin"].ToString();
                func_print._statusType = statusType;
                func_print._net = lbNetWgh.Text;
                func_print._numBox = txtNumBox.Text;
                func_print._numRoll = txtNumRollAll.Text;
                func_print._numMeter = txtNunMeter.Text;
                func_print._pchBox = txtPchBox.Text;
                func_print._pchRoll = txtPchRoll.Text;
                func_print._wghPaper = txtWghPaper.Text;
                func_print._wghCore = txtWghCors.Text;
                func_print.pictureBox1 = pictureBox1;
                func_print._operator = txtOperator.Text;
                func_print._lot = rw["wdt_lot"].ToString();
                break;
            }
            #region Print Data
            _ = Task.Run(async () =>
            {
                await func_tcpClient.SendDataAsync("GET_DATA");
            });
            // Print Sticker
            _ = Task.Run(() =>
             {
                 SetPaperAndPrint();
                 ShowDataGridAndCountPchOrWeight();
             });
            #endregion
        }
        //============================================================================================================================================================= End  input data form RS232
        #endregion

        private void KeyIn(object sender, KeyPressEventArgs e)
        {
            Guna2TextBox txt = sender as Guna2TextBox;

            if (tbWeightDetail.PO == "JIT")  // หากผู้ใช้เลือก JIT จะไม่สามารถคีย์ จำนวนกล่องจำนวนม้วนได้
            {
                switch (txt.Name)
                {
                    case "txtNumBox":
                        sb.Show(this, "กรณีเลือกงานกล่อง ไม่สามารถคีย์จำนวนม้วนได้", BunifuSnackbar.MessageTypes.Warning, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                        txt.Text = "0";
                        e.Handled = true; // ไม่อนุญาตให้ป้อนตัวอักษรนี้
                        break;
                    case "txtNumRollAll":
                        sb.Show(this, "กรณีเลือกงานม้วน ไม่สามารถคีย์จำนวนม้วนได้", BunifuSnackbar.MessageTypes.Warning, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                        txt.Text = "0";
                        e.Handled = true; // ไม่อนุญาตให้ป้อนตัวอักษรนี้
                        break;
                }
            }


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
            //this.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (!func_print.FormatPrint(e))
            {
                msg.Icon = MessageDialogIcon.Error;
                msg.Buttons = MessageDialogButtons.OK;
                msg.Show($"Can't print \n {func_print.ERR}", "Error print printDocument1_PrintPage");
                return;
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



        private void cbbPO_SelectedIndexChanged(object sender, EventArgs e)
        {
            // เครียข้อมูล
            Log.Information($"== เลือก PO {cbbPO.Text}");
            tbWeightDetail.PO = cbbPO.Text;
            if (cbbPO.Text == "JIT")
            {
                DataTable tb1 = tbWeightDetail.SELECT_JIT_AND_PO_NOT_SEND_ODOO();
                dgvDetail.DataSource = tb1;
            }
            else
            {

                DataTable tb1 = tbWeightDetail.SELECT_PO_NOT_SEND_ODOO();
                dgvDetail.DataSource = tb1;
            }
        }

        private async void txtJobNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtJobNo.Text == "")
                {
                    Log.Warning("== พบว่าผู้ใช้ไม่ได้คีย์ชื่อ GV");
                    sb.Show(this, "กรุณากรอกข้อมูล", BunifuSnackbar.MessageTypes.Warning, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                    return;
                }
                // เครีย์ propของ MRP
                MRP.ClearProp();

                // เครียฟอร์ม
                ClearForm();

                //แสดง Loader
                pnMain.Visible = false;
                gbLoadData.Visible = true;
                label1.Text = "กำลังดึงข้อมูล.....";

                if (!await MRP.GET_MRP($"GV-{txtJobNo.Text}"))
                {
                    pnMain.Visible = true;
                    gbLoadData.Visible = false;
                    sb.Show(this, MRP.err, BunifuSnackbar.MessageTypes.Error, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                    return;
                }

                // define label
                label7.Text = $"{MRP.name}";
                label8.Text = $"{MRP.partner_name}";
                label11.Text = $"{MRP.product_name}";
                label13.Text = $"{MRP.mo_type}";
                label15.Text = $"{MRP.mo_work}";
                label17.Text = $"{MRP.mo_film}";
                label21.Text = $"{MRP.mo_station_name}";
                label23.Text = $"{MRP.mo_date_delivery}";
                label31.Text = $"{MRP.mo_date}";
                label41.Text = $"{MRP.mo_po_qty.ToString("#,###,###")}  ({MRP.uom_id})";
                label40.Text = $"{MRP.mo_po_new.ToString("#,###,###")}";
                label45.Text = $"{MRP.product_roll_length.ToString()} เมตร";
                label39.Text = $"{MRP.mo_order_qty.ToString("#,###,###")}";

                await Task.Delay(1000);

                pnMain.Visible = true;
                gbLoadData.Visible = false;
                // define combobox
                string[] a = MRP.mo_pono.Split(',');
                cbbPO.Items.Clear();

                foreach (var b in a)
                {
                    cbbPO.Items.Add(b.Trim());
                }
                cbbPO.Items.Add("JIT");
            }
        }

        private async void frmWeightNew_FormClosing(object sender, FormClosingEventArgs e)
        {
            await func_tcpClient.Disconnect();
            spScale.Close();
        }

        private void txtJobNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ตรวจสอบว่าตัวอักษรที่ผู้ใช้ป้อนเป็นตัวเลขหรือจุดทศนิยมหรือไม่
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                sb.Show(this, "กรุณากรอกเฉพาะตัวเลข", BunifuSnackbar.MessageTypes.Warning, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                e.Handled = true; // ไม่อนุญาตให้ป้อนตัวอักษรนี้
            }
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            Guna2GradientButton btn = sender as Guna2GradientButton;
            switch (btn.Text)
            {
                case "เริ่มชั่งสินค้า":
                    Log.Information($"== เริ่มชั่งสินค้า");
                    // เช็คว่าเลือกข้อมูลครบหรือไม่
                    if (statusCounty == "" || statusSide == "" || statusType == "" || cbbPO.Text == "" || txtOperator.Text == "" || txtNumRoll.Text == "")
                    {
                        Log.Information($"== พบข้อมูลการชั่งไม่ครบ");
                        Log.Information($"- ประเทศ : {statusCounty}");
                        Log.Information($"- ประเภท : {statusType}");
                        Log.Information($"- ด้าน : {statusSide}");
                        Log.Information($"- PO : {cbbPO.Text}");
                        Log.Information($"- GV : {MRP.name}");
                        Log.Information($"- จำนวนม้วน : {txtNumRoll.Text}");
                        Log.Information($"- จำนวนม้วนทั้งหมด : {txtNumRollAll.Text}");
                        msg.Icon = MessageDialogIcon.Warning;
                        msg.Buttons = MessageDialogButtons.OK;
                        msg.Show("Please check the data County,Type,Side", "Check data before save");
                        return;
                    }

                    // เช็คว่าวันที่เป็น False หรือไม่
                    if (MRP.mo_date == "False")
                    {
                        msg.Icon = MessageDialogIcon.Warning;
                        msg.Buttons = MessageDialogButtons.OK;
                        msg.Show("Can't start because not have Production Date", "Date is incorrect format");
                        return;
                    }
                    if (MRP.mo_date_delivery == "False")
                    {
                        msg.Icon = MessageDialogIcon.Warning;
                        msg.Buttons = MessageDialogButtons.YesNo;
                        DialogResult dlr = msg.Show("Do you want to continus?\nBecuase delivery date is incorrect", "Date is incorrect format");
                        if (dlr != DialogResult.Yes)
                        {
                            return;
                        }
                    }

                    tbWeightDetail.PO = cbbPO.Text;
                    tbWeightDetail.country = statusCounty;
                    tbWeightDetail.type = statusType;
                    tbWeightDetail.side = statusSide;
                    // นำ GV ไปหาในระบบก่อน
                    DataTable tb = tbWeight.SELECT_SEARCH();
                    if (tb.Rows.Count == 0) // หากไม่พบในระบบ ให้ INSERT
                    {
                        //บันทึกข้อมูลไปที่ tbWeight
                        if (!tbWeight.INSERT_ALL_DATA())
                        {
                            msg.Icon = MessageDialogIcon.Error;
                            msg.Buttons = MessageDialogButtons.OK;
                            msg.Show($"Incorrect {tbWeight.ERR}", "Error insert");
                            return;
                        }
                    }
                    else // UPDATE
                    {
                        // อัพเดทข้อมูล
                        if (!tbWeight.UPDATE_ALL_DATA())
                        {
                            msg.Icon = MessageDialogIcon.Error;
                            msg.Buttons = MessageDialogButtons.OK;
                            msg.Show($"Incorrect {tbWeight.ERR}", "Error update");
                            return;
                        }
                    }

                    // ปิดปุ่ต่่าง ๆ 
                    isStart = true;

                    btn.Text = "หยุดชั่งสินค้า";
                    txtJobNo.Enabled = false;
                    cbbPO.Enabled = false;
                    dgvDetail.Enabled = true;
                    break;
                case "หยุดชั่งสินค้า":
                    isStart = false;

                    btn.Text = "เริ่มชั่งสินค้า";
                    txtJobNo.Enabled = true;
                    cbbPO.Enabled = true;
                    dgvDetail.Enabled = false;
                    Log.Information($"== หยุดชั่งสินค้า");
                    break;
            }
        }

        private void txtNumRoll_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (txtNumRoll.Text != "")
            //    {
            //        double numMetPerRoll = MRP.product_roll_length;
            //        double numMet = double.Parse(txtNumRoll.Text);
            //        double total = numMetPerRoll / numMet;
            //        txtNumRoll.Text = total.ToString("F1");
            //    }
            //}
            //catch (Exception ex)
            //{


            //}

        }

    }
}
