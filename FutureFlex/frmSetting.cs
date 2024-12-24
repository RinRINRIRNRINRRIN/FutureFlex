using Bunifu.UI.WinForms;
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
                    sk.Show(this, "กรุณาเลือก COM หรือ BUADRATE ก่อนการบันทึก", BunifuSnackbar.MessageTypes.Warning, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                    return;
                }
            }

            config.AppSettings.Settings["WGH_COM"].Value = cbbWGHC.Text;
            config.AppSettings.Settings["WGH_BAUDRATE"].Value = cbbWGHB.Text;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");

            MessageBox.Show("บันทึกการตั้งค่าสำเร็จระบบจะปิดโปรแกรม กรุณาเปิดการใช้งานใหม่อีกครั้ง", "Setting Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
    }
}
