using System;
using System.IO.Ports;
using System.Windows.Forms;
using System.Configuration;

namespace FutureFlex
{
    public partial class frmSetting : Form
    {
        SerialPort sa = new SerialPort();

        string appCOM = ConfigurationManager.AppSettings["COM_WGH"];
        string appBaudrate = ConfigurationManager.AppSettings["BAUDRATE"];
        string appParity = ConfigurationManager.AppSettings["Parity"];
        string appStopBits = ConfigurationManager.AppSettings["StopBits"];
        string appDataBits = ConfigurationManager.AppSettings["DataBits"];

        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        public frmSetting()
        {
            InitializeComponent();
        }

        private void comboBox15_DropDown(object sender, EventArgs e)
        {
            sender.GetHashCode();
            Console.WriteLine(sender);
        }

        private void frmSetting_Load(object sender, EventArgs e)
        {
            gbDate.Visible = false;
            gbPassword.Visible = true;         
        }

        private void cbbCOMPORT_DropDown(object sender, EventArgs e)
        {
            cbbCOMPORT.Items.Clear();
            string[] comprt = SerialPort.GetPortNames();
            cbbCOMPORT.Items.AddRange(comprt);        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            config.AppSettings.Settings["COM_WGH"].Value = cbbCOMPORT.Text;
            config.AppSettings.Settings["BAUDRATE"].Value = cbbBAUTRATE.Text;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }


        private void cbbCOMPORT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPassword.Text == "tsc1932")
                {
                    txtPassword.Clear();
                    txtPassword.PlaceholderText = "กรุณาใส่รหัสผ่านใหม่";
                }
                else if (txtPassword.Text == ConfigurationManager.AppSettings["PassAdmin"])
                {
                    gbDate.Visible = true;
                    gbPassword.Visible = false;

                    cbbCOMPORT.Text = appCOM;
                    cbbBAUTRATE.Text = appBaudrate;
                    cbbParity.Text = appParity;
                    cbbDATABITS.Text = appDataBits;
                    cbbSTOPBITS.Text = appStopBits;
                }
                else if (txtPassword.PlaceholderText == "กรุณาใส่รหัสผ่านใหม่")
                {
                    config.AppSettings.Settings["PassAdmin"].Value = txtPassword.Text;
                    config.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection("appSettings");
                    MessageBox.Show("รหัสผ่านถูกเปลี่ยนเรียนร้อย", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("รหัสผ่านแอดมินไม่ถูกต้องกรุณาผ่านใหม่", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Clear();
                    txtPassword.Focus();
                }
            }
        }
    }
}
