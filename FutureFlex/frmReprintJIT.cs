using FutureFlex.Function;
using System;
using System.Windows.Forms;

namespace FutureFlex
{
    public partial class frmReprintJIT : Form
    {
        public frmReprintJIT()
        {
            InitializeComponent();
        }
        private void frmReprintJIT_Load(object sender, EventArgs e)
        {
            // กำหนดค่าให้กับ serialport
            serialPort1.PortName = func_serialport.COM_SCANNER;
            serialPort1.BaudRate = func_serialport.BAUDRATE_SCANNER;
            serialPort1.Open();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string data = serialPort1.ReadLine();

            if (dgvDetail.Rows.Count != 0 && txtPO.Text != "")
            {
                BeginInvoke(new MethodInvoker(delegate ()
                {
                    lblQRCODE.Text = "";
                    lblQRCODE.Text = $"QRCODE : {data}";
                }));
            }
            else
            {
                MessageBox.Show("กรุณากรอก เลขที่ PO", "PO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
