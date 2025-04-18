using FutureFlex.SQL;
using Guna.UI2.WinForms;
using Serilog;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutureFlex
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            Log.Logger = new LoggerConfiguration()
.WriteTo.File(Application.StartupPath + "\\Logs\\log-.txt", rollingInterval: RollingInterval.Day)
.WriteTo.Console(Serilog.Events.LogEventLevel.Debug)
.CreateLogger();


            this.Size = new System.Drawing.Size(257, 401);
        }

        void Login()
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                Log.Information("พบผู้ใช้ไม่กรอกข้อมูล username หรือ password ไม่ครบ");
                md.Icon = MessageDialogIcon.Warning;
                md.Buttons = MessageDialogButtons.OK;
                md.Show("Please fill the username or password before log on", "Log on");
                //MessageBox.Show("กรุณากรอกข้อมูลให้ครบก่อนเข้าสู่ระบบ", "เข้าสู่ระบบ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tbEmployeeSQL.LOGIN(txtUsername.Text, txtPassword.Text))
            {
                Log.Information("เข้าสู่ระบบสำเร็จ");
                txtUsername.Clear();
                txtPassword.Clear();
                md.Icon = MessageDialogIcon.Information;
                md.Buttons = MessageDialogButtons.OK;
                md.Show("Log on success", "Log on");
                //MessageBox.Show("เข้าสู่ระบบสำเร็จ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmMain frm = new frmMain();
                for (int i = 0; i < tbPrivilage.menuPrivilage.Count; i++)
                {
                    Log.Information($"== เมนูที่เปิด {tbPrivilage.menuPrivilage[i]}");
                    string menu = tbPrivilage.menuPrivilage[i];

                    foreach (var btn in frm.Controls.OfType<Guna2Button>())
                    {
                        if (menu == btn.Tag)
                        {
                            btn.Enabled = true;
                            Log.Information($"- ฟังชั่นที่เปิด {btn.Text}");
                        }
                    }
                }


                frm.Show();
                this.Hide();
            }
            else
            {
                Log.Information("พบผู้ใช้ไม่กรอกข้อมูล username หรือ password ไม่ถูกต้อง");
                txtUsername.Clear();
                txtPassword.Clear();
                MessageBox.Show("ผู้ใช้ หรือ รหัสผ่านไม่ถูกต้อง", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
            }
        }

        bool CheckVersion()
        {
            if (!systems.CheckVersion())
            {
                msg.Icon = MessageDialogIcon.Information;
                msg.Buttons = MessageDialogButtons.OK;
                msg.Show("Have new version please update", "New version update");
                Application.Exit();
                Process.Start("Notepad");
                return false;
            }
            return true;
        }

        /// <summary>
        /// สำหรับเช็คว่าโปรแกมมีเปิดซ้ำไหม
        /// </summary>
        /// <returns></returns>
        bool CHECK_PROGRAM()
        {
            try
            {
                Process[] a = Process.GetProcessesByName("FutureFlex");

                if (a.Length > 1)
                {
                    return false;
                }
            }
            catch (System.Exception ex)
            {

                return false;
            }
            return true;
        }

        private async void frmLogin_Load(object sender, EventArgs e)
        {
            Log.Information("=================================================================  Open program");

            // เช็คโปรแกรมว่ามีเปิดซ้ำหรือไม่
            if (Function.Function.CHECK_PROGRAM())
            {
                int x = (this.Width - gbConnection.Width) / 2;
                int y = (this.Height - gbConnection.Height) / 2;
                gbConnection.Location = new System.Drawing.Point(x, y);
                gbConnection.Show();
                gbConnection.Visible = true;
                // ทดสอบเชื่อมต่อฐานข้อมูล
                if (await server.ConnectDatabase())
                {

                    Log.Warning("เชื่อมต่อฐานข้อมูลสำเร็จ");
                    await Task.Delay(900);
                    label1.Text = "Connect success";
                    await Task.Delay(1000);
                    gbConnection.Visible = false;

                    txtUsername.Focus();
                }
                else
                {
                    Log.Warning("ไม่สามารถเชื่อมต่อฐานข้อมูลได้");
                    label1.Text = "Connect fail";
                    MessageBox.Show("ไม่สามารถเชื่อมต่อฐานข้อมูลได้", "Error connect database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
            else
            {
                Log.Warning("พบโปรแกรมเปิดอยู่");
                MessageBox.Show("มีโปรแกรมเปิดอยู่แล้ว", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Log.Information("=================================================================  Program is closing");
                Application.Exit();
            }
        }


        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.PasswordChar = '\0';
            }
            else if (cbShowPassword.Checked == false)
            {
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            Login();
        }
    }
}
