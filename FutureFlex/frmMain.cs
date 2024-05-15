using FutureFlex.SQL;
using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FutureFlex
{

    public partial class frmMain : Form
    {


        public frmMain()
        {
            InitializeComponent();
        }

        bool stateNetwork = true;


        #region "FUNCSION LOCAL"

        async Task CHECK_NETWORK_CONNECT()
        {
            while (stateNetwork)
            {
                if (NetworkInterface.GetIsNetworkAvailable() == true)
                {
                    this.BeginInvoke(new MethodInvoker(delegate ()
                    {
                        tsINTERNETCEHCK.Text = "Connected";
                        tsINTERNETCEHCK.ForeColor = Color.Lime;
                        stateNetwork = false;
                    }));

                }
                if (NetworkInterface.GetIsNetworkAvailable() == false)
                {
                    this.BeginInvoke(new MethodInvoker(delegate ()
                    {
                        tsINTERNETCEHCK.Text = "Can't connect network !!!";
                        tsINTERNETCEHCK.ForeColor = Color.Red;
                        tsSERVERCHECK.Text = "Can't connect server !!!";
                        tsSERVERCHECK.ForeColor = Color.Red;
                        stateNetwork = false;
                    }));
                }

                await Task.Delay(2000);
            }
        }

        /// <summary>
        /// ทำหรับทำ NotifyIcon
        /// </summary>
        /// <returns></returns>
        async Task ShowNotify()
        {
            while (true)
            {
                int a = tbWeight.SELECT_NOT_SUCCESS().Rows.Count;
                BeginInvoke(new MethodInvoker(delegate ()
                {
                    notify1.Text = a.ToString();

                }));
                await Task.Delay(5000);
            }
        }

        /// <summary>
        /// สำหรับการแสดง form ให้อยู่กลางหน้าจอ
        /// </summary>
        /// <param name="frm">ฟอร์มที่ต้องการจะแสดง</param>
        void ShowFormCenterScreen(Form frm)
        {
            int x = (panel1.Width - frm.Width) / 2;
            int y = (panel1.Height - frm.Height) / 2;

            frm.TopLevel = false;
            panel1.Controls.Clear();

            frm.Location = new Point(x, y);
            panel1.Controls.Add(frm);
            frm.Show();
        }


        //void CheckPrivilage()
        //{
        //    for (int i = 0; i < tbPrivilage.menuPrivilage.Count; i++)
        //    {
        //        string menu = tbPrivilage.menuPrivilage[i];

        //        foreach (var btn in this.Controls.OfType<Guna2Button>())
        //        {
        //            if (menu == btn.Tag)
        //            {
        //                btn.Enabled = true;
        //            }
        //        }
        //    }
        //}

        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
            // กำหนดสิทธิ์การใช้งาน เมนู
            // CheckPrivilage();

            // แสดงข้อมูลที่ยังไม่ได้เพิ่มไปที่ odoo
            Task.Run(ShowNotify);

            // ตรวจสอบอินเตอร์
            Task.Run(CHECK_NETWORK_CONNECT);

            tbOdoo.defineServerOdoo();
            Console.WriteLine("define odoo success");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) //=======================================   เมื่อมีการกดปิดโปรแกรมจะเข้ามาทำงานตรงนี้ 
        {
            Application.Exit();
        }


        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            frmHistoryWeight frmHistoryWeight = new frmHistoryWeight();
            ShowFormCenterScreen(frmHistoryWeight);
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            frmHistorySuccess frmHistorySuccess = new frmHistorySuccess();
            ShowFormCenterScreen(frmHistorySuccess);
        }


        private void MenuSelect(object sender, EventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;


            switch (btn.Tag)
            {
                case "weight":
                    frmWeightNew frmWeightNew = new frmWeightNew();
                    ShowFormCenterScreen(frmWeightNew);
                    break;
                case "reprintJIT":
                    frmReprintJIT frmReprintJIT = new frmReprintJIT();
                    ShowFormCenterScreen(frmReprintJIT);
                    break;
                case "history":
                    break;
                case "account":
                    frmPrivilage frmPrivilage = new frmPrivilage();
                    ShowFormCenterScreen(frmPrivilage);
                    break;
                case "setting":
                    frmSetting frmSetting = new frmSetting();
                    ShowFormCenterScreen(frmSetting);
                    break;
            }

        }
    }
}
