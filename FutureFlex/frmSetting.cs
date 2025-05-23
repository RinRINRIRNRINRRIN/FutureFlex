﻿using Bunifu.UI.WinForms;
using Guna.UI2.WinForms;
using System;
using System.Configuration;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;

namespace FutureFlex
{
    public partial class frmSetting : Form
    {
        SerialPort sa = new SerialPort();

        string WGH_COM = ConfigurationManager.AppSettings["WGH_COM"];
        string WGH_BUADRATE = ConfigurationManager.AppSettings["WGH_BAUDRATE"];
        string ipserver = ConfigurationManager.AppSettings["IP_SERVER"];


        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        BunifuSnackbar sk = new BunifuSnackbar();
        public frmSetting()
        {
            InitializeComponent();
        }


        private void frmSetting_Load(object sender, EventArgs e)
        {
            // ดึงค่า COM BUADRATE มาแสดงที่ Combobox
            cbbWGHB.Items.Add(WGH_BUADRATE);
            cbbWGHC.Items.Add(WGH_COM);

            cbbWGHC.SelectedIndex = 0;
            cbbWGHB.SelectedIndex = 0;

            txtIp.Text = ipserver;
        }


        private void GET_SERIALPORT(object sender, EventArgs e)
        {
            Guna2ComboBox cbb = sender as Guna2ComboBox;

            string[] a = SerialPort.GetPortNames();

            cbb.Items.Clear();
            for (int i = 0; i < a.Length; i++)
            {
                cbb.Items.Add(a[i]);
            }
        }

        private void GET_BUADRATE(object sender, EventArgs e)
        {
            Guna2ComboBox cbb = sender as Guna2ComboBox;

            cbb.Items.Clear();
            cbb.Items.Add(9600);
            cbb.Items.Add(115200);
        }

        private void CLEAR_COMBOBOX(object sender, EventArgs e)
        {
            Guna2ComboBox cbb = sender as Guna2ComboBox;

            if (cbb.Text == "")
            {
                cbb.Items.Clear();
                switch (cbb.Tag)
                {
                    case "COM":
                        cbb.Items.Add("--COM--");
                        cbb.SelectedIndex = 0;
                        break;
                    case "BUADRATE":
                        cbb.Items.Add("--BUADRATE--");
                        cbb.SelectedIndex = 0;
                        break;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (var item in this.Controls.OfType<ComboBox>())
            {
                if (item.Text.Contains("--"))
                {
                    msg.Buttons = MessageDialogButtons.OK;
                    msg.Icon = MessageDialogIcon.Warning;
                    msg.Show("Please select COM and BUADRATE before to save", "COM and BAUDRATE");
                    return;
                }
            }

            if (txtIp.Text == "")
            {
                msg.Buttons = MessageDialogButtons.OK;
                msg.Icon = MessageDialogIcon.Warning;
                msg.Show("Please fill ip server before to save", "IP Server");
                return;
            }

            config.AppSettings.Settings["WGH_COM"].Value = cbbWGHC.Text;
            config.AppSettings.Settings["WGH_BAUDRATE"].Value = cbbWGHB.Text;
            config.AppSettings.Settings["IP_SERVER"].Value = txtIp.Text;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");

            msg.Buttons = MessageDialogButtons.OK;
            msg.Icon = MessageDialogIcon.Information;
            msg.Show("Save setting success program will close please open again", "Save setting");
            Application.Exit();
        }
    }
}
