using System;
using System.IO.Ports;
using System.Windows.Forms;
namespace FutureFlex
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            serialPort1.Open();
            Console.WriteLine(serialPort1.PortName);
            if (serialPort1.IsOpen)
            {
                Console.WriteLine("CONECTED");
            }
            else
            {
                Console.WriteLine("DISCONNECT");
            }

        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string a = serialPort1.ReadLine();
            Console.WriteLine($"SERIAL {a}");
            string[] b = a.Split(',');

            Console.WriteLine($"NET {b[2].Trim()}");
            Console.WriteLine($"TARE {b[3].Trim()}");
            Console.WriteLine($"GROSS {b[4].Trim()}");
        }
    }
}
