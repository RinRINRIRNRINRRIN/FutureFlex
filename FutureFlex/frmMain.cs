using FutureFlex.SQL;
using Guna.UI2.WinForms;
using Serilog;
using System;
using System.Windows.Forms;


namespace FutureFlex
{

    public partial class frmMain : Form
    {


        public frmMain()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            // นำชื่อผู้ใช้มาแสดงที่โปรแกรม
            tsShowEmp_name.Text = EmployeeModel.emp_name;
            tShowServerName.Text = server.serverLocal;
            Log.Information($"server name : {tShowServerName.Text}");
            Log.Information($"employee name : {tsShowEmp_name.Text}");
            tbOdoo.defineServerOdoo();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) //=======================================   เมื่อมีการกดปิดโปรแกรมจะเข้ามาทำงานตรงนี้ 
        {
            Application.Exit();
        }



        private void MenuSelect(object sender, EventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;
            switch (btn.Tag)
            {
                case "weight":
                    frmWeightNew frm = new frmWeightNew();
                    frm.ShowDialog();
                    break;
                case "reprintJIT":
                    frmReprintJIT frm1 = new frmReprintJIT();
                    frm1.ShowDialog();
                    break;
                case "history":
                    frmHistoryWeight frm2 = new frmHistoryWeight();
                    frm2.ShowDialog();
                    break;
                case "account":
                    frmAccount frm3 = new frmAccount();
                    frm3.ShowDialog();
                    break;
                case "setting":
                    frmSetting frm4 = new frmSetting();
                    frm4.ShowDialog();
                    break;
                case "RTFG":
                    //md.Buttons = MessageDialogButtons.OK;
                    //md.Icon = MessageDialogIcon.Information;
                    //md.Show("Coming soon", "RTFG");
                    //frmRTFG frm5 = new frmRTFG();
                    //frm5.ShowDialog();
                    frmRTFGList frmRTFGList = new frmRTFGList();
                    frmRTFGList.ShowDialog();
                    break;
            }
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9 && tbEmployeeSQL.emp_username == "sa")
            {
                frmConnect frmConnect = new frmConnect();
                frmConnect.ShowDialog();
            }
            else if (e.KeyCode == Keys.F8)
            {
                frmTcpClientServer frmTcpClientServer = new frmTcpClientServer();
                frmTcpClientServer.ShowDialog();
            }
        }

    }
}
