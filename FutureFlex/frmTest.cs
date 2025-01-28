using System;
using System.Drawing.Printing;
using System.IO;
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
            string a = File.ReadAllText("C:\\Users\\Admin\\AppData\\Roaming\\AnyDesk\\Service.conf");
            Console.WriteLine(a);
        }



        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }


        private void printDocument1_BeginPrint(object sender, PrintEventArgs e)
        {

        }

        private void printDocument1_EndPrint(object sender, PrintEventArgs e)
        {

        }
    }
}

