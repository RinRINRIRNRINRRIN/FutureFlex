using Bunifu.UI.WinForms;
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
        string WGH_BUADRATE = ConfigurationManager.AppSettings["WGH_BUADRATE"];

        string SCN_COM = ConfigurationManager.AppSettings["SCN_COM"];
        string SCN_BUADRATE = ConfigurationManager.AppSettings["SCN_BUADRATE"];


        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        BunifuSnackbar sk = new BunifuSnackbar();
        public frmSetting()
        {
            InitializeComponent();
        }


        private void frmSetting_Load(object sender, EventArgs e)
        {
            // ดึงค่า COM BUADRATE มาแสดงที่ Combobox
            cbbSCNBUADRATE.Text = SCN_BUADRATE;
            cbbSCNCOM.Text = SCN_COM;
            cbbWGHBAUTRATE.Text = WGH_BUADRATE;
            cbbWGHCOM.Text = WGH_COM;
            gbWGH.Visible = false;
        }


        private void GET_SERIALPORT(object sender, EventArgs e)
        {
            ComboBox cbb = sender as ComboBox;

            string[] a = SerialPort.GetPortNames();

            cbb.Items.Clear();
            for (int i = 0; i < a.Length; i++)
            {
                cbb.Items.Add(a[i]);
            }
        }

        private void GET_BUADRATE(object sender, EventArgs e)
        {
            ComboBox cbb = sender as ComboBox;

            cbb.Items.Clear();
            cbb.Items.Add(9600);
            cbb.Items.Add(115200);
        }

        private void CLEAR_COMBOBOX(object sender, EventArgs e)
        {
            ComboBox cbb = sender as ComboBox;

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

        private void btnHistory_Click(object sender, EventArgs e)
        {
            // ตรวจสอบค่าว่าง
            foreach (var item in gbSCN.Controls.OfType<ComboBox>())
            {
                if (item.Text.Contains("--"))
                {
                    sk.Show(this, "กรุณาเลือก COM หรือ BUADRATE ก่อนการบันทึก", BunifuSnackbar.MessageTypes.Warning, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                    return;
                }
            }

            foreach (var item in gbWGH.Controls.OfType<ComboBox>())
            {
                if (item.Text.Contains("--"))
                {
                    sk.Show(this, "กรุณาเลือก COM หรือ BUADRATE ก่อนการบันทึก", BunifuSnackbar.MessageTypes.Warning, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                    return;
                }
            }

            config.AppSettings.Settings["WGH_COM"].Value = cbbWGHCOM.Text;
            config.AppSettings.Settings["WGH_BAUDRATE"].Value = cbbWGHBAUTRATE.Text;
            config.AppSettings.Settings["SCN_COM"].Value = cbbWGHBAUTRATE.Text;
            config.AppSettings.Settings["SCN_BAUDRATE"].Value = cbbWGHBAUTRATE.Text;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
