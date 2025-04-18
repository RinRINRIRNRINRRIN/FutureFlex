using FutureFlex.API;
using FutureFlex.Function;
using FutureFlex.Models;
using FutureFlex.SQL;
using Guna.UI2.WinForms;
using Serilog;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutureFlex
{
    public partial class frmWeightPO : Form
    {
        public frmWeightPO()
        {
            InitializeComponent();
            ClearForm();
            ShowLoadData();

            this.FormBorderStyle = FormBorderStyle.None;
            dgvDetail.ColumnHeadersDefaultCellStyle.Font = new Font("Athiti", 12, System.Drawing.FontStyle.Regular);
            dgvDetail.DefaultCellStyle.Font = new Font("Athiti", 12, System.Drawing.FontStyle.Regular);
            dgvDetail.DefaultCellStyle.ForeColor = Color.Black;

            cbbSo.Items.Clear();
            cbbSo.Items.Add("--เลือกเลขที่ SO--");
            cbbSo.SelectedIndex = 0;
        }

        string statusType { get; set; }     ///// ใช่้สำหรับเก็บค่า การเลือกประเภท จาก Groupbox 
        string statusCounty { get; set; }   ///// ใช่้สำหรับเก็บค่า การเลือกประเทศ จาก Groupbox 
        string statusSide { get; set; }     ///// ใช่้สำหรับเก็บค่า การเลือกด้าน จาก Groupbox 
        bool statusPrint { get; set; } = false;   // ใช้สำหรับเก็บค่า การพิมพ์แบบ Auto หรือไม่ | true = AutoPrint ,False = ShowDialog before print

        bool isStart = false; // สำหรับเก็บค่าว่า เริ่มหรือยัง

        int _id = 0; // สำหรับเช็คว่ามีค่าที่จะต้อง UPDATE หรือไม่
        bool isEdit = false; // สำหรับเช็คว่ามีการ แก้ไข หรือไม่



        void ShowLoadData()
        {
            int x = (this.Width - gbLoadData.Width) / 2;
            int y = (this.Height - gbLoadData.Height) / 2;

            gbLoadData.Location = new System.Drawing.Point(x, y);
        }



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

            cbbSo.Items.Clear();
            cbbSo.Items.Add("--เลือกเลขที่ SO--");
            cbbSo.SelectedIndex = 0;

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
            Log.Information("== เครีย์ Form สำเร็จ");
        }


        void SetPaperAndPrint()
        {
            // Set paper 
            if (cbPrint.Checked)
            {
                Log.Information("- ผู้ใช้เลือกพิมพ์ข้อมูล");

                // Check print is online?
                if (!func_print.SetPrinter(printDocument1, "PO"))
                {
                    BeginInvoke(new MethodInvoker(delegate ()
                    {
                        msg.Icon = MessageDialogIcon.Warning;
                        msg.Buttons = MessageDialogButtons.OK;
                        msg.Show("Can't connect the printer", "Printer disconnect");
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
                            msg.Icon = MessageDialogIcon.Warning;
                            msg.Buttons = MessageDialogButtons.OK;
                            msg.Show("Please close form print", "Close form print!!");
                        }));
                        return;
                    }
                }
            }
        }


        /// <summary>
        /// สำหรับนับจำนวนน้ำหนักหลังจากชั่งแต่ละครั้งขึ้นอยู่กับว่า หน่วยซื้อ เป็น ใบหรือเป็นน้ำหนัก
        /// </summary>
        void ShowDataGridAndCountPchOrWeight()
        {
            // แสดงข้อมูล
            BeginInvoke(new MethodInvoker(delegate ()
            {
                DataTable tb1 = tbWeightDetail.SELECT_GV_NOT_SEND_ODOO(MRP.mo_so_no, MRP.mo_pono, statusType);
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


        /// <summary>
        /// กำหนดค่าตัวแปลก่อนทำการปริ้น
        /// </summary>
        void DefinePrintParameter(string seq, string statusType, string net, string numBox, string numRoll, string numMeter, string pchBox, string pchRoll, string wghPaper, string wghCore, string opareter, string lot, string printType)
        {

            // Print paper
            func_print._seq = seq;
            func_print._statusType = statusType;
            func_print._net = net;
            func_print._numBox = numBox;
            func_print._numRoll = numRoll;
            func_print._numMeter = numMeter;
            func_print._pchBox = pchBox;
            func_print._pchRoll = pchRoll;
            func_print._wghPaper = wghPaper;
            func_print._wghCore = wghCore;
            func_print.pictureBox1 = pictureBox1;
            func_print._operator = opareter;
            func_print._lot = lot;
            func_print.printType = printType;
        }



        private async void frmWeightPO_Load(object sender, EventArgs e)
        {
            try
            {
                Log.Information($"==================================================   weiught JIT is open");
                pnMain.Visible = false;
                gbLoadData.Visible = true;
                label1.Text = "กำลังเชื่อมต่อ server futureflex ..";
                //// เชื่อมต่อ TcpServer ก่อน
                if (!await func_tcpClient.Connect())
                {
                    msg.Icon = MessageDialogIcon.Error;
                    msg.Buttons = MessageDialogButtons.OK;
                    msg.Show("Can't connect to server futureflex", "TCP Server Error");
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

        private async void txtPo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPo.Text == "")
                {
                    Log.Warning("== พบว่าผู้ใช้ไม่ได้คีย์ชื่อ GV");
                    msg.Icon = MessageDialogIcon.Warning;
                    msg.Buttons = MessageDialogButtons.OK;
                    msg.Show("Please fill the Gv number", "Fill GV number");
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

                if (!await MRP.GET_PO(txtPo.Text))
                {
                    pnMain.Visible = true;
                    gbLoadData.Visible = false;
                    msg.Icon = MessageDialogIcon.Error;
                    msg.Buttons = MessageDialogButtons.OK;
                    msg.Show($"Get MRP Error \nError : {MRP.err}", "Get MRP Error");
                    return;
                }


                await Task.Delay(1000);

                pnMain.Visible = true;
                gbLoadData.Visible = false;

                cbbSo.Items.Clear();

                // นำข้อมูลมาแสดงที่ combobox
                for (int i = 0; i < MRP.gvAndPo.Count; i++)
                {
                    cbbSo.Items.Add(MRP.gvAndPo[i]);
                }

            }
        }

        private async void cbbSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSo.Text != "" && cbbSo.Text != "--เลือกเลขที่ SO--")
            {
                string[] gv = cbbSo.Text.Split('|');
                string _gv = gv[0].Substring(3).Trim();

                pnMain.Visible = false;
                gbLoadData.Visible = true;
                label1.Text = "กำลังดึงข้อมูล.....";

                if (!await MRP.GET_MRP($"GV-{_gv}"))
                {
                    pnMain.Visible = true;
                    gbLoadData.Visible = false;
                    msg.Icon = MessageDialogIcon.Error;
                    msg.Buttons = MessageDialogButtons.OK;
                    msg.Show($"Get MRP Error \nError : {MRP.err}", "Get MRP Error");
                    return;
                }
                // define label
                label7.Text = $"{MRP.name}";
                lblSo.Text = MRP.mo_so_no;
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
                lblMoBlock.Text = MRP.mo_block.ToString();

                await Task.Delay(1000);

                pnMain.Visible = true;
                gbLoadData.Visible = false;
            }
        }

        private void spScale_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string a = spScale.ReadLine();
            Console.WriteLine(a);
            if (!isStart)
            {
                return;
            }

            #region RECEIVE DATA
            //string data = Function.Function.RS232(spScale);
            string net = "";
            string tare = "0.00";
            string gross = "0.00";

            string[] b = a.Split('\r');
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i].Contains("NET"))
                {
                    Console.WriteLine(b[i]);
                    Console.WriteLine(b[i].Length);
                    string strSup = b[i].Substring(13, b[i].Length - 13).Trim();
                    double weight = double.Parse(strSup);
                    net = strSup;
                    break;
                }
            }

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
                net = Convert.ToString(Convert.ToDouble(net) - cors);
                BeginInvoke(new MethodInvoker(delegate ()
                {
                    lbNetWgh.Text = net;
                }));
                Log.Information($"- น้ำหนักแกน - น้ำหนักสุทธิ์ {net}");
            }
            #endregion
            DataTable tb = new DataTable();

            // เช็คว่าเป็น UPDATE or INSERT
            if (isEdit) // UDPATE
            {
                #region UPDATE
                tb = tbWeightDetail.UPDATE(_id.ToString(), double.Parse(net), double.Parse(tare), double.Parse(gross));
                if (tb.Rows.Count != 0)
                {
                    isEdit = false;
                    _id = 0;
                }
                else
                {
                    BeginInvoke(new MethodInvoker(delegate ()
                    {
                        msg.Icon = MessageDialogIcon.Error;
                        msg.Buttons = MessageDialogButtons.OK;
                        msg.Show($"Error update weight \nError {tbWeightDetail.ERR}", "Update error");
                    }));
                    return;
                }
                #endregion
            }
            else // INSERT
            {
                // เช็คว่าเป็นเป็นงานม้วนหรือกล่อง
                switch (statusType)
                {
                    case "box":
                        if (dgvDetail.Rows.Count >= int.Parse(txtNumBox.Text))
                        {
                            BeginInvoke(new MethodInvoker(delegate ()
                            {
                                msg.Icon = MessageDialogIcon.Warning;
                                msg.Buttons = MessageDialogButtons.OK;
                                msg.Show("Total box is full", "Box is full");
                            }));
                            return;
                        }
                        break;
                    case "roll":
                        if (dgvDetail.Rows.Count >= int.Parse(txtNumRollAll.Text))
                        {
                            BeginInvoke(new MethodInvoker(delegate ()
                            {
                                msg.Icon = MessageDialogIcon.Warning;
                                msg.Buttons = MessageDialogButtons.OK;
                                msg.Show("Total rolls is full", "Rolls is full");
                            }));
                            return;
                        }
                        break;
                }



                #region SAVE DATA

                string _date = DateTime.Now.ToString("dd/MM/yy", System.Globalization.CultureInfo.CreateSpecificCulture("EN-en"));
                string _Time = DateTime.Now.ToString("HH:mm:ss", System.Globalization.CultureInfo.CreateSpecificCulture("EN-en"));
                string _lot = $"{MRP.name}{_date.Replace("/", "").Trim()}{_Time.Replace(":", "").Trim()}";


                // insert new data
                double _net = double.Parse(net);
                double _tare = double.Parse(tare);
                double _gross = double.Parse(gross);
                double _wgh_paper_plasic = double.Parse(txtWghPaper.Text);
                double _wgh_core = double.Parse(txtWghCors.Text);
                double _wgh_joint = double.Parse(txtJoint.Text);
                int _numBox = int.Parse(txtNumBox.Text);
                int _numRollAll = int.Parse(txtNumRollAll.Text);
                double _numRoll = double.Parse(txtNumRoll.Text);
                double _wgh_meter_kg_in_rolll = 0;
                int _pch = 0;
                switch (statusType)
                {
                    case "box":
                        _wgh_meter_kg_in_rolll = 0;
                        _pch = int.Parse(txtPchBox.Text);
                        break;
                    case "roll":
                        _wgh_meter_kg_in_rolll = double.Parse(txtNunMeter.Text);
                        _pch = int.Parse(txtPchRoll.Text);
                        break;
                }

                tb = tbWeightDetail.INSERT_DATA(MRP.name, int.Parse(MRP.id), "", 0, "", 0, MRP.mo_pono, MRP.mo_so_no, statusCounty, statusType, statusSide, _net, _tare, _gross, _wgh_paper_plasic, _wgh_core, _wgh_joint, _wgh_meter_kg_in_rolll, _numBox, _numRollAll, _numRoll, _pch, _lot, txtOperator.Text, "PO", "L");
                // บันทึกข้อมูล
                if (tb.Rows.Count == 0)
                {
                    BeginInvoke(new MethodInvoker(delegate ()
                    {
                        msg.Icon = MessageDialogIcon.Error;
                        msg.Buttons = MessageDialogButtons.OK;
                        msg.Show($"Save weight error \nError : {tbWeightDetail.ERR}", "Save Error");
                    }));
                    return;
                }
                #endregion
            }

            // loop อ่านค่าจาก datatable
            foreach (DataRow rw in tb.Rows)
            {
                string Seq = rw["wdt_seqOrigin"].ToString();
                string Lot = rw["wdt_lot"].ToString();

                DefinePrintParameter(Seq, statusType, lbNetWgh.Text, txtNumBox.Text, txtNumRollAll.Text, txtNunMeter.Text, txtPchBox.Text, txtPchRoll.Text, txtWghPaper.Text, txtWghCors.Text, txtOperator.Text, Lot, "PO");
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

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
            Guna2GradientButton btn = sender as Guna2GradientButton;
            switch (btn.Text)
            {
                case "เริ่มชั่งสินค้า":
                    Log.Information($"== เริ่มชั่งสินค้า");
                    // เช็คว่าเลือกข้อมูลครบหรือไม่
                    if (statusCounty == "" || statusSide == "" || statusType == "" || cbbSo.Text == "" || txtOperator.Text == "" || txtNumRoll.Text == "")
                    {
                        Log.Information($"== พบข้อมูลการชั่งไม่ครบ");
                        Log.Information($"- ประเทศ : {statusCounty}");
                        Log.Information($"- ประเภท : {statusType}");
                        Log.Information($"- ด้าน : {statusSide}");
                        Log.Information($"- so : {MRP.mo_so_no}");
                        Log.Information($"- PO : {MRP.mo_po}");
                        Log.Information($"- GV : {MRP.name}");
                        Log.Information($"- จำนวนม้วน : {txtNumRoll.Text}");
                        Log.Information($"- จำนวนม้วนทั้งหมด : {txtNumRollAll.Text}");
                        msg.Icon = MessageDialogIcon.Warning;
                        msg.Buttons = MessageDialogButtons.OK;
                        msg.Show("Please check the data County,Type,Side", "Check data before save");
                        return;
                    }

                        //เช็คว่าวันที่เป็น False หรือไม่
                    if (MRP.mo_date == "False")
                    {
                        msg.Icon = MessageDialogIcon.Warning;
                        msg.Buttons = MessageDialogButtons.OK;
                        msg.Show("Can't start because not have Production Date", "Date is incorrect format");
                        return;
                    }

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

                        // Connect port 
                        if (spScale.IsOpen)
                        {
                            spScale.Close();
                        }

                        // กำหนดค่าให้กับ serialpor
                        spScale.PortName = func_serialport.COM_SCALE;
                        spScale.BaudRate = func_serialport.BAUDRATE_SCALE;
                        spScale.Open();
                        Log.Information($"==================================================== Serial port open");
                        Log.Information($"-- COM SCALE : {spScale.PortName}");
                        Log.Information($"-- COM BAUDRATE : {spScale.BaudRate}");
                        Log.Information($"Scale is connected");
                    // ปิดปุ่ต่่าง ๆ 
                    isStart = true;

                    btn.Text = "หยุดชั่งสินค้า";
                    txtPo.Enabled = false;
                    cbbSo.Enabled = false;
                    dgvDetail.Enabled = true;
                    break;
                case "หยุดชั่งสินค้า":
                    isStart = false;
                        spScale.Close();

                    btn.Text = "เริ่มชั่งสินค้า";
                    txtPo.Enabled = true;
                    cbbSo.Enabled = true;
                    dgvDetail.Enabled = false;
                    Log.Information($"== หยุดชั่งสินค้า");
                    break;
            }

            }
            catch (Exception ex)
            {
                msg.Icon = MessageDialogIcon.Error;
                msg.Buttons = MessageDialogButtons.OK;
                msg.Show(ex.Message, "Error");
        }
        }

        private void SelectCountry(object sender, EventArgs e)
        {
            RadioButton rdb = sender as RadioButton;
            if (rdb.Checked)
            {
                statusCounty = rdb.Tag.ToString();
            }
        }

        private void SelectType(object sender, EventArgs e)
        {
            RadioButton rdb = sender as RadioButton;
            if (rdb.Checked)
            {
                switch (rdb.Tag.ToString())
                {
                    case "box":
                        foreach (var txt in panel2.Controls.OfType<Guna.UI2.WinForms.Guna2TextBox>())
                        {
                            if (txt.Tag.ToString() == "roll")
                            {
                                txt.Text = "0";
                                txt.Enabled = false;
                            }
                        }

                        foreach (var txt in panel2.Controls.OfType<Guna.UI2.WinForms.Guna2TextBox>())
                        {
                            if (txt.Tag.ToString() == "box")
                            {
                                txt.Text = "0";
                                txt.Enabled = true;
                            }
                        }

                        btnReprint.Text = "NET WEIGHT";
                        gbSide.Enabled = false;
                        rdNot.Checked = true;


                        break;
                    case "roll":
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

                        break;
                }
                statusType = rdb.Tag.ToString();
                ShowDataGridAndCountPchOrWeight();
            }

        }

        private void SelectSide(object sender, EventArgs e)
        {
            RadioButton rdb = sender as RadioButton;
            if (rdb.Checked)
                statusSide = rdb.Tag.ToString();
        }

        private async void frmWeightPO_FormClosing(object sender, FormClosingEventArgs e)
        {
            await func_tcpClient.Disconnect();
            spScale.Close();
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

        private async void dgvDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                switch (dgvDetail.Columns[e.ColumnIndex].Name)
                {
                    case "cl_del":
                        Log.Information($"== ผู้ใช้เลือกลบข้อมูล");
                        _id = Convert.ToInt32(dgvDetail.Rows[e.RowIndex].Cells["cl_id"].Value.ToString());
                        msg.Icon = MessageDialogIcon.Question;
                        msg.Buttons = MessageDialogButtons.YesNo;

                        DialogResult dialogResult = msg.Show($"Do you want delete the weight id: {_id}", "Delete ?");
                        if (dialogResult == DialogResult.Yes)
                        {
                            if (tbWeightDetail.DELETE(_id.ToString()))
                            {
                                await func_tcpClient.SendDataAsync("GET_DATA");
                                dgvDetail.Rows.RemoveAt(e.RowIndex);
                                msg.Icon = MessageDialogIcon.Information;
                                msg.Buttons = MessageDialogButtons.OK;
                                msg.Show($"Delete weight id :{_id}", "Delete success");
                            }
                            else
                            {
                                msg.Icon = MessageDialogIcon.Error;
                                msg.Buttons = MessageDialogButtons.OK;
                                msg.Show($"Delete weight id :{_id} \nError : {tbWeightDetail.ERR}", "Delete Error");
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
                        if (EmployeeModel.emp_username != "sa")
                        {
                            if (_employee != EmployeeModel.emp_name)
                            {
                                msg.Icon = MessageDialogIcon.Warning;
                                msg.Buttons = MessageDialogButtons.OK;
                                msg.Show($"Do you want delete the weight id: {_id}", "Delete ?");
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
                        string _seq = dgvDetail.Rows[e.RowIndex].Cells["cl_seq"].Value.ToString();
                        string _statusType = dgvDetail.Rows[e.RowIndex].Cells["cl_type"].Value.ToString();
                        string _net = dgvDetail.Rows[e.RowIndex].Cells["cl_net"].Value.ToString();
                        string _numBox = dgvDetail.Rows[e.RowIndex].Cells["cl_numBox"].Value.ToString();
                        string _numRoll = dgvDetail.Rows[e.RowIndex].Cells["cl_numRoll"].Value.ToString();
                        string _numRollAll = dgvDetail.Rows[e.RowIndex].Cells["cl_numrollAll"].Value.ToString();
                        string _numMeter = dgvDetail.Rows[e.RowIndex].Cells["cl_meter_kg_in_roll"].Value.ToString();
                        string _pch = dgvDetail.Rows[e.RowIndex].Cells["cl_pch"].Value.ToString();
                        string _wghPaper = dgvDetail.Rows[e.RowIndex].Cells["cl_wgh_paper_plastic"].Value.ToString();
                        string _wghCore = dgvDetail.Rows[e.RowIndex].Cells["cl_core"].Value.ToString();
                        string _operator = dgvDetail.Rows[e.RowIndex].Cells["cl_oparator"].Value.ToString();
                        string _lot = dgvDetail.Rows[e.RowIndex].Cells["cl_lot"].Value.ToString();
                        DefinePrintParameter(_seq, _statusType, _net, _numBox, _numRollAll, _numMeter, _pch, _pch, _wghPaper, _wghCore, _operator, _lot, "PO");
                        SetPaperAndPrint();
                        break;
                }
            }
            catch (Exception ex)
            {
                msg.Icon = MessageDialogIcon.Error;
                msg.Buttons = MessageDialogButtons.OK;
                msg.Show($"DataGridView \nError : {ex.Message}", "Functoin dgvDetail_CellContentClick");
                return;
            }
        }

        private void txtNunMeter_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtNunMeter.Text != "")
                {
                    if (txtNunMeter.Text != "0")
                    {
                        string a = MRP.pch_length.ToString();

                        if (MRP.shrink_mm != 0)
                        {
                            double aa = MRP.pch_length + MRP.shrink_mm;
                            a = aa.ToString();
                        }

                        double c = double.Parse(a) / 1000;
                        double d = double.Parse(txtNunMeter.Text) / c;
                        double total = Math.Truncate(d);
                        txtPchRoll.Text = total.ToString();
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

        private void SelectPrint(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                statusPrint = true;
            }
            if (radioButton4.Checked)
            {
                statusPrint = false;
            }
        }
    }
}
