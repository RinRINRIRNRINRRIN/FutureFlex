using Bunifu.UI.WinForms;
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
    public partial class frmRTFG : Form
    {
        public frmRTFG()
        {
            InitializeComponent();

            ClearForm();

            ShowLoadData();
        }


        /// <summary>
        /// เก็บข้อมูลว่าเป็นงาน กล่องหรือม้วน
        /// </summary>
        private string statusType { get; set; }

        /// <summary>
        /// ใช่้สำหรับเก็บค่า การเลือกประเทศ จาก Groupbox 
        /// </summary>
        private string statusCounty { get; set; }

        /// <summary>
        /// ใช่้สำหรับเก็บค่า การเลือกด้าน จาก Groupbox 
        /// </summary>
        private string statusSide { get; set; }


        /// <summary>
        /// ใช้สำหรับเก็บค่า การพิมพ์แบบ Auto หรือไม่ | true = AutoPrint ,False = ShowDialog before print
        /// </summary>
        private bool statusPrint { get; set; } = false;

        /// <summary>
        /// การชั่งครั้งนี้เป็น PO หรือ JIT
        /// </summary>
        public string weightType { get; set; }


        /// <summary>
        /// สำหรับเก็บค่าว่า เริ่มหรือยัง
        /// </summary>
        private bool isStart { get; set; } = false;

        /// <summary>
        /// สำหรับเช็คว่ามีค่าที่จะต้อง UPDATE หรือไม่
        /// </summary>

        private int _id { get; set; } = 0;
        private bool isEdit { get; set; } = false; // สำหรับเช็คว่ามีการ แก้ไข หรือไม่

        BunifuSnackbar sb = new BunifuSnackbar();

        /// <summary>
        /// สำหรับแสดง UI Loader
        /// </summary>
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

            foreach (var txt in panel2.Controls.OfType<Guna.UI2.WinForms.Guna2TextBox>())
            {
                txt.Text = "0";
                txt.Enabled = false;
            }
        }


        /// <summary>
        /// สำหรับนับจำนวนน้ำหนักหลังจากชั่งแต่ละครั้งขึ้นอยู่กับว่า หน่วยซื้อ เป็น ใบหรือเป็นน้ำหนัก
        /// </summary>
        void ShowDataGridAndCountPchOrWeight()
        {
            try
            {
                // แสดงข้อมูล
                DataTable tb1 = tbWeightDetail.SELECT_RTFG_NOT_SEND_ODOO(statusType, RTFG.new_sale_name, weightType);
                BeginInvoke(new MethodInvoker(delegate ()
                {
                    dgvDetail.DataSource = tb1;

                    // เช็คว่าจะต้องแสดงจำนวนทั้งหมดในรูปแบบ ใบหรือกิโล
                    switch (MRP.product_uom_name)
                    {
                        case "ใบ(s)":
                            lblPchTotal.Text = "จำนวนใบทั้งหมด : ";
                            // ลูปเอาน้ำหนักทั้งหมดจากตาราง
                            foreach (DataGridViewRow rw in dgvDetail.Rows)
                            {
                                double _net = 0;
                                for (int i = 0; i < dgvDetail.Rows.Count; i++)
                                {
                                    _net += double.Parse(dgvDetail.Rows[i].Cells["cl_pch"].Value.ToString());
                                }

                                lblCountTotal.Text = $"{_net} s";
                            }
                            break;
                        default:
                            // ลูปเอาน้ำหนักทั้งหมดจากตาราง
                            foreach (DataGridViewRow rw in dgvDetail.Rows)
                            {
                                double _net = 0;
                                for (int i = 0; i < dgvDetail.Rows.Count; i++)
                                {
                                    _net += double.Parse(dgvDetail.Rows[i].Cells["cl_net"].Value.ToString());
                                }

                                lblCountTotal.Text = $"{_net} Kg";
                            }
                            lblPchTotal.Text = "จำนวนกิโลทั้งหมด : ";
                            break;
                    }
                }));
            }
            catch
            {


            }

        }

        void EnableAndDisableData(string BoxOrRoll)
        {
            foreach (var txt in panel2.Controls.OfType<Guna.UI2.WinForms.Guna2TextBox>())
            {
                if (txt.Tag.ToString() == BoxOrRoll)
                {
                    txt.Text = "0";
                    txt.Enabled = true;
                }
                else
                {
                    txt.Enabled = false;
                }
            }
        }

        void SetPaperAndPrint()
        {
            // Set paper 
            if (cbPrint.Checked)
            {
                Log.Information("- ผู้ใช้เลือกพิมพ์ข้อมูล");

                // Check print is online?
                if (!func_print.SetPrinter(printDocument1, weightType))
                {
                    BeginInvoke(new MethodInvoker(delegate ()
                    {
                        sb.Show(this, "ไม่สามารถเชื่อมต่อ printer ได้", BunifuSnackbar.MessageTypes.Warning, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                    }));
                    return;
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
                    catch (Exception ex)
                    {
                        //sb.Show(this, "กรุณาปิด หน้าต่างการพิมพ์ " + ex.Message, BunifuSnackbar.MessageTypes.Error, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                        return;
                    }
                }
            }
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

        private void KeyIn(object sender, KeyPressEventArgs e)
        {
            Guna2TextBox txt = sender as Guna2TextBox;

            if (weightType == "JIT")  // หากผู้ใช้เลือก JIT จะไม่สามารถคีย์ จำนวนกล่องจำนวนม้วนได้
            {
                switch (txt.Name)
                {
                    case "txtNumBox":
                        sb.Show(this, "กรณีเลือกงานกล่อง ไม่สามารถคีย์จำนวนม้วนได้", BunifuSnackbar.MessageTypes.Warning, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                        txt.Text = "0";
                        e.Handled = true; // ไม่อนุญาตให้ป้อนตัวอักษรนี้
                        return;
                    case "txtNumRoll":
                        sb.Show(this, "กรณีเลือกงานม้วน ไม่สามารถคีย์จำนวนม้วนได้", BunifuSnackbar.MessageTypes.Warning, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                        txt.Text = "0";
                        e.Handled = true; // ไม่อนุญาตให้ป้อนตัวอักษรนี้
                        return;
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


        /// <summary>
        /// ดึงข้อมูลจาก TCP SERVER
        /// </summary>
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
        /// กำหนดข้อมูลก่อนการชั่ง
        /// </summary>
        void DefineParameterBeforeWeight()
        {
            // แสดงข้อมูลจาก Property
            lblName.Text = RTFG.Name;
            lblDate.Text = MRP.mo_date;
            lblDateDelivery.Text = MRP.mo_date_delivery;
            lblMoFilm.Text = MRP.mo_film;
            lblMoBlock.Text = MRP.mo_block;
            lblMoWork.Text = MRP.mo_work;
            lblPartner.Text = MRP.partner_name;
            lblProduct.Text = MRP.product_name;
            lblProductUomName.Text = MRP.product_uom_name;
            lblMoType.Text = MRP.mo_type;
            lblRetrunQtyPch.Text = RTFG.Return_qty_pch.ToString();
            lblReturnQtyWeight.Text = RTFG.Return_qty_weight.ToString();
            label41.Text = MRP.mo_po_qty.ToString();
            label21.Text = MRP.mo_station_name;
            label8.Text = MRP.product_roll_length + " เมตร";
            lblReturnQtyWeight.Text = RTFG.Return_qty_weight.ToString() + " Kg";
            lblNewSaleOrder.Text = RTFG.new_sale_name;
        }

        /// <summary>
        /// สำหรับกำหนดค่า comport 
        /// </summary>
        bool DefineComport()
        {
            try
            {
                if (spScale.IsOpen)
                {
                    spScale.Close();
                }
                spScale.PortName = func_serialport.COM_SCALE;
                spScale.BaudRate = func_serialport.BAUDRATE_SCALE;
                spScale.Open();

                Log.Information($"== Serial port open");
                Log.Information($"-- COM SCALE : {spScale.PortName}");
                Log.Information($"-- COM BAUDRATE : {spScale.BaudRate}");
                Log.Information($"Scale is connected");
            }
            catch (Exception ex)
            {
                msg.Icon = MessageDialogIcon.Error;
                msg.Buttons = MessageDialogButtons.OK;
                msg.Show(ex.Message, "Error");
                return false;
            }
            return true;
        }


        /// <summary>
        /// สำหรับกำหนดสิทธิ์การใช้งานโปรแกรม
        /// </summary>
        void DefinePrivilage()
        {
            if (tbPrivilage.weight.del == "True") { dgvDetail.Columns["cl_del"].Visible = true; }
            if (tbPrivilage.weight.edit == "True") { dgvDetail.Columns["cl_edit"].Visible = true; }

            Log.Information($"== Get privilage");
            Log.Information($"-- DEL : {tbPrivilage.weight.del} ");
            Log.Information($"-- EDIT : {tbPrivilage.weight.edit} ");
        }

        private async void frmRTFG_Load(object sender, EventArgs e)
        {
            Log.Information($"==================================================   frmRTFGis open");
            pnMain.Visible = false;
            gbLoadData.Visible = true;
            switch (weightType)
            {
                case "PO":
                    lblWeightType.Text = $"ชั่งเพื่อขาย PO : {RTFG.new_po_customer}";
                    break;
                default:
                    lblWeightType.Text = $"ชั่งเพื่อเก็บ : {weightType}";
                    break;
            }
            // เชื่อมต่อ TcpServer ก่อน
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

            // เปิดการอ่านค่าจาก Server
            _ = Task.Run(() =>
            {
                GetMessage();
            });

            await Task.Delay(500);
            label7.Text = "กำลังแสดงข้อมูล";
            DefineParameterBeforeWeight();

            await Task.Delay(500);
            label7.Text = "กำลังกำหนดค่าสิทธิ์การใช้งาน";
            // เช็คสิทธื ว่าลบหรือแก้ไขได้หรือไม่
            DefinePrivilage();

            await Task.Delay(500);
            label7.Text = "กำลังแสดงข้อมูล";
            // แสดงข้อมูลจาก datagridview
            ShowDataGridAndCountPchOrWeight();

            gbLoadData.Visible = false;
            pnMain.Visible = true;
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
                        DialogResult dialogResult = System.Windows.Forms.MessageBox.Show("คุณต้องการลบข้อมูลหรือไม่", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            if (tbWeightDetail.DELETE(_id.ToString()))
                            {
                                //dgvDetail.Rows.RemoveAt(e.RowIndex);
                                await func_tcpClient.SendDataAsync("GET_DATA");
                                ShowDataGridAndCountPchOrWeight();
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
                        if (EmployeeModel.emp_username != "sa")
                        {
                            if (_employee != EmployeeModel.emp_name)
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
                        DefinePrintParameter(_seq, _statusType, _net, _numBox, _numRollAll, _numMeter, _pch, _pch, _wghPaper, _wghCore, _operator, _lot, weightType);
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

        private void RaidoButtonRecheckBoxAndRoll(object sender, EventArgs e)
        {
            RadioButton rdbName = sender as RadioButton;
            if (rdbName.Checked)
            {
                switch (rdbName.Name)
                {
                    case "rdTypeRoll":
                        statusType = "roll";
                        gbSide.Enabled = true;
                        txtNumBox.Enabled = false;
                        EnableAndDisableData("roll");
                        break;
                    case "rdTypeBox":
                        btnReprint.Text = "น้ำหนักสุทธิ - น้ำหนักแกน";
                        statusType = "box";
                        btnReprint.Text = "NET WEIGHT";
                        rdNot.Checked = true;
                        gbSide.Enabled = false;
                        EnableAndDisableData("box");
                        break;
                }
                ShowDataGridAndCountPchOrWeight();
            }
        }


        private void frmRTFG_FormClosing(object sender, FormClosingEventArgs e)
        {
            func_tcpClient.Disconnect();
            spScale.Close();
            Task.Delay(500);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Guna2GradientButton btn = sender as Guna2GradientButton;
            switch (btn.Text)
            {
                case "เริ่มคืนสินค้า":
                    Log.Information($"== เริ่มคืนสินค้า");
                    // เช็คว่าเลือกข้อมูลครบหรือไม่
                    if (statusCounty == "" || statusSide == "" || statusType == "" || txtOperator.Text == "" || txtNumRoll.Text == "")
                    {
                        Log.Information($"== พบข้อมูลการชั่งไม่ครบ");
                        Log.Information($"- ประเทศ : {statusCounty}");
                        Log.Information($"- ประเภท : {statusType}");
                        Log.Information($"- ด้าน : {statusSide}");
                        Log.Information($"- PO : JIT");
                        Log.Information($"- GV : {MRP.name}");
                        Log.Information($"- จำนวนม้วน : {txtNumRoll.Text}");
                        Log.Information($"- จำนวนม้วนทั้งหมด : {txtNumRollAll.Text}");
                        sb.Show(this, "กรุณาตรวจสอบ ประเทศ ประเภท ด้าน po ก่อนกันบันทึก", BunifuSnackbar.MessageTypes.Warning, 3000, "", BunifuSnackbar.Positions.TopCenter);
                        return;
                    }

                    tbWeightDetail.PO = "JIT";
                    tbWeightDetail.country = statusCounty;
                    tbWeightDetail.type = statusType;
                    tbWeightDetail.side = statusSide;
                    // !! กำลังงงว่าจะหาทำไม
                    // นำ GV ไปหาในระบบก่อน
                    DataTable tb = tbWeight.SELECT_SEARCH();
                    if (tb.Rows.Count == 0) // หากไม่พบในระบบ ให้ INSERT
                    {
                        //บันทึกข้อมูลไปที่ tbWeight
                        if (!tbWeight.INSERT_ALL_DATA())
                        {
                            sb.Show(this, $"เกิดข้อผิดผลาด {tbWeight.ERR}", BunifuSnackbar.MessageTypes.Error, 3000, "", BunifuSnackbar.Positions.TopCenter);
                            return;
                        }
                    }
                    else // UPDATE
                    {
                        // อัพเดทข้อมูล
                        if (!tbWeight.UPDATE_ALL_DATA())
                        {
                            sb.Show(this, $"เกิดข้อผิดผลาด {tbWeight.ERR}", BunifuSnackbar.MessageTypes.Error, 3000, "", BunifuSnackbar.Positions.TopCenter);
                            return;
                        }
                    }
                    // กำหนดค่าให้กับ serialport
                    if (!DefineComport())
                    {
                        return;
                    }
                    // ปิดปุ่ต่่าง ๆ 
                    isStart = true;

                    btn.Text = "หยุดคืนสินค้า";
                    dgvDetail.Enabled = true;
                    break;
                case "หยุดคืนสินค้า":
                    isStart = false;
                    spScale.Close();
                    btn.Text = "เริ่มคืนสินค้า";
                    dgvDetail.Enabled = false;
                    Log.Information($"== หยุดคืนสินค้า");
                    break;
            }
        }

        private void spScale_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            Console.WriteLine(spScale.ReadLine());
            if (!isStart)
            {
                return;
            }

            #region RECEIVE DATA
            //string data = Function.Function.RS232(spScale);
            string net = "";
            string tare = "0.00";
            string gross = "0.00";

            string a = spScale.ReadLine();
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
                double _net = double.Parse(net) - cors;
                net = _net.ToString();
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
                    BeginInvoke(new MethodInvoker(delegate ()
                    {
                        dgvDetail.Enabled = true;
                    }));
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
                // เช็คว่าจำนวนเกิน หรือไม่ แต่ต้องเช็คว่าเป็นเป็น ใบ หรือ KG 
                if (MRP.product_uom_name == "ใบ(s)")
                {
                    // เช็คว่าจำนวนใบว่าครบหรือไม่
                    double pch = 0;
                    for (int i = 0; i < dgvDetail.Rows.Count; i++)
                    {
                        pch += double.Parse(dgvDetail.Rows[i].Cells["cl_pch"].Value.ToString());
                    }
                    pch += int.Parse(txtPchBox.Text);

                    if (pch > RTFG.Return_qty_pch)
                    {
                        BeginInvoke(new MethodInvoker(delegate ()
                        {
                            msg.Icon = MessageDialogIcon.Error;
                            msg.Buttons = MessageDialogButtons.OK;
                            msg.Show($"Product is full", "Product is full");
                        }));
                        return;
                    }
                }
                else
                {
                    double znet = 0;
                    for (int i = 0; i < dgvDetail.Rows.Count; i++)
                    {
                        znet += double.Parse(dgvDetail.Rows[i].Cells["cl_net"].Value.ToString());
                    }

                    if ((znet + double.Parse(net)) > RTFG.Return_qty_weight)
                    {
                        BeginInvoke(new MethodInvoker(delegate ()
                        {
                            msg.Icon = MessageDialogIcon.Error;
                            msg.Buttons = MessageDialogButtons.OK;
                            msg.Show($"Product is full", "Product is full");
                        }));
                        return;
                    }
                }

                #region SAVE DATA
                // insert new data
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
                string printType = "";
                switch (weightType)
                {
                    case "PO":
                        printType = "L";
                        tb = tbWeightDetail.INSERT_DATA(MRP.name, int.Parse(MRP.id), RTFG.Name, RTFG.Id, "", 0, RTFG.new_po_customer, RTFG.new_sale_name, statusCounty, statusType, statusSide, _net, _tare, _gross, _wgh_paper_plasic, _wgh_core, _wgh_joint, _wgh_meter_kg_in_rolll, _numBox, _numRollAll, _numRoll, _pch, _lot, txtOperator.Text, "RTFG", printType);
                        break;
                    case "JIT":
                        printType = "S";
                        tb = tbWeightDetail.INSERT_DATA(MRP.name, int.Parse(MRP.id), RTFG.Name, RTFG.Id, "", 0, "", "", statusCounty, statusType, statusSide, _net, _tare, _gross, _wgh_paper_plasic, _wgh_core, _wgh_joint, _wgh_meter_kg_in_rolll, _numBox, _numRollAll, _numRoll, _pch, _lot, txtOperator.Text, "RTFG", printType);
                        break;
                }

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

                DefinePrintParameter(Seq, statusType, lbNetWgh.Text, txtNumBox.Text, txtNumRollAll.Text, txtNunMeter.Text, txtPchBox.Text, txtPchRoll.Text, txtWghPaper.Text, txtWghCors.Text, txtOperator.Text, Lot, weightType);
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

        private void RadioSelectSide(object sender, EventArgs e)
        {
            RadioButton rdb = sender as RadioButton;
            switch (rdb.Name)
            {
                case "rdNot":
                    statusSide = "none";
                    break;
                case "rdBackSide":
                    statusSide = "behind";
                    break;
                case "rdFrontSide":
                    statusSide = "front";
                    break;
            }
        }

        private void rdbSelectCountry(object sender, EventArgs e)
        {
            RadioButton rdb = sender as RadioButton;
            switch (rdb.Name)
            {
                case "rdInCounty":
                    statusCounty = "dom";
                    break;
                case "rdOutCounty":
                    statusCounty = "ovs";
                    break;
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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            func_print.FormatPrint(e);
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

        private void txtNunMeter_TextChanged_1(object sender, EventArgs e)
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

                    // ถ้าจะนวนความยาวม้วนเต็มทั้งหมด เป็น 0 ไม่ต้องคำนวนต่อ
                    if (MRP.product_roll_length != 0)
                    {
                        double numMetPerRoll = MRP.product_roll_length;
                        double numMet = double.Parse(txtNunMeter.Text);
                        double total = numMet / numMetPerRoll;
                        txtNumRoll.Text = total.ToString("F2");
                    }
                }
            }
            catch (Exception)
            {


            }
        }
    }
}
