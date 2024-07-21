using FutureFlex.SQL;
using Guna.UI2.WinForms;
using System;
using System.Drawing;
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

        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
            // นำชื่อผู้ใช้มาแสดงที่โปรแกรม
            tsShowEmp_name.Text = tbEmployeeSQL.emp_name;


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
            }
        }
    }
}
