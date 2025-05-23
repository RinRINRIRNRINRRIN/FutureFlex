﻿using FutureFlex.Models;
using FutureFlex.SQL;
using Guna.UI2.WinForms;
using Serilog;
using System;
using System.Configuration;
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
            // แสดงประเภทโปรแกรม
            string statusType = ConfigurationManager.AppSettings["DB_LOCAL"];
            string a = "";
            switch (statusType)
            {
                case "FutureflexUAT":
                    a = "UAT";
                    break;
                case "FutureFlex":
                    a = "Production";
                    break;
            }

            string status_odoo = ConfigurationManager.AppSettings["ODOO_STATUS"];
            switch (status_odoo)
            {
                case "UAT":
                    label4.Text = "ODOO : UAT";
                    break;
                case "PRODUCTION":
                    label4.Text = "ODOO : PRODUCTION";
                    break;
            }

            // นำชื่อผู้ใช้มาแสดงที่โปรแกรม
            label6.Text = EmployeeModel.emp_name;
            label5.Text = $"{server.serverLocal} : {a}";
            Log.Information($"server name : {label5.Text}");
            Log.Information($"employee name : {label6.Text}");
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
                case "weightJIT":
                    frmWeightJIT frmJIT = new frmWeightJIT();
                    frmJIT.ShowDialog();
                    break;
                case "weightPO":
                    frmWeightJIT frm = new frmWeightJIT();
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
                    frmRTFGList frmRTFGList = new frmRTFGList();
                    frmRTFGList.ShowDialog();
                    break;
                case "split":
                    frmSPLList frmSPLList = new frmSPLList();
                    frmSPLList.ShowDialog();
                    break;
            }
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F8)
            {
                frmTcpClientServer frmTcpClientServer = new frmTcpClientServer();
                frmTcpClientServer.ShowDialog();
            }
            if (e.KeyCode == Keys.F9)
            {
                var version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
                string versions = $"{version.Major}.{version.Minor}.{version.Build}";

                md.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                md.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                md.Show("Version info\n" +
                    $"Program version : {versions}\n" +
                    $"Program build version : {version}", "Program information");
            }
        }

        private void btnPO_Click(object sender, EventArgs e)
        {
            frmWeightPO frmWeightPO = new frmWeightPO();
            frmWeightPO.ShowDialog();
        }

        private void btnJIT_Click(object sender, EventArgs e)
        {
            frmWeightJIT frmWeightJIT = new frmWeightJIT();
            frmWeightJIT.ShowDialog();
        }
    }
}
